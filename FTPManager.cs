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

        public Exception Exception = null;

        public bool IsConnected { get; set; }

        private string ipAddr = string.Empty;
        private string port = string.Empty;
        private string userld = string.Empty;

        public FTPManager()
        {

        }


    }
}
