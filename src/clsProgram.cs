using System;
using System.Windows.Forms;
static class clsProgram
{
    //public const bool Test = false;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() 
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //if (!Test)
            Application.Run(new frmMain());
        //else
        //    Application.Run(new frmZobrazitDoklad());
    }
}