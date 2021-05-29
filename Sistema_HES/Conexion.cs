using System;
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
        public bool Ini_Sesion(string ci, string contraseña,Label LblError)     //funcion que verifica en las tablas correspondientes si dicho usuario y contraseña son correctos o si existen
        {
            StreamWriter archivo = new StreamWriter(@"Rol.txt");    //abre un archivo en stream para escribir dentro mas adelante
            //se hace la consulta primero a la tabla de usuarios, por si sea un paciente
            string query = "select contraseña from usuarios where ci="+ci+";";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            try
            {
                conexion.Open();    //se abre la conexion
                MySqlDataReader lector = comando.ExecuteReader();   //se ejecuta el comando y se crea un lector de datos
                conexion.Close();   //se cierra la conexion
                MessageBox.Show(query);
                if (lector.HasRows)  //si tiene filas hacer...
                {
                    while(lector.Read())
                     {
                        if (contraseña == lector.GetString(0))
                        {
                            archivo.WriteLine("paciente;"+ci);
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
                    query = "select contraseña from medico where ci=" + ci + ";";     //se crea una nueva consulta en la tabla medico
                    comando = new MySqlCommand(query, conexion);     //se crea un nuevo comando de consulta
                    conexion.Open();    //se abre la conexion
                    lector = comando.ExecuteReader();   //se ejecuta el comando, el resultado se guarda en lector
                    conexion.Close();   //se cierra la conexion
                    if(lector.HasRows)      //si tiene filas hacer...
                    {
                        while (lector.Read())
                         {
                            if (contraseña == lector.GetString(0))
                            {
                                archivo.WriteLine("medico;"+ci);
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
                        query = "select contraseña from admin where ci=" + ci + ";";     //se crea una nueva consulta para la tabla admin
                        comando = new MySqlCommand(query, conexion);     //se crea un nuevo comando de consulta
                        conexion.Open();    //se abre la conexion
                        lector = comando.ExecuteReader();   //se ejecuta el comando y el resultado se guarda en lector
                        conexion.Close();   //se cierra la conexion
                        if(lector.HasRows)  //si tiene filas...
                        {
                            while (lector.Read())
                            {
                                if (contraseña == lector.GetString(0))
                                {
                                    archivo.WriteLine("admin;"+ci);
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
        public bool VerificarDato(string query)     //funcion que verifica si cierto dato existe en la base de datos
        {
            MySqlCommand comando = new MySqlCommand(query, conexion);
            conexion.Open();
            MySqlDataReader lector = comando.ExecuteReader();
            conexion.Close();
            if (lector.HasRows)
            {
                return true;
                //while (lector.Read())
                //{
                //    dato = Convert.ToString(lector[0]);
                //}
            }
            else
                return false;
                //MessageBox.Show("No se encotro ningun registro");
            //conexion.Close();
        }
        public MySqlDataReader ObtenerDatos(string query)       //metodo que devuelve un dato de tipo DataReader, devolviendo una fila completa de datos
        { 
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader lector = null;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                conexion.Close();
                return lector;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return lector;
            }
        }
    }
}
