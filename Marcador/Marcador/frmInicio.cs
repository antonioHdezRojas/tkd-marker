using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                                 
            frmCombate frmC = new frmCombate();
            //r.ajustarResolucion(frmC)
            frmC._noRounds = updwRouds.Text;
            int t = (int.Parse(updwMin.Text)*60) + int.Parse(updwSeg.Text);                       
            frmC._tiempoRound = t.ToString();
            frmC.Scale(1.3f, 1.6f);
            frmC.Show();            
            t = (int.Parse(updwMinD.Text) * 60) + int.Parse(updwSegD.Text);
            frmC._tiempoD = t;
        }

        private void updwMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            updwMin.Text = "2";
            updwSeg.Text = "30";
            updwRouds.Text = "2";
            updwMinD.Text = "1";
            updwSegD.Text = "00";
        }
    }
}
