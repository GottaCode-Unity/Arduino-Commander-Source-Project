namespace Arduino_Commander
{
    partial class MainWindow
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
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.gbCommunication = new System.Windows.Forms.GroupBox();
            this.lbSerial = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.timerRecieve = new System.Windows.Forms.Timer(this.components);
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btnRefrashPorts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.Inspector = new System.Windows.Forms.GroupBox();
            this.panelCreateComponent = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateComp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbProgram = new System.Windows.Forms.GroupBox();
            this.component1 = new System.Windows.Forms.Button();
            this.menuIDE = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatusManual = new System.Windows.Forms.StatusStrip();
            this.arduinoConnectedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.arduinoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbll = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDisconnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbCommunication.SuspendLayout();
            this.gbConnect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Inspector.SuspendLayout();
            this.panelCreateComponent.SuspendLayout();
            this.gbProgram.SuspendLayout();
            this.menuIDE.SuspendLayout();
            this.ssStatusManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // Arduino
            // 
            this.Arduino.PortName = "COM4";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(306, 35);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbText
            // 
            this.tbText.AutoCompleteCustomSource.AddRange(new string[] {
            "DOUT",
            "AOUT",
            "DREAD",
            "AREAD",
            "TEXT"});
            this.tbText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbText.Location = new System.Drawing.Point(6, 18);
            this.tbText.Name = "tbText";
            this.tbText.ShortcutsEnabled = false;
            this.tbText.Size = new System.Drawing.Size(306, 20);
            this.tbText.TabIndex = 1;
            this.tbText.TabStop = false;
            this.tbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbText_KeyDown);
            // 
            // gbCommunication
            // 
            this.gbCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommunication.Controls.Add(this.lbSerial);
            this.gbCommunication.Controls.Add(this.btnClear);
            this.gbCommunication.Controls.Add(this.tbText);
            this.gbCommunication.Controls.Add(this.btnSend);
            this.gbCommunication.Enabled = false;
            this.gbCommunication.Location = new System.Drawing.Point(183, 6);
            this.gbCommunication.Name = "gbCommunication";
            this.gbCommunication.Size = new System.Drawing.Size(795, 525);
            this.gbCommunication.TabIndex = 2;
            this.gbCommunication.TabStop = false;
            this.gbCommunication.Text = "Communication";
            // 
            // lbSerial
            // 
            this.lbSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSerial.FormattingEnabled = true;
            this.lbSerial.Items.AddRange(new object[] {
            "Serial:"});
            this.lbSerial.Location = new System.Drawing.Point(318, 19);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.ScrollAlwaysVisible = true;
            this.lbSerial.Size = new System.Drawing.Size(416, 498);
            this.lbSerial.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(740, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timerRecieve
            // 
            this.timerRecieve.Enabled = true;
            this.timerRecieve.Tick += new System.EventHandler(this.timerRecieve_Tick);
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btnRefrashPorts);
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Controls.Add(this.label1);
            this.gbConnect.Controls.Add(this.cbPort);
            this.gbConnect.Location = new System.Drawing.Point(6, 6);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(171, 117);
            this.gbConnect.TabIndex = 3;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connection";
            // 
            // btnRefrashPorts
            // 
            this.btnRefrashPorts.Location = new System.Drawing.Point(6, 45);
            this.btnRefrashPorts.Name = "btnRefrashPorts";
            this.btnRefrashPorts.Size = new System.Drawing.Size(159, 23);
            this.btnRefrashPorts.TabIndex = 4;
            this.btnRefrashPorts.Text = "Refresh ports...";
            this.btnRefrashPorts.UseVisualStyleBackColor = true;
            this.btnRefrashPorts.Click += new System.EventHandler(this.PortSetup);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 74);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(159, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(41, 18);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 585);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbConnect);
            this.tabPage1.Controls.Add(this.gbCommunication);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddComponent);
            this.tabPage2.Controls.Add(this.Inspector);
            this.tabPage2.Controls.Add(this.gbProgram);
            this.tabPage2.Controls.Add(this.menuIDE);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programming";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(6, 49);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(78, 36);
            this.btnAddComponent.TabIndex = 4;
            this.btnAddComponent.Text = "Add Component";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            // 
            // Inspector
            // 
            this.Inspector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inspector.Controls.Add(this.panelCreateComponent);
            this.Inspector.Location = new System.Drawing.Point(736, 30);
            this.Inspector.Name = "Inspector";
            this.Inspector.Size = new System.Drawing.Size(242, 508);
            this.Inspector.TabIndex = 3;
            this.Inspector.TabStop = false;
            this.Inspector.Text = "Inspector";
            // 
            // panelCreateComponent
            // 
            this.panelCreateComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCreateComponent.Controls.Add(this.textBox1);
            this.panelCreateComponent.Controls.Add(this.label3);
            this.panelCreateComponent.Controls.Add(this.btnCreateComp);
            this.panelCreateComponent.Controls.Add(this.label2);
            this.panelCreateComponent.Controls.Add(this.comboBox1);
            this.panelCreateComponent.Enabled = false;
            this.panelCreateComponent.Location = new System.Drawing.Point(6, 19);
            this.panelCreateComponent.Name = "panelCreateComponent";
            this.panelCreateComponent.Size = new System.Drawing.Size(230, 483);
            this.panelCreateComponent.TabIndex = 0;
            this.panelCreateComponent.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // btnCreateComp
            // 
            this.btnCreateComp.Location = new System.Drawing.Point(6, 61);
            this.btnCreateComp.Name = "btnCreateComp";
            this.btnCreateComp.Size = new System.Drawing.Size(221, 48);
            this.btnCreateComp.TabIndex = 2;
            this.btnCreateComp.Text = "Initialize Component";
            this.btnCreateComp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Digital Output",
            "Digital Input",
            "Analog Output",
            "Analog Input"});
            this.comboBox1.Location = new System.Drawing.Point(47, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // gbProgram
            // 
            this.gbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProgram.Controls.Add(this.component1);
            this.gbProgram.Location = new System.Drawing.Point(90, 30);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Size = new System.Drawing.Size(640, 508);
            this.gbProgram.TabIndex = 2;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program";
            // 
            // component1
            // 
            this.component1.Location = new System.Drawing.Point(6, 19);
            this.component1.Name = "component1";
            this.component1.Size = new System.Drawing.Size(100, 100);
            this.component1.TabIndex = 0;
            this.component1.Text = "None";
            this.component1.UseVisualStyleBackColor = true;
            this.component1.Click += new System.EventHandler(this.component1_Click);
            // 
            // menuIDE
            // 
            this.menuIDE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuIDE.Location = new System.Drawing.Point(3, 3);
            this.menuIDE.Name = "menuIDE";
            this.menuIDE.Size = new System.Drawing.Size(980, 24);
            this.menuIDE.TabIndex = 0;
            this.menuIDE.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // clesToolStripMenuItem
            // 
            this.clesToolStripMenuItem.Name = "clesToolStripMenuItem";
            this.clesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clesToolStripMenuItem.Text = "Disconnect and Close";
            this.clesToolStripMenuItem.Click += new System.EventHandler(this.clesToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // ssStatusManual
            // 
            this.ssStatusManual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arduinoConnectedStatus,
            this.arduinoStatus,
            this.lbll,
            this.btnDisconnect});
            this.ssStatusManual.Location = new System.Drawing.Point(0, 563);
            this.ssStatusManual.Name = "ssStatusManual";
            this.ssStatusManual.Size = new System.Drawing.Size(994, 22);
            this.ssStatusManual.TabIndex = 6;
            this.ssStatusManual.Text = "Status:";
            // 
            // arduinoConnectedStatus
            // 
            this.arduinoConnectedStatus.Name = "arduinoConnectedStatus";
            this.arduinoConnectedStatus.Size = new System.Drawing.Size(53, 17);
            this.arduinoConnectedStatus.Text = "Arduino ";
            // 
            // arduinoStatus
            // 
            this.arduinoStatus.BackColor = System.Drawing.Color.Red;
            this.arduinoStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.arduinoStatus.Name = "arduinoStatus";
            this.arduinoStatus.Size = new System.Drawing.Size(19, 17);
            this.arduinoStatus.Text = "    ";
            // 
            // lbll
            // 
            this.lbll.BackColor = System.Drawing.SystemColors.Control;
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(13, 17);
            this.lbll.Text = "  ";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(66, 17);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Disconnect);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 585);
            this.Controls.Add(this.ssStatusManual);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuIDE;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.PortSetup);
            this.gbCommunication.ResumeLayout(false);
            this.gbCommunication.PerformLayout();
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Inspector.ResumeLayout(false);
            this.panelCreateComponent.ResumeLayout(false);
            this.panelCreateComponent.PerformLayout();
            this.gbProgram.ResumeLayout(false);
            this.menuIDE.ResumeLayout(false);
            this.menuIDE.PerformLayout();
            this.ssStatusManual.ResumeLayout(false);
            this.ssStatusManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.GroupBox gbCommunication;
        private System.Windows.Forms.Timer timerRecieve;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btnRefrashPorts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbSerial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuIDE;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatusManual;
        private System.Windows.Forms.ToolStripStatusLabel arduinoConnectedStatus;
        private System.Windows.Forms.ToolStripStatusLabel arduinoStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbll;
        private System.Windows.Forms.ToolStripStatusLabel btnDisconnect;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbProgram;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.GroupBox Inspector;
        private System.Windows.Forms.Button component1;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Panel panelCreateComponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreateComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

