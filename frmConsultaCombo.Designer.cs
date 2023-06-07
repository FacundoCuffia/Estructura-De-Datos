namespace Pry_EstructuraDeDatos
{
    partial class frmConsultaCombo
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
            this.cboOperaciones = new System.Windows.Forms.ComboBox();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOperaciones
            // 
            this.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperaciones.FormattingEnabled = true;
            this.cboOperaciones.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Juntar",
            "Proyección Simple",
            "Proyección Multiatributo",
            "Selección Multiatributo con operador AND",
            "Selección Multiatributo con operador OR",
            "Selección por Convolución",
            "Selección Simple",
            "Union"});
            this.cboOperaciones.Location = new System.Drawing.Point(310, 17);
            this.cboOperaciones.Name = "cboOperaciones";
            this.cboOperaciones.Size = new System.Drawing.Size(289, 21);
            this.cboOperaciones.TabIndex = 0;
            this.cboOperaciones.SelectedIndexChanged += new System.EventHandler(this.cboOperaciones_SelectedIndexChanged);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.Location = new System.Drawing.Point(12, 15);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(292, 25);
            this.lblIndicacion.TabIndex = 1;
            this.lblIndicacion.Text = "Seleccione una operación:";
            this.lblIndicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(605, 5);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(118, 44);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(706, 117);
            this.lblDescripcion.TabIndex = 3;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(18, 201);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(705, 248);
            this.dgvGrilla.TabIndex = 4;
            // 
            // frmConsultaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 461);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.cboOperaciones);
            this.Name = "frmConsultaCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Consultas por combo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOperaciones;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}