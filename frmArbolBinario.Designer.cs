namespace Pry_EstructuraDeDatos
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.imgArbol = new System.Windows.Forms.PictureBox();
            this.gboNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramAg = new System.Windows.Forms.Label();
            this.lblNomAg = new System.Windows.Forms.Label();
            this.lblCodAg = new System.Windows.Forms.Label();
            this.gboEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodEl = new System.Windows.Forms.Label();
            this.cboEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gboLisGri = new System.Windows.Forms.GroupBox();
            this.tvEquilibrado = new System.Windows.Forms.TreeView();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.gboBuscar = new System.Windows.Forms.GroupBox();
            this.txtBusCodigo = new System.Windows.Forms.TextBox();
            this.lblBusTramite = new System.Windows.Forms.Label();
            this.lblBusNombre = new System.Windows.Forms.Label();
            this.lblTramBus = new System.Windows.Forms.Label();
            this.lblNomBus = new System.Windows.Forms.Label();
            this.lblCodBus = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gboEquilibrar = new System.Windows.Forms.GroupBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.gboTipoListado = new System.Windows.Forms.GroupBox();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgArbol)).BeginInit();
            this.gboNuevo.SuspendLayout();
            this.gboEliminado.SuspendLayout();
            this.gboLisGri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gboBuscar.SuspendLayout();
            this.gboEquilibrar.SuspendLayout();
            this.gboTipoListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgArbol
            // 
            this.imgArbol.Image = ((System.Drawing.Image)(resources.GetObject("imgArbol.Image")));
            this.imgArbol.Location = new System.Drawing.Point(12, 12);
            this.imgArbol.Name = "imgArbol";
            this.imgArbol.Size = new System.Drawing.Size(225, 237);
            this.imgArbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgArbol.TabIndex = 0;
            this.imgArbol.TabStop = false;
            // 
            // gboNuevo
            // 
            this.gboNuevo.Controls.Add(this.txtTramite);
            this.gboNuevo.Controls.Add(this.txtNombre);
            this.gboNuevo.Controls.Add(this.txtCodigo);
            this.gboNuevo.Controls.Add(this.btnAgregar);
            this.gboNuevo.Controls.Add(this.lblTramAg);
            this.gboNuevo.Controls.Add(this.lblNomAg);
            this.gboNuevo.Controls.Add(this.lblCodAg);
            this.gboNuevo.Location = new System.Drawing.Point(243, 12);
            this.gboNuevo.Name = "gboNuevo";
            this.gboNuevo.Size = new System.Drawing.Size(215, 237);
            this.gboNuevo.TabIndex = 1;
            this.gboNuevo.TabStop = false;
            this.gboNuevo.Text = "Nuevo elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 114);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 18;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 41);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramAg
            // 
            this.lblTramAg.AutoSize = true;
            this.lblTramAg.Location = new System.Drawing.Point(16, 117);
            this.lblTramAg.Name = "lblTramAg";
            this.lblTramAg.Size = new System.Drawing.Size(42, 13);
            this.lblTramAg.TabIndex = 15;
            this.lblTramAg.Text = "Trámite";
            // 
            // lblNomAg
            // 
            this.lblNomAg.AutoSize = true;
            this.lblNomAg.Location = new System.Drawing.Point(16, 70);
            this.lblNomAg.Name = "lblNomAg";
            this.lblNomAg.Size = new System.Drawing.Size(44, 13);
            this.lblNomAg.TabIndex = 14;
            this.lblNomAg.Text = "Nombre";
            // 
            // lblCodAg
            // 
            this.lblCodAg.AutoSize = true;
            this.lblCodAg.Location = new System.Drawing.Point(16, 25);
            this.lblCodAg.Name = "lblCodAg";
            this.lblCodAg.Size = new System.Drawing.Size(40, 13);
            this.lblCodAg.TabIndex = 13;
            this.lblCodAg.Text = "Código";
            // 
            // gboEliminado
            // 
            this.gboEliminado.Controls.Add(this.lblCodEl);
            this.gboEliminado.Controls.Add(this.cboEliminar);
            this.gboEliminado.Controls.Add(this.btnEliminar);
            this.gboEliminado.Location = new System.Drawing.Point(478, 12);
            this.gboEliminado.Name = "gboEliminado";
            this.gboEliminado.Size = new System.Drawing.Size(199, 113);
            this.gboEliminado.TabIndex = 7;
            this.gboEliminado.TabStop = false;
            this.gboEliminado.Text = "Elemento eliminado";
            // 
            // lblCodEl
            // 
            this.lblCodEl.AutoSize = true;
            this.lblCodEl.Location = new System.Drawing.Point(25, 25);
            this.lblCodEl.Name = "lblCodEl";
            this.lblCodEl.Size = new System.Drawing.Size(43, 13);
            this.lblCodEl.TabIndex = 15;
            this.lblCodEl.Text = "Código:";
            // 
            // cboEliminar
            // 
            this.cboEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEliminar.FormattingEnabled = true;
            this.cboEliminar.Location = new System.Drawing.Point(74, 22);
            this.cboEliminar.Name = "cboEliminar";
            this.cboEliminar.Size = new System.Drawing.Size(100, 21);
            this.cboEliminar.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 41);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gboLisGri
            // 
            this.gboLisGri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboLisGri.Controls.Add(this.tvEquilibrado);
            this.gboLisGri.Controls.Add(this.dgvGrilla);
            this.gboLisGri.Controls.Add(this.lstLista);
            this.gboLisGri.Location = new System.Drawing.Point(12, 255);
            this.gboLisGri.Name = "gboLisGri";
            this.gboLisGri.Size = new System.Drawing.Size(1075, 314);
            this.gboLisGri.TabIndex = 8;
            this.gboLisGri.TabStop = false;
            this.gboLisGri.Text = "Listado en una lista, en una grilla y en un tree view";
            // 
            // tvEquilibrado
            // 
            this.tvEquilibrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvEquilibrado.Location = new System.Drawing.Point(6, 31);
            this.tvEquilibrado.Name = "tvEquilibrado";
            this.tvEquilibrado.Size = new System.Drawing.Size(300, 263);
            this.tvEquilibrado.TabIndex = 5;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(595, 31);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(455, 263);
            this.dgvGrilla.TabIndex = 4;
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
            this.lstLista.Location = new System.Drawing.Point(312, 31);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(277, 264);
            this.lstLista.TabIndex = 3;
            // 
            // gboBuscar
            // 
            this.gboBuscar.Controls.Add(this.txtBusCodigo);
            this.gboBuscar.Controls.Add(this.lblBusTramite);
            this.gboBuscar.Controls.Add(this.lblBusNombre);
            this.gboBuscar.Controls.Add(this.lblTramBus);
            this.gboBuscar.Controls.Add(this.lblNomBus);
            this.gboBuscar.Controls.Add(this.lblCodBus);
            this.gboBuscar.Controls.Add(this.btnBuscar);
            this.gboBuscar.Location = new System.Drawing.Point(683, 12);
            this.gboBuscar.Name = "gboBuscar";
            this.gboBuscar.Size = new System.Drawing.Size(199, 237);
            this.gboBuscar.TabIndex = 16;
            this.gboBuscar.TabStop = false;
            this.gboBuscar.Text = "Buscar elemento";
            // 
            // txtBusCodigo
            // 
            this.txtBusCodigo.Location = new System.Drawing.Point(74, 22);
            this.txtBusCodigo.Name = "txtBusCodigo";
            this.txtBusCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBusCodigo.TabIndex = 20;
            this.txtBusCodigo.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtBusCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusCodigo_KeyPress);
            // 
            // lblBusTramite
            // 
            this.lblBusTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBusTramite.Location = new System.Drawing.Point(74, 112);
            this.lblBusTramite.Name = "lblBusTramite";
            this.lblBusTramite.Size = new System.Drawing.Size(100, 23);
            this.lblBusTramite.TabIndex = 19;
            this.lblBusTramite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBusNombre
            // 
            this.lblBusNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBusNombre.Location = new System.Drawing.Point(74, 65);
            this.lblBusNombre.Name = "lblBusNombre";
            this.lblBusNombre.Size = new System.Drawing.Size(100, 23);
            this.lblBusNombre.TabIndex = 18;
            this.lblBusNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramBus
            // 
            this.lblTramBus.AutoSize = true;
            this.lblTramBus.Location = new System.Drawing.Point(23, 117);
            this.lblTramBus.Name = "lblTramBus";
            this.lblTramBus.Size = new System.Drawing.Size(45, 13);
            this.lblTramBus.TabIndex = 17;
            this.lblTramBus.Text = "Trámite:";
            // 
            // lblNomBus
            // 
            this.lblNomBus.AutoSize = true;
            this.lblNomBus.Location = new System.Drawing.Point(21, 70);
            this.lblNomBus.Name = "lblNomBus";
            this.lblNomBus.Size = new System.Drawing.Size(47, 13);
            this.lblNomBus.TabIndex = 16;
            this.lblNomBus.Text = "Nombre:";
            // 
            // lblCodBus
            // 
            this.lblCodBus.AutoSize = true;
            this.lblCodBus.Location = new System.Drawing.Point(21, 25);
            this.lblCodBus.Name = "lblCodBus";
            this.lblCodBus.Size = new System.Drawing.Size(43, 13);
            this.lblCodBus.TabIndex = 15;
            this.lblCodBus.Text = "Código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(28, 171);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 41);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gboEquilibrar
            // 
            this.gboEquilibrar.Controls.Add(this.btnEquilibrar);
            this.gboEquilibrar.Location = new System.Drawing.Point(888, 12);
            this.gboEquilibrar.Name = "gboEquilibrar";
            this.gboEquilibrar.Size = new System.Drawing.Size(199, 237);
            this.gboEquilibrar.TabIndex = 17;
            this.gboEquilibrar.TabStop = false;
            this.gboEquilibrar.Text = "Funciones";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(28, 25);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(146, 41);
            this.btnEquilibrar.TabIndex = 13;
            this.btnEquilibrar.Text = "Equilibrar Árbol";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(28, 52);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(146, 41);
            this.btnReporte.TabIndex = 14;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // gboTipoListado
            // 
            this.gboTipoListado.Controls.Add(this.btnReporte);
            this.gboTipoListado.Controls.Add(this.cboOrden);
            this.gboTipoListado.Location = new System.Drawing.Point(478, 131);
            this.gboTipoListado.Name = "gboTipoListado";
            this.gboTipoListado.Size = new System.Drawing.Size(199, 118);
            this.gboTipoListado.TabIndex = 18;
            this.gboTipoListado.TabStop = false;
            this.gboTipoListado.Text = "Tipo de listado";
            // 
            // cboOrden
            // 
            this.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Items.AddRange(new object[] {
            "InOrder-A",
            "InOrder-D",
            "PreOrder",
            "PostOrder"});
            this.cboOrden.Location = new System.Drawing.Point(28, 19);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(146, 21);
            this.cboOrden.TabIndex = 2;
            this.cboOrden.TextChanged += new System.EventHandler(this.cboOrden_TextChanged);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 585);
            this.Controls.Add(this.gboTipoListado);
            this.Controls.Add(this.gboEquilibrar);
            this.Controls.Add(this.gboBuscar);
            this.Controls.Add(this.gboLisGri);
            this.Controls.Add(this.gboEliminado);
            this.Controls.Add(this.gboNuevo);
            this.Controls.Add(this.imgArbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgArbol)).EndInit();
            this.gboNuevo.ResumeLayout(false);
            this.gboNuevo.PerformLayout();
            this.gboEliminado.ResumeLayout(false);
            this.gboEliminado.PerformLayout();
            this.gboLisGri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gboBuscar.ResumeLayout(false);
            this.gboBuscar.PerformLayout();
            this.gboEquilibrar.ResumeLayout(false);
            this.gboTipoListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgArbol;
        private System.Windows.Forms.GroupBox gboNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramAg;
        private System.Windows.Forms.Label lblNomAg;
        private System.Windows.Forms.Label lblCodAg;
        private System.Windows.Forms.GroupBox gboEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gboLisGri;
        private System.Windows.Forms.TreeView tvEquilibrado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label lblCodEl;
        private System.Windows.Forms.ComboBox cboEliminar;
        private System.Windows.Forms.GroupBox gboBuscar;
        private System.Windows.Forms.Label lblCodBus;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gboEquilibrar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox gboTipoListado;
        private System.Windows.Forms.Label lblBusTramite;
        private System.Windows.Forms.Label lblBusNombre;
        private System.Windows.Forms.Label lblTramBus;
        private System.Windows.Forms.Label lblNomBus;
        private System.Windows.Forms.ComboBox cboOrden;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtBusCodigo;
    }
}