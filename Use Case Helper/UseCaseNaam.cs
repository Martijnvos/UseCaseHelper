using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public partial class UseCaseNaam : Form
    {
        private Use_Case useCase;

        /// <summary>
        /// Ontvang de klasse die bewerkt of ingesteld moet worden
        /// </summary>
        /// <param name="useCase">Use Case die bewerkt of ingesteld moet worden</param>
        public UseCaseNaam(Use_Case useCase)
        {
            InitializeComponent();
            this.useCase = useCase;
        }

        /// <summary>
        /// Slaat gegevens op in betreffende Use Case klasse
        /// </summary>
        private void slaGegevensOp()
        {
            useCase.UseCaseNaamGetterSetter = textBoxUseCaseNaam.Text;
            useCase.UseCaseSamenvattingGetterSetter = textBoxUseCaseSamenvatting.Text;
            useCase.UseCaseActorenGetterSetter = textBoxUseCaseActoren.Text;
            useCase.UseCaseAannamesGetterSetter = textBoxUseCaseAannames.Text;
            useCase.UseCaseBeschrijvingGetterSetter = textBoxUseCaseBeschrijving.Text;
            useCase.UseCaseUitzonderingenGetterSetter = textBoxUseCaseUitzonderingen.Text;
            useCase.UseCaseResultaatGetterSetter = textBoxUseCaseResultaat.Text;

            this.Close();
        }

        /// <summary>
        /// Laad eventueel al aangewezen gegevens opnieuw zodat ze bewerkt kunnen worden
        /// </summary>
        private void laadOpgeslagenGegevens()
        {
            textBoxUseCaseNaam.Text = useCase.UseCaseNaamGetterSetter;
            textBoxUseCaseSamenvatting.Text = useCase.UseCaseSamenvattingGetterSetter;
            textBoxUseCaseActoren.Text = useCase.UseCaseActorenGetterSetter;
            textBoxUseCaseAannames.Text = useCase.UseCaseAannamesGetterSetter;
            textBoxUseCaseBeschrijving.Text = useCase.UseCaseBeschrijvingGetterSetter;
            textBoxUseCaseUitzonderingen.Text = useCase.UseCaseUitzonderingenGetterSetter;
            textBoxUseCaseResultaat.Text = useCase.UseCaseResultaatGetterSetter;
        }

        private void UseCaseNaam_Load(object sender, EventArgs e)
        {
            laadOpgeslagenGegevens();
        }

        private void buttonSlaOp_Click(object sender, EventArgs e)
        {
            slaGegevensOp();
        }
    }
}
