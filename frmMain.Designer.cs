namespace HotspotRecorder
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBlackspot = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnAddMailbox = new System.Windows.Forms.Button();
            this.btnAddHotspot = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblProfileNameLabel = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstHotSpots = new FlickerFreeListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstBlackspots = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstMailboxes = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstNPC = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlackspotRadius = new System.Windows.Forms.TextBox();
            this.chkGenerateHotspots = new System.Windows.Forms.CheckBox();
            this.txtSpacing = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLocationNPC = new System.Windows.Forms.Label();
            this.lblLocationMe = new System.Windows.Forms.Label();
            this.lblNPCName = new System.Windows.Forms.Label();
            this.lblMeName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGoTo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCheckPoints = new System.Windows.Forms.Button();
            this.btnSetTop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBlackspot);
            this.groupBox1.Controls.Add(this.btnAddVendor);
            this.groupBox1.Controls.Add(this.btnAddMailbox);
            this.groupBox1.Controls.Add(this.btnAddHotspot);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(143, 63);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // btnAddBlackspot
            // 
            this.btnAddBlackspot.Location = new System.Drawing.Point(4, 39);
            this.btnAddBlackspot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBlackspot.Name = "btnAddBlackspot";
            this.btnAddBlackspot.Size = new System.Drawing.Size(67, 19);
            this.btnAddBlackspot.TabIndex = 12;
            this.btnAddBlackspot.Text = "Blackspot";
            this.toolTip1.SetToolTip(this.btnAddBlackspot, "Add a blackspot at the current location, with the radius specified below");
            this.btnAddBlackspot.UseVisualStyleBackColor = true;
            this.btnAddBlackspot.Click += new System.EventHandler(this.btnAddBlackspot_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(73, 39);
            this.btnAddVendor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(67, 19);
            this.btnAddVendor.TabIndex = 11;
            this.btnAddVendor.Text = "Vendor";
            this.toolTip1.SetToolTip(this.btnAddVendor, "Add a vendor at the current location");
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnAddMailbox
            // 
            this.btnAddMailbox.Location = new System.Drawing.Point(73, 16);
            this.btnAddMailbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMailbox.Name = "btnAddMailbox";
            this.btnAddMailbox.Size = new System.Drawing.Size(67, 19);
            this.btnAddMailbox.TabIndex = 10;
            this.btnAddMailbox.Text = "Mailbox";
            this.toolTip1.SetToolTip(this.btnAddMailbox, "Add a mailbox at the current location");
            this.btnAddMailbox.UseVisualStyleBackColor = true;
            this.btnAddMailbox.Click += new System.EventHandler(this.btnAddMailbox_Click);
            // 
            // btnAddHotspot
            // 
            this.btnAddHotspot.Location = new System.Drawing.Point(4, 16);
            this.btnAddHotspot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddHotspot.Name = "btnAddHotspot";
            this.btnAddHotspot.Size = new System.Drawing.Size(67, 19);
            this.btnAddHotspot.TabIndex = 8;
            this.btnAddHotspot.Text = "Hotspot";
            this.toolTip1.SetToolTip(this.btnAddHotspot, "Add a single hotspot at the current location");
            this.btnAddHotspot.UseVisualStyleBackColor = true;
            this.btnAddHotspot.Click += new System.EventHandler(this.btnAddHotspot_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProfile.Location = new System.Drawing.Point(317, 2);
            this.btnSaveProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(67, 19);
            this.btnSaveProfile.TabIndex = 71;
            this.btnSaveProfile.Text = "Save...";
            this.toolTip1.SetToolTip(this.btnSaveProfile, "Save profile");
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileName.Location = new System.Drawing.Point(80, 4);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(198, 20);
            this.txtProfileName.TabIndex = 70;
            this.toolTip1.SetToolTip(this.txtProfileName, "The filename of the currently loaded profile.");
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadProfile.Location = new System.Drawing.Point(279, 2);
            this.btnLoadProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(22, 19);
            this.btnLoadProfile.TabIndex = 68;
            this.btnLoadProfile.Text = "...";
            this.toolTip1.SetToolTip(this.btnLoadProfile, "Load profile");
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReverse.Location = new System.Drawing.Point(241, 336);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(70, 40);
            this.btnReverse.TabIndex = 67;
            this.btnReverse.Text = "Reverse";
            this.toolTip1.SetToolTip(this.btnReverse, "Reverse XYZ locations");
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplace.Location = new System.Drawing.Point(241, 292);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(70, 40);
            this.btnReplace.TabIndex = 64;
            this.btnReplace.Text = "Replace";
            this.toolTip1.SetToolTip(this.btnReplace, "Replace current XYZ location");
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(315, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 40);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete selected";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete selected XYZ locations");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblProfileNameLabel
            // 
            this.lblProfileNameLabel.AutoSize = true;
            this.lblProfileNameLabel.Location = new System.Drawing.Point(7, 6);
            this.lblProfileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileNameLabel.Name = "lblProfileNameLabel";
            this.lblProfileNameLabel.Size = new System.Drawing.Size(70, 13);
            this.lblProfileNameLabel.TabIndex = 69;
            this.lblProfileNameLabel.Text = "Profile Name:";
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Location = new System.Drawing.Point(167, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(217, 260);
            this.tabMain.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstHotSpots);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(209, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hotspots";
            this.toolTip1.SetToolTip(this.tabPage1, "The primary hotspots in your profile.");
            this.tabPage1.ToolTipText = "The primary hotspots in your profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstHotSpots
            // 
            this.lstHotSpots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHotSpots.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstHotSpots.FormattingEnabled = true;
            this.lstHotSpots.ItemHeight = 20;
            this.lstHotSpots.Location = new System.Drawing.Point(4, 5);
            this.lstHotSpots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHotSpots.Name = "lstHotSpots";
            this.lstHotSpots.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstHotSpots.Size = new System.Drawing.Size(204, 204);
            this.lstHotSpots.TabIndex = 0;
            this.lstHotSpots.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstHotSpots_DrawItem);
            this.lstHotSpots.DoubleClick += new System.EventHandler(this.lstHotSpots_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstBlackspots);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(228, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blackspots";
            this.toolTip1.SetToolTip(this.tabPage2, "Spots that cause problems and need to be avoided.");
            this.tabPage2.ToolTipText = "Spots that cause problems and need to be avoided";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstBlackspots
            // 
            this.lstBlackspots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBlackspots.FormattingEnabled = true;
            this.lstBlackspots.Location = new System.Drawing.Point(4, 5);
            this.lstBlackspots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBlackspots.Name = "lstBlackspots";
            this.lstBlackspots.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBlackspots.Size = new System.Drawing.Size(296, 186);
            this.lstBlackspots.TabIndex = 21;
            this.lstBlackspots.DoubleClick += new System.EventHandler(this.lstBlackspots_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstMailboxes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(228, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailboxes";
            this.toolTip1.SetToolTip(this.tabPage3, "Mailbox locations.");
            this.tabPage3.ToolTipText = "Mailbox locations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstMailboxes
            // 
            this.lstMailboxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMailboxes.FormattingEnabled = true;
            this.lstMailboxes.Location = new System.Drawing.Point(4, 5);
            this.lstMailboxes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMailboxes.Name = "lstMailboxes";
            this.lstMailboxes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMailboxes.Size = new System.Drawing.Size(295, 186);
            this.lstMailboxes.TabIndex = 22;
            this.lstMailboxes.DoubleClick += new System.EventHandler(this.lstMailboxes_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstNPC);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(228, 193);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NPC";
            this.toolTip1.SetToolTip(this.tabPage4, "Repair/food vendors.");
            this.tabPage4.ToolTipText = "Repair and food vendors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstNPC
            // 
            this.lstNPC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNPC.FormattingEnabled = true;
            this.lstNPC.Location = new System.Drawing.Point(4, 5);
            this.lstNPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstNPC.Name = "lstNPC";
            this.lstNPC.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstNPC.Size = new System.Drawing.Size(296, 186);
            this.lstNPC.TabIndex = 22;
            this.lstNPC.DoubleClick += new System.EventHandler(this.lstNPC_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBlackspotRadius);
            this.groupBox2.Controls.Add(this.chkGenerateHotspots);
            this.groupBox2.Controls.Add(this.txtSpacing);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(143, 86);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Hotspot spacing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blackspot radius:";
            // 
            // txtBlackspotRadius
            // 
            this.txtBlackspotRadius.Location = new System.Drawing.Point(105, 18);
            this.txtBlackspotRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBlackspotRadius.Name = "txtBlackspotRadius";
            this.txtBlackspotRadius.Size = new System.Drawing.Size(24, 20);
            this.txtBlackspotRadius.TabIndex = 5;
            this.txtBlackspotRadius.Text = "20";
            this.toolTip1.SetToolTip(this.txtBlackspotRadius, "The radius of the blackspot");
            // 
            // chkGenerateHotspots
            // 
            this.chkGenerateHotspots.AutoSize = true;
            this.chkGenerateHotspots.Location = new System.Drawing.Point(16, 60);
            this.chkGenerateHotspots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkGenerateHotspots.Name = "chkGenerateHotspots";
            this.chkGenerateHotspots.Size = new System.Drawing.Size(85, 14);
            this.chkGenerateHotspots.TabIndex = 11;
            this.chkGenerateHotspots.Text = "Generate hotspots";
            this.toolTip1.SetToolTip(this.chkGenerateHotspots, "Automatically generate hotspots with the spacing indicated above");
            this.chkGenerateHotspots.UseVisualStyleBackColor = true;
            // 
            // txtSpacing
            // 
            this.txtSpacing.Location = new System.Drawing.Point(105, 39);
            this.txtSpacing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpacing.Name = "txtSpacing";
            this.txtSpacing.Size = new System.Drawing.Size(24, 20);
            this.txtSpacing.TabIndex = 12;
            this.txtSpacing.Text = "20";
            this.toolTip1.SetToolTip(this.txtSpacing, "The minimum distance between autogenerated hotspots");
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(9, 387);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(374, 58);
            this.txtOutput.TabIndex = 60;
            this.toolTip1.SetToolTip(this.txtOutput, "Messages from Hotspot Recorder");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(389, 22);
            this.statusStrip1.TabIndex = 59;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Resize += new System.EventHandler(this.statusStrip1_Resize);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(67, 16);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLocationNPC);
            this.groupBox3.Controls.Add(this.lblLocationMe);
            this.groupBox3.Controls.Add(this.lblNPCName);
            this.groupBox3.Controls.Add(this.lblMeName);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(143, 95);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location:";
            // 
            // lblLocationNPC
            // 
            this.lblLocationNPC.AutoSize = true;
            this.lblLocationNPC.Location = new System.Drawing.Point(14, 76);
            this.lblLocationNPC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationNPC.Name = "lblLocationNPC";
            this.lblLocationNPC.Size = new System.Drawing.Size(86, 13);
            this.lblLocationNPC.TabIndex = 3;
            this.lblLocationNPC.Text = "<target location>";
            this.toolTip1.SetToolTip(this.lblLocationNPC, "Target location");
            // 
            // lblLocationMe
            // 
            this.lblLocationMe.AutoSize = true;
            this.lblLocationMe.Location = new System.Drawing.Point(14, 34);
            this.lblLocationMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationMe.Name = "lblLocationMe";
            this.lblLocationMe.Size = new System.Drawing.Size(72, 13);
            this.lblLocationMe.TabIndex = 2;
            this.lblLocationMe.Text = "<my location>";
            this.toolTip1.SetToolTip(this.lblLocationMe, "My location");
            // 
            // lblNPCName
            // 
            this.lblNPCName.AutoSize = true;
            this.lblNPCName.Location = new System.Drawing.Point(4, 59);
            this.lblNPCName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNPCName.Name = "lblNPCName";
            this.lblNPCName.Size = new System.Drawing.Size(75, 13);
            this.lblNPCName.TabIndex = 1;
            this.lblNPCName.Text = "<target name>";
            this.toolTip1.SetToolTip(this.lblNPCName, "Target Name");
            // 
            // lblMeName
            // 
            this.lblMeName.AutoSize = true;
            this.lblMeName.Location = new System.Drawing.Point(4, 21);
            this.lblMeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeName.Name = "lblMeName";
            this.lblMeName.Size = new System.Drawing.Size(25, 13);
            this.lblMeName.TabIndex = 0;
            this.lblMeName.Text = "Me:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoTo.Location = new System.Drawing.Point(167, 292);
            this.btnGoTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(70, 40);
            this.btnGoTo.TabIndex = 76;
            this.btnGoTo.Text = "Go To";
            this.toolTip1.SetToolTip(this.btnGoTo, "Go to selected XYZ location.");
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnCheckPoints
            // 
            this.btnCheckPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckPoints.Location = new System.Drawing.Point(315, 292);
            this.btnCheckPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckPoints.Name = "btnCheckPoints";
            this.btnCheckPoints.Size = new System.Drawing.Size(70, 40);
            this.btnCheckPoints.TabIndex = 77;
            this.btnCheckPoints.Text = "Check points";
            this.toolTip1.SetToolTip(this.btnCheckPoints, "Check the points for navigability, commenting out those that can\'t be reached.");
            this.btnCheckPoints.UseVisualStyleBackColor = true;
            this.btnCheckPoints.Click += new System.EventHandler(this.btnCheckPoints_Click);
            // 
            // btnSetTop
            // 
            this.btnSetTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetTop.Location = new System.Drawing.Point(167, 336);
            this.btnSetTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetTop.Name = "btnSetTop";
            this.btnSetTop.Size = new System.Drawing.Size(70, 40);
            this.btnSetTop.TabIndex = 78;
            this.btnSetTop.Text = "Set As Top";
            this.toolTip1.SetToolTip(this.btnSetTop, "Set the currently selected hotspot as the first hotspot in the profile.");
            this.btnSetTop.UseVisualStyleBackColor = true;
            this.btnSetTop.Click += new System.EventHandler(this.btnSetTop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 469);
            this.Controls.Add(this.btnSetTop);
            this.Controls.Add(this.btnCheckPoints);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblProfileNameLabel);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Hotspot Recorder by Kamilche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBlackspot;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnAddMailbox;
        private System.Windows.Forms.Button btnAddHotspot;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblProfileNameLabel;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private FlickerFreeListBox lstHotSpots;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstBlackspots;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstMailboxes;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstNPC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlackspotRadius;
        private System.Windows.Forms.CheckBox chkGenerateHotspots;
        private System.Windows.Forms.TextBox txtSpacing;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLocationNPC;
        private System.Windows.Forms.Label lblLocationMe;
        private System.Windows.Forms.Label lblNPCName;
        private System.Windows.Forms.Label lblMeName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCheckPoints;
        private System.Windows.Forms.Button btnSetTop;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

    }
}

