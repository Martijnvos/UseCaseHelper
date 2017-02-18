using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public class Use_Case
    {
        public string UseCaseNaamGetterSetter { get; set; }
        public string UseCaseSamenvattingGetterSetter { get; set; }
        public string UseCaseActorenGetterSetter { get; set; }
        public string UseCaseAannamesGetterSetter { get; set; }
        public string UseCaseBeschrijvingGetterSetter { get; set; }
        public string UseCaseUitzonderingenGetterSetter { get; set; }
        public string UseCaseResultaatGetterSetter { get; set; }
        public Rectangle UseCaseRectangleGetterSetter { get; set; }

        StringFormat stringFormat;

        public Use_Case()
        {
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        public void tekenUseCase(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea, int muisPositieX, int muisPositieY)
        {
            Rectangle ellipseSpace = new Rectangle(muisPositieX, muisPositieY, 150, 30);
            UseCaseRectangleGetterSetter = ellipseSpace;

            Graphics g = Graphics.FromImage(DrawArea);
            Pen drawPen = new Pen(Color.Black);
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawEllipse(drawPen, ellipseSpace);
            g.DrawString(UseCaseNaamGetterSetter, drawFont, drawBrush, ellipseSpace, stringFormat);
            pictureBoxDrawingBoard.Image = DrawArea;
            drawPen.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }

        public void updateUseCase(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(UseCaseNaamGetterSetter, drawFont, drawBrush, UseCaseRectangleGetterSetter, stringFormat);
            pictureBoxDrawingBoard.Image = DrawArea;
            drawFont.Dispose();
            drawBrush.Dispose();
            g.Dispose();
        }

        public void verwijderUseCase()
        {

        }
    }
}
