using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
public partial class frmMain : Form {
    frmAbout objAbout;
    frmSettings objSettings;
    bool isMining = false;
    Process proc;
    public frmMain() {
        InitializeComponent();
    }
    private void cmdStart_Click(object sender, EventArgs e) {
        Mine();
    }
    void Mine() {
        if (isMining) {
            try {
                proc.Kill();
            } catch (Exception ex) {
                Error(ex.ToString());
            }
        } else {
            if (txtAddress.Text != "") {
                if (txtUser.Text != "") {
                    SaveValues();
                    proc = new Process();
                    proc.StartInfo.FileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "cpuminer.exe");
                    proc.StartInfo.Arguments = "-a yescryptr16 -o " + txtAddress.Text + " -u " + txtUser.Text.Trim() + (txtPassword.Text.Trim() != "" ? " -p " + txtPassword.Text.Trim() : "") + (txtParams.Text.Trim() != "" ? " " + txtParams.Text.Trim() : "");
                    proc.Exited += new EventHandler(proc_Exited);
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.EnableRaisingEvents = true;
                    proc.ErrorDataReceived += new DataReceivedEventHandler(proc_ErrorDataReceived);
                    proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);
                    try {
                        proc.Start();
                        proc.BeginErrorReadLine();
                        proc.BeginOutputReadLine();
                        AddLog(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + " Process has started.");
                        SetStartButtons(false);
                        if (proc != null) isMining = true;
                    } catch (Exception ex) {
                        Error(ex.ToString());
                    }
                } else Error("Please enter user value!");
            } else Error("Please enter address value!");
        }
    }
    void proc_Exited(object sender, EventArgs e) {
        AfterProcessExited();
    }
    private void AfterProcessExited() {
        try {
            proc = null;
            isMining = false;
            if (InvokeRequired) Invoke(new MethodInvoker(delegate { SetStartButtons(true); }));
            else SetStartButtons(true);
            if (InvokeRequired) Invoke(new MethodInvoker(delegate { AddLog(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + " Process has stopped."); }));
            else AddLog(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + " Process has stopped.");
        } catch (Exception ex) {
            Error(ex.ToString());
        }
    }
    void proc_OutputDataReceived(object sender, DataReceivedEventArgs e) {
        if (InvokeRequired) Invoke(new MethodInvoker(delegate { AddLog(e.Data); }));
        else AddLog(e.Data);
    }
    void SetStartButtons(bool start) {
        cmdStart.Text = (start ? "Start mining" : "Stop mining");
        miStart.Text = (start ? "Start mining" : "Stop mining");
    }
    void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
        if (InvokeRequired) Invoke(new MethodInvoker(delegate { AddLog(e.Data); }));
        else AddLog(e.Data);
    }
    private void AddLog(string text) {
        try {
            if (text != null) {
                rtbLog.Select(rtbLog.TextLength, 0);
                string sep = @"(\x1b\[0m)|(\x1b\[30m)|(\x1b\[31m)|(\x1b\[32m)|(\x1b\[33m)|(\x1b\[34m)|(\x1b\[35m)|(\x1b\[36m)|(\x1b\[37m)|(\x1b\[01;37m)";
                string[] arr = Regex.Split(text, sep);
                foreach (string s in arr) {
                    switch (s) {
                        case "\x1b[0m":
                            rtbLog.SelectionColor = Color.White;
                            break;
                        case "\x1b[30m":
                            rtbLog.SelectionColor = Color.Black;
                            break;
                        case "\x1b[31m":
                            rtbLog.SelectionColor = Color.Red;
                            break;
                        case "\x1b[32m":
                            rtbLog.SelectionColor = Color.Green;
                            break;
                        case "\x1b[33m":
                            rtbLog.SelectionColor = Color.Yellow;
                            break;
                        case "\x1b[34m":
                            rtbLog.SelectionColor = Color.Blue;
                            break;
                        case "\x1b[35m":
                            rtbLog.SelectionColor = Color.Magenta;
                            break;
                        case "\x1b[36m":
                            rtbLog.SelectionColor = Color.Cyan;
                            break;
                        case "\x1b[37m":
                            rtbLog.SelectionColor = Color.White;
                            break;
                        case "\x1b[01;37m":
                            rtbLog.SelectionColor = Color.White;
                            break;
                        default:
                            rtbLog.AppendText(s);
                            break;
                    }
                }
                rtbLog.AppendText(Environment.NewLine);
                rtbLog.Select(rtbLog.TextLength, 0);
                rtbLog.ScrollToCaret();
            }
        } catch (Exception ex) {
            Error(ex.ToString());
        }
    }
    private void cmdExit_Click(object sender, EventArgs e) {
        Quit();
    }
    private void frmMain_Load(object sender, EventArgs e) {
        Text = clsSettings.AppName + " " + clsSettings.Version;
        miAbout.Text += " " + clsSettings.AppName;
        string address = clsSettings.GetValue("Address");
        string user = clsSettings.GetValue("User");
        string pass = clsSettings.GetValue("Pass");
        string parms = clsSettings.GetValue("Params");
        txtAddress.Text = (address == null ? clsSettings.DefaultAddress : address);
        txtUser.Text = (user == null ? clsSettings.DefaultUser : user);
        txtPassword.Text = (pass == null ? clsSettings.DefaultPass : pass);
        txtParams.Text = (parms == null ? clsSettings.DefaultParams : parms);
        if (clsSettings.GetValue("AutoMine") == "1") Mine();
    }
    void Error(string text) {
        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void SaveValues() {
        clsSettings.SetValue("Address", txtAddress.Text);
        clsSettings.SetValue("User", txtUser.Text);
        clsSettings.SetValue("Pass", txtPassword.Text);
        clsSettings.SetValue("Params", txtParams.Text);
    }
    private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
        Quit();
    }
    private void Quit() {
        SaveValues();
        try {
            if (proc != null) proc.Kill();
        } catch(Exception ex) {
            Error(ex.ToString());
        }
        Environment.Exit(0);
    }
    private void frmMain_Resize(object sender, EventArgs e) {
        Width = Width < 640 ? 640 : Width;
        Height = Height < 480 ? 480 : Height;
        txtAddress.Width = Width - 169;
        txtUser.Width = Width - 333;
        txtPassword.Width = Width - 333;
        txtParams.Width = Width - 333;
        lblUserNote.Left = Width - 180;
        lblPasswordNote.Left = Width - 180;
        lblParamsNote.Left = Width - 180;
        rtbLog.Height = Height - 416;
        cmdStart.Width = (Width / 2) - cmdStart.Left - 8;
        cmdExit.Left = (Width / 2) - 2;
        cmdExit.Width = cmdStart.Width;
    }
    private void miReset_Click(object sender, EventArgs e) {
        DialogResult dr = MessageBox.Show("Do you really want to reset settings values to default?", "Reset default values", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (dr == DialogResult.Yes) {
            txtAddress.Text = clsSettings.DefaultAddress;
            txtUser.Text = clsSettings.DefaultUser;
            txtPassword.Text = clsSettings.DefaultPass;
            txtParams.Text = clsSettings.DefaultParams;
        }
    }
    private void miStart_Click(object sender, EventArgs e) {
        Mine();
    }
    private void miSettings_Click(object sender, EventArgs e) {
        objSettings = new frmSettings();
        objSettings.Show();
    }
    private void miExit_Click(object sender, EventArgs e) {
        Quit();
    }
    private void miAbout_Click(object sender, EventArgs e) {
        objAbout = new frmAbout();
        objAbout.Show();
    }
}