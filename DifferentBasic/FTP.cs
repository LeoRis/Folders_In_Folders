using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DifferentBasic
{

    public class FTP
    {
        //string host = "82.214.114.2:21";
        public string UserId = "bojan_academy";
        public string Password = "qjeK7#88";

        public string host;
        //public string UserId;
        //public string Password;

        // For this, we need an FTP Host, Username, and Password.
        public bool CreateFolder(string host)
        {
            string path = "/Index";
            bool IsCreated = true;
            try
            {
                WebRequest request = WebRequest.Create(host + path);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(UserId, Password);
                using (var resp = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine(resp.StatusCode);
                }
            }
            catch (Exception ex)
            {
                IsCreated = false;
            }
            finally
            {
                // This code block MUST happen.
            }
            return IsCreated;
        }

        // Below code is used to check if the folder exists or not.
        public bool DoesFtpDirectoryExist(string dirPath)
        {
            bool isexist = false;

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dirPath);
                request.Credentials = new NetworkCredential(UserId, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    isexist = true;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        return false;
                    }
                }
            }
            return isexist;
        }
    }
}
