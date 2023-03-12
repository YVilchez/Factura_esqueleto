using Biblio_Datos;
using Biblio_Entidades;
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
    public partial class UsuarioFrom : Form
    {
        public UsuarioFrom()
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
                errorProvider1.SetError(tbcontra,"Ingrese la contrasena");
                //contra incorrecta
                tbcontra.Clear();
                tbcontra.Focus();
                return;
            }
            errorProvider1.Clear();

            //Validad en BDD que el usuario y la contra sean existentes
            //=======================================================

            Login login = new Login(tbusuario.Text, tbcontra.Text);
            Usuario usuario = new Usuario();
            UsuarioBDD usuarioBDD = new UsuarioBDD();


            //MOSTRAR MENU, se instanca un objeto
            menu menuFormulario = new menu();
            //
            this.Hide();
            menuFormulario.Show();


        }
        // ver contra
        private void btver_Click(object sender, EventArgs e)
        {
            if (tbcontra.PasswordChar == '*')
            {
                tbcontra.PasswordChar = '\0';
            }
            else
            {
                tbcontra.PasswordChar = '*';
            }

        }
    }
}
