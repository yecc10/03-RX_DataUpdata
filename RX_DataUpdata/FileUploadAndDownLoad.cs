using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net;

namespace RX_DataUpdata
{
    public class FileUploadAndDownLoad
    {

        /// <summary>
        /// WebClient上传文件至服务器
        /// </summary>
        /// <param name="fileNamePath">文件名</param>
        /// <param name="serverFileURL">服务器地址</param>
        public void UpLoadFile(string fileNamePath, string serverFileURL)
        {
            FileStream Instram = File.OpenRead(fileNamePath);
            System.Uri myuri = new System.Uri(serverFileURL);
            WebRequest req = WebRequest.Create(myuri);
            req.Method = "PUT";
            req.Timeout = 10;
            req.Credentials = CredentialCache.DefaultCredentials;
            Stream Ostream = req.GetRequestStream();
            byte[] indata = new byte[4096];
            int bytesRead = Instram.Read(indata, 0, indata.Length);
            while(bytesRead>0)
            {
                Ostream.Write(indata, 0, bytesRead);
                bytesRead = Instram.Read(indata, 0, indata.Length);
            } 
            // 创建WebClient实例
            WebClient myWebClient = new WebClient();

            myWebClient.Credentials = CredentialCache.DefaultCredentials;

            // 要上传的文件

            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);

            BinaryReader r = new BinaryReader(fs);

            try

            {

                //使用UploadFile方法可以用下面的格式

                byte[] postArray = r.ReadBytes((int)fs.Length);

                Stream postStream = myWebClient.OpenWrite(serverFileURL, "PUT");

                if (postStream.CanWrite)

                {

                    postStream.Write(postArray, 0, postArray.Length);

                }

                postStream.Close();
                MessageBox.Show("文件上传成功！");

            }

            catch (Exception E)

            {
                throw E;

            }
        }

