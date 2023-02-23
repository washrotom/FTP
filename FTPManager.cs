using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Net;
using System.Threading.Tasks;

using System.IO;

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

            string url = string.Format(@"FTP://{0}:{1}/", this.ipAddr, this.port);

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

        public bool UpLoad(string folder, string filename)
        {
            return upload(folder, filename);
        }


        private bool upload(string folder, string filename)
        {
            try
            {
                makeDir(folder);

                FileInfo filelnf = new FileInfo(filename);

                folder = folder.Replace('\\', '/');
                filename = filename.Replace('\\', '/');

                string url = string.Format(@"FTP://{0}:{1}/{2}/{3}", this.ipAddr, this.port, folder, filelnf.Name);
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(userld, pwd);

                ftpRequest.KeepAlive = false;
                ftpRequest.UseBinary = false;
                ftpRequest.UsePassive = false;

                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.ContentLength = filelnf.Length;

                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;

                using(FileStream fs = filelnf.OpenRead())
                {
                    using(Stream strm = ftpRequest.GetRequestStream())
                    {
                        contentLen = fs.Read(buff, 0, buffLength);

                        while(contentLen != 0)
                        {
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                    }

                    fs.Flush();
                    fs.Close();
                }

                if(buff != null)
                {
                    Array.Clear(buff, 0, buffLength);
                    buff = null;
                }
            }

            catch(Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();

                string id = string.Format("{0},{1}", info.ReflectedType.Name, info.Name);

                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);

                return false;
            }

            return true;
        }

        private void makeDir(string dirName)
        {
            string[] arrDir = dirName.Split('\\');
            string currentDir = string.Empty;

            try
            {
                foreach(string tmpFoler in arrDir)
                {
                    try
                    {
                        if (tmpFoler == string.Empty) continue;

                        currentDir += @"/" + tmpFoler;

                        string url = string.Format(@"FTP://{0}:{1} {2}", this.ipAddr, this.port, currentDir);
                        FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                        ftpRequest.Credentials = new NetworkCredential(userld, pwd);

                        ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                        ftpRequest.KeepAlive = false;
                        ftpRequest.UsePassive = false;

                        FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();

                        response.Close();
                    }

                    catch { }
                }
            }

            catch(Exception ex)
            {
                this.LastException = ex;
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();

                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                if (this.ExceptionEvent != null)
                    this.ExceptionEvent(id, ex);
            }
        }

        private void checkDir(string localFullPathFile)
        {
            FileInfo flnfo = new FileInfo(localFullPathFile);

            if (!flnfo.Exists)
            {
                DirectoryInfo dlnfo = new DirectoryInfo(flnfo.DirectoryName);
                if (!dlnfo.Exists)
                {
                    dlnfo.Create();
                }
            }
        }
    }
}
