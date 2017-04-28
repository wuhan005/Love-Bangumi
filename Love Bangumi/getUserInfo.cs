using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love_Bangumi
{
    class getUserInfo
    {
        private HttpWebRequest webRequest;
        private Stream reqStream;
        private HttpWebResponse webResp;
        private Stream stream;
        private StreamReader reader;
        private string returnJson;
        private JObject jsonDecoder;

        public Dictionary<string, string> data = new Dictionary<string, string>();

        public getUserInfo(uint uid)
        {

            webRequest = (HttpWebRequest)WebRequest.Create("https://space.bilibili.com/ajax/member/GetInfo");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Referer = "https://space.bilibili.com/";      //Pay attation! Without it, it will back error!

            byte[] sendData = Encoding.UTF8.GetBytes("mid=" + uid.ToString());
            webRequest.ContentLength = sendData.Length;
            reqStream = webRequest.GetRequestStream();

            reqStream.Write(sendData, 0, sendData.Length);
            reqStream.Close();

            webResp = (HttpWebResponse)webRequest.GetResponse();
            stream = webResp.GetResponseStream();
            reader = new StreamReader(stream, Encoding.UTF8);
            returnJson = reader.ReadToEnd();
            jsonDecoder = JObject.Parse(returnJson);

            data.Add("UserName", (string)jsonDecoder["data"]["name"]);
            data.Add("FaceURL", (string)jsonDecoder["data"]["face"]);
        }
    }
}