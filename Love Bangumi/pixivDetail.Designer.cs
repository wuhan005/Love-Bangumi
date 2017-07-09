namespace Love_Bangumi
{
    partial class pixivDetail
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
            this.picName = new System.Windows.Forms.Label();
            this.picAuthor = new System.Windows.Forms.Label();
            this.picTime = new System.Windows.Forms.Label();
            this.picContext = new System.Windows.Forms.Label();
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.picTags = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picName
            // 
            this.picName.AutoSize = true;
            this.picName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picName.Location = new System.Drawing.Point(7, 498);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(67, 31);
            this.picName.TabIndex = 1;
            this.picName.Text = "Title";
            // 
            // picAuthor
            // 
            this.picAuthor.AutoSize = true;
            this.picAuthor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(110)))), ((int)(((byte)(238)))));
            this.picAuthor.Location = new System.Drawing.Point(9, 528);
            this.picAuthor.Name = "picAuthor";
            this.picAuthor.Size = new System.Drawing.Size(56, 20);
            this.picAuthor.TabIndex = 2;
            this.picAuthor.Text = "Author";
            // 
            // picTime
            // 
            this.picTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picTime.ForeColor = System.Drawing.Color.Gray;
            this.picTime.Location = new System.Drawing.Point(9, 548);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(144, 16);
            this.picTime.TabIndex = 3;
            this.picTime.Text = "0000-00-00 00:00:00";
            // 
            // picContext
            // 
            this.picContext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picContext.Location = new System.Drawing.Point(9, 607);
            this.picContext.Name = "picContext";
            this.picContext.Size = new System.Drawing.Size(710, 103);
            this.picContext.TabIndex = 4;
            this.picContext.Text = "Context";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(7, 21);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(713, 464);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // picTags
            // 
            this.picTags.AutoSize = true;
            this.picTags.BackColor = System.Drawing.Color.DarkGray;
            this.picTags.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.picTags.ForeColor = System.Drawing.Color.DimGray;
            this.picTags.Location = new System.Drawing.Point(10, 575);
            this.picTags.Name = "picTags";
            this.picTags.Size = new System.Drawing.Size(0, 17);
            this.picTags.TabIndex = 5;
            this.picTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pixivDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 725);
            this.Controls.Add(this.picTags);
            this.Controls.Add(this.picContext);
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.picAuthor);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.picBox);
            this.MaximizeBox = false;
            this.Name = "pixivDetail";
            this.Shadow = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox picBox;
        private System.Windows.Forms.Label picName;
        private System.Windows.Forms.Label picAuthor;
        private System.Windows.Forms.Label picTime;
        private System.Windows.Forms.Label picContext;
        private System.Windows.Forms.Label picTags;
    }
}