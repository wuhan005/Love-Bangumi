using CCWin;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.tags = picDetail.json()["response"][0]["tags"];
            setTags();
            this.picTime.Text = (string)picDetail.json()["response"][0]["reuploaded_time"];
            this.picContext.Text = (string)picDetail.json()["response"][0]["caption"];

            
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
