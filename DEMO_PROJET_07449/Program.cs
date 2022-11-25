using DEMO_PROJET_07449.Business.Services;
using System.Diagnostics;

namespace DEMO_PROJET_07449;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args) {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        if (args.Contains("test-marc")) {
            TestMarc();

        } else if (args.Contains("do-potatoes")) {
            DoPotatoes();

        } else {
            MainService.GetInstance().StartApplication();
        }
    }

    private static void TestMarc() {
        Debug.WriteLine("TEST MARC");
    }

    private static void DoPotatoes() {
        Debug.WriteLine("PO-TA-TOES!");
    }
}