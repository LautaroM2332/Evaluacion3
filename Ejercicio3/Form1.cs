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
        Ventanas ven = new Ventanas();
        Productos produc { get; set; } = new Productos();
        public Form1()
        {
            InitializeComponent();
            dg.DataSource = produc.ListaPro;
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
            
            int suma = 0;
            if(dg.Rows.Count > 0)
            {
                foreach(DataGridViewRow Row in dg.Rows)
                {
                    suma += Convert.ToInt32(Row.Cells[1].Value);
                    lblprecioFinal.Text = "$" + Convert.ToString(suma);
                }
            }

            if (ven.tresCu)
            {
                lblprecioFinal.Text = "$" + suma;
                lblCuotas.Text = "/ En 3 cuotas de $" + (suma / 3);
            }
            else if (ven.seisCu)
            {
                lblprecioFinal.Text = "$" + suma;
                lblCuotas.Text = "/ En 6 cuotas de $" + (suma / 6);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("En efectivo se le realiza un descuento del 5%", "DE$CUENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked == true)
            {
                ven.ShowDialog();
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

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarCa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Agregado");
            Agregar agregar = new Agregar();

            agregar.AgregarPro(produc.ListaPro.Rows.Count+1, txtProducto.Text, txtPrecio.Text);
            produc.adicionar(agregar);
            txtCodigo.Text = agregar.codigo.ToString();

            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dg.Rows.Remove(dg.CurrentRow);
        }
    }
}
