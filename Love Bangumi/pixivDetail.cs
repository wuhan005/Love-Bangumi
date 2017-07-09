using CCWin;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love_Bangumi
{
    public partial class pixivDetail : CCSkinMain
    {
        private int pixivID;
        private jsonCatcher picDetail;
        public ArrayList tagsArray = new ArrayList();
        private JToken tags;
        public pixivDetail(int ID)
        {
            InitializeComponent();
            pixivID = ID;
            picDetail = new jsonCatcher("https://api.imjad.cn/pixiv/v1/?type=illust&id=" + pixivID.ToString());

            this.picName.Text = (string)picDetail.json()["response"][0]["title"];
            this.picAuthor.Text = (string)picDetail.json()["response"][0]["user"]["name"];
            getPic();
            this.tags = picDetail.json()["response"][0]["tags"];
            setTags();
            this.picTime.Text = (string)picDetail.json()["response"][0]["reuploaded_time"];
            this.picContext.Text = (string)picDetail.json()["response"][0]["caption"];

            
        }

        private void getPic()
        {
            Encoding encode = Encoding.GetEncoding("utf-8");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri((string)picDetail.json()["response"][0]["image_urls"]["large"]));
            req.Method = "GET";
            req.UserAgent = " Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko";
            req.Accept = "image/png, image/svg+xml, image/*;q=0.8, */*;q=0.5";
            req.Referer = "https://www.pixiv.net/member_illust.php";
            req.Headers.Add("Accept-Language", "zh-Hans-CN,zh-Hans;q=0.8,en-US;q=0.5,en;q=0.3");

            HttpWebResponse ress = (HttpWebResponse)req.GetResponse();
            Stream sstreamRes = ress.GetResponseStream();

            picBox.Image = Image.FromStream(sstreamRes);
        }

        private void setTags()
        {
            if (tags.LongCount() != 0)
            {
                for (int i = 0; i < tags.LongCount(); i++)
                {
                    this.tagsArray.Add((string)tags[i]);
                    //Console.WriteLine(tagsArray[i]);
                    this.picTags.Text += " | " + tagsArray[i];
                }
            } 
        }
    }
}
