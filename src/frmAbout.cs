using System;
using System.Diagnostics;
using System.Windows.Forms;
public partial class frmAbout : Form {
    public frmAbout() {
        InitializeComponent();
    }
    private void frmAbout_Load(object sender, EventArgs e) {
        Text += " " + clsSettings.AppName;
        lblAppName.Text = clsSettings.AppName + " v. " + clsSettings.Version;
        lblCreated.Text = "Created by " + clsSettings.CreatedBy + ", " + clsSettings.Year;
        lnkWeb.Text = clsSettings.Web;
    }
    private void cmdOK_Click(object sender, EventArgs e) {
        Close();
    }
    private void lnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        Process.Start(clsSettings.Web);
    }
}