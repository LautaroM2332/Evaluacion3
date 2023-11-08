using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana
{
    public partial class Ventanas : Form
    {
        public bool unicoPago;
        public bool tresCu;
        public bool seisCu;
        public Ventanas()
        {
            InitializeComponent();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Close();   
        }

        public void rbt3Cu_CheckedChanged(object sender, EventArgs e)
        {
            tresCu = rbt3Cu.Checked = true;
        }

        public void rbtUnico_CheckedChanged(object sender, EventArgs e)
        {
            unicoPago = rbtUnico.Checked = true;
        }

        public void rbt6Cu_CheckedChanged(object sender, EventArgs e)
        {
            seisCu = rbt6Cu.Checked = true;
        }

        private void Ventanas_Load(object sender, EventArgs e)
        {

        }
    }
}
