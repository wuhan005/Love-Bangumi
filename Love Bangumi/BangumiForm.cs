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
using Newtonsoft.Json;

namespace Love_Bangumi
{
    public partial class bangumiForm : CCSkinMain
    {
        private getBiliBangumi bangumiInfo;     //IMPORTANT!!

        private MusicHunter opHunter;
        private getPixiv pixiv;
        private int nowPage = 0;    //start from 0!!
        private bool picIsLoad = false;

        public bangumiForm(uint bangumiID)
        {
            InitializeComponent();

            this.bangumiInfo = new getBiliBangumi(bangumiID);

            initBangumiData();  //Get the bangumi data from bilibili
            initEpisodes();
            this.Text = bangumiInfo.data()["Name"];

            opHunter = new MusicHunter(bangumiInfo.data()["Name"]);

            this.tabControl.SelectedIndexChanged += new EventHandler(this.tabControlChanged);

        }

        private void tabControlChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == pagePic)
            {
                if (!picIsLoad)
                {
                    pixivInit();
                    picIsLoad = true;
                }
            }
        }
        
        private void initEpisodes()
        {
            int count = int.Parse(bangumiInfo.data()["Count"]);
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
                ePicture.ImageLocation = (string)bangumiInfo.episodes()[count - 1 - i]["cover"];
                ePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                ePicture.InitialImage = Properties.Resources.loading;

                eName.ArtTextStyle = ArtTextStyle.None;
                eName.Location = new Point(105 + i % 4 * 230, 28 + row * 80);
                eName.Size = new Size(110, 35);
                eName.Text = (string)bangumiInfo.episodes()[count - 1 - i]["index_title"];
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

                eBlankGround.Click += new EventHandler(toWebBangumi_Click);

                }
        }

        private void toWebBangumi_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            //System.Diagnostics.Process.Start((string)bangumiInfo.episodes()[count - 1 - i]["cover"]);
        }

        private void initBangumiData()
        {
            this.bangumiName.Text = bangumiInfo.data()["Name"];
            this.bangumiPicture.ImageLocation = bangumiInfo.data()["Picture"];
            this.bangumiCount.Text = "(共 " + bangumiInfo.data()["Count"] + " 集)";
            if (bangumiInfo.data()["IsFinish"] == "0") { this.iconIsFinished.Visible = false; }
            this.bangumiDetail.Text = bangumiInfo.data()["Detail"];
        }

        //Get the bangumi pictures from pixiv!
        private void pixivInit()
        {
            pixiv = new getPixiv(bangumiInfo.data()["JapanName"]);     //Search this bangumi's japanese name.
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
                int singlePixivID = Convert.ToInt32(pixivID[i]);

                pixivPics[i] = new PictureBox();
                pixivPics[i].Name = "picBox" + Convert.ToString(i + 1);
                pixivPics[i].Size = new Size(100, 100);
                pixivPics[i].Location = new Point(70 + i%(pixivPics.Length/2)* 105, 40 + row * 105);
                pixivPics[i].SizeMode = PictureBoxSizeMode.StretchImage;

                pixivPics[i].Tag = singlePixivID;    //Send the pixiv ID.
                pixivPics[i].Click += new System.EventHandler(this.pixivPics_Click);    //Click -> open the detail win.

                //Get the pic detail info
                jsonCatcher pictureCatcher = new jsonCatcher("https://api.imjad.cn/pixiv/v1/?type=illust&id=" + pixivID[i]);

                ////Load Pic

                ///

                pixivPics[i].ImageLocation = (string)pictureCatcher.json()["response"][0]["image_urls"]["px_128x128"];
                this.pagePic.Controls.Add(pixivPics[i]);
            }

            int pageNumber = pixivID.Count / 16 + 1;
            int nowPage = 1;
            pageNum.Text = nowPage.ToString() + " / " + pageNumber.ToString();

            for (int i = 0; i < pixivPics.Length; i++)
            {
                Console.WriteLine(pixivID[i]);
            }
        }

        private void pixivPics_Click(object sender, EventArgs e)
        {
            //Open picture detail win.
            PictureBox pic = (PictureBox)sender;
            pixivDetail picDetail = new pixivDetail((int)pic.Tag);
            picDetail.Show();
        }

        private void bangumiOP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(opHunter.bSongURL);
        }

    }
}
