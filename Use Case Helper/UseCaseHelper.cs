using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public partial class FormUseCaseHelper : Form
    {
        private List<Actor> actorList = new List<Actor>();
        private List<Line> lijnenLijst = new List<Line>();
        private List<Use_Case> useCaseList = new List<Use_Case>();

        private Bitmap DrawArea;
        private bool lijnPositieClick1 = true;
        private Line teTekenenLijn;

        public FormUseCaseHelper()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBoxDrawingBoard.Size.Width, pictureBoxDrawingBoard.Size.Height);
            pictureBoxDrawingBoard.Image = DrawArea;

            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.White);
            g.Dispose();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            if (pictureBoxDrawingBoard.Image != null)
            {
                pictureBoxDrawingBoard.Image = null;
                actorList.Clear();
                lijnenLijst.Clear();
                useCaseList.Clear();

                DrawArea = new Bitmap(pictureBoxDrawingBoard.Size.Width, pictureBoxDrawingBoard.Size.Height);
                pictureBoxDrawingBoard.Image = DrawArea;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (radioButtonActor.Checked)
            {

            } else if (radioButtonLine.Checked)
            {
                foreach (Line line in lijnenLijst)
                {
                    int X1 = line.LijnPositieX1;
                    int X2 = line.LijnPositieX2;
                    int Y1 = line.LijnPositieY1;
                    int Y2 = line.LijnPositieY2;

                    Graphics g;
                    g = Graphics.FromImage(DrawArea);
                    Pen mypen = new Pen(Color.White);
                    g.DrawLine(mypen, X1, Y1, X2, Y2);
                    pictureBoxDrawingBoard.Image = DrawArea;
                    g.Dispose();
                }

                lijnenLijst.Clear();

            } else if (radioButtonUseCase.Checked)
            {

            }
        }

        private void buttonGenereerJPG_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBoxDrawingBoard.Image;
            bmp.Save(@"D:\Documents - HDD\Martijn Fontys\Software Development\S2\Week 2\Use Case Helper\useCaseImage.png");
        }

        private void pictureBoxDrawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            int muisPositieX = e.X;
            int muisPositieY = e.Y;

            if (radioButtonActor.Checked)
            {
                if (radioButtonSelect.Checked)
                {
                    //selecteerActor();
                }
                else if (radioButtonCreate.Checked)
                {
                    if (muisPositieX < 100)
                    {
                        ActorNaam actorNaam = new ActorNaam();
                        actorNaam.ShowDialog();
                        string ingevuldeActorNaam = actorNaam.ActorNaamGetter;

                        Graphics g;
                        g = Graphics.FromImage(DrawArea);
                        Pen drawPen = new Pen(Color.Black);
                        Font drawFont = new Font("Arial", 8);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawEllipse(drawPen, new Rectangle(muisPositieX, muisPositieY, 20, 20));
                        g.DrawLine(drawPen, muisPositieX + 10, muisPositieY + 20, muisPositieX + 10, muisPositieY + 45);
                        g.DrawLine(drawPen, muisPositieX, muisPositieY + 30, muisPositieX + 20, muisPositieY + 30);
                        g.DrawLine(drawPen, muisPositieX + 10, muisPositieY + 45, muisPositieX, muisPositieY + 60);
                        g.DrawLine(drawPen, muisPositieX + 10, muisPositieY + 45, muisPositieX + 20, muisPositieY + 60);
                        g.DrawString(ingevuldeActorNaam, drawFont, drawBrush, muisPositieX - 10, muisPositieY + 60);
                        pictureBoxDrawingBoard.Image = DrawArea;
                        drawPen.Dispose();
                        drawFont.Dispose();
                        drawBrush.Dispose();
                        g.Dispose();


                        Actor actor = new Actor();
                        actor.ActorPositieX = muisPositieX;
                        actor.ActorPositieY = muisPositieY;
                        actorList.Add(actor);
                    } else
                    {
                        MessageBox.Show("Zet je actor meer naar links neer...");
                    }
                    
                }
            }
            else if (radioButtonLine.Checked)
            {
                if (radioButtonSelect.Checked)
                {
                    //selecteerLijn();
                }
                else if (radioButtonCreate.Checked)
                {
                    if (lijnPositieClick1)
                    {
                        teTekenenLijn = new Line();
                        teTekenenLijn.LijnPositieX1 = muisPositieX;
                        teTekenenLijn.LijnPositieY1 = muisPositieY;
                        lijnenLijst.Add(teTekenenLijn);

                        lijnPositieClick1 = false;
                    } else
                    {
                        teTekenenLijn.LijnPositieX2 = muisPositieX;
                        teTekenenLijn.LijnPositieY2 = muisPositieY;

                        Graphics g;
                        g = Graphics.FromImage(DrawArea);
                        Pen mypen = new Pen(Color.Black);
                        g.DrawLine(mypen, teTekenenLijn.LijnPositieX1, teTekenenLijn.LijnPositieY1, muisPositieX, muisPositieY);
                        pictureBoxDrawingBoard.Image = DrawArea;
                        g.Dispose();

                        lijnPositieClick1 = true;
                    }

                }
            }
            else if (radioButtonUseCase.Checked)
            {
                if (radioButtonSelect.Checked)
                {
                    //selecteerUseCase();
                }
                else if (radioButtonCreate.Checked)
                {
                    UseCaseNaam useCaseNaam = new UseCaseNaam();
                    useCaseNaam.ShowDialog();

                    Use_Case useCase = new Use_Case();
                    string useCaseNaamResultaat = useCaseNaam.UseCaseNaamGetter;
                    useCase.UseCaseNaamGetterSetter = useCaseNaam.UseCaseNaamGetter;
                    useCase.UseCaseSamenvattingGetterSetter = useCaseNaam.UseCaseSamenvattingGetter;
                    useCase.UseCaseActorenGetterSetter = useCaseNaam.UseCaseActorenGetter;
                    useCase.UseCaseAannamesGetterSetter = useCaseNaam.UseCaseAannamesGetter;
                    useCase.UseCaseBeschrijvingGetterSetter = useCaseNaam.UseCaseBeschrijvingGetter;
                    useCase.UseCaseUitzonderingenGetterSetter = useCaseNaam.UseCaseUitzonderingenGetter;
                    useCase.UseCaseResultaatGetterSetter = useCaseNaam.UseCaseResultaatGetter;
                    useCaseList.Add(useCase);

                    Rectangle ellipseSpace = new Rectangle(muisPositieX, muisPositieY, 150, 30);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    Graphics g;
                    g = Graphics.FromImage(DrawArea);
                    Pen drawPen = new Pen(Color.Black);
                    Font drawFont = new Font("Arial", 8);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    g.DrawEllipse(drawPen, ellipseSpace);
                    g.DrawString(useCaseNaamResultaat, drawFont, drawBrush, ellipseSpace, stringFormat);
                    pictureBoxDrawingBoard.Image = DrawArea;
                    drawPen.Dispose();
                    drawFont.Dispose();
                    drawBrush.Dispose();
                    g.Dispose();
                }
            }
        }

    }
}
