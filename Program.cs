using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainFTP();

            Application.Run(new Form1());
        }

        static void MainFTP(string addr, string user, string pwd, string port)
        {
            /*string addr = string.Empty;
            string user = string.Empty;
            string pwd = string.Empty;
            string port = string.Empty;*/

            FTPManager manager = new FTPManager();

            bool result = manager.ConnectToServer(addr, port, user, pwd);

            if(result == true)
            {
                MessageBox.Show("FTP 立加己傍");
            }
            else
            {
                MessageBox.Show("FTP 立加角菩");
            }

        }
    }
}
