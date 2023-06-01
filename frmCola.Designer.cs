namespace Pry_EstructuraDeDatos
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.imgRepresentacionCola = new System.Windows.Forms.PictureBox();
            this.gboNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.lblTramAg = new System.Windows.Forms.Label();
            this.lblNomAg = new System.Windows.Forms.Label();
            this.lblCodAg = new System.Windows.Forms.Label();
            this.gboEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramTEL = new System.Windows.Forms.Label();
            this.lblNomTEL = new System.Windows.Forms.Label();
            this.lblCodTEL = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramEl = new System.Windows.Forms.Label();
            this.lblNomEl = new System.Windows.Forms.Label();
            this.lblCodEl = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.gboLisGri = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgRepresentacionCola)).BeginInit();
            this.gboNuevo.SuspendLayout();
            this.gboEliminado.SuspendLayout();
            this.gboLisGri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // imgRepresentacionCola
            // 
            this.imgRepresentacionCola.Image = ((System.Drawing.Image)(resources.GetObject("imgRepresentacionCola.Image")));
            this.imgRepresentacionCola.Location = new System.Drawing.Point(12, 12);
            this.imgRepresentacionCola.Name = "imgRepresentacionCola";
            this.imgRepresentacionCola.Size = new System.Drawing.Size(254, 216);
            this.imgRepresentacionCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRepresentacionCola.TabIndex = 0;
            this.imgRepresentacionCola.TabStop = false;
            // 
            // gboNuevo
            // 
            this.gboNuevo.Controls.Add(this.txtTramite);
            this.gboNuevo.Controls.Add(this.txtNombre);
            this.gboNuevo.Controls.Add(this.txtCodigo);
            this.gboNuevo.Controls.Add(this.btnEncolar);
            this.gboNuevo.Controls.Add(this.lblTramAg);
            this.gboNuevo.Controls.Add(this.lblNomAg);
            this.gboNuevo.Controls.Add(this.lblCodAg);
            this.gboNuevo.Location = new System.Drawing.Point(283, 12);
            this.gboNuevo.Name = "gboNuevo";
            this.gboNuevo.Size = new System.Drawing.Size(234, 216);
            this.gboNuevo.TabIndex = 1;
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
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(51, 156);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(138, 41);
            this.btnEncolar.TabIndex = 12;
            this.btnEncolar.Text = "Agregar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
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
            // gboEliminado
            // 
            this.gboEliminado.Controls.Add(this.lblTramTEL);
            this.gboEliminado.Controls.Add(this.lblNomTEL);
            this.gboEliminado.Controls.Add(this.lblCodTEL);
            this.gboEliminado.Controls.Add(this.btnEliminar);
            this.gboEliminado.Controls.Add(this.lblTramEl);
            this.gboEliminado.Controls.Add(this.lblNomEl);
            this.gboEliminado.Controls.Add(this.lblCodEl);
            this.gboEliminado.Location = new System.Drawing.Point(554, 12);
            this.gboEliminado.Name = "gboEliminado";
            this.gboEliminado.Size = new System.Drawing.Size(234, 216);
            this.gboEliminado.TabIndex = 2;
            this.gboEliminado.TabStop = false;
            this.gboEliminado.Text = "Elemento eliminado";
            // 
            // lblTramTEL
            // 
            this.lblTramTEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTramTEL.Location = new System.Drawing.Point(92, 118);
            this.lblTramTEL.Name = "lblTramTEL";
            this.lblTramTEL.Size = new System.Drawing.Size(100, 20);
            this.lblTramTEL.TabIndex = 18;
            this.lblTramTEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomTEL
            // 
            this.lblNomTEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomTEL.Location = new System.Drawing.Point(92, 71);
            this.lblNomTEL.Name = "lblNomTEL";
            this.lblNomTEL.Size = new System.Drawing.Size(100, 20);
            this.lblNomTEL.TabIndex = 17;
            this.lblNomTEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodTEL
            // 
            this.lblCodTEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodTEL.Location = new System.Drawing.Point(92, 26);
            this.lblCodTEL.Name = "lblCodTEL";
            this.lblCodTEL.Size = new System.Drawing.Size(100, 20);
            this.lblCodTEL.TabIndex = 16;
            this.lblCodTEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCodTEL.TextChanged += new System.EventHandler(this.lblCodTEL_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(73, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 41);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramEl
            // 
            this.lblTramEl.AutoSize = true;
            this.lblTramEl.Location = new System.Drawing.Point(30, 122);
            this.lblTramEl.Name = "lblTramEl";
            this.lblTramEl.Size = new System.Drawing.Size(42, 13);
            this.lblTramEl.TabIndex = 14;
            this.lblTramEl.Text = "Trámite";
            // 
            // lblNomEl
            // 
            this.lblNomEl.AutoSize = true;
            this.lblNomEl.Location = new System.Drawing.Point(30, 75);
            this.lblNomEl.Name = "lblNomEl";
            this.lblNomEl.Size = new System.Drawing.Size(44, 13);
            this.lblNomEl.TabIndex = 13;
            this.lblNomEl.Text = "Nombre";
            // 
            // lblCodEl
            // 
            this.lblCodEl.AutoSize = true;
            this.lblCodEl.Location = new System.Drawing.Point(30, 30);
            this.lblCodEl.Name = "lblCodEl";
            this.lblCodEl.Size = new System.Drawing.Size(40, 13);
            this.lblCodEl.TabIndex = 12;
            this.lblCodEl.Text = "Código";
            // 
            // lstCola
            // 
            this.lstCola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(20, 29);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(234, 212);
            this.lstCola.TabIndex = 3;
            // 
            // gboLisGri
            // 
            this.gboLisGri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboLisGri.Controls.Add(this.dgvCola);
            this.gboLisGri.Controls.Add(this.lstCola);
            this.gboLisGri.Location = new System.Drawing.Point(12, 243);
            this.gboLisGri.Name = "gboLisGri";
            this.gboLisGri.Size = new System.Drawing.Size(776, 272);
            this.gboLisGri.TabIndex = 2;
            this.gboLisGri.TabStop = false;
            this.gboLisGri.Text = "Listado en una lista y en una grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.AllowUserToAddRows = false;
            this.dgvCola.AllowUserToDeleteRows = false;
            this.dgvCola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(284, 29);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.ReadOnly = true;
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(474, 212);
            this.dgvCola.TabIndex = 4;
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
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.gboLisGri);
            this.Controls.Add(this.gboEliminado);
            this.Controls.Add(this.gboNuevo);
            this.Controls.Add(this.imgRepresentacionCola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRepresentacionCola)).EndInit();
            this.gboNuevo.ResumeLayout(false);
            this.gboNuevo.PerformLayout();
            this.gboEliminado.ResumeLayout(false);
            this.gboEliminado.PerformLayout();
            this.gboLisGri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRepresentacionCola;
        private System.Windows.Forms.GroupBox gboNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Label lblTramAg;
        private System.Windows.Forms.Label lblNomAg;
        private System.Windows.Forms.Label lblCodAg;
        private System.Windows.Forms.GroupBox gboEliminado;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox gboLisGri;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Label lblTramTEL;
        private System.Windows.Forms.Label lblNomTEL;
        private System.Windows.Forms.Label lblCodTEL;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramEl;
        private System.Windows.Forms.Label lblNomEl;
        private System.Windows.Forms.Label lblCodEl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}