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
            this.Inspector = new System.Windows.Forms.GroupBox();
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
            this.btnSend.Location = new System.Drawing.Point(9, 69);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(459, 54);
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
            this.tbText.Location = new System.Drawing.Point(9, 28);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbText.Name = "tbText";
            this.tbText.ShortcutsEnabled = false;
            this.tbText.Size = new System.Drawing.Size(457, 26);
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
            this.gbCommunication.Location = new System.Drawing.Point(274, 9);
            this.gbCommunication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCommunication.Name = "gbCommunication";
            this.gbCommunication.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCommunication.Size = new System.Drawing.Size(1192, 808);
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
            this.lbSerial.ItemHeight = 20;
            this.lbSerial.Items.AddRange(new object[] {
            "Serial:"});
            this.lbSerial.Location = new System.Drawing.Point(477, 29);
            this.lbSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.ScrollAlwaysVisible = true;
            this.lbSerial.Size = new System.Drawing.Size(622, 764);
            this.lbSerial.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1110, 28);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 35);
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
            this.gbConnect.Location = new System.Drawing.Point(9, 9);
            this.gbConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConnect.Size = new System.Drawing.Size(256, 180);
            this.gbConnect.TabIndex = 3;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connection";
            // 
            // btnRefrashPorts
            // 
            this.btnRefrashPorts.Location = new System.Drawing.Point(9, 69);
            this.btnRefrashPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrashPorts.Name = "btnRefrashPorts";
            this.btnRefrashPorts.Size = new System.Drawing.Size(238, 35);
            this.btnRefrashPorts.TabIndex = 4;
            this.btnRefrashPorts.Text = "Refresh ports...";
            this.btnRefrashPorts.UseVisualStyleBackColor = true;
            this.btnRefrashPorts.Click += new System.EventHandler(this.PortSetup);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 114);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(238, 57);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(62, 28);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(180, 28);
            this.cbPort.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1491, 900);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbConnect);
            this.tabPage1.Controls.Add(this.gbCommunication);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1483, 867);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Inspector);
            this.tabPage2.Controls.Add(this.gbProgram);
            this.tabPage2.Controls.Add(this.menuIDE);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1483, 867);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programming";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Inspector
            // 
            this.Inspector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inspector.Location = new System.Drawing.Point(1104, 46);
            this.Inspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inspector.Name = "Inspector";
            this.Inspector.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inspector.Size = new System.Drawing.Size(363, 782);
            this.Inspector.TabIndex = 3;
            this.Inspector.TabStop = false;
            this.Inspector.Text = "Inspector";
            // 
            // gbProgram
            // 
            this.gbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProgram.Controls.Add(this.component1);
            this.gbProgram.Location = new System.Drawing.Point(12, 46);
            this.gbProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProgram.Name = "gbProgram";
            this.gbProgram.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProgram.Size = new System.Drawing.Size(1083, 782);
            this.gbProgram.TabIndex = 2;
            this.gbProgram.TabStop = false;
            this.gbProgram.Text = "Program";
            // 
            // component1
            // 
            this.component1.Location = new System.Drawing.Point(9, 29);
            this.component1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.component1.Name = "component1";
            this.component1.Size = new System.Drawing.Size(150, 154);
            this.component1.TabIndex = 0;
            this.component1.Text = "None";
            this.component1.UseVisualStyleBackColor = true;
            // 
            // menuIDE
            // 
            this.menuIDE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuIDE.Location = new System.Drawing.Point(4, 5);
            this.menuIDE.Name = "menuIDE";
            this.menuIDE.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuIDE.Size = new System.Drawing.Size(1475, 25);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
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
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
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
            this.ssStatusManual.Location = new System.Drawing.Point(0, 878);
            this.ssStatusManual.Name = "ssStatusManual";
            this.ssStatusManual.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssStatusManual.Size = new System.Drawing.Size(1491, 22);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 900);
            this.Controls.Add(this.ssStatusManual);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuIDE;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

