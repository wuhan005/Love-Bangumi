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
        private uint uid;

        public getUserInfo(uint uid)
        {
            this.uid = uid;
        }

        public Dictionary<string,string> UserData()
        {
            HttpWebRequest webRequest;
            Stream reqStream;
            HttpWebResponse webResp;
            Stream stream;
            StreamReader reader;
            string returnJson;
            JObject jsonDecoder;

            Dictionary<string, string> data = new Dictionary<string, string>();

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
            data.Add("Sign", (string)jsonDecoder["data"]["sign"]);

            return data;
        }

        public List<string> RecentBangumi()     //Back bangumi IDs!!
        {
            List<string> bangumiID = new List<string>();

            jsonCatcher bangumiJson = new jsonCatcher("http://space.bilibili.com/ajax/Bangumi/getList?mid=" + uid.ToString() + "&page=1");

            if ((bool)bangumiJson.json()["status"] == true)
            {
                string count = (string)bangumiJson.json()["data"]["count"];
                string pages = (string)bangumiJson.json()["data"]["pages"];

                if(int.Parse(pages) >= 2)
                {
                    for(int i = 0; i<15; i++)
                    {
                        bangumiID.Add((string)bangumiJson.json()["data"]["result"][i]["season_id"]);
                    }
                }
            }
            else
            {
                MessageBox.Show("无法从Bilibili拉取番剧数据！");
            }

            return bangumiID;
        }
        
    }
}