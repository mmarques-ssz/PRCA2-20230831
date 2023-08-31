using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projPOOWF
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            Soma s = new Soma();
            s.setN1(int.Parse(txtNum1.Text));
            s.setN2(int.Parse(txtNum2.Text));
            s.calcular();
            lblResultado.Text = s.getResultado().ToString();
            txtResultado.Text = s.getResultado().ToString();
        }
    }
}
