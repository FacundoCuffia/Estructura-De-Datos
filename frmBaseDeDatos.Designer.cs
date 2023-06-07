namespace Pry_EstructuraDeDatos
{
    partial class frmBaseDeDatos
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.gboProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntarJoin = new System.Windows.Forms.Button();
            this.btnProyeccionMulti = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.gboSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMulti = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.gboAritmeticas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gboProyeccion.SuspendLayout();
            this.gboSeleccion.SuspendLayout();
            this.gboAritmeticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(658, 225);
            this.dgvGrilla.TabIndex = 0;
            // 
            // gboProyeccion
            // 
            this.gboProyeccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboProyeccion.Controls.Add(this.btnJuntarJoin);
            this.gboProyeccion.Controls.Add(this.btnProyeccionMulti);
            this.gboProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.gboProyeccion.Location = new System.Drawing.Point(12, 270);
            this.gboProyeccion.Name = "gboProyeccion";
            this.gboProyeccion.Size = new System.Drawing.Size(194, 203);
            this.gboProyeccion.TabIndex = 1;
            this.gboProyeccion.TabStop = false;
            this.gboProyeccion.Text = "Operaciones de proyección";
            // 
            // btnJuntarJoin
            // 
            this.btnJuntarJoin.Location = new System.Drawing.Point(31, 139);
            this.btnJuntarJoin.Name = "btnJuntarJoin";
            this.btnJuntarJoin.Size = new System.Drawing.Size(124, 44);
            this.btnJuntarJoin.TabIndex = 2;
            this.btnJuntarJoin.Text = "Juntar / Join";
            this.btnJuntarJoin.UseVisualStyleBackColor = true;
            this.btnJuntarJoin.Click += new System.EventHandler(this.btnJuntarJoin_Click);
            // 
            // btnProyeccionMulti
            // 
            this.btnProyeccionMulti.Location = new System.Drawing.Point(31, 89);
            this.btnProyeccionMulti.Name = "btnProyeccionMulti";
            this.btnProyeccionMulti.Size = new System.Drawing.Size(124, 44);
            this.btnProyeccionMulti.TabIndex = 1;
            this.btnProyeccionMulti.Text = "Proyección Multiatributo";
            this.btnProyeccionMulti.UseVisualStyleBackColor = true;
            this.btnProyeccionMulti.Click += new System.EventHandler(this.btnProyeccionMulti_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(31, 39);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(124, 44);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // gboSeleccion
            // 
            this.gboSeleccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboSeleccion.Controls.Add(this.btnSeleccionConvolucion);
            this.gboSeleccion.Controls.Add(this.btnSeleccionMulti);
            this.gboSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gboSeleccion.Location = new System.Drawing.Point(248, 270);
            this.gboSeleccion.Name = "gboSeleccion";
            this.gboSeleccion.Size = new System.Drawing.Size(194, 203);
            this.gboSeleccion.TabIndex = 3;
            this.gboSeleccion.TabStop = false;
            this.gboSeleccion.Text = "Operaciones de selección";
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(31, 139);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(124, 44);
            this.btnSeleccionConvolucion.TabIndex = 2;
            this.btnSeleccionConvolucion.Text = "Selección por Convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // btnSeleccionMulti
            // 
            this.btnSeleccionMulti.Location = new System.Drawing.Point(31, 89);
            this.btnSeleccionMulti.Name = "btnSeleccionMulti";
            this.btnSeleccionMulti.Size = new System.Drawing.Size(124, 44);
            this.btnSeleccionMulti.TabIndex = 1;
            this.btnSeleccionMulti.Text = "Selección Multiatributo";
            this.btnSeleccionMulti.UseVisualStyleBackColor = true;
            this.btnSeleccionMulti.Click += new System.EventHandler(this.btnSeleccionMulti_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(31, 39);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(124, 44);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // gboAritmeticas
            // 
            this.gboAritmeticas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboAritmeticas.Controls.Add(this.btnDiferencia);
            this.gboAritmeticas.Controls.Add(this.btnInterseccion);
            this.gboAritmeticas.Controls.Add(this.btnUnion);
            this.gboAritmeticas.Location = new System.Drawing.Point(476, 270);
            this.gboAritmeticas.Name = "gboAritmeticas";
            this.gboAritmeticas.Size = new System.Drawing.Size(194, 203);
            this.gboAritmeticas.TabIndex = 3;
            this.gboAritmeticas.TabStop = false;
            this.gboAritmeticas.Text = "Operaciones aritméticas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(31, 139);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(124, 44);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(31, 89);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(124, 44);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(31, 39);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(124, 44);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 493);
            this.Controls.Add(this.gboAritmeticas);
            this.Controls.Add(this.gboSeleccion);
            this.Controls.Add(this.gboProyeccion);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gboProyeccion.ResumeLayout(false);
            this.gboSeleccion.ResumeLayout(false);
            this.gboAritmeticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox gboProyeccion;
        private System.Windows.Forms.Button btnJuntarJoin;
        private System.Windows.Forms.Button btnProyeccionMulti;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox gboSeleccion;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.Button btnSeleccionMulti;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox gboAritmeticas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}