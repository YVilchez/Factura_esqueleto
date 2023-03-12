
namespace Vista
{
    partial class UsuarioFrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioFrom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontra = new System.Windows.Forms.TextBox();
            this.btaceptar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena: ";
            // 
            // tbusuario
            // 
            this.tbusuario.Location = new System.Drawing.Point(342, 9);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(302, 30);
            this.tbusuario.TabIndex = 2;
            // 
            // tbcontra
            // 
            this.tbcontra.Location = new System.Drawing.Point(342, 95);
            this.tbcontra.Name = "tbcontra";
            this.tbcontra.PasswordChar = '*';
            this.tbcontra.Size = new System.Drawing.Size(302, 30);
            this.tbcontra.TabIndex = 3;
            // 
            // btaceptar
            // 
            this.btaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btaceptar.Image")));
            this.btaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaceptar.Location = new System.Drawing.Point(342, 162);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(117, 49);
            this.btaceptar.TabIndex = 4;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaceptar.UseVisualStyleBackColor = true;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btcancelar.Image")));
            this.btcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcancelar.Location = new System.Drawing.Point(513, 162);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(131, 49);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 139);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btver
            // 
            this.btver.Image = ((System.Drawing.Image)(resources.GetObject("btver.Image")));
            this.btver.Location = new System.Drawing.Point(650, 95);
            this.btver.Name = "btver";
            this.btver.Size = new System.Drawing.Size(30, 30);
            this.btver.TabIndex = 7;
            this.btver.UseVisualStyleBackColor = true;
            this.btver.Click += new System.EventHandler(this.btver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Usuarios
            // 
            this.AcceptButton = this.btaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btcancelar;
            this.ClientSize = new System.Drawing.Size(725, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.tbcontra);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbcontra;
        private System.Windows.Forms.Button btaceptar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

