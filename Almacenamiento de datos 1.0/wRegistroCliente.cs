using System;
using Finisar.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Almacenamiento_de_datos_1._0
{
    public partial class wRegistroCliente : Form
    {
        public wRegistroCliente()
        {
            InitializeComponent();
        }

        string UsuarioRegistro, ContrasenaRegistro,NombresRegistro,ApellidosRegistro,CorreoRegistro;
        int EdadRegistro, TelefonoRegistro;
        string RolRegistro = "Cliente";

        // Solo se admiten numeros en el campo de Telefono 
        private void txt_Telefono_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        // Solo se admiten numeros en el campo de Edad
        private void txt_Edad_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void LimpiarTextBox()
        {
            // Limpia los datos de los TextBox asignando una cadena vacía
            txt_Usuario_Registro.Text = string.Empty;
            txt_Contrasena_Registro.Text = string.Empty;
            txt_Nombres_Registro.Text = string.Empty;
            txt_Apellidos_Registro.Text = string.Empty;
            txt_Edad_Registro.Text = string.Empty;
            txt_Telefono_Registro.Text = string.Empty;
            txt_Correo_Registro.Text = string.Empty;

        }

        string Usuario;             
        string Contrasena;

            

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            //Conexion a base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbClientes.db;Version=3;Compress=False;");
            try
            {   //Se abre la conexion
                conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                //Mensae en caso de error 
                MessageBox.Show("No se pudo localizar la base de datos");
            }


            cmd_sqlite = conexion_sqlite.CreateCommand();
            try
            {
                UsuarioRegistro = txt_Usuario_Registro.Text;
                ContrasenaRegistro = txt_Contrasena_Registro.Text;
                NombresRegistro = txt_Nombres_Registro.Text;
                ApellidosRegistro = txt_Apellidos_Registro.Text;
                EdadRegistro = int.Parse(txt_Edad_Registro.Text);
                TelefonoRegistro = int.Parse(txt_Telefono_Registro.Text);
                CorreoRegistro = txt_Correo_Registro.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifica que todos los datos esten llenos, no se admiten espacios vacios");
            }

            cmd_sqlite = conexion_sqlite.CreateCommand();
             try
             {
              //Insertando datos en la tabla
                cmd_sqlite.CommandText = $"INSERT INTO tbl_Clientes(Usuario, Contraseña, Rol, Nombres, Apellidos, Edad, Telefono, Correo) VALUES('{UsuarioRegistro}', '{ContrasenaRegistro}', '{RolRegistro}', '{NombresRegistro}', '{ApellidosRegistro}', '{EdadRegistro}', '{TelefonoRegistro}', '{CorreoRegistro}')";
                cmd_sqlite.ExecuteNonQuery();



             }
             catch (Exception ex)
             {

            MessageBox.Show("Usuario Existente");
             }

            LimpiarTextBox();
            this.Close();

            conexion_sqlite.Close();
        }
    }
}


    

                