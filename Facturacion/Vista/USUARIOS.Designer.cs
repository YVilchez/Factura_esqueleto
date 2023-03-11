
namespace Vista
{
    partial class USUARIOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbcontrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcorreo = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.tbrol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chec = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.btfoto = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.datausuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datausuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Location = new System.Drawing.Point(168, 42);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(438, 30);
            this.tbcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // tbnombre
            // 
            this.tbnombre.Enabled = false;
            this.tbnombre.Location = new System.Drawing.Point(168, 109);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(438, 30);
            this.tbnombre.TabIndex = 3;
            // 
            // tbcontrase
            // 
            this.tbcontrase.Enabled = false;
            this.tbcontrase.Location = new System.Drawing.Point(168, 171);
            this.tbcontrase.Name = "tbcontrase";
            this.tbcontrase.PasswordChar = '*';
            this.tbcontrase.Size = new System.Drawing.Size(438, 30);
            this.tbcontrase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contrasena";
            // 
            // tbcorreo
            // 
            this.tbcorreo.Enabled = false;
            this.tbcorreo.Location = new System.Drawing.Point(168, 235);
            this.tbcorreo.Name = "tbcorreo";
            this.tbcorreo.Size = new System.Drawing.Size(438, 30);
            this.tbcorreo.TabIndex = 7;
            // 
            // cvv
            // 
            this.cvv.AutoSize = true;
            this.cvv.Location = new System.Drawing.Point(75, 232);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(72, 25);
            this.cvv.TabIndex = 6;
            this.cvv.Text = "Correo";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(107, 299);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(40, 25);
            this.Rol.TabIndex = 8;
            this.Rol.Text = "Rol";
            // 
            // tbrol
            // 
            this.tbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbrol.Enabled = false;
            this.tbrol.FormattingEnabled = true;
            this.tbrol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.tbrol.Location = new System.Drawing.Point(168, 299);
            this.tbrol.Name = "tbrol";
            this.tbrol.Size = new System.Drawing.Size(442, 33);
            this.tbrol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // chec
            // 
            this.chec.AutoSize = true;
            this.chec.Enabled = false;
            this.chec.Location = new System.Drawing.Point(168, 382);
            this.chec.Name = "chec";
            this.chec.Size = new System.Drawing.Size(22, 21);
            this.chec.TabIndex = 11;
            this.chec.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(497, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 12;
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbfoto.Location = new System.Drawing.Point(637, 42);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(207, 290);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 13;
            this.pbfoto.TabStop = false;
            // 
            // btfoto
            // 
            this.btfoto.Enabled = false;
            this.btfoto.Location = new System.Drawing.Point(674, 359);
            this.btfoto.Name = "btfoto";
            this.btfoto.Size = new System.Drawing.Size(131, 44);
            this.btfoto.TabIndex = 14;
            this.btfoto.Text = "Foto";
            this.btfoto.UseVisualStyleBackColor = true;
            this.btfoto.Click += new System.EventHandler(this.btfoto_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(80, 439);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(119, 53);
            this.btnuevo.TabIndex = 15;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(378, 439);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(119, 53);
            this.btguardar.TabIndex = 16;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.Enabled = false;
            this.btmodificar.Location = new System.Drawing.Point(218, 439);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(138, 53);
            this.btmodificar.TabIndex = 17;
            this.btmodificar.Text = "MODIFICAR";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // btteliminar
            // 
            this.btteliminar.Enabled = false;
            this.btteliminar.Location = new System.Drawing.Point(512, 439);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(138, 53);
            this.btteliminar.TabIndex = 18;
            this.btteliminar.Text = "ELIMINAR";
            this.btteliminar.UseVisualStyleBackColor = true;
            this.btteliminar.Click += new System.EventHandler(this.btteliminar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Enabled = false;
            this.btcancelar.Location = new System.Drawing.Point(667, 439);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(138, 53);
            this.btcancelar.TabIndex = 19;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // datausuarios
            // 
            this.datausuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datausuarios.Location = new System.Drawing.Point(1, 535);
            this.datausuarios.Name = "datausuarios";
            this.datausuarios.RowHeadersWidth = 62;
            this.datausuarios.RowTemplate.Height = 28;
            this.datausuarios.Size = new System.Drawing.Size(869, 118);
            this.datausuarios.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 655);
            this.Controls.Add(this.datausuarios);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btteliminar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btfoto);
            this.Controls.Add(this.pbfoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbrol);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.tbcorreo);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.tbcontrase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datausuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbcontrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcorreo;
        private System.Windows.Forms.Label cvv;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.ComboBox tbrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Button btfoto;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btteliminar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.DataGridView datausuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}