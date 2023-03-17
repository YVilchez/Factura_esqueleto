using Biblio_Datos;
using Biblio_Entidades;
using System;
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
                
                tbcontra.Focus();
                return;
            }
            errorProvider1.Clear();

            //Valida en BDD que el usuario y la contra sean existentes
            //=======================================================

            Login login = new Login(tbusuario.Text, tbcontra.Text);
            Usuario usuario = new Usuario();
            UsuarioBDD usuarioBDD = new UsuarioBDD();

            usuario = usuarioBDD.Autenticar(login);

            if (usuario != null)
            {
                if (usuario.EstadoActivo)
                {
                    //Mostrar menu
                    //MOSTRAR MENU, se instanca un objeto
                  menufrom menuFormulario = new menufrom();
                 
                 Hide();
                 menuFormulario.Show();
                 }
                else
                {
                    MessageBox.Show("ERROR", "El Usuario NO esta Activo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

            else
            {
                MessageBox.Show("ERROR", "Datos de Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
