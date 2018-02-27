partial class frmSettings {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
        this.cbStartup = new System.Windows.Forms.CheckBox();
        this.cbAutoMine = new System.Windows.Forms.CheckBox();
        this.cmdSave = new System.Windows.Forms.Button();
        this.cmdCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // cbStartup
        // 
        this.cbStartup.AutoSize = true;
        this.cbStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cbStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cbStartup.Location = new System.Drawing.Point(12, 12);
        this.cbStartup.Name = "cbStartup";
        this.cbStartup.Size = new System.Drawing.Size(239, 20);
        this.cbStartup.TabIndex = 0;
        this.cbStartup.Text = "Start application on Windows startup";
        this.cbStartup.UseVisualStyleBackColor = true;
        // 
        // cbAutoMine
        // 
        this.cbAutoMine.AutoSize = true;
        this.cbAutoMine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cbAutoMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cbAutoMine.Location = new System.Drawing.Point(12, 38);
        this.cbAutoMine.Name = "cbAutoMine";
        this.cbAutoMine.Size = new System.Drawing.Size(175, 20);
        this.cbAutoMine.TabIndex = 1;
        this.cbAutoMine.Text = "Start mining automatically";
        this.cbAutoMine.UseVisualStyleBackColor = true;
        // 
        // cmdSave
        // 
        this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cmdSave.Location = new System.Drawing.Point(12, 64);
        this.cmdSave.Name = "cmdSave";
        this.cmdSave.Size = new System.Drawing.Size(100, 32);
        this.cmdSave.TabIndex = 2;
        this.cmdSave.Text = "Save";
        this.cmdSave.UseVisualStyleBackColor = true;
        this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
        // 
        // cmdCancel
        // 
        this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.cmdCancel.Location = new System.Drawing.Point(144, 64);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new System.Drawing.Size(100, 32);
        this.cmdCancel.TabIndex = 3;
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = true;
        this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
        // 
        // frmSettings
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(256, 110);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.cmdSave);
        this.Controls.Add(this.cbAutoMine);
        this.Controls.Add(this.cbStartup);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmSettings";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Settings";
        this.Load += new System.EventHandler(this.frmSettings_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbStartup;
    private System.Windows.Forms.CheckBox cbAutoMine;
    private System.Windows.Forms.Button cmdSave;
    private System.Windows.Forms.Button cmdCancel;
}