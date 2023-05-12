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

namespace Almacenamiento_de_Datos
{
    public partial class fmrCSV : Form
    {
        public fmrCSV()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabecera = new List<string>();
                foreach (DataGridViewColumn col in dtgCSV.Columns)
                {
                    cabecera.Add(col.HeaderText);
                }
                string Separador = txtSeparador.Text; 
                filas.Add(string.Join(Separador, cabecera));

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

                    }
                }

                File.WriteAllLines(sfd.FileName, filas);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Archivos (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Separador = txtSeparador.Text;
                string[] lineas = File.ReadAllLines(ofd.FileName);
                string[] cabeceras = lineas[0].Split(new[] {Separador}, StringSplitOptions.None);

                dtgCSV.Columns.Clear();
                foreach (string cabecera in cabeceras)
                    dtgCSV.Columns.Add(cabecera, cabecera);
                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] celdas = lineas[i].Split(new[] { Separador }, StringSplitOptions.None);
                    dtgCSV.Rows.Add(celdas);
                }
            }
        }

        private void btnBorrarColuma_Click(object sender, EventArgs e)
        {
            dtgCSV.Columns.RemoveAt(0);
        }
    }
}
