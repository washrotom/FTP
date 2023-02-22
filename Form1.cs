using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addr = string.Empty;
            string user = string.Empty;
            string pwd = string.Empty;
            string port = string.Empty;

            addr = string.Format("{0}", label_addr.Text);
            user = string.Format("{0}", label_user.Text);
            pwd = string.Format("{0}", label_pwd.Text);
            port = string.Format("{0}", label_port.Text);

            MainFTP(addr, user, pwd, port);

        }


        static void MainFTP(string addr, string user, string pwd, string port)
        {
            /*string addr = string.Empty;
            string user = string.Empty;
            string pwd = string.Empty;
            string port = string.Empty;*/

            FTPManager manager = new FTPManager();

            bool result = manager.ConnectToServer(addr, port, user, pwd);

            if (result == true)
            {
                MessageBox.Show("FTP 접속성공");
            }
            else
            {
                MessageBox.Show("FTP 접속실패");
            }

        }
    }

}
