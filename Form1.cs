using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

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
            
            string path = string.Empty;
            string localPath = string.Empty;
            string fileName = string.Empty;

            addr = string.Format("{0}", addr_box.Text);
            user = string.Format("{0}", user_box.Text);
            pwd = string.Format("{0}", pwd_box.Text);
            port = string.Format("{0}", port_box.Text);

            // path = string.Format("{0}", path_box.Text); // 업로드 파일 저장할 경로
            localPath = @"C:\\Users\\h_ul\\OneDrive\\바탕 화면\\DB Layout\\";
            fileName = string.Format("{0}", filename_box.Text);

            MainFTP(addr, user, pwd, port, localPath, fileName);

        }


        static void MainFTP(string addr, string user, string pwd, string port, string localPath, string fileName)
        {

            FTPManager manager = new FTPManager();

            bool result = manager.ConnectToServer(addr, port, user, pwd);

            string path = @"GULAG";
            DirectoryInfo dirInfo = new DirectoryInfo(localPath);
            FileInfo[] infos = dirInfo.GetFiles();

            if (result == true)
            {
                MessageBox.Show("FTP 접속성공");
                foreach(FileInfo info in dirInfo.GetFiles())
                {
                    if(Path.GetExtension(info.Name) == ".txt") // txt 확장자 파일만 ftp서버에 업로드
                    {
                        if(manager.UpLoad(path, info.FullName) == false)
                        {
                            MessageBox.Show("FTP Upload 실패");
                        }
                        else
                        {
                            MessageBox.Show("FTP 업로드 시작");
                            MessageBox.Show("FTP 업로드 완료");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("FTP 접속실패");
            }

        }
    }

}
