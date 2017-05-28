using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using System.Net;
using System.IO;
using System.Collections;

namespace Love_Bangumi
{
    public partial class bangumiForm : CCSkinMain
    {
        private jsonCatcher bangumiInfoJson;
        private uint bID;
        private string bName;
        private string bJpName;     //Bangumi's Japanese Name.
        private string bPicture;
        private string bCount;
        private string bDetail;
        private string bIsFinished;
        private MusicHunter opHunter;

        private getPixiv pixiv;
        private int nowPage = 0;    //start from 0!!

        public bangumiForm(uint bangumiID)
        {
            InitializeComponent();

            bID = bangumiID;
            initBangumiData();  //Get the bangumi data from bilibili
            initEpisodes();
            this.Text = bName;

            opHunter = new MusicHunter(bName);

            pixivInit();
        }

        private void initEpisodes()
        {
            int count = int.Parse(bCount);
            int row = 0;
            for (int i = 0; i < count; i++)
            {
                if(i % 4 == 0 && i != 0)
                {
                    row++;
                }

                Label eBlankGround = new Label();
                PictureBox ePicture = new PictureBox();
                SkinLabel eCountNumber = new SkinLabel();
                SkinLabel eName = new SkinLabel();

                eBlankGround.Location = new Point(0 + i % 4 * 230, 5 + row * 80);
                eBlankGround.Size = new Size(210, 60);
                //eBlankGround.Text = (count -1 - i).ToString();

                ePicture.Location = new Point(0 + i % 4 * 230, 5 + row * 80);
                ePicture.Size = new Size(96, 60);
                ePicture.ImageLocation = (string)bangumiInfoJson.json()["result"]["episodes"][count - 1 - i]["cover"];
                ePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ePicture.InitialImage = Properties.Resources.loading;

                eName.ArtTextStyle = ArtTextStyle.None;
                eName.Location = new Point(105 + i % 4 * 230, 28 + row * 80);
                eName.Size = new Size(110, 35);
                eName.Text = (string)bangumiInfoJson.json()["result"]["episodes"][count - 1 - i]["index_title"];
                eName.Font = new Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                eCountNumber.ArtTextStyle = ArtTextStyle.None;
                eCountNumber.Location = new Point(105 + i % 4 * 230, 5 + row * 80);
                eCountNumber.Size = new Size(100, 25);
                eCountNumber.Text = "第 " + (i+1).ToString() + " 集";
                eCountNumber.Font = new Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.pageVideo.Controls.Add(eName);
                this.pageVideo.Controls.Add(eCountNumber);
                this.pageVideo.Controls.Add(ePicture);
                this.pageVideo.Controls.Add(eBlankGround);
                //MessageBox.Show((string)bangumiInfoJson.json()["result"]["episodes"]);
                eBlankGround.Click += new EventHandler(toWebBangumi_Click);

                }
        }

        private void toWebBangumi_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            System.Diagnostics.Process.Start((string)bangumiInfoJson.json()["result"]["episodes"][int.Parse(l.Text)]["webplay_url"]);
        }

        private void initBangumiData()
        {
            bangumiInfoJson = new jsonCatcher("http://bangumi.bilibili.com/jsonp/seasoninfo/" + bID.ToString() + ".ver?callback=seasonListCallback&jsonp=jsonp&_=1493791405048", true);

            if ((string)bangumiInfoJson.json()["message"] == "success")
            {
                bName = (string)bangumiInfoJson.json()["result"]["bangumi_title"];
                bJpName = (string)bangumiInfoJson.json()["result"]["jp_title"];
                bPicture = (string)bangumiInfoJson.json()["result"]["cover"];
                bCount = (string)bangumiInfoJson.json()["result"]["total_count"];
                bDetail = (string)bangumiInfoJson.json()["result"]["evaluate"];
                bIsFinished = (string)bangumiInfoJson.json()["result"]["is_finish"];

                this.bangumiName.Text = bName;
                this.bangumiPicture.ImageLocation = bPicture;
                this.bangumiCount.Text = "(共 " + bCount + " 集)";
                if (bIsFinished == "0") { this.iconIsFinished.Visible = false; }
                this.bangumiDetail.Text = bDetail;
            }
            else
            {
                MessageBox.Show("无法从Bilibili拉取番剧数据！");
            }
        }

        //Get the bangumi pictures from pixiv!
        private void pixivInit()
        {


            pixiv = new getPixiv(this.bJpName);     //Search this bangumi's japanese name.
            ArrayList pixivID = pixiv.pic();        //Get the pictures' pixiv ID.
     
            PictureBox[] pixivPics;
            if (pixivID.Count >= 16)                //If the count of the pictures is no more than 16.
            {
                pixivPics = new PictureBox[16];
            }
            else
            {
                pixivPics = new PictureBox[pixivID.Count];
            }
            int row = 0;   //2 rows / 16 pictures
            for (int i = 0; i < pixivPics.Length; i++)
            {
                if (i % (pixivPics.Length/2) == 0 && i != 0)
                {
                    row++;
                }

                //Init the UI
                pixivPics[i] = new PictureBox();
                pixivPics[i].Name = "picBox" + Convert.ToString(i + 1);
                pixivPics[i].Size = new Size(100, 100);
                pixivPics[i].Location = new Point(70 + i%(pixivPics.Length/2)* 105, 40 + row * 105);
                pixivPics[i].SizeMode = PictureBoxSizeMode.StretchImage;

                //Get the pic detail info
                jsonCatcher pictureCatcher = new jsonCatcher("https://api.imjad.cn/pixiv/v1/?type=illust&id=" + pixivID[i]);
                Console.WriteLine(pixivID[i]);

                ////Load Pic

                ///

                pixivPics[i].ImageLocation = (string)pictureCatcher.json()["response"][0]["image_urls"]["px_128x128"];
                this.pagePic.Controls.Add(pixivPics[i]);
            }

            int pageNumber = pixivID.Count / 16 + 1;
            Console.WriteLine(pixivID.Count);
            int nowPage = 1;
            pageNum.Text = nowPage.ToString() + " / " + pageNumber.ToString();

            for (int i = 0; i < pixivPics.Length; i++)
            {
                Console.WriteLine(pixivID[i]);
            }
        }

        private void bangumiOP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(opHunter.bSongURL);
        }

    }
}
