
namespace presentacion
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.picboxArticulo = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado2 = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblErrorCampo = new System.Windows.Forms.Label();
            this.lblErrorFiltro = new System.Windows.Forms.Label();
            this.lblErrorCriterio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 37);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(545, 473);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // picboxArticulo
            // 
            this.picboxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxArticulo.Location = new System.Drawing.Point(570, 37);
            this.picboxArticulo.Name = "picboxArticulo";
            this.picboxArticulo.Size = new System.Drawing.Size(200, 200);
            this.picboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxArticulo.TabIndex = 1;
            this.picboxArticulo.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescripcion.Location = new System.Drawing.Point(570, 308);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(200, 79);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(570, 259);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(106, 27);
            this.txtPrecio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregar.Location = new System.Drawing.Point(12, 516);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 516);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(9, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(88, 16);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(103, 8);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(170, 20);
            this.txtFiltro.TabIndex = 10;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(566, 404);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(97, 23);
            this.lblFiltroAvanzado.TabIndex = 11;
            this.lblFiltroAvanzado.Text = "Filtar por:";
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(567, 432);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(55, 16);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(569, 462);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(53, 16);
            this.lblCriterio.TabIndex = 13;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado2
            // 
            this.lblFiltroAvanzado2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroAvanzado2.AutoSize = true;
            this.lblFiltroAvanzado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado2.Location = new System.Drawing.Point(579, 492);
            this.lblFiltroAvanzado2.Name = "lblFiltroAvanzado2";
            this.lblFiltroAvanzado2.Size = new System.Drawing.Size(40, 16);
            this.lblFiltroAvanzado2.TabIndex = 14;
            this.lblFiltroAvanzado2.Text = "Filtro:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(623, 430);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(133, 21);
            this.cbxCampo.TabIndex = 15;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(623, 460);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(133, 21);
            this.cbxCriterio.TabIndex = 16;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(623, 490);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(133, 20);
            this.txtFiltroAvanzado.TabIndex = 17;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Location = new System.Drawing.Point(656, 516);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 28);
            this.btnFiltro.TabIndex = 18;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblErrorCampo
            // 
            this.lblErrorCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCampo.AutoSize = true;
            this.lblErrorCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCampo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampo.Location = new System.Drawing.Point(757, 430);
            this.lblErrorCampo.Name = "lblErrorCampo";
            this.lblErrorCampo.Size = new System.Drawing.Size(16, 20);
            this.lblErrorCampo.TabIndex = 19;
            this.lblErrorCampo.Text = "*";
            this.lblErrorCampo.Visible = false;
            // 
            // lblErrorFiltro
            // 
            this.lblErrorFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFiltro.AutoSize = true;
            this.lblErrorFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFiltro.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFiltro.Location = new System.Drawing.Point(757, 489);
            this.lblErrorFiltro.Name = "lblErrorFiltro";
            this.lblErrorFiltro.Size = new System.Drawing.Size(16, 20);
            this.lblErrorFiltro.TabIndex = 20;
            this.lblErrorFiltro.Text = "*";
            this.lblErrorFiltro.Visible = false;
            // 
            // lblErrorCriterio
            // 
            this.lblErrorCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCriterio.AutoSize = true;
            this.lblErrorCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCriterio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCriterio.Location = new System.Drawing.Point(757, 460);
            this.lblErrorCriterio.Name = "lblErrorCriterio";
            this.lblErrorCriterio.Size = new System.Drawing.Size(16, 20);
            this.lblErrorCriterio.TabIndex = 21;
            this.lblErrorCriterio.Text = "*";
            this.lblErrorCriterio.Visible = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 553);
            this.Controls.Add(this.lblErrorCriterio);
            this.Controls.Add(this.lblErrorFiltro);
            this.Controls.Add(this.lblErrorCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblFiltroAvanzado2);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.picboxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Artículos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox picboxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado2;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblErrorCampo;
        private System.Windows.Forms.Label lblErrorFiltro;
        private System.Windows.Forms.Label lblErrorCriterio;
    }
}

