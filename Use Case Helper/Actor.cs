using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    class Actor
    {
        public int ActorPositieX { get; set; }
        public int ActorPositieY { get; set; }

        public Resultaat tekenActor(PictureBox pictureBoxDrawingBoard, Bitmap DrawArea)
        {
            if (ActorPositieX < 100)
            {
                ActorNaam actorNaam = new ActorNaam();
                actorNaam.ShowDialog();
                string ingevuldeActorNaam = actorNaam.ActorNaamGetter;

                Graphics g = Graphics.FromImage(DrawArea);
                Pen drawPen = new Pen(Color.Black);
                Font drawFont = new Font("Arial", 8);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawEllipse(drawPen, new Rectangle(ActorPositieX, ActorPositieY, 20, 20));
                g.DrawLine(drawPen, ActorPositieX + 10, ActorPositieY + 20, ActorPositieX + 10, ActorPositieY + 45);
                g.DrawLine(drawPen, ActorPositieX, ActorPositieY + 30, ActorPositieX + 20, ActorPositieY + 30);
                g.DrawLine(drawPen, ActorPositieX + 10, ActorPositieY + 45, ActorPositieX, ActorPositieY + 60);
                g.DrawLine(drawPen, ActorPositieX + 10, ActorPositieY + 45, ActorPositieX + 20, ActorPositieY + 60);
                g.DrawString(ingevuldeActorNaam, drawFont, drawBrush, ActorPositieX - 10, ActorPositieY + 60);
                pictureBoxDrawingBoard.Image = DrawArea;
                drawPen.Dispose();
                drawFont.Dispose();
                drawBrush.Dispose();
                g.Dispose();

                return Resultaat.ActorTekenenGeslaagd;

            }
            else
            {
                return Resultaat.ActorMeerNaarLinks;
            }
        }

        public void verwijderActor()
        {

        }
    }
}
