using BackEnd;
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
using Ventana;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Calculo calcular = new Calculo();
        Ventanas ven = new Ventanas();
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
                lblCuotas.Visible = false;
                lblprecioFinal.Text = "$0";

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
                calcular.precio = Convert.ToDecimal(txtPrecio.Text);

                lblprecioFinal.Text = calcular.efectivoDes(calcular.descuento, Convert.ToDecimal(calcular.precio)).ToString();
                lblCuotas.Visible = false;
            }
            else if(rbtTarjeta.Checked == true)
            {
                calcular.precio = Convert.ToDecimal(txtPrecio.Text);

                lblprecioFinal.Text = calcular.tarjeta(Convert.ToDecimal(calcular.precio)).ToString();

                if (ven.tresCu)
                {
                    int precioF = Convert.ToInt32(calcular.precio);
                    lblCuotas.Visible = true;
                    lblCuotas.Text = "/ En 3 Cuotas de $" + (precioF / 3).ToString() + " pesos";
                }
                else if (ven.seisCu)
                {
                    int precioF = Convert.ToInt32(calcular.precio);
                    lblCuotas.Visible=true;
                    lblCuotas.Text ="/ En 6 Cuotas de $" + (precioF / 6).ToString() + " pesos";
                }
            }
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("En efectivo se le realiza un descuento del 15%");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked == true)
            {
                ven.Visible = true;
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

        private void lblCuotas_Click(object sender, EventArgs e)
        {
        }
    }
}
