
namespace Vista
{
    partial class PRODUCTOS
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
            this.tbcodigopro = new System.Windows.Forms.TextBox();
            this.tbdescrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbexisten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpre = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.Label();
            this.pbprod = new System.Windows.Forms.PictureBox();
            this.btfotopro = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.dgproductos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tbcodigopro
            // 
            this.tbcodigopro.Enabled = false;
            this.tbcodigopro.Location = new System.Drawing.Point(233, 58);
            this.tbcodigopro.Name = "tbcodigopro";
            this.tbcodigopro.Size = new System.Drawing.Size(274, 26);
            this.tbcodigopro.TabIndex = 1;
            // 
            // tbdescrip
            // 
            this.tbdescrip.Enabled = false;
            this.tbdescrip.Location = new System.Drawing.Point(233, 123);
            this.tbdescrip.Name = "tbdescrip";
            this.tbdescrip.Size = new System.Drawing.Size(274, 26);
            this.tbdescrip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tbexisten
            // 
            this.tbexisten.Enabled = false;
            this.tbexisten.Location = new System.Drawing.Point(233, 188);
            this.tbexisten.Name = "tbexisten";
            this.tbexisten.Size = new System.Drawing.Size(274, 26);
            this.tbexisten.TabIndex = 5;
            this.tbexisten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbexisten_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia";
            // 
            // tbpre
            // 
            this.tbpre.Enabled = false;
            this.tbpre.Location = new System.Drawing.Point(233, 262);
            this.tbpre.Name = "tbpre";
            this.tbpre.Size = new System.Drawing.Size(274, 26);
            this.tbpre.TabIndex = 7;
            this.tbpre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpre_KeyPress);
            // 
            // tbprecio
            // 
            this.tbprecio.AutoSize = true;
            this.tbprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprecio.Location = new System.Drawing.Point(67, 263);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(67, 25);
            this.tbprecio.TabIndex = 6;
            this.tbprecio.Text = "Precio";
            // 
            // pbprod
            // 
            this.pbprod.BackColor = System.Drawing.Color.White;
            this.pbprod.Location = new System.Drawing.Point(576, 58);
            this.pbprod.Name = "pbprod";
            this.pbprod.Size = new System.Drawing.Size(230, 230);
            this.pbprod.TabIndex = 8;
            this.pbprod.TabStop = false;
            // 
            // btfotopro
            // 
            this.btfotopro.Enabled = false;
            this.btfotopro.Location = new System.Drawing.Point(605, 307);
            this.btfotopro.Name = "btfotopro";
            this.btfotopro.Size = new System.Drawing.Size(142, 34);
            this.btfotopro.TabIndex = 9;
            this.btfotopro.Text = "Foto Producto";
            this.btfotopro.UseVisualStyleBackColor = true;
            // 
            // btcancelar
            // 
            this.btcancelar.Enabled = false;
            this.btcancelar.Location = new System.Drawing.Point(654, 393);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(138, 53);
            this.btcancelar.TabIndex = 24;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btteliminar
            // 
            this.btteliminar.Enabled = false;
            this.btteliminar.Location = new System.Drawing.Point(499, 393);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(138, 53);
            this.btteliminar.TabIndex = 23;
            this.btteliminar.Text = "ELIMINAR";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // btmodificar
            // 
            this.btmodificar.Enabled = false;
            this.btmodificar.Location = new System.Drawing.Point(205, 393);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(138, 53);
            this.btmodificar.TabIndex = 22;
            this.btmodificar.Text = "MODIFICAR";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(365, 393);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(119, 53);
            this.btguardar.TabIndex = 21;
            this.btguardar.Text = "GUARDAR";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(72, 393);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(119, 53);
            this.btnuevo.TabIndex = 20;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // dgproductos
            // 
            this.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproductos.Location = new System.Drawing.Point(7, 500);
            this.dgproductos.Name = "dgproductos";
            this.dgproductos.RowHeadersWidth = 62;
            this.dgproductos.RowTemplate.Height = 28;
            this.dgproductos.Size = new System.Drawing.Size(865, 150);
            this.dgproductos.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 655);
            this.Controls.Add(this.dgproductos);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btteliminar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btfotopro);
            this.Controls.Add(this.pbprod);
            this.Controls.Add(this.tbpre);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.tbexisten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbdescrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcodigopro);
            this.Controls.Add(this.label1);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.pbprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcodigopro;
        private System.Windows.Forms.TextBox tbdescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbexisten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbpre;
        private System.Windows.Forms.Label tbprecio;
        private System.Windows.Forms.PictureBox pbprod;
        private System.Windows.Forms.Button btfotopro;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btteliminar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.DataGridView dgproductos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}