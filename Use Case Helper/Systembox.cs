using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public class Systembox
    {
        public string SysteemNaamGetterSetter { get; set; }

        private StringFormat stringFormat;

        public void creëerSysteemBox(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea)
        {
            Rectangle systeemBox = new Rectangle(300, 10, 300, 450);

            SysteemNaam systeemNaam = new SysteemNaam(this);
            systeemNaam.ShowDialog();

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            Graphics g = Graphics.FromImage(DrawArea);
            Pen drawPen = new Pen(Color.Black);
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawRectangle(drawPen, systeemBox);
            g.DrawString(SysteemNaamGetterSetter, drawFont, drawBrush, systeemBox, stringFormat);
            pictureBoxDrawingBoard.Image = DrawArea;
            drawPen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }

    }
}
