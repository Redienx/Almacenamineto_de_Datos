using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace Almacenamiento_de_datos_1._0
{
    public partial class wLogin : Form
    {

        // Var que almacenan datos del registro y del login
        string UsuarioRegistro;
        string ContrasenaRegistro;
        string Usuario;
        string Contrasena;

        // Contador para saber el numero de intentos 
        int intentos;

        // Variable señuelo para verificar registro
        bool señuelo = false;
        
        public wLogin()
        {
            InitializeComponent();
        }

        

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            wRegistroCliente wRegistro = new wRegistroCliente();
            wRegistro.Show();
            señuelo = true;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;



            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbClientes.db;Version=3;Compress=True;");
            try
            {
                //Abriremos la conexión
                conexion_sqlite.Open();
            }
            catch (Exception ex) { MessageBox.Show("No se pudo localizar la base de datos."); }
            cmd_sqlite = conexion_sqlite.CreateCommand();

            Usuario = txt_Usuario.Text;
            Contrasena = txt_Contrasena.Text;

            cmd_sqlite.CommandText = $"SELECT Usuario, Contraseña FROM tbl_Clientes WHERE Usuario = '{Usuario}' AND Contraseña = '{Contrasena}'";
            datareader_sqlite = cmd_sqlite.ExecuteReader();

            if (datareader_sqlite.Read())
            {
                wPrueba wPrueba = new wPrueba();
                wPrueba.Show();
                intentos = 0;
                conexion_sqlite.Close();

            }

            else
            {
                intentos++;
                //Cuando hay 3 intentos muestra el error
                if (intentos < 3)
                {
                    MessageBox.Show("Credenciales incorrectas intente de nuevo");

                }
                //Cuando se detectan los 3 errores cierra la aplicación
                else
                {
                    MessageBox.Show("Demasiados Intentos erroneos");
                    this.Close();
                    conexion_sqlite.Close();
                }
            }
            //Limpio los campos al ingresar el usuario
            txt_Usuario.Text = string.Empty;
            txt_Contrasena.Text = string.Empty;
        }
    }
}
