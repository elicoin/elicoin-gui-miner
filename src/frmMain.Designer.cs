using System.Windows.Forms;
partial class frmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        this.lblAddress = new System.Windows.Forms.Label();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.txtUser = new System.Windows.Forms.TextBox();
        this.lblUser = new System.Windows.Forms.Label();
        this.cmdExit = new System.Windows.Forms.Button();
        this.cmdStart = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.rtbLog = new System.Windows.Forms.RichTextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.lblPasswordNote = new System.Windows.Forms.Label();
        this.lblParamsNote = new System.Windows.Forms.Label();
        this.txtParams = new System.Windows.Forms.TextBox();
        this.lblParams = new System.Windows.Forms.Label();
        this.lblUserNote = new System.Windows.Forms.Label();
        this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
        this.miMiner = new System.Windows.Forms.MenuItem();
        this.miStart = new System.Windows.Forms.MenuItem();
        this.miSettings = new System.Windows.Forms.MenuItem();
        this.miReset = new System.Windows.Forms.MenuItem();
        this.miSeparator = new System.Windows.Forms.MenuItem();
        this.miExit = new System.Windows.Forms.MenuItem();
        this.miHelp = new System.Windows.Forms.MenuItem();
        this.miAbout = new System.Windows.Forms.MenuItem();
        this.SuspendLayout();
        // 
        // lblAddress
        // 
        this.lblAddress.AutoSize = true;
        this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblAddress.Location = new System.Drawing.Point(71, 14);
        this.lblAddress.Name = "lblAddress";
        this.lblAddress.Size = new System.Drawing.Size(70, 16);
        this.lblAddress.TabIndex = 0;
        this.lblAddress.Text = "Address:";
        this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtAddress
        // 
        this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.txtAddress.Location = new System.Drawing.Point(147, 12);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(471, 22);
        this.txtAddress.TabIndex = 1;
        // 
        // txtUser
        // 
        this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.txtUser.Location = new System.Drawing.Point(147, 40);
        this.txtUser.Name = "txtUser";
        this.txtUser.Size = new System.Drawing.Size(307, 22);
        this.txtUser.TabIndex = 2;
        // 
        // lblUser
        // 
        this.lblUser.AutoSize = true;
        this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblUser.Location = new System.Drawing.Point(96, 42);
        this.lblUser.Name = "lblUser";
        this.lblUser.Size = new System.Drawing.Size(45, 16);
        this.lblUser.TabIndex = 0;
        this.lblUser.Text = "User:";
        this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cmdExit
        // 
        this.cmdExit.AutoSize = true;
        this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
        this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cmdExit.Image = global::Eliminer.Properties.Resources.exit;
        this.cmdExit.Location = new System.Drawing.Point(318, 124);
        this.cmdExit.Name = "cmdExit";
        this.cmdExit.Size = new System.Drawing.Size(300, 214);
        this.cmdExit.TabIndex = 6;
        this.cmdExit.Text = "Exit";
        this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.cmdExit.UseVisualStyleBackColor = false;
        this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
        // 
        // cmdStart
        // 
        this.cmdStart.AutoSize = true;
        this.cmdStart.BackColor = System.Drawing.SystemColors.Control;
        this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cmdStart.Image = global::Eliminer.Properties.Resources.miner;
        this.cmdStart.Location = new System.Drawing.Point(12, 124);
        this.cmdStart.Name = "cmdStart";
        this.cmdStart.Size = new System.Drawing.Size(300, 214);
        this.cmdStart.TabIndex = 5;
        this.cmdStart.Text = "Start mining";
        this.cmdStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.cmdStart.UseVisualStyleBackColor = false;
        this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label1.Location = new System.Drawing.Point(12, 346);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(83, 16);
        this.label1.TabIndex = 0;
        this.label1.Text = "Mining log:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // rtbLog
        // 
        this.rtbLog.BackColor = System.Drawing.Color.Black;
        this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.rtbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.rtbLog.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.rtbLog.ForeColor = System.Drawing.Color.White;
        this.rtbLog.Location = new System.Drawing.Point(0, 369);
        this.rtbLog.Name = "rtbLog";
        this.rtbLog.ReadOnly = true;
        this.rtbLog.Size = new System.Drawing.Size(632, 224);
        this.rtbLog.TabIndex = 7;
        this.rtbLog.Text = "";
        // 
        // txtPassword
        // 
        this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.txtPassword.Location = new System.Drawing.Point(147, 68);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(307, 22);
        this.txtPassword.TabIndex = 3;
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblPassword.Location = new System.Drawing.Point(61, 70);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(80, 16);
        this.lblPassword.TabIndex = 0;
        this.lblPassword.Text = "Password:";
        this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblPasswordNote
        // 
        this.lblPasswordNote.AutoSize = true;
        this.lblPasswordNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblPasswordNote.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblPasswordNote.Location = new System.Drawing.Point(460, 70);
        this.lblPasswordNote.Name = "lblPasswordNote";
        this.lblPasswordNote.Size = new System.Drawing.Size(155, 15);
        this.lblPasswordNote.TabIndex = 0;
        this.lblPasswordNote.Text = "(leave blank if not required)";
        this.lblPasswordNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblParamsNote
        // 
        this.lblParamsNote.AutoSize = true;
        this.lblParamsNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblParamsNote.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblParamsNote.Location = new System.Drawing.Point(460, 98);
        this.lblParamsNote.Name = "lblParamsNote";
        this.lblParamsNote.Size = new System.Drawing.Size(155, 15);
        this.lblParamsNote.TabIndex = 0;
        this.lblParamsNote.Text = "(leave blank if not required)";
        this.lblParamsNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtParams
        // 
        this.txtParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.txtParams.Location = new System.Drawing.Point(147, 96);
        this.txtParams.Name = "txtParams";
        this.txtParams.Size = new System.Drawing.Size(307, 22);
        this.txtParams.TabIndex = 4;
        // 
        // lblParams
        // 
        this.lblParams.AutoSize = true;
        this.lblParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblParams.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblParams.Location = new System.Drawing.Point(9, 98);
        this.lblParams.Name = "lblParams";
        this.lblParams.Size = new System.Drawing.Size(132, 16);
        this.lblParams.TabIndex = 0;
        this.lblParams.Text = "Other parameters:";
        this.lblParams.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblUserNote
        // 
        this.lblUserNote.AutoSize = true;
        this.lblUserNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblUserNote.ForeColor = System.Drawing.SystemColors.ControlText;
        this.lblUserNote.Location = new System.Drawing.Point(460, 42);
        this.lblUserNote.Name = "lblUserNote";
        this.lblUserNote.Size = new System.Drawing.Size(158, 15);
        this.lblUserNote.TabIndex = 0;
        this.lblUserNote.Text = "(sometimes wallet address)";
        this.lblUserNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // mainMenu1
        // 
        this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miMiner,
            this.miHelp});
        // 
        // miMiner
        // 
        this.miMiner.Index = 0;
        this.miMiner.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miStart,
            this.miSettings,
            this.miReset,
            this.miSeparator,
            this.miExit});
        this.miMiner.Text = "Miner";
        // 
        // miStart
        // 
        this.miStart.Index = 0;
        this.miStart.Text = "Start mining";
        this.miStart.Click += new System.EventHandler(this.miStart_Click);
        // 
        // miSettings
        // 
        this.miSettings.Index = 1;
        this.miSettings.Text = "Settings";
        this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
        // 
        // miReset
        // 
        this.miReset.Index = 2;
        this.miReset.Text = "Reset to default values";
        this.miReset.Click += new System.EventHandler(this.miReset_Click);
        // 
        // miSeparator
        // 
        this.miSeparator.Index = 3;
        this.miSeparator.Text = "-";
        // 
        // miExit
        // 
        this.miExit.Index = 4;
        this.miExit.Text = "Exit";
        this.miExit.Click += new System.EventHandler(this.miExit_Click);
        // 
        // miHelp
        // 
        this.miHelp.Index = 1;
        this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miAbout});
        this.miHelp.Text = "Help";
        // 
        // miAbout
        // 
        this.miAbout.Index = 0;
        this.miAbout.Text = "About";
        this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(632, 593);
        this.Controls.Add(this.lblUserNote);
        this.Controls.Add(this.lblParamsNote);
        this.Controls.Add(this.txtParams);
        this.Controls.Add(this.lblParams);
        this.Controls.Add(this.lblPasswordNote);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.lblPassword);
        this.Controls.Add(this.rtbLog);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtUser);
        this.Controls.Add(this.lblUser);
        this.Controls.Add(this.cmdExit);
        this.Controls.Add(this.cmdStart);
        this.Controls.Add(this.txtAddress);
        this.Controls.Add(this.lblAddress);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Menu = this.mainMenu1;
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
        this.Load += new System.EventHandler(this.frmMain_Load);
        this.Resize += new System.EventHandler(this.frmMain_Resize);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    private Label lblAddress;
    private TextBox txtAddress;
    private Button cmdStart;
    private Button cmdExit;
    private TextBox txtUser;
    private Label lblUser;
    private Label label1;
    private RichTextBox rtbLog;
    private TextBox txtPassword;
    private Label lblPassword;
    private Label lblPasswordNote;
    private Label lblParamsNote;
    private TextBox txtParams;
    private Label lblParams;
    private Label lblUserNote;
    private MainMenu mainMenu1;
    private MenuItem miMiner;
    private MenuItem miSettings;
    private MenuItem miReset;
    private MenuItem miExit;
    private MenuItem miHelp;
    private MenuItem miStart;
    private MenuItem miAbout;
    private MenuItem miSeparator;

}