namespace Almacenamiento_de_Datos
{
    partial class fmrCSV
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
            this.dtgCSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.lblCSV = new System.Windows.Forms.Label();
            this.btnCrearColumna = new System.Windows.Forms.Button();
            this.btnBorrarColuma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCSV
            // 
            this.dtgCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgCSV.Location = new System.Drawing.Point(34, 12);
            this.dtgCSV.Name = "dtgCSV";
            this.dtgCSV.RowHeadersWidth = 51;
            this.dtgCSV.RowTemplate.Height = 24;
            this.dtgCSV.Size = new System.Drawing.Size(676, 321);
            this.dtgCSV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Personas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(34, 363);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(146, 63);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(186, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 63);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(338, 363);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 63);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtSeparador
            // 
            this.txtSeparador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeparador.Location = new System.Drawing.Point(572, 394);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(64, 34);
            this.txtSeparador.TabIndex = 4;
            this.txtSeparador.Text = ";";
            this.txtSeparador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(511, 361);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(184, 16);
            this.lblCSV.TabIndex = 5;
            this.lblCSV.Text = "Ingrese el separador del CSV";
            // 
            // btnCrearColumna
            // 
            this.btnCrearColumna.Location = new System.Drawing.Point(739, 12);
            this.btnCrearColumna.Name = "btnCrearColumna";
            this.btnCrearColumna.Size = new System.Drawing.Size(114, 48);
            this.btnCrearColumna.TabIndex = 6;
            this.btnCrearColumna.Text = "Crear Columna";
            this.btnCrearColumna.UseVisualStyleBackColor = true;
            // 
            // btnBorrarColuma
            // 
            this.btnBorrarColuma.Location = new System.Drawing.Point(739, 95);
            this.btnBorrarColuma.Name = "btnBorrarColuma";
            this.btnBorrarColuma.Size = new System.Drawing.Size(114, 48);
            this.btnBorrarColuma.TabIndex = 7;
            this.btnBorrarColuma.Text = "Borrar Columna";
            this.btnBorrarColuma.UseVisualStyleBackColor = true;
            this.btnBorrarColuma.Click += new System.EventHandler(this.btnBorrarColuma_Click);
            // 
            // fmrCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btnBorrarColuma);
            this.Controls.Add(this.btnCrearColumna);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.dtgCSV);
            this.Name = "fmrCSV";
            this.Text = "Archivos CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCSV;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnCrearColumna;
        private System.Windows.Forms.Button btnBorrarColuma;
    }
}

