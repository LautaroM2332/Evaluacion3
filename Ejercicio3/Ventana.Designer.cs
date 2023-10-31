namespace Ejercicio3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtUnicopago = new System.Windows.Forms.RadioButton();
            this.rbt3cuotas = new System.Windows.Forms.RadioButton();
            this.rbt6cuotas = new System.Windows.Forms.RadioButton();
            this.btListo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seleccione la Cantidad de Cuotas:\r\n";
            // 
            // rbtUnicopago
            // 
            this.rbtUnicopago.AutoSize = true;
            this.rbtUnicopago.BackColor = System.Drawing.Color.Transparent;
            this.rbtUnicopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUnicopago.Location = new System.Drawing.Point(5, 42);
            this.rbtUnicopago.Name = "rbtUnicopago";
            this.rbtUnicopago.Size = new System.Drawing.Size(104, 22);
            this.rbtUnicopago.TabIndex = 1;
            this.rbtUnicopago.TabStop = true;
            this.rbtUnicopago.Text = "Único Pago";
            this.rbtUnicopago.UseVisualStyleBackColor = false;
            this.rbtUnicopago.CheckedChanged += new System.EventHandler(this.rbtUnicopago_CheckedChanged);
            // 
            // rbt3cuotas
            // 
            this.rbt3cuotas.AutoSize = true;
            this.rbt3cuotas.BackColor = System.Drawing.Color.Transparent;
            this.rbt3cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3cuotas.Location = new System.Drawing.Point(5, 70);
            this.rbt3cuotas.Name = "rbt3cuotas";
            this.rbt3cuotas.Size = new System.Drawing.Size(86, 22);
            this.rbt3cuotas.TabIndex = 2;
            this.rbt3cuotas.TabStop = true;
            this.rbt3cuotas.Text = "3 Cuotas";
            this.rbt3cuotas.UseVisualStyleBackColor = false;
            this.rbt3cuotas.CheckedChanged += new System.EventHandler(this.rbt3cuotas_CheckedChanged);
            // 
            // rbt6cuotas
            // 
            this.rbt6cuotas.AutoSize = true;
            this.rbt6cuotas.BackColor = System.Drawing.Color.Transparent;
            this.rbt6cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt6cuotas.Location = new System.Drawing.Point(5, 98);
            this.rbt6cuotas.Name = "rbt6cuotas";
            this.rbt6cuotas.Size = new System.Drawing.Size(86, 22);
            this.rbt6cuotas.TabIndex = 3;
            this.rbt6cuotas.TabStop = true;
            this.rbt6cuotas.Text = "6 Cuotas";
            this.rbt6cuotas.UseVisualStyleBackColor = false;
            this.rbt6cuotas.CheckedChanged += new System.EventHandler(this.rbt6cuotas_CheckedChanged);
            // 
            // btListo
            // 
            this.btListo.BackgroundImage = global::Ejercicio3.Properties.Resources.pngtree_simple_gradient_universal_background_material_image_213211;
            this.btListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListo.Location = new System.Drawing.Point(5, 126);
            this.btListo.Name = "btListo";
            this.btListo.Size = new System.Drawing.Size(86, 29);
            this.btListo.TabIndex = 4;
            this.btListo.Text = "Listo";
            this.btListo.UseVisualStyleBackColor = true;
            this.btListo.Click += new System.EventHandler(this.btListo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio3.Properties.Resources.pngtree_simple_gradient_universal_background_material_image_213211;
            this.ClientSize = new System.Drawing.Size(342, 157);
            this.Controls.Add(this.btListo);
            this.Controls.Add(this.rbt6cuotas);
            this.Controls.Add(this.rbt3cuotas);
            this.Controls.Add(this.rbtUnicopago);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtUnicopago;
        private System.Windows.Forms.RadioButton rbt3cuotas;
        private System.Windows.Forms.RadioButton rbt6cuotas;
        private System.Windows.Forms.Button btListo;
    }
}