using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Sistema_HES
{
    public class Conexion   //Clase para la conexion con la base de datos
    {
        public MySqlConnection conexion = new MySqlConnection("server=localhost;database=sys_hes;uid=root;pwd=12345");
        public Conexion()
        {
        }
        public bool Ini_Sesion(string ci, string contraseña,Label LblError)
        {
            StreamWriter archivo = new StreamWriter(@"Rol.txt");
            //se hace la consulta primero a la tabla de usuarios, por si sea un paciente
            string consulta = "select contraseña from usuarios where num_ci="+ci+";";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            try
            {
                conexion.Open();    //se abre la conexion
                MySqlDataReader lector = comando.ExecuteReader();   //se ejecuta el comando y se crea un lector de datos
                conexion.Close();
                if(lector.HasRows)  //si tiene filas hacer...
                {
                    while(lector.Read())
                     {
                        if (contraseña == lector.GetString(0))
                        {
                            archivo.WriteLine("paciente");
                            //archivo.Close();
                            //lector.Close();
                            return true;
                        }
                        else
                        {
                            LblError.Visible = true;
                        }
                     }
                }
                else    //si no tiene filas...
                {
                    consulta= "select contraseña from medico where num_ci=" + ci + ";";     //se crea una nueva consulta en la tabla medico
                    comando = new MySqlCommand(consulta, conexion);     //se crea un nuevo comando de consulta
                    conexion.Open();
                    lector = comando.ExecuteReader();   //se ejecuta el comando, el resultado se guarda en lector
                    conexion.Close();
                    if(lector.HasRows)      //si tiene filas hacer...
                    {
                        while (lector.Read())
                         {
                            if (contraseña == lector.GetString(0))
                            {
                                archivo.WriteLine("medico");
                                return true;
                            }
                            else
                            {
                                LblError.Visible = true;
                            }
                         }
                    }
                    else    //si no tiene filas...
                    {
                        consulta = "select contraseña from admin where num_ci=" + ci + ";";     //se crea una nueva consulta en la tabla admin
                        comando = new MySqlCommand(consulta, conexion);     //se crea un nuevo comando de consulta
                        conexion.Open();
                        lector = comando.ExecuteReader();   //se ejecuta el comando y el resultado se guarda en lector
                        conexion.Close();
                        if(lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                if (contraseña == lector.GetString(0))
                                {
                                    archivo.WriteLine("admin");
                                   // lector.Close();
                                    return true;
                                }
                                else
                                {
                                    LblError.Visible = true;
                                }
                             }
                        }
                        else
                        {
                            LblError.Visible = true;
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return false;
            }
            return false;
        }
        public void SinRetorno(string query)    //hace operaciones que no devuelven nada como insertar, eliminar o modificar
        {
            try //intenta la conexion con la base de datos y la operacion sin retorno
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Proceso Exitoso");
                conexion.Close();
            }
            catch (MySqlException ex)  //si hay un error en la ejecucion, lanza un mensaje de error y cierra la conexion
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
        public DataTable VistaTabla(string query)   //hace las consultas en las que se devuelve una tabla
        {
            conexion.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();    //adaptador que hara la consulta y obtendra la tabla de respuesta
            adaptador.SelectCommand = new MySqlCommand(query, conexion);
            DataTable tabla = new DataTable();  //tabla que guardara la tabla obtenida de la consulta
            adaptador.Fill(tabla);  //se guarda los datos en tabla
            conexion.Close();
            return tabla;
        }
    }
}
