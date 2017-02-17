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
    public partial class ActorNaam : Form
    {
        private string actorNaam;

        public string ActorNaamGetter { get { return actorNaam; } }

        public ActorNaam()
        {
            InitializeComponent();
        }

        private void buttonGebruikNaam_Click(object sender, EventArgs e)
        {
            actorNaam = textBoxActorNaam.Text;
            this.Close();
        }
    }
}
