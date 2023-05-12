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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.lblCSV = new System.Windows.Forms.Label();
            this.btnCrearColumna = new System.Windows.Forms.Button();
            this.btnBorrarColuma = new System.Windows.Forms.Button();
            this.txtNumeroColumna = new System.Windows.Forms.TextBox();
            this.lblNumeroColumna = new System.Windows.Forms.Label();
            this.lblNombreColumna = new System.Windows.Forms.Label();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.lblBorrarFila = new System.Windows.Forms.Label();
            this.txtBorrarFila = new System.Windows.Forms.TextBox();
            this.btnBorrarFila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCSV
            // 
            this.dtgCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCSV.Location = new System.Drawing.Point(34, 12);
            this.dtgCSV.Name = "dtgCSV";
            this.dtgCSV.RowHeadersWidth = 51;
            this.dtgCSV.RowTemplate.Height = 24;
            this.dtgCSV.Size = new System.Drawing.Size(676, 321);
            this.dtgCSV.TabIndex = 0;
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
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnCrearColumna.Location = new System.Drawing.Point(763, 88);
            this.btnCrearColumna.Name = "btnCrearColumna";
            this.btnCrearColumna.Size = new System.Drawing.Size(114, 48);
            this.btnCrearColumna.TabIndex = 6;
            this.btnCrearColumna.Text = "Crear Columna";
            this.btnCrearColumna.UseVisualStyleBackColor = true;
            this.btnCrearColumna.Click += new System.EventHandler(this.btnCrearColumna_Click);
            // 
            // btnBorrarColuma
            // 
            this.btnBorrarColuma.Location = new System.Drawing.Point(763, 225);
            this.btnBorrarColuma.Name = "btnBorrarColuma";
            this.btnBorrarColuma.Size = new System.Drawing.Size(114, 48);
            this.btnBorrarColuma.TabIndex = 7;
            this.btnBorrarColuma.Text = "Borrar Columna";
            this.btnBorrarColuma.UseVisualStyleBackColor = true;
            this.btnBorrarColuma.Click += new System.EventHandler(this.btnBorrarColuma_Click);
            // 
            // txtNumeroColumna
            // 
            this.txtNumeroColumna.Location = new System.Drawing.Point(763, 188);
            this.txtNumeroColumna.Name = "txtNumeroColumna";
            this.txtNumeroColumna.Size = new System.Drawing.Size(114, 22);
            this.txtNumeroColumna.TabIndex = 8;
            // 
            // lblNumeroColumna
            // 
            this.lblNumeroColumna.AutoSize = true;
            this.lblNumeroColumna.Location = new System.Drawing.Point(735, 158);
            this.lblNumeroColumna.Name = "lblNumeroColumna";
            this.lblNumeroColumna.Size = new System.Drawing.Size(178, 16);
            this.lblNumeroColumna.TabIndex = 9;
            this.lblNumeroColumna.Text = "Numero de columna a borrar";
            // 
            // lblNombreColumna
            // 
            this.lblNombreColumna.AutoSize = true;
            this.lblNombreColumna.Location = new System.Drawing.Point(760, 29);
            this.lblNombreColumna.Name = "lblNombreColumna";
            this.lblNombreColumna.Size = new System.Drawing.Size(143, 16);
            this.lblNombreColumna.TabIndex = 11;
            this.lblNombreColumna.Text = "Nombre de la columna";
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(763, 60);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(114, 22);
            this.txtNombreColumna.TabIndex = 10;
            // 
            // lblBorrarFila
            // 
            this.lblBorrarFila.AutoSize = true;
            this.lblBorrarFila.Location = new System.Drawing.Point(754, 291);
            this.lblBorrarFila.Name = "lblBorrarFila";
            this.lblBorrarFila.Size = new System.Drawing.Size(149, 16);
            this.lblBorrarFila.TabIndex = 14;
            this.lblBorrarFila.Text = "Numero de Fila a borrar";
            // 
            // txtBorrarFila
            // 
            this.txtBorrarFila.Location = new System.Drawing.Point(763, 321);
            this.txtBorrarFila.Name = "txtBorrarFila";
            this.txtBorrarFila.Size = new System.Drawing.Size(114, 22);
            this.txtBorrarFila.TabIndex = 13;
            // 
            // btnBorrarFila
            // 
            this.btnBorrarFila.Location = new System.Drawing.Point(763, 358);
            this.btnBorrarFila.Name = "btnBorrarFila";
            this.btnBorrarFila.Size = new System.Drawing.Size(114, 48);
            this.btnBorrarFila.TabIndex = 12;
            this.btnBorrarFila.Text = "Borrar Columna";
            this.btnBorrarFila.UseVisualStyleBackColor = true;
            this.btnBorrarFila.Click += new System.EventHandler(this.btnBorrarFila_Click);
            // 
            // fmrCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.lblBorrarFila);
            this.Controls.Add(this.txtBorrarFila);
            this.Controls.Add(this.btnBorrarFila);
            this.Controls.Add(this.lblNombreColumna);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.lblNumeroColumna);
            this.Controls.Add(this.txtNumeroColumna);
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
        private System.Windows.Forms.Button btnCrearColumna;
        private System.Windows.Forms.Button btnBorrarColuma;
        private System.Windows.Forms.TextBox txtNumeroColumna;
        private System.Windows.Forms.Label lblNumeroColumna;
        private System.Windows.Forms.Label lblNombreColumna;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.Label lblBorrarFila;
        private System.Windows.Forms.TextBox txtBorrarFila;
        private System.Windows.Forms.Button btnBorrarFila;
    }
}

