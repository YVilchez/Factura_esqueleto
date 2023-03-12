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
    public partial class menufrom : Form
    {
        public menufrom()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void toolusu_Click(object sender, EventArgs e)
        {
            USUARIOS userForm = new USUARIOS();
            //contenedor hijo
            userForm.MdiParent = this;
            userForm.Show();


        }

        private void toolproducto_Click(object sender, EventArgs e)
        {
            PRODUCTOS producForm = new PRODUCTOS();
            producForm.MdiParent = this;
            producForm.Show();

        }

        private void toolclientes_Click(object sender, EventArgs e)
        {
            CLIENTES clientesFrom = new CLIENTES();
            clientesFrom.MdiParent = this;
            clientesFrom.Show();

        }

        private void toolfacturas_Click(object sender, EventArgs e)
        {
            FACTURAS facturasFrom = new FACTURAS();
            facturasFrom.MdiParent = this;
            facturasFrom.Show();
        }
    }
}
