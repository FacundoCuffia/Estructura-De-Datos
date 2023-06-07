namespace Pry_EstructuraDeDatos
{
    partial class frmConsultas
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
            this.lblSQL = new System.Windows.Forms.Label();
            this.txtInstruccion = new System.Windows.Forms.TextBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnEjecutarQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQL.Location = new System.Drawing.Point(12, 9);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(289, 24);
            this.lblSQL.TabIndex = 0;
            this.lblSQL.Text = "Introduzca su instrucción SQL";
            // 
            // txtInstruccion
            // 
            this.txtInstruccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstruccion.Location = new System.Drawing.Point(16, 40);
            this.txtInstruccion.Multiline = true;
            this.txtInstruccion.Name = "txtInstruccion";
            this.txtInstruccion.Size = new System.Drawing.Size(767, 143);
            this.txtInstruccion.TabIndex = 1;
            this.txtInstruccion.TextChanged += new System.EventHandler(this.txtInstruccion_TextChanged);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(16, 243);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(767, 261);
            this.dgvGrilla.TabIndex = 2;
            // 
            // btnEjecutarQuery
            // 
            this.btnEjecutarQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjecutarQuery.Location = new System.Drawing.Point(662, 189);
            this.btnEjecutarQuery.Name = "btnEjecutarQuery";
            this.btnEjecutarQuery.Size = new System.Drawing.Size(121, 48);
            this.btnEjecutarQuery.TabIndex = 3;
            this.btnEjecutarQuery.Text = "CONSULTAR";
            this.btnEjecutarQuery.UseVisualStyleBackColor = true;
            this.btnEjecutarQuery.Click += new System.EventHandler(this.btnEjecutarQuery_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnEjecutarQuery);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.txtInstruccion);
            this.Controls.Add(this.lblSQL);
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.TextBox txtInstruccion;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnEjecutarQuery;
    }
}