using System;
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
    public partial class bangumiForm : Form
    {
        private jsonCatcher bangumiInfoJson;
        private uint bID;
        private string bName;
        private string bPicture;
        private string bCount;
        private string bDetail;
        private string bIsFinished;

        public bangumiForm(uint bangumiID)
        {
            InitializeComponent();

            bID = bangumiID;
            initBangumiData();
            initEpisodes();
            this.Text = bName;
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
                Label eCountNumber = new Label();
                Label eName = new Label();

                eBlankGround.Location = new Point(45 + i % 4 * 230, 270 + row * 80);
                eBlankGround.Size = new Size(210, 60);
                eBlankGround.Text = (count -1 - i).ToString();

                ePicture.Location = new Point(45 + i % 4 * 230, 270 + row * 80);
                ePicture.Size = new Size(96, 60);
                ePicture.ImageLocation = (string)bangumiInfoJson.json()["result"]["episodes"][count - 1 - i]["cover"];
                ePicture.SizeMode = PictureBoxSizeMode.StretchImage;

                eName.Location = new Point(145 + i % 4 * 230, 300 + row * 80);
                eName.Size = new Size(100, 20);
                eName.Text = (string)bangumiInfoJson.json()["result"]["episodes"][count - 1 - i]["index_title"];
                eName.Font = new Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                eCountNumber.Location = new Point(145 + i % 4 * 230, 275 + row * 80);
                eCountNumber.Size = new Size(100, 25);
                eCountNumber.Text = "第 " + (i+1).ToString() + " 集";
                eCountNumber.Font = new Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                this.Controls.Add(eName);
                this.Controls.Add(eCountNumber);
                this.Controls.Add(ePicture);
                this.Controls.Add(eBlankGround);

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
            bangumiInfoJson = new jsonCatcher("http://bangumi.bilibili.com/jsonp/seasoninfo/" + bID.ToString() + ".ver", true);

            if ((string)bangumiInfoJson.json()["message"] == "success")
            {
                bName = (string)bangumiInfoJson.json()["result"]["bangumi_title"];
                bPicture = (string)bangumiInfoJson.json()["result"]["cover"];
                bCount = (string)bangumiInfoJson.json()["result"]["total_count"];
                bDetail = (string)bangumiInfoJson.json()["result"]["evaluate"];
                bIsFinished = (string)bangumiInfoJson.json()["result"]["is_finish"];

                this.bangumiName.Text = bName;
                this.bangumiPicture.ImageLocation = bPicture;
                this.bangumiCount.Text = "(共 " + bCount + " 集)";
                if (bIsFinished == "0") { this.iconIsFinished.Visible = false; }
                this.bangumiDetail.Text = bDetail;
                //MessageBox.Show(bEpisodes);
            }
            else
            {
                MessageBox.Show("无法从Bilibili拉取番剧数据！");
            }
        }

    }
}
