namespace prySilvaMenendezRegistroCompras
{
    partial class frmRegistroCompras
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblIngresoo = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(210, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(112, 13);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido Al Sistema";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // lblIngresoo
            // 
            this.lblIngresoo.AutoSize = true;
            this.lblIngresoo.Location = new System.Drawing.Point(185, 36);
            this.lblIngresoo.Name = "lblIngresoo";
            this.lblIngresoo.Size = new System.Drawing.Size(158, 13);
            this.lblIngresoo.TabIndex = 2;
            this.lblIngresoo.Text = "Ingrese Los Datos de la Compra";
            this.lblIngresoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(179, 112);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(81, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(179, 156);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(179, 201);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(81, 20);
            this.txtPrecioU.TabIndex = 5;
            // 
            // frmRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblIngresoo);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmRegistroCompras";
            this.Text = "Registro de Compras Tienda 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblIngresoo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioU;
    }
}

