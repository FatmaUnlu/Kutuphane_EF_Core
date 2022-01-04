using Kutuphane_EF_Core.Forms;
namespace Kutuphane_EF_Core
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new KutuphaneForm());
        }
    }
}