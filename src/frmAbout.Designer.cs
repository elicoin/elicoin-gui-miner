partial class frmAbout {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
        this.cmdOK = new System.Windows.Forms.Button();
        this.lblAppName = new System.Windows.Forms.Label();
        this.lblCreated = new System.Windows.Forms.Label();
        this.lblWeb = new System.Windows.Forms.Label();
        this.lnkWeb = new System.Windows.Forms.LinkLabel();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // cmdOK
        // 
        this.cmdOK.AutoSize = true;
        this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
        this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cmdOK.Location = new System.Drawing.Point(12, 111);
        this.cmdOK.Name = "cmdOK";
        this.cmdOK.Size = new System.Drawing.Size(482, 36);
        this.cmdOK.TabIndex = 2;
        this.cmdOK.Text = "OK";
        this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.cmdOK.UseVisualStyleBackColor = false;
        this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
        // 
        // lblAppName
        // 
        this.lblAppName.AutoSize = true;
        this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblAppName.Location = new System.Drawing.Point(114, 27);
        this.lblAppName.Name = "lblAppName";
        this.lblAppName.Size = new System.Drawing.Size(70, 16);
        this.lblAppName.TabIndex = 0;
        this.lblAppName.Text = "AppName";
        // 
        // lblCreated
        // 
        this.lblCreated.AutoSize = true;
        this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblCreated.Location = new System.Drawing.Point(114, 48);
        this.lblCreated.Name = "lblCreated";
        this.lblCreated.Size = new System.Drawing.Size(56, 16);
        this.lblCreated.TabIndex = 0;
        this.lblCreated.Text = "Created";
        // 
        // lblWeb
        // 
        this.lblWeb.AutoSize = true;
        this.lblWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lblWeb.Location = new System.Drawing.Point(114, 69);
        this.lblWeb.Name = "lblWeb";
        this.lblWeb.Size = new System.Drawing.Size(61, 16);
        this.lblWeb.TabIndex = 0;
        this.lblWeb.Text = "Website:";
        this.lblWeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lnkWeb
        // 
        this.lnkWeb.AutoSize = true;
        this.lnkWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.lnkWeb.Location = new System.Drawing.Point(175, 69);
        this.lnkWeb.Name = "lnkWeb";
        this.lnkWeb.Size = new System.Drawing.Size(65, 16);
        this.lnkWeb.TabIndex = 1;
        this.lnkWeb.TabStop = true;
        this.lnkWeb.Text = "Website";
        this.lnkWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.lnkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeb_LinkClicked);
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(12, 9);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(96, 96);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 15;
        this.pictureBox1.TabStop = false;
        // 
        // frmAbout
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(506, 160);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.lnkWeb);
        this.Controls.Add(this.lblWeb);
        this.Controls.Add(this.lblCreated);
        this.Controls.Add(this.lblAppName);
        this.Controls.Add(this.cmdOK);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmAbout";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "About";
        this.Load += new System.EventHandler(this.frmAbout_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdOK;
    private System.Windows.Forms.Label lblAppName;
    private System.Windows.Forms.Label lblCreated;
    private System.Windows.Forms.Label lblWeb;
    private System.Windows.Forms.LinkLabel lnkWeb;
    private System.Windows.Forms.PictureBox pictureBox1;
}