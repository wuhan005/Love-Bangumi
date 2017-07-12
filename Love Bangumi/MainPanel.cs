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
        private static uint biliID = 3788683;
        //private bangumiTimeLine timeLine = new bangumiTimeLine();
        private getUserInfo userInfo = new getUserInfo(biliID);
        private getBiliBangumi getFirstBangumi;
        private GraphicsPath circlePath = new GraphicsPath();   //Used to cut the user face to circle.

        public MainPanel()
        {
            InitializeComponent();
            getRecentBangumi();
            this.UserName.Text = userInfo.UserData()["UserName"];
            this.UserSign.Text = userInfo.UserData()["Sign"];

            this.UserFace.ImageLocation = userInfo.UserData()["FaceURL"];
            circlePath.AddArc(UserFace.DisplayRectangle, 0, 360);
            this.UserFace.Region = new Region(circlePath);
        }


        private void getRecentBangumi()
        {
            string firstBangumiID = userInfo.RecentBangumi()[0];
            getFirstBangumi = new getBiliBangumi(uint.Parse(firstBangumiID));

            this.bangumiName.Text = getFirstBangumi.data()["Name"];
            this.bangumiPicture.ImageLocation = getFirstBangumi.data()["Picture"];
            if(getFirstBangumi.data()["IsFinish"] == "0")    //0: not finished.
            {
                this.iconIsFinished.Visible = false;
            }
            this.bangumiDetail.Text = "（共 " + getFirstBangumi.data()["Count"] + " 集）";
        }

        private void bangumiPicture_Click(object sender, EventArgs e)
        {
            bangumiForm recentBangumiForm = new bangumiForm(uint.Parse(getFirstBangumi.data()["ID"]));
            recentBangumiForm.Show();
        }


    }
}
