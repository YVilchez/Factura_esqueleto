using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class PRODUCTOS : Form
    {

        public PRODUCTOS()
        {
            InitializeComponent();
        }

        string operacion;
        private void btnuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            habilitarControles();
        }

        private void habilitarControles()
        {
            tbcodigopro.Enabled = true;
            tbdescrip.Enabled = true;
            tbexisten.Enabled = true;
            tbpre.Enabled = true;
            pbprod.Enabled = true;
            btguardar.Enabled = true;
            btcancelar.Enabled = true;
            btnuevo.Enabled = false;
        }

        private void deshabilitarControles()
        {
            tbcodigopro.Enabled = false;
            tbdescrip.Enabled = false;
            tbexisten.Enabled = false;
            tbpre.Enabled = false;
            pbprod.Enabled = false;
            btguardar.Enabled = false;
            btcancelar.Enabled = false;
            btnuevo.Enabled = true;
        }

        private void LimpiarControles()
        {
            tbcodigopro.Clear();
            tbdescrip.Clear();
            tbexisten.Clear();
            tbpre.Clear();
            pbprod.Image = null;

        }



        private void btcancelar_Click(object sender, EventArgs e)
        {
            deshabilitarControles();
            LimpiarControles();
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(tbcodigopro.Text))
                {
                    errorProvider1.SetError(tbcodigopro, "Ingrese un codigo");
                    tbcodigopro.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(tbdescrip.Text))
                {
                    errorProvider1.SetError(tbdescrip, "Ingrese una descripcion");
                    tbdescrip.Focus();
                    return;
                }
                errorProvider1.Clear();


                if (string.IsNullOrEmpty(tbexisten.Text))
                {
                    errorProvider1.SetError(tbexisten, "ïngrese la existencia");
                    tbexisten.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(tbpre.Text))
                {
                    errorProvider1.SetError(tbpre, "ïngrese el precio");
                    tbpre.Focus();
                    return;
                }
                errorProvider1.Clear();

                }
            }

        private void tbexisten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //digit decimal
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
