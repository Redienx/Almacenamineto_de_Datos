using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<summary>
/// Hecho por Sneider Velasquez Iglesias Y Juan Camilo Valest Gomez
/// Este proyecto consiste en la Creacion, Eliminacion y modificacion de archivos CSV.
/// </summary>

namespace Almacenamiento_de_Datos
{
    /// <summary>
    /// Formulario para almacenamiento de datos en formato CSV.
    /// </summary>
    public partial class fmrCSV : Form
    {
        /// <summary>
        /// Constructor de la clase fmrCSV.
        /// Inicializa una nueva instancia del formulario.
        /// </summary>
        public fmrCSV()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Guardar".
        /// Guarda el contenido del DataGridView en un archivo CSV.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos (*.csv)|*.csv";
            
            // Muestra un cuadro de diálogo para seleccionar la ubicación y el nombre del archivo CSV
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                // Obtiene los encabezados de las columnas del DataGridView y los agrega como la primera línea del archivo CSV
                List<string> cabecera = new List<string>();
                foreach (DataGridViewColumn col in dtgCSV.Columns)
                {
                    cabecera.Add(col.HeaderText);
                }
                string Separador = txtSeparador.Text;
                filas.Add(string.Join(Separador, cabecera));

                // Recorre cada fila del DataGridView y obtiene los valores de las celdas, los agrega como una línea en el archivo CSV
                foreach (DataGridViewRow fila in dtgCSV.Rows)
                {
                    try
                    {
                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell celda in fila.Cells)
                            celdas.Add(celda.Value.ToString());
                        filas.Add(string.Join(Separador, celdas));
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones en caso de que ocurra un error al obtener los valores de las celdas
                    }
                }

                // Escribe todas las líneas en el archivo CSV seleccionado
                File.WriteAllLines(sfd.FileName, filas);
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Abrir".
        /// Abre un archivo CSV y muestra su contenido en el DataGridView.
        /// </summary>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Archivos (*.csv)|*.csv";
            
            // Muestra un cuadro de diálogo para seleccionar un archivo CSV
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Separador = txtSeparador.Text;
                string[] lineas = File.ReadAllLines(ofd.FileName);
                
                // Divide la primera línea en los encabezados de las columnas y agrega las columnas al DataGridView
                string[] cabeceras = lineas[0].Split(new[] { Separador }, StringSplitOptions.None);
                dtgCSV.Columns.Clear();
                foreach (string cabecera in cabeceras)
                    dtgCSV.Columns.Add(cabecera, cabecera);
                
                // Recorre el resto de las líneas y agrega las filas al DataGridView
                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] celdas = lineas[i].Split(new[] { Separador }, StringSplitOptions.None);

                    dtgCSV.Rows.Add(celdas);
                }
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Borrar Columna".
        /// Elimina una columna del DataGridView según el número de columna especificado.
        /// </summary>
        private void btnBorrarColuma_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el número de columna especificado por el usuario y lo utiliza para eliminar la columna correspondiente del DataGridView
                int BorrarColumna = int.Parse(txtNumeroColumna.Text);
                dtgCSV.Columns.RemoveAt(BorrarColumna);
                txtNumeroColumna.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número válido");
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Crear Columna".
        /// Crea una nueva columna en el DataGridView con el nombre especificado.
        /// </summary>
        private void btnCrearColumna_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            string NombreColumna = txtNombreColumna.Text;
            column.HeaderText = NombreColumna;
            column.ReadOnly = false;

            // Agrega la columna creada al DataGridView
            dtgCSV.Columns.Add(column);
            txtNombreColumna.Text = null;
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Borrar".
        /// Borra todas las columnas y filas del DataGridView.
        /// </summary>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Borra todas las columnas y filas del DataGridView
            dtgCSV.Columns.Clear();
            dtgCSV.Rows.Clear();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Borrar Fila".
        /// Elimina una fila del DataGridView según el número de fila especificado.
        /// </summary>
        private void btnBorrarFila_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el número de fila especificado por el usuario y lo utiliza para eliminar la fila correspondiente del DataGridView
                int BorrarFila = int.Parse(txtBorrarFila.Text);
                dtgCSV.Rows.RemoveAt(BorrarFila);
                txtNumeroColumna.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número válido");
            }
        }
    }
}