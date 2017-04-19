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
            this.bangumiPicture = new System.Windows.Forms.PictureBox();
            this.recentFollowBangumi = new System.Windows.Forms.Label();
            this.bangumiName = new CCWin.SkinControl.SkinLabel();
            this.iconIsFinished = new System.Windows.Forms.PictureBox();
            this.bangumiDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).BeginInit();
            this.SuspendLayout();
            // 
            // bangumiPicture
            // 
            this.bangumiPicture.Location = new System.Drawing.Point(15, 73);
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
            this.recentFollowBangumi.ForeColor = System.Drawing.Color.White;
            this.recentFollowBangumi.Location = new System.Drawing.Point(-1, 27);
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
            this.bangumiName.ForeColor = System.Drawing.Color.White;
            this.bangumiName.Location = new System.Drawing.Point(15, 279);
            this.bangumiName.Name = "bangumiName";
            this.bangumiName.Size = new System.Drawing.Size(150, 20);
            this.bangumiName.TabIndex = 5;
            this.bangumiName.Text = "番剧名称";
            this.bangumiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconIsFinished
            // 
            this.iconIsFinished.BackColor = System.Drawing.Color.Transparent;
            this.iconIsFinished.Image = global::Love_Bangumi.Properties.Resources.icon_end;
            this.iconIsFinished.Location = new System.Drawing.Point(157, 281);
            this.iconIsFinished.Name = "iconIsFinished";
            this.iconIsFinished.Size = new System.Drawing.Size(18, 18);
            this.iconIsFinished.TabIndex = 6;
            this.iconIsFinished.TabStop = false;
            // 
            // bangumiDetail
            // 
            this.bangumiDetail.BackColor = System.Drawing.Color.Transparent;
            this.bangumiDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiDetail.ForeColor = System.Drawing.Color.White;
            this.bangumiDetail.Location = new System.Drawing.Point(12, 302);
            this.bangumiDetail.Name = "bangumiDetail";
            this.bangumiDetail.Size = new System.Drawing.Size(148, 51);
            this.bangumiDetail.TabIndex = 7;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Love_Bangumi.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
            this.Text = "LoveBangumi - 主面板 Main Control Panel";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bangumiPicture;
        private System.Windows.Forms.Label recentFollowBangumi;
        private SkinLabel bangumiName;
        private System.Windows.Forms.PictureBox iconIsFinished;
        private System.Windows.Forms.Label bangumiDetail;
    }
}