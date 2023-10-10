using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        int precio;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                   ctrl.Text = string.Empty;
                }
                else if(ctrl is RadioButton)
                {
                    (((RadioButton)ctrl).Checked) = false;

                }

            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            while (rbtEfectivo.Checked == false && rbtTarjeta.Checked == false)
            {
                MessageBox.Show("Por Favor, seleccione la forma de pago");
                return;
                
            }

            if (rbtEfectivo.Checked == true)
            {
                int descuento;
                int precio1 = int.Parse(txtPrecio.Text);
                descuento = precio1 * 15 / 100;
                precio = precio1 - descuento;
            }
            else if(rbtTarjeta.Checked == true)
            {
                int precio1 = int.Parse(txtPrecio.Text);
                precio = precio1 * 11 / 10;
            }
            lblprecioFinal.Text = precio.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("En efectivo se le realiza un descuento del 15%");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked == true)
            {
                Form2 ventana = new Form2();
                ventana.Visible = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <=255))
            {
                MessageBox.Show("Ingresar Solo Números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFinal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
