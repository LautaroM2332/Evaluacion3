namespace Ventana
{
    partial class Ventanas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListo = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.rbtUnico = new System.Windows.Forms.RadioButton();
            this.rbt3Cu = new System.Windows.Forms.RadioButton();
            this.rbt6Cu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Location = new System.Drawing.Point(10, 221);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(93, 30);
            this.btnListo.TabIndex = 0;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(8, 23);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(285, 20);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "Seleccione la Cantidad de Cuotas:";
            // 
            // rbtUnico
            // 
            this.rbtUnico.AutoSize = true;
            this.rbtUnico.BackColor = System.Drawing.Color.Transparent;
            this.rbtUnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUnico.Location = new System.Drawing.Point(13, 67);
            this.rbtUnico.Name = "rbtUnico";
            this.rbtUnico.Size = new System.Drawing.Size(109, 24);
            this.rbtUnico.TabIndex = 2;
            this.rbtUnico.TabStop = true;
            this.rbtUnico.Text = "Unico Pago";
            this.rbtUnico.UseVisualStyleBackColor = false;
            this.rbtUnico.CheckedChanged += new System.EventHandler(this.rbtUnico_CheckedChanged);
            // 
            // rbt3Cu
            // 
            this.rbt3Cu.AutoSize = true;
            this.rbt3Cu.BackColor = System.Drawing.Color.Transparent;
            this.rbt3Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3Cu.Location = new System.Drawing.Point(12, 115);
            this.rbt3Cu.Name = "rbt3Cu";
            this.rbt3Cu.Size = new System.Drawing.Size(91, 24);
            this.rbt3Cu.TabIndex = 3;
            this.rbt3Cu.TabStop = true;
            this.rbt3Cu.Text = "3 Cuotas";
            this.rbt3Cu.UseVisualStyleBackColor = false;
            this.rbt3Cu.CheckedChanged += new System.EventHandler(this.rbt3Cu_CheckedChanged);
            // 
            // rbt6Cu
            // 
            this.rbt6Cu.AutoSize = true;
            this.rbt6Cu.BackColor = System.Drawing.Color.Transparent;
            this.rbt6Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt6Cu.Location = new System.Drawing.Point(13, 167);
            this.rbt6Cu.Name = "rbt6Cu";
            this.rbt6Cu.Size = new System.Drawing.Size(91, 24);
            this.rbt6Cu.TabIndex = 4;
            this.rbt6Cu.TabStop = true;
            this.rbt6Cu.Text = "6 Cuotas";
            this.rbt6Cu.UseVisualStyleBackColor = false;
            this.rbt6Cu.CheckedChanged += new System.EventHandler(this.rbt6Cu_CheckedChanged);
            // 
            // Ventanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ventana.Properties.Resources.photo_1615715874994_bb83092ef331;
            this.ClientSize = new System.Drawing.Size(318, 269);
            this.Controls.Add(this.rbt6Cu);
            this.Controls.Add(this.rbt3Cu);
            this.Controls.Add(this.rbtUnico);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnListo);
            this.Name = "Ventanas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventanas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.RadioButton rbtUnico;
        private System.Windows.Forms.RadioButton rbt3Cu;
        private System.Windows.Forms.RadioButton rbt6Cu;
    }
}

