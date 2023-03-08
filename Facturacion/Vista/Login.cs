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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
          if (tbusuario.Text == string.Empty)
            {
                // Se agrega al formulario errorProvider
                errorProvider1.SetError(tbusuario, "Ingrese un usuario");
                //Devuelve a la casilla que tiene error
                tbusuario.Focus();
                return;
            }

            errorProvider1.Clear();


            // (tbcontra.Text == "") 
            if (string.IsNullOrEmpty(tbcontra.Text))
            {
                errorProvider1.SetError(tbcontra, "Ingrese la contrasena");
                //contra incorrecta
                tbcontra.Clear();
                tbcontra.Focus();
                return;
            }
            errorProvider1.Clear();

        }
    }
}
