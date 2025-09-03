using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendezRegistroCompras
{
    public partial class frmRegistroCompras : Form
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
        }

        DateTime vFecha;
        string vProducto;
        int vCantidad;
        int vPrecioUnitario;

        private void lblIngreso_Click(object sender, EventArgs e)
        {
           
                
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            vFecha = dateTimePicker1.Value;
            vProducto = lstProducto.Text;
            vCantidad = Convert.ToInt32(txtCantidad.Text);
            vPrecioUnitario = Convert.ToInt32(txtPrecio.Text);

            lblResultado.Text =
                vFecha.ToString() + " - " +
                vProducto.ToString() + " - " +
                vCantidad.ToString() + " - " +
                vPrecioUnitario.ToString();
                
                
            MessageBox.Show("Datos Enviados Correctamente");
        }

        private void frmRegistroCompras_Load(object sender, EventArgs e)
        {

        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = false;
            }
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Value > 0)
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                txtPrecio.Enabled= false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                btnEnviar.Enabled = true;
            }
            else
            {
                btnEnviar.Enabled = false;
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
