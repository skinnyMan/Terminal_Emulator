namespace Terminal_Emulator
{
    partial class mainWindow
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
            this.txTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rxTextBox = new System.Windows.Forms.RichTextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bClearRxText = new System.Windows.Forms.Button();
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txTextBox
            // 
            this.txTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.txTextBox.Location = new System.Drawing.Point(12, 24);
            this.txTextBox.Multiline = false;
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(570, 23);
            this.txTextBox.TabIndex = 0;
            this.txTextBox.Text = "";
            this.txTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTextBox_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // rxTextBox
            // 
            this.rxTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.rxTextBox.Location = new System.Drawing.Point(12, 53);
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.ReadOnly = true;
            this.rxTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rxTextBox.Size = new System.Drawing.Size(570, 392);
            this.rxTextBox.TabIndex = 1;
            this.rxTextBox.Text = "";
            this.rxTextBox.TextChanged += new System.EventHandler(this.rxTextBox_TextChanged);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(603, 24);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bClearRxText
            // 
            this.bClearRxText.Location = new System.Drawing.Point(603, 422);
            this.bClearRxText.Name = "bClearRxText";
            this.bClearRxText.Size = new System.Drawing.Size(75, 23);
            this.bClearRxText.TabIndex = 3;
            this.bClearRxText.Text = "Clear";
            this.bClearRxText.UseVisualStyleBackColor = true;
            this.bClearRxText.Click += new System.EventHandler(this.bClearRxText_Click);
            // 
            // comPort
            // 
            this.comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comPort_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openComPortToolStripMenuItem,
            this.closeComPortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openComPortToolStripMenuItem
            // 
            this.openComPortToolStripMenuItem.Name = "openComPortToolStripMenuItem";
            this.openComPortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openComPortToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openComPortToolStripMenuItem.Text = "Open Com Port";
            this.openComPortToolStripMenuItem.Click += new System.EventHandler(this.openComPortToolStripMenuItem_Click);
            // 
            // closeComPortToolStripMenuItem
            // 
            this.closeComPortToolStripMenuItem.Name = "closeComPortToolStripMenuItem";
            this.closeComPortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeComPortToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.closeComPortToolStripMenuItem.Text = "Close Com Port";
            this.closeComPortToolStripMenuItem.Click += new System.EventHandler(this.closeComPortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialOptionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // serialOptionsToolStripMenuItem
            // 
            this.serialOptionsToolStripMenuItem.Name = "serialOptionsToolStripMenuItem";
            this.serialOptionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serialOptionsToolStripMenuItem.Text = "Serial Options";
            this.serialOptionsToolStripMenuItem.Click += new System.EventHandler(this.serialOptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 454);
            this.Controls.Add(this.bClearRxText);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.rxTextBox);
            this.Controls.Add(this.txTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWindow";
            this.Text = "Terminal Emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txTextBox;
        private System.Windows.Forms.RichTextBox rxTextBox;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bClearRxText;
        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeComPortToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
    }
}