        //public bool DeletFile(string FileName)
        //{
        //    WebClient WClient = new WebClient();
        //    WClient.Credentials = new NetworkCredential("NWUSER","ycc123!");
        //    Uri url = new Uri(FileName);
        //    //WClient.UploadFileCompleted += WClient_U;
        //    WClient.UploadDataTaskAsync(url, "DELETE", new byte[0]);
        //    Console.Read();
        //    return true;
        //}
        /// <summary>
        /// 下载服务器文件至客户端（不带进度条）
        /// </summary>
        /// <param name="strUrlFilePath">要下载的Web服务器上的文件地址（全路径　如：http://www.dzbsoft.com/test.rar）</param>
        /// <param name="strLocalDirPath">下载到的目录（存放位置，机地机器文件夹）</param>
        /// <returns>True/False是否上传成功</returns>
        public bool WebClientDownLoadFile(string strUrlFilePath, string strLocalDirPath)
        {

            // 创建WebClient实例
            WebClient client = new WebClient();
            //被下载的文件名
            string fileName = strUrlFilePath.Substring(strUrlFilePath.LastIndexOf("/"));
            //另存为的绝对路径＋文件名
            string Path = strLocalDirPath +fileName;
            try
            {
                WebRequest myWebRequest = WebRequest.Create(strUrlFilePath);
                client.DownloadFile(strUrlFilePath, Path);
                return true;
            }
            catch
            {  
                client.Dispose();
                return false;
            }

        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="ServerUrl">服务器地址</param>
        /// <param name="LocationFilePath">本地图片全路径</param>
        /// <param name="SavePath">上传成功返回保存的路径</param>
        /// <param name="AllowFormat">允许上传图片的后缀名，* 和空值都表示所有图片格式，多个请用,隔开，例如：.gif,.png,.jpg,.bmp</param>
        /// <param name="progressBar">进度控件</param>
        ///  /// <param name="NewFileName">新文件名</param>
        /// <returns>返回：-2=图片格式有误，-1=服务器地址 或 本地图片全路径为空 0=上传失败 1=上传成功</returns>
        public int UpLoad(string ServerUrl, string LocationFilePath,string NewFileName, out string SavePath,string AllowFormat, System.Windows.Forms.ProgressBar progressBar)
        {
            SavePath = string.Empty;
            if (string.IsNullOrEmpty(ServerUrl) || string.IsNullOrEmpty(LocationFilePath))
                return -1;
            AllowFormat = string.IsNullOrEmpty(AllowFormat) == true ? "*" : AllowFormat;
            //获取后缀名
            string Suffix = LocationFilePath.Substring(LocationFilePath.LastIndexOf(".")).Trim().ToLower();
            string[] strformat = ".gif,.png,.jpeg,.jpg,.bmp".Split(",".ToCharArray());
            if (!strformat.Contains(Suffix))
                return -2;
            //检验图片格式
            if (AllowFormat != "*")
            {
                string[] strformat2 = AllowFormat.Split(",".ToCharArray());
                if (!strformat2.Contains(Suffix))
                    return -2;
            }
            //string year = DateTime.Now.Year.ToString();
            string filename = NewFileName+Suffix;
            if (! FileCheck("http://rx_yfb_yf079:8080/WPDS/"+ filename))
            {
                int result = Upload_Request(ServerUrl, LocationFilePath, filename, progressBar);
                if (result == 1)
                    SavePath = "/WeldPictureDocumentServer" + "/" + filename;
                return result;
            }
            else
            {
                MessageBox.Show("同名图片服务器已存在，已放弃上传并显示服务器照片到客户端！");
                SavePath = "/WeldPictureDocumentServer" + "/" + filename;
                return 0;
            }
        }
        /// <summary> 
        /// 将本地文件上传到指定的服务器(HttpWebRequest方法) 
        /// </summary> 
        /// <param name="address">文件上传到的服务器</param> 
        /// <param name="fileNamePath">要上传的本地文件（全路径）</param> 
        /// <param name="saveName">文件上传后的名称</param> 
        /// <param name="progressBar">上传进度条</param> 
        /// <returns>成功返回1，失败返回0</returns> 
        private int Upload_Request(string address, string fileNamePath, string saveName, System.Windows.Forms.ProgressBar progressBar)
        {
            int returnValue = 0;     // 要上传的文件 
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);     //时间戳 
            string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + strBoundary + "\r\n");     //请求头部信息 
            StringBuilder sb = new StringBuilder();
            sb.Append("--");
            sb.Append(strBoundary);
            sb.Append("\r\n");
            sb.Append("Content-Disposition: form-data; name=\"");
            sb.Append("file");
            sb.Append("\"; filename=\"");
            sb.Append(saveName);
            sb.Append("\";");
            sb.Append("\r\n");
            sb.Append("Content-Type: ");
            sb.Append("application/octet-stream");
            sb.Append("\r\n");
            sb.Append("\r\n");
            string strPostHeader = sb.ToString();
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);     // 根据uri创建HttpWebRequest对象 
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            httpReq.Method = "POST";     //对发送的数据不使用缓存 
            httpReq.AllowWriteStreamBuffering = false;     //设置获得响应的超时时间（300秒） 
            httpReq.Timeout = 300000;
            httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
            long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
            long fileLength = fs.Length;
            httpReq.ContentLength = length;
            try
            {
                progressBar.Maximum = int.MaxValue;
                progressBar.Minimum = 0;
                progressBar.Value = 0;
                //每次上传4k
                int bufferLength = 4096;
                byte[] buffer = new byte[bufferLength]; //已上传的字节数 
                long offset = 0;                        //开始上传时间 
                DateTime startTime = DateTime.Now;
                int size = r.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();//发送请求头部消息 
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size;
                    progressBar.Value = (int)(offset * (int.MaxValue / length));
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds;
                    System.Windows.Forms.Application.DoEvents();
                    size = r.Read(buffer, 0, bufferLength);
                }
                //添加尾部的时间戳 
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();
                WebResponse webRespon = httpReq.GetResponse();
                Stream s = webRespon.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                String sReturnString = sr.ReadLine();
                s.Close();
                sr.Close();
                if (sReturnString == "Success")
                {
                    returnValue = 1;
                }
                else if (sReturnString == "Error")
                {
                    returnValue = 0;
                }
            }
            catch
            {
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            return returnValue;
        }
        private bool FileCheck(string FileName)
        {
            try
            {
                HttpWebRequest htp = (HttpWebRequest)WebRequest.CreateDefault(new Uri(FileName));
                htp.Method = "HEAD";
                htp.Timeout = 1000;
                using (HttpWebResponse rep = (HttpWebResponse)htp.GetResponse())
                {
                    return rep.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 删除服务器指定文件
        /// </summary>
        /// <param name="Url">服务其处理地址</param>
        /// <param name="FileName">图片对应焊点PID</param>
        /// <returns>成功返回1，失败返回-1,文件不存在返回0</returns>
        public int FileDelet(string Url,string FileName)
        {
            string DeUrl = Url;
            WebClient webclient = new WebClient();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(DeUrl));
            Uri upTargetUri = new Uri(String.Format(DeUrl + "?OPM=FileDelete&DeleteFileName=" + FileName + "_Fw_Picture" + ".jpg", UriKind.Absolute));
            webclient.UploadStringAsync(upTargetUri, "");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse webRespon = request.GetResponse();
            Stream s = webRespon.GetResponseStream();
            StreamReader sr = new StreamReader(s);
            String sReturnString = sr.ReadLine();
            if (sReturnString== "Success")
            {
                return 1;
            }
            else if(sReturnString=="NoExistsDocument")
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}