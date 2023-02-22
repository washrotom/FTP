using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FTP
{
    class FTPManager
    {
        public delegate void ExceptionEventHander(string LocationD, Exception ex);
        public event ExceptionEventHander ExceptionEvent;

        public Exception LastException = null;

        public bool IsConnected { get; set; }

        private string ipAddr = string.Empty;
        private string port = string.Empty;
        private string userld = string.Empty;
        private string pwd = string.Empty;

        public FTPManager()
        {

        }

        public bool ConnectToServer(string ip, string port, string userld, string pwd)
        {
            this.IsConnected = false;

            this.ipAddr = ip;
            this.port = port;
            this.userld = userld;
            this.pwd = pwd;

            string url = string.Format(@"FTP://{0}:{1}", this.ipAddr, this.port);

            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(userld, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = false;

                using (ftpRequest.GetResponse())
                {

                }

                this.IsConnected = true;
            }
            catch(Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);

                return false;
            }
            return true;
        }
    }
}
