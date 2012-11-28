using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using Styx;
using Styx.Pathing;
using Styx.WoWInternals;


namespace HotspotRecorder
{
    public partial class frmMain : Form
    {
        System.Threading.Thread newThread = null;
        private string targetname = string.Empty;
        private HotspotRecorderPlugin.XYZ targetlocation = null;
        private int targetentry = 0;
        private bool isrepair = false;
        private HotspotRecorderPlugin.XYZ mylocation = null;
        private HotspotRecorderPlugin.UpdateUIDelegate updateui = null;
        private HotspotRecorderPlugin.XYZ oldloc = null;
        private string profile = null;
        private Queue<KeyValuePair<string, object>> queue = new Queue<KeyValuePair<string, object>>();
        private int closesthotspot = -1;
        private List<HotspotRecorderPlugin.XYZ> points = null;
        private HotspotRecorderPlugin fakeplugin = null;
        private string header = @"<?xml version=""1.0"" encoding=""utf-8""?>
<HBProfile>
  <Name>{0}</Name>
  <MinDurability>0.4</MinDurability>
  <MinFreeBagSlots>1</MinFreeBagSlots>
  <MinLevel>1</MinLevel>
  <MaxLevel>999</MaxLevel>
  <Factions>99999</Factions>
  <MailGrey>False</MailGrey>
  <MailWhite>True</MailWhite>
  <MailGreen>True</MailGreen>
  <MailBlue>True</MailBlue>
  <MailPurple>True</MailPurple>
  <SellGrey>True</SellGrey>
  <SellWhite>False</SellWhite>
  <SellGreen>False</SellGreen>
  <SellBlue>False</SellBlue>
  <SellPurple>False</SellPurple>
  <SellPurple>False</SellPurple>
";

        #region Supporting Routines

