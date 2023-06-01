namespace Pry_EstructuraDeDatos
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.gboLisGri = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.gboEliminado = new System.Windows.Forms.GroupBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEl = new System.Windows.Forms.Label();
            this.gboNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramAg = new System.Windows.Forms.Label();
            this.lblNomAg = new System.Windows.Forms.Label();
            this.lblCodAg = new System.Windows.Forms.Label();
            this.imgRepresentacionCola = new System.Windows.Forms.PictureBox();
            this.gboLisGri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gboEliminado.SuspendLayout();
            this.gboNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRepresentacionCola)).BeginInit();
            this.SuspendLayout();
            // 
            // gboLisGri
            // 
            this.gboLisGri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboLisGri.Controls.Add(this.dgvLista);
            this.gboLisGri.Controls.Add(this.lstLista);
            this.gboLisGri.Location = new System.Drawing.Point(12, 248);
            this.gboLisGri.Name = "gboLisGri";
            this.gboLisGri.Size = new System.Drawing.Size(776, 272);
            this.gboLisGri.TabIndex = 5;
            this.gboLisGri.TabStop = false;
            this.gboLisGri.Text = "Listado en una lista y en una grilla";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLista.Location = new System.Drawing.Point(284, 29);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(474, 212);
            this.dgvLista.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lstLista
            // 
            this.lstLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(20, 29);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(234, 212);
            this.lstLista.TabIndex = 3;
            // 
            // gboEliminado
            // 
            this.gboEliminado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboEliminado.Controls.Add(this.cboCodigo);
            this.gboEliminado.Controls.Add(this.btnEliminar);
            this.gboEliminado.Controls.Add(this.lblCodigoEl);
            this.gboEliminado.Location = new System.Drawing.Point(554, 17);
            this.gboEliminado.Name = "gboEliminado";
            this.gboEliminado.Size = new System.Drawing.Size(234, 216);
            this.gboEliminado.TabIndex = 6;
            this.gboEliminado.TabStop = false;
            this.gboEliminado.Text = "Elemento eliminado";
            // 
            // cboCodigo
            // 
            this.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(73, 26);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(138, 21);
            this.cboCodigo.TabIndex = 15;
            this.cboCodigo.SelectedIndexChanged += new System.EventHandler(this.cboCodigo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(53, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 41);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoEl
            // 
            this.lblCodigoEl.AutoSize = true;
            this.lblCodigoEl.Location = new System.Drawing.Point(30, 29);
            this.lblCodigoEl.Name = "lblCodigoEl";
            this.lblCodigoEl.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEl.TabIndex = 14;
            this.lblCodigoEl.Text = "Código";
            // 
            // gboNuevo
            // 
            this.gboNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboNuevo.Controls.Add(this.txtTramite);
            this.gboNuevo.Controls.Add(this.txtNombre);
            this.gboNuevo.Controls.Add(this.txtCodigo);
            this.gboNuevo.Controls.Add(this.btnAgregar);
            this.gboNuevo.Controls.Add(this.lblTramAg);
            this.gboNuevo.Controls.Add(this.lblNomAg);
            this.gboNuevo.Controls.Add(this.lblCodAg);
            this.gboNuevo.Location = new System.Drawing.Point(283, 17);
            this.gboNuevo.Name = "gboNuevo";
            this.gboNuevo.Size = new System.Drawing.Size(234, 216);
            this.gboNuevo.TabIndex = 4;
            this.gboNuevo.TabStop = false;
            this.gboNuevo.Text = "Nuevo elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(70, 119);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 11;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(70, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(51, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 41);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramAg
            // 
            this.lblTramAg.AutoSize = true;
            this.lblTramAg.Location = new System.Drawing.Point(19, 122);
            this.lblTramAg.Name = "lblTramAg";
            this.lblTramAg.Size = new System.Drawing.Size(42, 13);
            this.lblTramAg.TabIndex = 7;
            this.lblTramAg.Text = "Trámite";
            // 
            // lblNomAg
            // 
            this.lblNomAg.AutoSize = true;
            this.lblNomAg.Location = new System.Drawing.Point(19, 75);
            this.lblNomAg.Name = "lblNomAg";
            this.lblNomAg.Size = new System.Drawing.Size(44, 13);
            this.lblNomAg.TabIndex = 6;
            this.lblNomAg.Text = "Nombre";
            // 
            // lblCodAg
            // 
            this.lblCodAg.AutoSize = true;
            this.lblCodAg.Location = new System.Drawing.Point(19, 30);
            this.lblCodAg.Name = "lblCodAg";
            this.lblCodAg.Size = new System.Drawing.Size(40, 13);
            this.lblCodAg.TabIndex = 5;
            this.lblCodAg.Text = "Código";
            // 
            // imgRepresentacionCola
            // 
            this.imgRepresentacionCola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgRepresentacionCola.Image = ((System.Drawing.Image)(resources.GetObject("imgRepresentacionCola.Image")));
            this.imgRepresentacionCola.Location = new System.Drawing.Point(12, 17);
            this.imgRepresentacionCola.Name = "imgRepresentacionCola";
            this.imgRepresentacionCola.Size = new System.Drawing.Size(254, 216);
            this.imgRepresentacionCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRepresentacionCola.TabIndex = 3;
            this.imgRepresentacionCola.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.gboLisGri);
            this.Controls.Add(this.gboEliminado);
            this.Controls.Add(this.gboNuevo);
            this.Controls.Add(this.imgRepresentacionCola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.gboLisGri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gboEliminado.ResumeLayout(false);
            this.gboEliminado.PerformLayout();
            this.gboNuevo.ResumeLayout(false);
            this.gboNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRepresentacionCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboLisGri;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox gboEliminado;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEl;
        private System.Windows.Forms.GroupBox gboNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramAg;
        private System.Windows.Forms.Label lblNomAg;
        private System.Windows.Forms.Label lblCodAg;
        private System.Windows.Forms.PictureBox imgRepresentacionCola;
    }
}