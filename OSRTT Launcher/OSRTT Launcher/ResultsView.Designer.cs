
namespace OSRTT_Launcher
{
    partial class ResultsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perceivedResponseTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialResponseTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeResponseTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deNoisedRawDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHeatmapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asTransparentPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stdResultsMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.runSelectToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.graphViewMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.rtViewMenuList = new System.Windows.Forms.ToolStripComboBox();
            this.denoiseToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importViewMenuButton = new System.Windows.Forms.ToolStripButton();
            this.graphViewPanel = new System.Windows.Forms.Panel();
            this.viewGammaBtn = new System.Windows.Forms.Button();
            this.saveGraphNoHSpanBtn = new System.Windows.Forms.Button();
            this.saveAsPNGBtn = new System.Windows.Forms.Button();
            this.latencyLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.runSelectBox = new System.Windows.Forms.ComboBox();
            this.rtTypeLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.overshootStyleListBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processTypeListBox = new System.Windows.Forms.ComboBox();
            this.rtLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetGraphBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transSelect1 = new System.Windows.Forms.ComboBox();
            this.graphedData = new ScottPlot.FormsPlot();
            this.importPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.importProcessedInputLagBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.processRawInputLagBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.importGraphBtn = new System.Windows.Forms.Button();
            this.importRawFolder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.importRawFolderBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.importRawFileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.importResultsViewBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.importProcILBtn = new System.Windows.Forms.Button();
            this.heatmaps1 = new OSRTT_Launcher.Heatmaps();
            this.inputLagProcRV1 = new OSRTT_Launcher.InputLagProcRV();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.graphViewPanel.SuspendLayout();
            this.importPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.saveHeatmapsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(5278, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perceivedResponseTimeToolStripMenuItem,
            this.initialResponseTimeToolStripMenuItem,
            this.completeResponseTimeToolStripMenuItem,
            this.toolStripSeparator2,
            this.deNoisedRawDataToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // perceivedResponseTimeToolStripMenuItem
            // 
            this.perceivedResponseTimeToolStripMenuItem.Checked = true;
            this.perceivedResponseTimeToolStripMenuItem.CheckOnClick = true;
            this.perceivedResponseTimeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.perceivedResponseTimeToolStripMenuItem.Name = "perceivedResponseTimeToolStripMenuItem";
            this.perceivedResponseTimeToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.perceivedResponseTimeToolStripMenuItem.Text = "Perceived Response Time";
            this.perceivedResponseTimeToolStripMenuItem.Click += new System.EventHandler(this.perceivedResponseTimeToolStripMenuItem_Click);
            // 
            // initialResponseTimeToolStripMenuItem
            // 
            this.initialResponseTimeToolStripMenuItem.CheckOnClick = true;
            this.initialResponseTimeToolStripMenuItem.Name = "initialResponseTimeToolStripMenuItem";
            this.initialResponseTimeToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.initialResponseTimeToolStripMenuItem.Text = "Initial Response Time";
            this.initialResponseTimeToolStripMenuItem.Click += new System.EventHandler(this.initialResponseTimeToolStripMenuItem_Click);
            // 
            // completeResponseTimeToolStripMenuItem
            // 
            this.completeResponseTimeToolStripMenuItem.CheckOnClick = true;
            this.completeResponseTimeToolStripMenuItem.Name = "completeResponseTimeToolStripMenuItem";
            this.completeResponseTimeToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.completeResponseTimeToolStripMenuItem.Text = "Complete Response Time";
            this.completeResponseTimeToolStripMenuItem.Click += new System.EventHandler(this.completeResponseTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(321, 6);
            // 
            // deNoisedRawDataToolStripMenuItem
            // 
            this.deNoisedRawDataToolStripMenuItem.CheckOnClick = true;
            this.deNoisedRawDataToolStripMenuItem.Name = "deNoisedRawDataToolStripMenuItem";
            this.deNoisedRawDataToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.deNoisedRawDataToolStripMenuItem.Text = "De-Noised Raw Data";
            this.deNoisedRawDataToolStripMenuItem.Click += new System.EventHandler(this.deNoisedRawDataToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // saveHeatmapsToolStripMenuItem
            // 
            this.saveHeatmapsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asPNGToolStripMenuItem,
            this.asTransparentPNGToolStripMenuItem});
            this.saveHeatmapsToolStripMenuItem.Name = "saveHeatmapsToolStripMenuItem";
            this.saveHeatmapsToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            this.saveHeatmapsToolStripMenuItem.Text = "Save Heatmaps";
            // 
            // asPNGToolStripMenuItem
            // 
            this.asPNGToolStripMenuItem.Name = "asPNGToolStripMenuItem";
            this.asPNGToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.asPNGToolStripMenuItem.Text = "As PNG";
            this.asPNGToolStripMenuItem.Click += new System.EventHandler(this.asPNGToolStripMenuItem_Click);
            // 
            // asTransparentPNGToolStripMenuItem
            // 
            this.asTransparentPNGToolStripMenuItem.Name = "asTransparentPNGToolStripMenuItem";
            this.asTransparentPNGToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.asTransparentPNGToolStripMenuItem.Text = "As Transparent PNG";
            this.asTransparentPNGToolStripMenuItem.Click += new System.EventHandler(this.asTransparentPNGToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stdResultsMenuBtn,
            this.runSelectToolStrip,
            this.toolStripSeparator1,
            this.graphViewMenuBtn,
            this.rtViewMenuList,
            this.denoiseToolStripBtn,
            this.toolStripSeparator3,
            this.importViewMenuButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(5278, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stdResultsMenuBtn
            // 
            this.stdResultsMenuBtn.Checked = true;
            this.stdResultsMenuBtn.CheckOnClick = true;
            this.stdResultsMenuBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stdResultsMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stdResultsMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("stdResultsMenuBtn.Image")));
            this.stdResultsMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stdResultsMenuBtn.Name = "stdResultsMenuBtn";
            this.stdResultsMenuBtn.Size = new System.Drawing.Size(98, 29);
            this.stdResultsMenuBtn.Text = "Heatmaps";
            this.stdResultsMenuBtn.Click += new System.EventHandler(this.stdResultsMenuBtn_Click);
            // 
            // runSelectToolStrip
            // 
            this.runSelectToolStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runSelectToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSelectToolStrip.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.runSelectToolStrip.Name = "runSelectToolStrip";
            this.runSelectToolStrip.Size = new System.Drawing.Size(199, 34);
            this.runSelectToolStrip.SelectedIndexChanged += new System.EventHandler(this.runSelectToolStrip_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // graphViewMenuBtn
            // 
            this.graphViewMenuBtn.CheckOnClick = true;
            this.graphViewMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.graphViewMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("graphViewMenuBtn.Image")));
            this.graphViewMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.graphViewMenuBtn.Name = "graphViewMenuBtn";
            this.graphViewMenuBtn.Size = new System.Drawing.Size(155, 29);
            this.graphViewMenuBtn.Text = "Raw Data Graphs";
            this.graphViewMenuBtn.Click += new System.EventHandler(this.graphViewMenuBtn_Click);
            // 
            // rtViewMenuList
            // 
            this.rtViewMenuList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rtViewMenuList.DropDownWidth = 175;
            this.rtViewMenuList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rtViewMenuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtViewMenuList.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.rtViewMenuList.Name = "rtViewMenuList";
            this.rtViewMenuList.Size = new System.Drawing.Size(289, 34);
            this.rtViewMenuList.SelectedIndexChanged += new System.EventHandler(this.rtViewMenuList_SelectedIndexChanged);
            // 
            // denoiseToolStripBtn
            // 
            this.denoiseToolStripBtn.CheckOnClick = true;
            this.denoiseToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.denoiseToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("denoiseToolStripBtn.Image")));
            this.denoiseToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.denoiseToolStripBtn.Name = "denoiseToolStripBtn";
            this.denoiseToolStripBtn.Size = new System.Drawing.Size(137, 29);
            this.denoiseToolStripBtn.Text = "Denoise Graph";
            this.denoiseToolStripBtn.Click += new System.EventHandler(this.denoiseToolStripBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // importViewMenuButton
            // 
            this.importViewMenuButton.CheckOnClick = true;
            this.importViewMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importViewMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("importViewMenuButton.Image")));
            this.importViewMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importViewMenuButton.Name = "importViewMenuButton";
            this.importViewMenuButton.Size = new System.Drawing.Size(114, 29);
            this.importViewMenuButton.Text = "Import Data";
            this.importViewMenuButton.Click += new System.EventHandler(this.importViewMenuButton_Click);
            // 
            // graphViewPanel
            // 
            this.graphViewPanel.Controls.Add(this.viewGammaBtn);
            this.graphViewPanel.Controls.Add(this.saveGraphNoHSpanBtn);
            this.graphViewPanel.Controls.Add(this.saveAsPNGBtn);
            this.graphViewPanel.Controls.Add(this.latencyLabel);
            this.graphViewPanel.Controls.Add(this.label8);
            this.graphViewPanel.Controls.Add(this.label7);
            this.graphViewPanel.Controls.Add(this.runSelectBox);
            this.graphViewPanel.Controls.Add(this.rtTypeLabel);
            this.graphViewPanel.Controls.Add(this.osLabel);
            this.graphViewPanel.Controls.Add(this.label6);
            this.graphViewPanel.Controls.Add(this.label4);
            this.graphViewPanel.Controls.Add(this.overshootStyleListBox);
            this.graphViewPanel.Controls.Add(this.label3);
            this.graphViewPanel.Controls.Add(this.processTypeListBox);
            this.graphViewPanel.Controls.Add(this.rtLabel);
            this.graphViewPanel.Controls.Add(this.label2);
            this.graphViewPanel.Controls.Add(this.resetGraphBtn);
            this.graphViewPanel.Controls.Add(this.label1);
            this.graphViewPanel.Controls.Add(this.transSelect1);
            this.graphViewPanel.Controls.Add(this.graphedData);
            this.graphViewPanel.Location = new System.Drawing.Point(8, 773);
            this.graphViewPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.graphViewPanel.Name = "graphViewPanel";
            this.graphViewPanel.Size = new System.Drawing.Size(2307, 996);
            this.graphViewPanel.TabIndex = 4;
            // 
            // viewGammaBtn
            // 
            this.viewGammaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewGammaBtn.FlatAppearance.BorderSize = 0;
            this.viewGammaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewGammaBtn.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.viewGammaBtn.Location = new System.Drawing.Point(1967, 12);
            this.viewGammaBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viewGammaBtn.Name = "viewGammaBtn";
            this.viewGammaBtn.Size = new System.Drawing.Size(322, 50);
            this.viewGammaBtn.TabIndex = 28;
            this.viewGammaBtn.Text = "Gamma Curve";
            this.viewGammaBtn.UseVisualStyleBackColor = false;
            this.viewGammaBtn.Click += new System.EventHandler(this.viewGammaBtn_Click);
            // 
            // saveGraphNoHSpanBtn
            // 
            this.saveGraphNoHSpanBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveGraphNoHSpanBtn.FlatAppearance.BorderSize = 0;
            this.saveGraphNoHSpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveGraphNoHSpanBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.saveGraphNoHSpanBtn.Location = new System.Drawing.Point(1978, 894);
            this.saveGraphNoHSpanBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saveGraphNoHSpanBtn.Name = "saveGraphNoHSpanBtn";
            this.saveGraphNoHSpanBtn.Size = new System.Drawing.Size(303, 73);
            this.saveGraphNoHSpanBtn.TabIndex = 25;
            this.saveGraphNoHSpanBtn.Text = "Save as PNG\r\nWithout Block";
            this.saveGraphNoHSpanBtn.UseVisualStyleBackColor = false;
            this.saveGraphNoHSpanBtn.Click += new System.EventHandler(this.saveGraphNoHSpanBtn_Click);
            // 
            // saveAsPNGBtn
            // 
            this.saveAsPNGBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveAsPNGBtn.FlatAppearance.BorderSize = 0;
            this.saveAsPNGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAsPNGBtn.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.saveAsPNGBtn.Location = new System.Drawing.Point(1978, 839);
            this.saveAsPNGBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saveAsPNGBtn.Name = "saveAsPNGBtn";
            this.saveAsPNGBtn.Size = new System.Drawing.Size(303, 47);
            this.saveAsPNGBtn.TabIndex = 24;
            this.saveAsPNGBtn.Text = "Save as PNG";
            this.saveAsPNGBtn.UseVisualStyleBackColor = false;
            this.saveAsPNGBtn.Click += new System.EventHandler(this.saveAsPNGBtn_Click);
            // 
            // latencyLabel
            // 
            this.latencyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.latencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latencyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.latencyLabel.Location = new System.Drawing.Point(1983, 698);
            this.latencyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.latencyLabel.Name = "latencyLabel";
            this.latencyLabel.Size = new System.Drawing.Size(298, 69);
            this.latencyLabel.TabIndex = 23;
            this.latencyLabel.Text = "0 ms";
            this.latencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1987, 660);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "Result Latency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(30, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Select a Run:";
            // 
            // runSelectBox
            // 
            this.runSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSelectBox.FormattingEnabled = true;
            this.runSelectBox.Location = new System.Drawing.Point(293, 14);
            this.runSelectBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.runSelectBox.Name = "runSelectBox";
            this.runSelectBox.Size = new System.Drawing.Size(231, 45);
            this.runSelectBox.TabIndex = 20;
            this.runSelectBox.SelectedIndexChanged += new System.EventHandler(this.runSelectBox_SelectedIndexChanged);
            // 
            // rtTypeLabel
            // 
            this.rtTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtTypeLabel.Location = new System.Drawing.Point(2005, 115);
            this.rtTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rtTypeLabel.Name = "rtTypeLabel";
            this.rtTypeLabel.Size = new System.Drawing.Size(253, 36);
            this.rtTypeLabel.TabIndex = 19;
            this.rtTypeLabel.Text = "Perceived";
            this.rtTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // osLabel
            // 
            this.osLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.osLabel.Location = new System.Drawing.Point(1982, 453);
            this.osLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(298, 69);
            this.osLabel.TabIndex = 18;
            this.osLabel.Text = "0 RGB";
            this.osLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1995, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 46);
            this.label6.TabIndex = 17;
            this.label6.Text = "Overshoot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1973, 543);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Change Overshoot Style:";
            // 
            // overshootStyleListBox
            // 
            this.overshootStyleListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overshootStyleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overshootStyleListBox.FormattingEnabled = true;
            this.overshootStyleListBox.Location = new System.Drawing.Point(1967, 569);
            this.overshootStyleListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.overshootStyleListBox.Name = "overshootStyleListBox";
            this.overshootStyleListBox.Size = new System.Drawing.Size(319, 33);
            this.overshootStyleListBox.TabIndex = 15;
            this.overshootStyleListBox.SelectedIndexChanged += new System.EventHandler(this.overshootStyleListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1973, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Change Measurement Style:";
            // 
            // processTypeListBox
            // 
            this.processTypeListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTypeListBox.FormattingEnabled = true;
            this.processTypeListBox.Location = new System.Drawing.Point(1967, 321);
            this.processTypeListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.processTypeListBox.Name = "processTypeListBox";
            this.processTypeListBox.Size = new System.Drawing.Size(319, 33);
            this.processTypeListBox.TabIndex = 13;
            this.processTypeListBox.SelectedIndexChanged += new System.EventHandler(this.processTypeListBox_SelectedIndexChanged);
            // 
            // rtLabel
            // 
            this.rtLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtLabel.Location = new System.Drawing.Point(1983, 195);
            this.rtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rtLabel.Name = "rtLabel";
            this.rtLabel.Size = new System.Drawing.Size(298, 69);
            this.rtLabel.TabIndex = 10;
            this.rtLabel.Text = "0 ms";
            this.rtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1975, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Response Time:";
            // 
            // resetGraphBtn
            // 
            this.resetGraphBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetGraphBtn.FlatAppearance.BorderSize = 0;
            this.resetGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetGraphBtn.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.resetGraphBtn.Location = new System.Drawing.Point(1623, 12);
            this.resetGraphBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.resetGraphBtn.Name = "resetGraphBtn";
            this.resetGraphBtn.Size = new System.Drawing.Size(322, 47);
            this.resetGraphBtn.TabIndex = 8;
            this.resetGraphBtn.Text = "Reset Graph";
            this.resetGraphBtn.UseVisualStyleBackColor = false;
            this.resetGraphBtn.Click += new System.EventHandler(this.resetGraphBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(627, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Transition:";
            // 
            // transSelect1
            // 
            this.transSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transSelect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transSelect1.FormattingEnabled = true;
            this.transSelect1.Location = new System.Drawing.Point(992, 14);
            this.transSelect1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.transSelect1.Name = "transSelect1";
            this.transSelect1.Size = new System.Drawing.Size(544, 45);
            this.transSelect1.TabIndex = 1;
            this.transSelect1.SelectedIndexChanged += new System.EventHandler(this.transSelect1_SelectedIndexChanged);
            // 
            // graphedData
            // 
            this.graphedData.Location = new System.Drawing.Point(10, 71);
            this.graphedData.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.graphedData.Name = "graphedData";
            this.graphedData.Size = new System.Drawing.Size(1973, 922);
            this.graphedData.TabIndex = 0;
            // 
            // importPanel
            // 
            this.importPanel.Controls.Add(this.panel4);
            this.importPanel.Controls.Add(this.panel3);
            this.importPanel.Controls.Add(this.panel2);
            this.importPanel.Controls.Add(this.panel1);
            this.importPanel.Location = new System.Drawing.Point(8, 72);
            this.importPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(1803, 562);
            this.importPanel.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.importProcessedInputLagBtn);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.processRawInputLagBtn);
            this.panel4.Location = new System.Drawing.Point(12, 400);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1769, 145);
            this.panel4.TabIndex = 25;
            // 
            // importProcessedInputLagBtn
            // 
            this.importProcessedInputLagBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importProcessedInputLagBtn.FlatAppearance.BorderSize = 0;
            this.importProcessedInputLagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importProcessedInputLagBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importProcessedInputLagBtn.Location = new System.Drawing.Point(1188, 18);
            this.importProcessedInputLagBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importProcessedInputLagBtn.Name = "importProcessedInputLagBtn";
            this.importProcessedInputLagBtn.Size = new System.Drawing.Size(515, 104);
            this.importProcessedInputLagBtn.TabIndex = 24;
            this.importProcessedInputLagBtn.Text = "Import Processed File to Graph";
            this.importProcessedInputLagBtn.UseVisualStyleBackColor = false;
            this.importProcessedInputLagBtn.Click += new System.EventHandler(this.importProcILBtn_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(73, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 110);
            this.label9.TabIndex = 23;
            this.label9.Text = "Input Latency\r\nFunctions";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // processRawInputLagBtn
            // 
            this.processRawInputLagBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processRawInputLagBtn.FlatAppearance.BorderSize = 0;
            this.processRawInputLagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.processRawInputLagBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.processRawInputLagBtn.Location = new System.Drawing.Point(548, 18);
            this.processRawInputLagBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.processRawInputLagBtn.Name = "processRawInputLagBtn";
            this.processRawInputLagBtn.Size = new System.Drawing.Size(515, 104);
            this.processRawInputLagBtn.TabIndex = 9;
            this.processRawInputLagBtn.Text = "Import Raw Data File to Process";
            this.processRawInputLagBtn.UseVisualStyleBackColor = false;
            this.processRawInputLagBtn.Click += new System.EventHandler(this.processRawInputLagBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.importGraphBtn);
            this.panel3.Controls.Add(this.importRawFolder);
            this.panel3.Location = new System.Drawing.Point(1258, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 387);
            this.panel3.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(38, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(397, 55);
            this.label13.TabIndex = 23;
            this.label13.Text = "Graph Raw Data";
            // 
            // importGraphBtn
            // 
            this.importGraphBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importGraphBtn.FlatAppearance.BorderSize = 0;
            this.importGraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importGraphBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importGraphBtn.Location = new System.Drawing.Point(72, 82);
            this.importGraphBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importGraphBtn.Name = "importGraphBtn";
            this.importGraphBtn.Size = new System.Drawing.Size(385, 129);
            this.importGraphBtn.TabIndex = 7;
            this.importGraphBtn.Text = "Import Raw Data File to Graph";
            this.importGraphBtn.UseVisualStyleBackColor = false;
            this.importGraphBtn.Click += new System.EventHandler(this.importGraphBtn_Click);
            // 
            // importRawFolder
            // 
            this.importRawFolder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importRawFolder.FlatAppearance.BorderSize = 0;
            this.importRawFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importRawFolder.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importRawFolder.Location = new System.Drawing.Point(72, 219);
            this.importRawFolder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importRawFolder.Name = "importRawFolder";
            this.importRawFolder.Size = new System.Drawing.Size(385, 129);
            this.importRawFolder.TabIndex = 8;
            this.importRawFolder.Text = "Import Raw Data Folder to Graph";
            this.importRawFolder.UseVisualStyleBackColor = false;
            this.importRawFolder.Click += new System.EventHandler(this.importRawFolder_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.importRawFolderBtn);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.importRawFileBtn);
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 330);
            this.panel2.TabIndex = 24;
            // 
            // importRawFolderBtn
            // 
            this.importRawFolderBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importRawFolderBtn.FlatAppearance.BorderSize = 0;
            this.importRawFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importRawFolderBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importRawFolderBtn.Location = new System.Drawing.Point(37, 197);
            this.importRawFolderBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importRawFolderBtn.Name = "importRawFolderBtn";
            this.importRawFolderBtn.Size = new System.Drawing.Size(515, 104);
            this.importRawFolderBtn.TabIndex = 24;
            this.importRawFolderBtn.Text = "Import Raw Data Folder to Process";
            this.importRawFolderBtn.UseVisualStyleBackColor = false;
            this.importRawFolderBtn.Click += new System.EventHandler(this.importRawFolderBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(48, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(439, 55);
            this.label11.TabIndex = 23;
            this.label11.Text = "Process Raw Data";
            // 
            // importRawFileBtn
            // 
            this.importRawFileBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importRawFileBtn.FlatAppearance.BorderSize = 0;
            this.importRawFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importRawFileBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importRawFileBtn.Location = new System.Drawing.Point(37, 82);
            this.importRawFileBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importRawFileBtn.Name = "importRawFileBtn";
            this.importRawFileBtn.Size = new System.Drawing.Size(515, 104);
            this.importRawFileBtn.TabIndex = 9;
            this.importRawFileBtn.Text = "Import Raw Data File to Process";
            this.importRawFileBtn.UseVisualStyleBackColor = false;
            this.importRawFileBtn.Click += new System.EventHandler(this.importRawFileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.importResultsViewBtn);
            this.panel1.Location = new System.Drawing.Point(635, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 240);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 55);
            this.label5.TabIndex = 23;
            this.label5.Text = "Create Heatmaps";
            // 
            // importResultsViewBtn
            // 
            this.importResultsViewBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importResultsViewBtn.FlatAppearance.BorderSize = 0;
            this.importResultsViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importResultsViewBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importResultsViewBtn.Location = new System.Drawing.Point(40, 82);
            this.importResultsViewBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.importResultsViewBtn.Name = "importResultsViewBtn";
            this.importResultsViewBtn.Size = new System.Drawing.Size(515, 129);
            this.importResultsViewBtn.TabIndex = 9;
            this.importResultsViewBtn.Text = "Import Processed Data File for Heatmaps";
            this.importResultsViewBtn.UseVisualStyleBackColor = false;
            this.importResultsViewBtn.Click += new System.EventHandler(this.importResultsViewBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 642);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1812, 32);
            this.progressBar1.Step = 50;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 34;
            this.progressBar1.Visible = false;
            // 
            // importProcILBtn
            // 
            this.importProcILBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importProcILBtn.FlatAppearance.BorderSize = 0;
            this.importProcILBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importProcILBtn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.importProcILBtn.Location = new System.Drawing.Point(713, 13);
            this.importProcILBtn.Name = "importProcILBtn";
            this.importProcILBtn.Size = new System.Drawing.Size(309, 75);
            this.importProcILBtn.TabIndex = 24;
            this.importProcILBtn.Text = "Import Processed File to Graph";
            this.importProcILBtn.UseVisualStyleBackColor = false;
            // 
            // heatmaps1
            // 
            this.heatmaps1.Location = new System.Drawing.Point(2325, 76);
            this.heatmaps1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.heatmaps1.Name = "heatmaps1";
            this.heatmaps1.Size = new System.Drawing.Size(2958, 1315);
            this.heatmaps1.TabIndex = 6;
            // 
            // inputLagProcRV1
            // 
            this.inputLagProcRV1.BackColor = System.Drawing.Color.Transparent;
            this.inputLagProcRV1.inputLagResults = null;
            this.inputLagProcRV1.Location = new System.Drawing.Point(2388, 132);
            this.inputLagProcRV1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.inputLagProcRV1.Name = "inputLagProcRV1";
            this.inputLagProcRV1.Size = new System.Drawing.Size(2053, 1072);
            this.inputLagProcRV1.TabIndex = 35;
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(5278, 1667);
            this.Controls.Add(this.inputLagProcRV1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.heatmaps1);
            this.Controls.Add(this.importPanel);
            this.Controls.Add(this.graphViewPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ResultsView";
            this.Text = "ResultsView";
            this.Load += new System.EventHandler(this.ResultsView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.graphViewPanel.ResumeLayout(false);
            this.graphViewPanel.PerformLayout();
            this.importPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stdResultsMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton graphViewMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton importViewMenuButton;
        private System.Windows.Forms.Panel graphViewPanel;
        private ScottPlot.FormsPlot graphedData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox transSelect1;
        private System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.Button importGraphBtn;
        private System.Windows.Forms.Button resetGraphBtn;
        private System.Windows.Forms.Label rtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox processTypeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox overshootStyleListBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rtTypeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox runSelectBox;
        private System.Windows.Forms.Button importRawFolder;
        private System.Windows.Forms.Label latencyLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button importResultsViewBtn;
        private System.Windows.Forms.Button saveAsPNGBtn;
        private System.Windows.Forms.Button saveGraphNoHSpanBtn;
        private System.Windows.Forms.ToolStripMenuItem saveHeatmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTransparentPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perceivedResponseTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialResponseTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeResponseTimeToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button importRawFileBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button importRawFolderBtn;
        private Heatmaps heatmaps1;
        private System.Windows.Forms.ToolStripComboBox runSelectToolStrip;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem asPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deNoisedRawDataToolStripMenuItem;
        private System.Windows.Forms.Button viewGammaBtn;
        private System.Windows.Forms.ToolStripComboBox rtViewMenuList;
        private System.Windows.Forms.ToolStripButton denoiseToolStripBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button importProcessedInputLagBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button processRawInputLagBtn;
        private System.Windows.Forms.Button importProcILBtn;
        private InputLagProcRV inputLagProcRV1;
    }
}