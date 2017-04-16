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

namespace Love_Bangumi
{
    public partial class MainPanel : Form
    {
        private string[] recentBangumi;

        public MainPanel()
        {
            InitializeComponent();
            getBangumiInfo();
            MusicHunter mh = new MusicHunter("only my railgun");
        }

        private void getBangumiInfo()
        {
            getBiliBangumi getBangumi = new getBiliBangumi();
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
