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
            this.bangumiDetail = new System.Windows.Forms.Label();
            this.iconIsFinished = new System.Windows.Forms.PictureBox();
            this.bangumiName = new System.Windows.Forms.Label();
            this.bangumiPicture = new System.Windows.Forms.PictureBox();
            this.bangumiCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bangumiDetail
            // 
            this.bangumiDetail.BackColor = System.Drawing.Color.Transparent;
            this.bangumiDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangumiDetail.ForeColor = System.Drawing.Color.White;
            this.bangumiDetail.Location = new System.Drawing.Point(244, 132);
            this.bangumiDetail.Name = "bangumiDetail";
            this.bangumiDetail.Size = new System.Drawing.Size(590, 111);
            this.bangumiDetail.TabIndex = 11;
            // 
            // iconIsFinished
            // 
            this.iconIsFinished.BackColor = System.Drawing.Color.Transparent;
            this.iconIsFinished.Image = global::Love_Bangumi.Properties.Resources.icon_end;
            this.iconIsFinished.Location = new System.Drawing.Point(330, 91);
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
            this.bangumiName.Location = new System.Drawing.Point(241, 43);
            this.bangumiName.Name = "bangumiName";
            this.bangumiName.Size = new System.Drawing.Size(333, 43);
            this.bangumiName.TabIndex = 9;
            this.bangumiName.Text = "番剧名称";
            this.bangumiName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bangumiPicture
            // 
            this.bangumiPicture.Location = new System.Drawing.Point(74, 43);
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
            this.bangumiCount.Location = new System.Drawing.Point(247, 89);
            this.bangumiCount.Name = "bangumiCount";
            this.bangumiCount.Size = new System.Drawing.Size(82, 23);
            this.bangumiCount.TabIndex = 12;
            // 
            // bangumiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackgroundImage = global::Love_Bangumi.Properties.Resources.wallpaper02;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.bangumiCount);
            this.Controls.Add(this.bangumiDetail);
            this.Controls.Add(this.iconIsFinished);
            this.Controls.Add(this.bangumiName);
            this.Controls.Add(this.bangumiPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bangumiForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.iconIsFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangumiPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bangumiDetail;
        private System.Windows.Forms.PictureBox iconIsFinished;
        private System.Windows.Forms.Label bangumiName;
        private System.Windows.Forms.PictureBox bangumiPicture;
        private System.Windows.Forms.Label bangumiCount;
    }
}