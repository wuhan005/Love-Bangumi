using CCWin.SkinControl;

namespace Love_Bangumi
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.bangumiPicture = new CCWin.SkinControl.SkinPictureBox();
            this.recentFollowBangumi = new System.Windows.Forms.Label();
            this.bangumiName = new CCWin.SkinControl.SkinLabel();
            this.iconIsFinished = new System.Windows.Forms.PictureBox();
            this.bangumiDetail = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserFace = new System.Windows.Forms.PictureBox();
            this.UserSign = new System.Windows.Forms.Label();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserFace)).BeginInit();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangumiPicture
            // 
            this.bangumiPicture.BackColor = System.Drawing.Color.Transparent;
            this.bangumiPicture.InitialImage = global::Love_Bangumi.Properties.Resources.loading;
            this.bangumiPicture.Location = new System.Drawing.Point(22, 147);
            this.bangumiPicture.Name = "bangumiPicture";
            this.bangumiPicture.Size = new System.Drawing.Size(150, 200);
            this.bangumiPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bangumiPicture.TabIndex = 3;
            this.bangumiPicture.TabStop = false;
            this.bangumiPicture.Click += new System.EventHandler(this.bangumiPicture_Click);
            // 
            // recentFollowBangumi
            // 
            this.recentFollowBangumi.AutoSize = true;
            this.recentFollowBangumi.BackColor = System.Drawing.Color.Transparent;
            this.recentFollowBangumi.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recentFollowBangumi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.recentFollowBangumi.Location = new System.Drawing.Point(9, 111);
            this.recentFollowBangumi.Name = "recentFollowBangumi";
            this.recentFollowBangumi.Size = new System.Drawing.Size(134, 31);
            this.recentFollowBangumi.TabIndex = 4;
            this.recentFollowBangumi.Text = "最近在追：";
            // 
            // bangumiName
            // 
            this.bangumiName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.bangumiName.BackColor = System.Drawing.Color.Transparent;
            this.bangumiName.BorderColor = System.Drawing.Color.White;
            this.bangumiName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.bangumiName.Location = new System.Drawing.Point(18, 350);
            this.bangumiName.Name = "bangumiName";
            this.bangumiName.Size = new System.Drawing.Size(150, 26);
            this.bangumiName.TabIndex = 5;
            this.bangumiName.Text = "番剧名称";
            this.bangumiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconIsFinished
            // 
            this.iconIsFinished.BackColor = System.Drawing.Color.Transparent;
            this.iconIsFinished.Image = global::Love_Bangumi.Properties.Resources.icon_end;
            this.iconIsFinished.Location = new System.Drawing.Point(160, 355);
            this.iconIsFinished.Name = "iconIsFinished";
            this.iconIsFinished.Size = new System.Drawing.Size(18, 18);
            this.iconIsFinished.TabIndex = 6;
            this.iconIsFinished.TabStop = false;
            // 
            // bangumiDetail
            // 
            this.bangumiDetail.BackColor = System.Drawing.Color.Transparent;
            this.bangumiDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bangumiDetail.Location = new System.Drawing.Point(18, 376);
            this.bangumiDetail.Name = "bangumiDetail";
            this.bangumiDetail.Size = new System.Drawing.Size(148, 51);
            this.bangumiDetail.TabIndex = 7;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UserName.Location = new System.Drawing.Point(87, 34);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(298, 31);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "UserName";
            // 
            // UserFace
            // 
            this.UserFace.BackColor = System.Drawing.Color.Transparent;
            this.UserFace.InitialImage = global::Love_Bangumi.Properties.Resources.loading;
            this.UserFace.Location = new System.Drawing.Point(21, 25);
            this.UserFace.Name = "UserFace";
            this.UserFace.Size = new System.Drawing.Size(60, 60);
            this.UserFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserFace.TabIndex = 9;
            this.UserFace.TabStop = false;
            // 
            // UserSign
            // 
            this.UserSign.BackColor = System.Drawing.Color.Transparent;
            this.UserSign.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.UserSign.ForeColor = System.Drawing.Color.DarkGray;
            this.UserSign.Location = new System.Drawing.Point(89, 65);
            this.UserSign.Name = "UserSign";
            this.UserSign.Size = new System.Drawing.Size(777, 20);
            this.UserSign.TabIndex = 10;
            this.UserSign.Text = "UserSign";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(80, 60);
            this.skinTabControl1.Location = new System.Drawing.Point(431, 34);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageArrowPalace = true;
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(450, 60);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 11;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.skinTabPage1.ImageKey = "(无)";
            this.skinTabPage1.Location = new System.Drawing.Point(0, 60);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(450, 0);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = global::Love_Bangumi.Properties.Resources.icon_mainpage;
            this.skinTabPage1.Text = "首页";
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage2.Location = new System.Drawing.Point(0, 60);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(450, 0);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = global::Love_Bangumi.Properties.Resources.icon_setting;
            this.skinTabPage2.Text = "设置";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Love_Bangumi.Properties.Resources.bg_MainPanel;
            this.ClientSize = new System.Drawing.Size(885, 560);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.UserSign);
            this.Controls.Add(this.UserFace);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.bangumiDetail);
            this.Controls.Add(this.iconIsFinished);
            this.Controls.Add(this.bangumiName);
            this.Controls.Add(this.recentFollowBangumi);
            this.Controls.Add(this.bangumiPicture);
            this.EffectCaption = CCWin.TitleType.Title;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Love Bangumi - 主面板 Main Control Panel";
            this.TitleCenter = true;
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserFace)).EndInit();
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox bangumiPicture;
        private System.Windows.Forms.Label recentFollowBangumi;
        private SkinLabel bangumiName;
        private System.Windows.Forms.PictureBox iconIsFinished;
        private System.Windows.Forms.Label bangumiDetail;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox UserFace;
        private System.Windows.Forms.Label UserSign;
        private SkinTabControl skinTabControl1;
        private SkinTabPage skinTabPage1;
        private SkinTabPage skinTabPage2;
    }
}