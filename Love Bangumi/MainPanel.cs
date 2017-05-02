using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using CCWin;
using System.Drawing.Drawing2D;

namespace Love_Bangumi
{
    public partial class MainPanel : CCSkinMain
    {
        [DLLImport("CSkin.dll")]
        
        private string[] recentBangumi;
        private static uint biliID = 3788683;
        private getUserInfo userInfo = new getUserInfo(biliID);
        private GraphicsPath circlePath = new GraphicsPath();   //Used to cut the user face to circle.

        public MainPanel()
        {
            InitializeComponent();
            getBangumiInfo();
            this.UserName.Text = userInfo.data["UserName"];
            this.UserSign.Text = userInfo.data["Sign"];

            this.UserFace.ImageLocation = userInfo.data["FaceURL"];
            circlePath.AddArc(UserFace.DisplayRectangle, 0, 360);
            this.UserFace.Region = new Region(circlePath);
        }


        private void getBangumiInfo()
        {
            getBiliBangumi getBangumi = new getBiliBangumi(biliID);
            recentBangumi = getBangumi.recentBangumi();

            this.bangumiName.Text = recentBangumi[0];
            this.bangumiPicture.ImageLocation = recentBangumi[1];
            if(recentBangumi[2] == "0")
            {
                this.iconIsFinished.Visible = false;
            }
            this.bangumiDetail.Text = "（共 " + recentBangumi[3] + " 集）";
        }

        private void bangumiPicture_Click(object sender, EventArgs e)
        {
            bangumiForm recentBangumiForm = new bangumiForm(uint.Parse(recentBangumi[5]));
            recentBangumiForm.Show();
        }


    }
}
