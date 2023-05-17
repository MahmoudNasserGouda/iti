

using System.Windows.Forms;

namespace MyApp
{
    public static class Program
    {
        public static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Starter());
            return 0;
        }
    }
}