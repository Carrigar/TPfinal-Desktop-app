
namespace presentacion
{
    partial class frmNuevoArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.picboxAgregar = new System.Windows.Forms.PictureBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(34, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(153, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(279, 276);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(180, 60);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(276, 258);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(89, 146);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(153, 20);
            this.txtUrlImg.TabIndex = 7;
            this.txtUrlImg.Leave += new System.EventHandler(this.txtUrlImg_Leave);
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImg.Location = new System.Drawing.Point(12, 149);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(71, 15);
            this.lblUrlImg.TabIndex = 6;
            this.lblUrlImg.Text = "Url Imagen:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(89, 198);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(153, 21);
            this.cbxMarca.TabIndex = 8;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(89, 250);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(153, 21);
            this.cbxCategoria.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(38, 199);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 15);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(279, 235);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(89, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(170, 302);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 15;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // picboxAgregar
            // 
            this.picboxAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picboxAgregar.Location = new System.Drawing.Point(279, 34);
            this.picboxAgregar.Name = "picboxAgregar";
            this.picboxAgregar.Size = new System.Drawing.Size(180, 180);
            this.picboxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAgregar.TabIndex = 16;
            this.picboxAgregar.TabStop = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(248, 145);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(25, 23);
            this.btnAgregarImg.TabIndex = 17;
            this.btnAgregarImg.Text = "+";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // frmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.picboxAgregar);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmNuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.PictureBox picboxAgregar;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}