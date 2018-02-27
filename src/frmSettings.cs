using System;
using System.Windows.Forms;
public partial class frmSettings : Form {
    public frmSettings() {
        InitializeComponent();
    }
    private void cmdCancel_Click(object sender, EventArgs e) {
        Close();
    }
    private void cmdSave_Click(object sender, EventArgs e) {
        clsSettings.SetValue("Startup", cbStartup.Checked ? "1" : "0");
        clsSettings.SetValue("AutoMine", cbAutoMine.Checked ? "1" : "0");
        clsSettings.SetStartup(cbStartup.Checked ? true : false);
        Close();
    }
    private void frmSettings_Load(object sender, EventArgs e) {
        if (clsSettings.GetValue("Startup") == "1") cbStartup.Checked = true;
        if (clsSettings.GetValue("AutoMine") == "1") cbAutoMine.Checked = true;
    }
}