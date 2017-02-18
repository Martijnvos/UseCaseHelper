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
    public enum Resultaat { ActorMeerNaarLinks, ActorTekenenGeslaagd };
    public partial class FormUseCaseHelper : Form
    {
        private List<Actor> actorList = new List<Actor>();
        private List<Line> lijnenLijst = new List<Line>();
        private List<Use_Case> useCaseList = new List<Use_Case>();
        private Systembox systeemBox;

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
                    line.verwijderLijn(pictureBoxDrawingBoard, DrawArea);
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
                    Actor actor = new Actor();
                    actor.ActorPositieX = muisPositieX;
                    actor.ActorPositieY = muisPositieY;

                    Resultaat tekenActorMethodeResultaat = actor.tekenActor(pictureBoxDrawingBoard, DrawArea);
                    if (tekenActorMethodeResultaat == Resultaat.ActorMeerNaarLinks)
                    {
                        MessageBox.Show("Zet je actor meer naar links neer...");
                    } else if (tekenActorMethodeResultaat == Resultaat.ActorTekenenGeslaagd)
                    {
                        actorList.Add(actor);
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

                        lijnPositieClick1 = false;
                    } else
                    {
                        teTekenenLijn.LijnPositieX2 = muisPositieX;
                        teTekenenLijn.LijnPositieY2 = muisPositieY;

                        teTekenenLijn.tekenLijn(pictureBoxDrawingBoard, DrawArea, muisPositieX, muisPositieY);

                        lijnPositieClick1 = true;

                        lijnenLijst.Add(teTekenenLijn);
                    }

                }
            }
            else if (radioButtonUseCase.Checked)
            {
                if (radioButtonSelect.Checked)
                {
                    Point gekliktPunt = new Point(muisPositieX, muisPositieY);
                    foreach (Use_Case useCase in useCaseList)
                    {
                        if (useCase.UseCaseRectangleGetterSetter.Contains(gekliktPunt))
                        {
                            UseCaseNaam useCaseNaam = new UseCaseNaam(useCase);
                            useCaseNaam.ShowDialog();
                            useCase.updateUseCase(pictureBoxDrawingBoard, DrawArea);
                        }
                    }
                }
                else if (radioButtonCreate.Checked)
                {
                    if (useCaseList.Count == 0)
                    {
                        systeemBox = new Systembox();
                        systeemBox.creëerSysteemBox(pictureBoxDrawingBoard, DrawArea);
                    }

                    Use_Case useCase = new Use_Case();
                    UseCaseNaam useCaseNaam = new UseCaseNaam(useCase);
                    useCaseNaam.ShowDialog();
                    useCase.tekenUseCase(pictureBoxDrawingBoard, DrawArea, muisPositieX, muisPositieY);
                    useCaseList.Add(useCase);
                }
            }
        }
    }
}