using System.Windows.Forms;
using Microsoft.Win32;
class clsSettings {
    public static string AppName = "Elicoin GUI Miner";
    public static string AppShortName = "Eliminer";
    public static string Version = "0.1";
    public static string CreatedBy = "Elicoin developers";
    public static string Year = "2018";
    public static string Web = "https://github.com/elicoin/elicoin-gui-miner/";
    public static string DefaultAddress = "stratum+tcp://pool.elicoin.net:3333";
    public static string DefaultUser = "EfE81t29ykt7DSka2Y3cSonHiGa5QhUFwc";
    public static string DefaultPass = "";
    public static string DefaultParams = "";
    public static RegistryKey rk =  Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + AppShortName);
    public static string GetValue(string key) {
        try {
            return rk.GetValue(key).ToString();
        } catch {
            return null;
        }
    }
    public static void SetValue(string key, string value) {
        try {
            rk.SetValue(key, value);
        } catch {
        }
    }
    public static void SetStartup(bool set) {
        try {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (set) reg.SetValue(AppShortName, Application.ExecutablePath);
            else reg.DeleteValue(AppShortName);
        } catch {
        }
    }
}