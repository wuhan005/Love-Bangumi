namespace Love_Bangumi
{
    partial class bangumiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bangumiForm));
            this.bangumiDetail = new System.Windows.Forms.Label();
            this.iconIsFinished = new System.Windows.Forms.PictureBox();
            this.bangumiName = new System.Windows.Forms.Label();
            this.bangumiPicture = new System.Windows.Forms.PictureBox();
            this.bangumiCount = new System.Windows.Forms.Label();
            this.bangumiOP = new System.Windows.Forms.Label();
            this.tabControl = new CCWin.SkinControl.SkinTabControl();
            this.pageVideo = new CCWin.SkinControl.SkinTabPage();
            this.pageMusic = new CCWin.SkinControl.SkinTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangumiDetail
            // 
            this.bangumiDetail.BackColor = System.Drawing.Color.Transparent;
            this.bangumiDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiDetail.ForeColor = System.Drawing.Color.White;
            this.bangumiDetail.Location = new System.Drawing.Point(270, 141);
            this.bangumiDetail.Name = "bangumiDetail";
            this.bangumiDetail.Size = new System.Drawing.Size(590, 111);
            this.bangumiDetail.TabIndex = 11;
            // 
            // iconIsFinished
            // 
            this.iconIsFinished.BackColor = System.Drawing.Color.Transparent;
            this.iconIsFinished.Image = global::Love_Bangumi.Properties.Resources.icon_end;
            this.iconIsFinished.Location = new System.Drawing.Point(356, 100);
            this.iconIsFinished.Name = "iconIsFinished";
            this.iconIsFinished.Size = new System.Drawing.Size(18, 18);
            this.iconIsFinished.TabIndex = 10;
            this.iconIsFinished.TabStop = false;
            // 
            // bangumiName
            // 
            this.bangumiName.BackColor = System.Drawing.Color.Transparent;
            this.bangumiName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiName.ForeColor = System.Drawing.Color.White;
            this.bangumiName.Location = new System.Drawing.Point(267, 52);
            this.bangumiName.Name = "bangumiName";
            this.bangumiName.Size = new System.Drawing.Size(333, 43);
            this.bangumiName.TabIndex = 9;
            this.bangumiName.Text = "番剧名称";
            this.bangumiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bangumiPicture
            // 
            this.bangumiPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bangumiPicture.Location = new System.Drawing.Point(100, 52);
            this.bangumiPicture.Name = "bangumiPicture";
            this.bangumiPicture.Size = new System.Drawing.Size(150, 200);
            this.bangumiPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bangumiPicture.TabIndex = 8;
            this.bangumiPicture.TabStop = false;
            // 
            // bangumiCount
            // 
            this.bangumiCount.BackColor = System.Drawing.Color.Transparent;
            this.bangumiCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiCount.ForeColor = System.Drawing.Color.White;
            this.bangumiCount.Location = new System.Drawing.Point(273, 98);
            this.bangumiCount.Name = "bangumiCount";
            this.bangumiCount.Size = new System.Drawing.Size(82, 23);
            this.bangumiCount.TabIndex = 12;
            // 
            // bangumiOP
            // 
            this.bangumiOP.BackColor = System.Drawing.Color.Transparent;
            this.bangumiOP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiOP.ForeColor = System.Drawing.Color.White;
            this.bangumiOP.Location = new System.Drawing.Point(668, 63);
            this.bangumiOP.Name = "bangumiOP";
            this.bangumiOP.Size = new System.Drawing.Size(264, 32);
            this.bangumiOP.TabIndex = 13;
            this.bangumiOP.Text = "OP: ";
            this.bangumiOP.Click += new System.EventHandler(this.bangumiOP_Click);
            // 
            // tabControl
            // 
            this.tabControl.AnimationStart = true;
            this.tabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl.Controls.Add(this.pageVideo);
            this.tabControl.Controls.Add(this.pageMusic);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.HeadBack = null;
            this.tabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl.ItemSize = new System.Drawing.Size(70, 36);
            this.tabControl.Location = new System.Drawing.Point(20, 270);
            this.tabControl.Name = "tabControl";
            this.tabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowDown")));
            this.tabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowHover")));
            this.tabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseHover")));
            this.tabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseNormal")));
            this.tabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageDown")));
            this.tabControl.PageDownTxtColor = System.Drawing.Color.White;
            this.tabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageHover")));
            this.tabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl.PageNorml = null;
            this.tabControl.PageNormlTxtColor = System.Drawing.Color.White;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 323);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 14;
            // 
            // pageVideo
            // 
            this.pageVideo.AutoScroll = true;
            this.pageVideo.BackColor = System.Drawing.Color.Transparent;
            this.pageVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageVideo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageVideo.Location = new System.Drawing.Point(0, 36);
            this.pageVideo.Name = "pageVideo";
            this.pageVideo.Padding = new System.Windows.Forms.Padding(3);
            this.pageVideo.Size = new System.Drawing.Size(992, 287);
            this.pageVideo.TabIndex = 0;
            this.pageVideo.TabItemImage = null;
            this.pageVideo.Text = "分集";
            // 
            // pageMusic
            // 
            this.pageMusic.BackColor = System.Drawing.Color.White;
            this.pageMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMusic.Location = new System.Drawing.Point(0, 36);
            this.pageMusic.Name = "pageMusic";
            this.pageMusic.Padding = new System.Windows.Forms.Padding(3);
            this.pageMusic.Size = new System.Drawing.Size(992, 287);
            this.pageMusic.TabIndex = 1;
            this.pageMusic.TabItemImage = null;
            this.pageMusic.Text = "音乐";
            this.pageMusic.UseVisualStyleBackColor = true;
            // 
            // bangumiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.BackgroundImage = global::Love_Bangumi.Properties.Resources.blue_wallpaper;
            this.ClientSize = new System.Drawing.Size(1019, 600);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.bangumiOP);
            this.Controls.Add(this.bangumiCount);
            this.Controls.Add(this.bangumiDetail);
            this.Controls.Add(this.iconIsFinished);
            this.Controls.Add(this.bangumiName);
            this.Controls.Add(this.bangumiPicture);
            this.EffectCaption = CCWin.TitleType.Title;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bangumiForm";
            this.Opacity = 0.95D;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bangumiDetail;
        private System.Windows.Forms.PictureBox iconIsFinished;
        private System.Windows.Forms.Label bangumiName;
        private System.Windows.Forms.PictureBox bangumiPicture;
        private System.Windows.Forms.Label bangumiCount;
        private System.Windows.Forms.Label bangumiOP;
        private CCWin.SkinControl.SkinTabControl tabControl;
        private CCWin.SkinControl.SkinTabPage pageVideo;
        private CCWin.SkinControl.SkinTabPage pageMusic;
    }
}