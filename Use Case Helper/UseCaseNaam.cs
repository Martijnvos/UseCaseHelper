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
        private string useCaseNaam;
        private string useCaseSamenvatting;
        private string useCaseActoren;
        private string useCaseAannames;
        private string useCaseBeschrijving;
        private string useCaseUitzonderingen;
        private string useCaseResultaat;

        public string UseCaseNaamGetter { get { return useCaseNaam; } }
        public string UseCaseSamenvattingGetter { get { return useCaseSamenvatting; } }
        public string UseCaseActorenGetter { get { return useCaseActoren; } }
        public string UseCaseAannamesGetter { get { return useCaseAannames; } }
        public string UseCaseBeschrijvingGetter { get { return useCaseBeschrijving; } }
        public string UseCaseUitzonderingenGetter { get { return useCaseUitzonderingen; } }
        public string UseCaseResultaatGetter { get { return useCaseResultaat; } }

        public UseCaseNaam()
        {
            InitializeComponent();
        }

        private void buttonSlaOp_Click(object sender, EventArgs e)
        {
            useCaseNaam = textBoxUseCaseNaam.Text;
            useCaseSamenvatting = textBoxUseCaseSamenvatting.Text;
            useCaseActoren = textBoxUseCaseActoren.Text;
            useCaseAannames = textBoxUseCaseAannames.Text;
            useCaseBeschrijving = textBoxUseCaseBeschrijving.Text;
            useCaseUitzonderingen = textBoxUseCaseUitzonderingen.Text;
            useCaseResultaat = textBoxUseCaseResultaat.Text;

            this.Close();
        }
    }
}
