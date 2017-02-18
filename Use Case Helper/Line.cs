using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    class Line
    {
        public int LijnPositieX1 { get; set; }
        public int LijnPositieY1 { get; set; }
        public int LijnPositieX2 { get; set; }
        public int LijnPositieY2 { get; set; }

        public void tekenLijn(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea, int muisPositieX, int muisPositieY)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen mypen = new Pen(Color.Black);
            g.DrawLine(mypen, LijnPositieX1, LijnPositieY1, muisPositieX, muisPositieY);
            pictureBoxDrawingBoard.Image = DrawArea;
            g.Dispose();
        }

        public void verwijderLijn(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            Pen mypen = new Pen(Color.White);
            g.DrawLine(mypen, LijnPositieX1, LijnPositieY1, LijnPositieX2, LijnPositieY2);
            pictureBoxDrawingBoard.Image = DrawArea;
            g.Dispose();
        }
    }
}    
