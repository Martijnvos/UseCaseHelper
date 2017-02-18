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
    public partial class SysteemNaam : Form
    {
        Systembox systemBox;

        public SysteemNaam(Systembox systemBox)
        {
            InitializeComponent();
            this.systemBox = systemBox;
        }

        private void buttonGebruikNaam_Click(object sender, EventArgs e)
        {
            systemBox.SysteemNaamGetterSetter = textBoxSysteemnaam.Text;
            this.Close();
        }
    }
}
