using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Love_Bangumi
{
    
    class bangumiSummary
    {
        public PictureBox bangumiCover = new PictureBox();
        public Label bangumiName = new Label();
        public PictureBox iconIsFinished = new PictureBox();

        public bangumiSummary()
        {
            bangumiCover.Size = new Size(150, 200);
            bangumiCover.Location = new Point(0, 0);

            bangumiName.Size = new Size(150, 20);
            bangumiName.Location = new Point(0 , 260);

            iconIsFinished.Size = new Size(18,18);
            iconIsFinished.Location = new Point(0, 265);
            iconIsFinished.Image = Love_Bangumi.Properties.Resources.icon_end;

            //Controls.Add(bangumiCover);
           // Controls.Add(bangumiName);
            //Controls.Add(iconIsFinished);

        }
    }
}
