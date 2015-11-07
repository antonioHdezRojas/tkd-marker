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
    public partial class frmDescanso : Form
    {
        public frmDescanso()
        {
            InitializeComponent();
        }
        public int _tiempo;
        int t;
        private void tmrDescanso_Tick(object sender, EventArgs e)
        {
            t -= 1;
            int min, seg;
            if ((t / 3) > 60)
            {
                min = 3;
                seg = 0;
            }
            else if ((t / 2) >= 60)
            {
                min = 2;
                seg = t - 120;
            }
            else if (t >= 60)
            {
                min = 1;
                seg = t - 60;
            }
            else
            {
                min = 0;
                seg = t;
            }
            txtCronometro.Text = min.ToString() + ":";
            if (seg > 9)
                txtCronometro.Text += seg;
            else
                txtCronometro.Text += "0" + seg;
            if (min == 0 && seg == 0)
            {
                tmrDescanso.Stop();
                Close();
            }
        }

        private void frmDescanso_Load(object sender, EventArgs e)
        {
            t = _tiempo;
            int min = _tiempo / 60;
            int seg = _tiempo - (min * 60);
            txtCronometro.Text = min.ToString() + ":" + seg.ToString();
            tmrDescanso.Enabled = true;
        }
    }
}
