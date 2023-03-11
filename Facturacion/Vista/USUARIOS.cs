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
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();
        }

        string tipoOpera;
        private void habilitarControles()
        {
            tbcodigo.Enabled = true;
            tbcontrase.Enabled = true;
            tbcorreo.Enabled = true;
            tbnombre.Enabled = true;
            tbrol.Enabled = true;
            chec.Enabled = true;
            btfoto.Enabled = true;
            btguardar.Enabled = true;
            btcancelar.Enabled = true;
        }

        private void deshabilitarControles()
        {
            tbcodigo.Enabled = false;
            tbcontrase.Enabled = false;
            tbcorreo.Enabled = false;
            tbnombre.Enabled = false;
            tbrol.Enabled = false;
            chec.Enabled = false;
            btfoto.Enabled = false;
            btguardar.Enabled = false;
            btcancelar.Enabled = false;
        }

        private void LimpiarControles()
        {
            tbcodigo.Clear();
            tbcontrase.Clear();
            tbcorreo.Clear();
            tbnombre.Clear();
            tbrol.Text = "";
            chec.Checked = false;
            pbfoto.Image = null;


        }


        private void btnuevo_Click(object sender, EventArgs e)
        {
            tbcodigo.Focus();
            habilitarControles();
            tipoOpera = "Nuevo";

        }


        private void btcancelar_Click(object sender, EventArgs e)
        {
            deshabilitarControles();
            LimpiarControles();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (tipoOpera == "Nuevo")
            {
                if (string.IsNullOrEmpty(tbcodigo.Text))
                {
                    errorProvider1.SetError(tbcodigo, "Ingrese un codigo");
                    tbcodigo.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(tbnombre.Text))
                {
                    errorProvider1.SetError(tbnombre, "Ingrese un nombre");
                    tbnombre.Focus();
                    return;
                }
                errorProvider1.Clear();


                if (string.IsNullOrEmpty(tbcontrase.Text))
                {
                    errorProvider1.SetError(tbcontrase, "ïngrese una contrase");
                    tbcontrase.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(tbrol.Text))
                {
                    errorProvider1.SetError(tbrol, "ïngrese un rol");
                    tbrol.Focus();
                    return;
                }
                errorProvider1.Clear();


                //llamar a clase usuario datos
                Usuario user = new Usuario();

                user.codigoUsuario = tbcodigo.Text;
                user.Nombre = tbnombre.Text;
                user.Contra = tbcontrase.Text;
                user.Correo = tbcorreo.Text;
                user.Rol = tbrol.Text;
                user.EstadoActivo = chec.Checked;

                //Validar que contenga la fotografia 
                if (pbfoto.Image != null)
                {
                    //Foto es ARREGLO DE BITS
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    //pasar pic box
                    pbfoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //pasar direcccion a use foto
                    user.Foto = ms.GetBuffer();

                }

                //Insertar BDD
            }


            else if (tipoOpera == "Modificar")
            {

            }
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            tipoOpera = "Modificar";
        }

        private void btfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                pbfoto.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void btteliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