        private void display(String fmt, params object[] args)
        {
            try
            {
                String s = string.Format(fmt, args);
                s = Environment.NewLine + s;
                // Do a thread-safe update on txtOutput
                // (this routine is used by On_Update, which is called by an external thread.)
                this.txtOutput.Invoke((MethodInvoker)(() => txtOutput.Text += s));
                this.txtOutput.Invoke((MethodInvoker)(() => txtOutput.SelectionStart = txtOutput.Text.Length));
                this.txtOutput.Invoke((MethodInvoker)(() => txtOutput.ScrollToCaret()));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }

        private double FastDistance(HotspotRecorderPlugin.XYZ pt1, HotspotRecorderPlugin.XYZ pt2)
        {
            double x = pt2.X - pt1.X;
            double y = pt2.Y - pt1.Y;
            double z = pt2.Z - pt1.Z;
            return x * x + y * y + z * z;
        }
        private double Distance(HotspotRecorderPlugin.XYZ pt1, HotspotRecorderPlugin.XYZ pt2)
        {
            double x = pt2.X - pt1.X;
            double y = pt2.Y - pt1.Y;
            double z = pt2.Z - pt1.Z;
            return Math.Sqrt(x * x + y * y + z * z);
        }
        private void ClearPoints()
        {
            points = null;
        }
        private string PointToString(string spottype, HotspotRecorderPlugin.XYZ spot)
        {
            string suffix = string.Empty;
            if (spottype.ToLower() == "blackspot")
                suffix = string.Format(@"Radius=""{0}""", this.txtBlackspotRadius.Text);
            string s = string.Format(@"<{0} X=""{1:0.0000}"" Y=""{2:0.0000}"" Z=""{3:0.0000}"" {4} />", spottype, spot.X, spot.Y, spot.Z, suffix);
            return s;
        }
        private string PointToVendorString(string vendorname, int entry, string vendortype, HotspotRecorderPlugin.XYZ spot)
        {
            string s = string.Format(@"<Vendor Name=""{0}"" Entry=""{1}"" Type=""{2}"" X=""{3:0.0000}"" Y=""{4:0.0000}"" Z=""{5:0.0000}"" />", vendorname, entry, vendortype, spot.X, spot.Y, spot.Z);
            return s;
        }
        private HotspotRecorderPlugin.XYZ StringToPoint(string input)
        {
            try
            {
                string pattern = @"X=""(?<X>.*?)"".*Y=""(?<Y>.*?)"".*Z=""(?<Z>.*?)""";
                Regex regex = new Regex(pattern);
                var match = regex.Match(input);
                string strX = match.Groups["X"].Value;
                string strY = match.Groups["Y"].Value;
                string strZ = match.Groups["Z"].Value;

                double x = double.Parse(strX);
                double y = double.Parse(strY);
                double z = double.Parse(strZ);

                return new HotspotRecorderPlugin.XYZ(x, y, z);
            }
            catch (Exception ex)
            {
                string errmsg = string.Format("Error: {0}", ex.Message);
                display(errmsg);
                MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        private void AutoGenerateHotspot()
        {
            int spacing = 20;
            if (!(Int32.TryParse(txtSpacing.Text, out spacing)))
            {
                display("Hotspot spacing must be a numeric integer!");
                return;
            }

            if (oldloc == null)
            {
                oldloc = mylocation;
                return;
            }

            double dist = Distance(mylocation, oldloc);
            if (dist > spacing)
            {
                AddSpot(lstHotSpots, "Hotspot", mylocation);
                oldloc = mylocation;
            }

        }
        private void AddSpot(ListBox lb, string spottype, HotspotRecorderPlugin.XYZ spot)
        {
            lb.Items.Add(PointToString(spottype, spot));
            int visibleItems = lb.ClientSize.Height / lb.ItemHeight;
            lb.TopIndex = Math.Max(lb.Items.Count - visibleItems + 1, 0);
            ClearPoints();
        }
        private void AddVendor(ListBox lb, string vendorname, int entry, string vendortype, HotspotRecorderPlugin.XYZ spot)
        {
            lb.Items.Add(PointToVendorString(vendorname, entry, vendortype, spot));
            int visibleItems = lb.ClientSize.Height / lb.ItemHeight;
            lb.TopIndex = Math.Max(lb.Items.Count - visibleItems + 1, 0);
            ClearPoints();
        }
        private void GoTo(string input)
        {
            HotspotRecorderPlugin.XYZ xyz = StringToPoint(input);
            if (xyz != null)
                GoTo(xyz);
        }
        private void GoTo(HotspotRecorderPlugin.XYZ xyz)
        {
            // Go to the specified point in WoW, on the next pulse.
            // Don't do it right away! You will probably fail with memory read errors.
            // Just stuff it in a queue, and wait for the next 'On_Update' to execute it.
            queue.Enqueue(new KeyValuePair<string, object>("goto", xyz));
        }
        private void CalculateClosestHotspot()
        {
            if (points == null)
            {
                points = new List<HotspotRecorderPlugin.XYZ>();
                for (int i = 0; i < lstHotSpots.Items.Count; i++)
                    points.Add(StringToPoint(lstHotSpots.Items[i].ToString()));
            }
            double closestdist = -1;
            int closestindex = -1;
            for (int i = 0; i < points.Count; i++)
            {
                double dist = FastDistance(mylocation, points[i]);
                if (closestdist < 0 || dist < closestdist)
                {
                    closestdist = dist;
                    closestindex = i;
                }
            }
            closesthotspot = closestindex;
            lstHotSpots.Invalidate();
        }
        private ListBox theSelectedTab()
        {
            ListBox lb;
            if (tabMain.SelectedTab.Text == "Hotspots")
                lb = lstHotSpots;
            else if (tabMain.SelectedTab.Text == "Blackspots")
                lb = lstBlackspots;
            else if (tabMain.SelectedTab.Text == "Mailboxes")
                lb = lstMailboxes;
            else if (tabMain.SelectedTab.Text == "NPC")
                lb = lstNPC;
            else
            {
                display("Unknown tab {0}!", tabMain.SelectedTab.Text);
                return null;
            }
            return lb;
        }
        #endregion

        #region Routine called by Honorbuddy Pulse method
        public void On_Update(HotspotRecorderPlugin.CustomEventArgs args)
        {
            string fmt = "{0:0.000}, {1:0.000}, {2:0.000}";
            targetlocation = args.targetlocation;
            targetname = args.targetname;
            targetentry = args.targetentry;
            isrepair = args.isrepair;
            mylocation = args.mylocation;
            CalculateClosestHotspot();
            // Do a thread-safe update on the fields 
            // (this routine (On_Update) is called by an external thread.)
            this.lblLocationNPC.Invoke((MethodInvoker)(() => lblLocationNPC.Text = (targetlocation == null ? "<no target>" : string.Format(fmt, targetlocation.X, targetlocation.Y, targetlocation.Z))));
            this.lblLocationMe.Invoke((MethodInvoker)(() => lblLocationMe.Text = (mylocation == null ? "<null>" : string.Format(fmt, mylocation.X, mylocation.Y, mylocation.Z))));
            this.lblNPCName.Invoke((MethodInvoker)(() => lblNPCName.Text = (targetname == null ? "<no target>" : targetname)));

            if (queue.Count > 0)
            {
                int commandcnt = queue.Count;
                for (int i = 0; i < commandcnt; i++)
                {
                    KeyValuePair<string, object> kvp = queue.Dequeue();
                    display("Executing queued command {0} of {1}", i+1, commandcnt);
                    switch (kvp.Key)
                    {
                        case "goto":
                            HotspotRecorderPlugin.XYZ xyz = (HotspotRecorderPlugin.XYZ)kvp.Value;
                            display("Go to {0:0.0000}, {1:0.0000}, {2:0.0000}", xyz.X, xyz.Y, xyz.Z);
                            if (StyxWoW.Me == null)
                                return;
                            int ctr = 0;
                            int maxloops = 100;
                            WoWPoint pt = new WoWPoint(xyz.X, xyz.Y, xyz.Z);
                            while (!StyxWoW.Me.IsMoving && !StyxWoW.Me.Combat && ctr < maxloops)
                            {
                                Flightor.MoveTo(pt);
                                Thread.Sleep(10);
                                ctr++;
                            }
                            break;
                        default:
                            display("Unknown command {0}!", kvp.Key);
                            break;
                    }
                    display("Done executing queued command {0} of {1}", i+1, commandcnt);
                }
            }
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateui = new HotspotRecorderPlugin.UpdateUIDelegate(On_Update);
            if (StyxWoW.Me == null)
            {
                // Create the plugin manually since we're testing in standalone mode.
                fakeplugin = new HotspotRecorderPlugin();
                newThread = new System.Threading.Thread(fakeplugin.MessagePump);
                newThread.Start();
            }
            HotspotRecorderPlugin.UpdateUI += updateui;
            timer1.Enabled = true;
            lstHotSpots.HorizontalScrollbar = true;
            lstBlackspots.HorizontalScrollbar = true;
            lstMailboxes.HorizontalScrollbar = true;
            lstNPC.HorizontalScrollbar = true;
            this.TopMost = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotspotRecorderPlugin.UpdateUI -= updateui;
            if (newThread != null)
                newThread.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkGenerateHotspots.Checked)
                AutoGenerateHotspot();
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                profile = openFileDialog1.FileName;
                string[] lines = System.IO.File.ReadAllLines(profile);
                lstHotSpots.Items.Clear();
                lstBlackspots.Items.Clear();
                lstNPC.Items.Clear();
                lstMailboxes.Items.Clear();
                foreach (string origline in lines)
                {
                    string line = origline.Trim();
                    if (line.StartsWith("<Hotspot "))
                        lstHotSpots.Items.Add(line);
                    else if (line.StartsWith("<Blackspot "))
                        lstBlackspots.Items.Add(line);
                    else if (line.StartsWith("<Vendor "))
                        lstNPC.Items.Add(line);
                    else if (line.StartsWith("<Mailbox "))
                        lstMailboxes.Items.Add(line);
                }
                Cursor.Current = Cursors.Default;
                string s = string.Format("Loaded profile '{0}'.", profile);
                display(s);
                txtProfileName.Text = profile;
                ClearPoints();
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                profile = saveFileDialog1.FileName;
                txtProfileName.Text = profile;
                List<string> lines = new List<string>();
                string shortfilename = System.IO.Path.GetFileName(profile);
                lines.Add(string.Format(header, shortfilename));
                lines.Add("<Vendors>");
                foreach (string s in lstNPC.Items)
                    lines.Add(string.Format("    {0}", s));
                lines.Add("</Vendors>");
                lines.Add("");
                lines.Add("<Mailboxes>");
                foreach (string s in lstMailboxes.Items)
                    lines.Add(string.Format("    {0}", s));
                lines.Add("</Mailboxes>");
                lines.Add("");
                lines.Add("<Blackspots>");
                foreach (string s in lstBlackspots.Items)
                    lines.Add(string.Format("    {0}", s));
                lines.Add("</Blackspots>");
                lines.Add("");
                lines.Add("<Hotspots>");
                foreach (string s in lstHotSpots.Items)
                    lines.Add(string.Format("    {0}", s));
                lines.Add("</Hotspots>");
                lines.Add("");
                lines.Add("</HBProfile>");
                System.IO.File.WriteAllLines(profile, lines.ToArray());
                string msg = string.Format("Saved file to '{0}'.", profile);
                display(msg);
            }
        }

        private void btnAddHotspot_Click(object sender, EventArgs e)
        {
            AddSpot(lstHotSpots, "Hotspot", mylocation);
        }

        private void btnAddBlackspot_Click(object sender, EventArgs e)
        {
            AddSpot(lstBlackspots, "Blackspot", mylocation);
        }

        private void btnAddMailbox_Click(object sender, EventArgs e)
        {
            AddSpot(lstMailboxes, "Mailbox", mylocation);
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            AddVendor(lstNPC, targetname, targetentry, (isrepair ? "Repair" : "Food"), targetlocation);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ListBox lb = theSelectedTab();
            if (lb == null) return;
            string[] lst = lb.Items.Cast<string>().ToArray();
            Array.Reverse(lst);
            lb.Items.Clear();
            lb.Items.AddRange(lst);
            ClearPoints();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListBox lb = theSelectedTab();
            if (lb == null) return;
            List<string> newlist = new List<string>();

            for (int x = 0; x < lb.Items.Count; x++)
            {
                if (lb.GetSelected(x) == false)
                    newlist.Add(lb.Items[x].ToString());
            }

            lb.Items.Clear();
            lb.Items.AddRange(newlist.ToArray());
            ClearPoints();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            ListBox lb = theSelectedTab();
            if (lb == null) return;
            if (lb.SelectedIndex < 0)
                return;
            if (lb == this.lstNPC)
                lb.Items[lb.SelectedIndex] = PointToVendorString(this.targetname, this.targetentry, (this.isrepair ? "Repair" : "Food"), targetlocation);
            else if (lb == this.lstMailboxes)
                lb.Items[lb.SelectedIndex] = PointToString("Mailbox", this.mylocation);
            else if (lb == this.lstBlackspots)
                lb.Items[lb.SelectedIndex] = PointToString("Blackspot", this.mylocation);
            else if (lb == this.lstHotSpots)
                lb.Items[lb.SelectedIndex] = PointToString("Hotspot", this.mylocation);
            ClearPoints();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            ListBox lb = theSelectedTab();
            if (lb == null) return;
            if (lb.SelectedIndex < 0)
                return;
            GoTo(lb.Items[lb.SelectedIndex].ToString());
        }

        private void lstBlackspots_DoubleClick(object sender, EventArgs e)
        {
            if (lstBlackspots.SelectedIndex >= 0)
                GoTo(lstBlackspots.Items[lstBlackspots.SelectedIndex].ToString());
        }

        private void lstHotSpots_DoubleClick(object sender, EventArgs e)
        {
            if (lstHotSpots.SelectedIndex >= 0)
                GoTo(lstHotSpots.Items[lstHotSpots.SelectedIndex].ToString());
        }

        private void lstMailboxes_DoubleClick(object sender, EventArgs e)
        {
            if (lstMailboxes.SelectedIndex >= 0)
                GoTo(lstMailboxes.Items[lstMailboxes.SelectedIndex].ToString());
        }

        private void lstNPC_DoubleClick(object sender, EventArgs e)
        {
            if (lstNPC.SelectedIndex >= 0)
                GoTo(lstNPC.Items[lstNPC.SelectedIndex].ToString());
        }

        private void lstHotSpots_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lst = (ListBox)sender;
            e.DrawBackground();
            if (e.Index == closesthotspot)
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            e.Graphics.DrawString(lst.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

    }
}


internal class FlickerFreeListBox : System.Windows.Forms.ListBox
{
    public FlickerFreeListBox()
    {
        this.SetStyle(
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.UserPaint,
            true);
        this.DrawMode = DrawMode.OwnerDrawFixed;
    }
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (this.Items.Count > 0)
        {
            e.DrawBackground();
            e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(this.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
        }
        base.OnDrawItem(e);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Region iRegion = new Region(e.ClipRectangle);
        e.Graphics.FillRegion(new SolidBrush(this.BackColor), iRegion);
        if (this.Items.Count > 0)
        {
            for (int i = 0; i < this.Items.Count; ++i)
            {
                System.Drawing.Rectangle irect = this.GetItemRectangle(i);
                if (e.ClipRectangle.IntersectsWith(irect))
                {
                    if ((this.SelectionMode == SelectionMode.One && this.SelectedIndex == i)
                    || (this.SelectionMode == SelectionMode.MultiSimple && this.SelectedIndices.Contains(i))
                    || (this.SelectionMode == SelectionMode.MultiExtended && this.SelectedIndices.Contains(i)))
                    {
                        OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                            irect, i,
                            DrawItemState.Selected, this.ForeColor,
                            this.BackColor));
                    }
                    else
                    {
                        OnDrawItem(new DrawItemEventArgs(e.Graphics, this.Font,
                            irect, i,
                            DrawItemState.Default, this.ForeColor,
                            this.BackColor));
                    }
                    iRegion.Complement(irect);
                }
            }
        }
        base.OnPaint(e);
    }
}