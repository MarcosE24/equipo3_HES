using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Sistema_HES
{
    public class Conexion   //Clase para la conexion con la base de datos
    {
        public MySqlConnection conexion = new MySqlConnection("server=localhost;database=sys_hes;uid=root;pwd=trivial");
        public Conexion()
        {
        }
        public bool Ini_Sesion(string ci, string contraseña,Label LblError)     //funcion que verifica en las tablas correspondientes si dicho usuario y contraseña son correctos o si existen
        {
            StreamWriter archivo = new StreamWriter(@"Rol.txt");    //abre un archivo en stream para escribir dentro mas adelante
            DataTable tabla = new DataTable();
            MySqlDataAdapter adaptador;
            string query = "select contraseña from usuarios where ci="+ci+";";      //se hace la consulta primero a la tabla de usuarios, por si sea un paciente
            MySqlCommand comando = new MySqlCommand(query, conexion);
            try
            {
                conexion.Open();    //se abre la conexion
                adaptador = new MySqlDataAdapter(comando);      //se encarga de ejecutar la consulta y obtener de vuelta el valor que estamos buscando
                conexion.Close();   //se cierra la conexion
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 1)  //si recupero algun dato...
                {
                    if (tabla.Rows[0][0].ToString() == contraseña)  //si coinciden los datos...
                    {
                        archivo.WriteLine("usuarios," + ci);
                        archivo.Close();
                        return true;
                    }
                    else    //sino coinciden los datos
                        LblError.Visible = true;
                }
                else    //si no recupero ningun dato
                {
                    query= "select contraseña from medico where ci=" + ci + ";";      //se hace la consulta a la tabla medico
                    comando = new MySqlCommand(query, conexion);
                    conexion.Open();    //se abre la conexion
                    adaptador = new MySqlDataAdapter(comando);      //se encarga de ejecutar la consulta y obtener de vuelta el valor que estamos buscando
                    conexion.Close();   //se cierra la conexion
                    adaptador.Fill(tabla);
                    if (tabla.Rows.Count == 1)  //si recupero algun dato...
                    {
                        if (tabla.Rows[0][0].ToString() == contraseña)  //si coinciden los datos...
                        {
                            archivo.WriteLine("medico," + ci);
                            archivo.Close();
                            return true;
                        }
                        else    //sino coinciden los datos
                            LblError.Visible = true;
                    }
                    else    //si no recupero ningun dato
                    {
                        query = "select contraseña from admin where ci=" + ci + ";";      //se hace la consulta a la tabla medico
                        comando = new MySqlCommand(query, conexion);
                        conexion.Open();    //se abre la conexion
                        adaptador = new MySqlDataAdapter(comando);      //se encarga de ejecutar la consulta y obtener de vuelta el valor que estamos buscando
                        conexion.Close();   //se cierra la conexion
                        adaptador.Fill(tabla);
                        if (tabla.Rows.Count == 1)  //si recupero algun dato...
                        {
                            if (tabla.Rows[0][0].ToString() == contraseña)  //si coinciden los datos...
                            {
                                archivo.WriteLine("admin," + ci);
                                archivo.Close();
                                return true;
                            }
                            else    //sino coinciden los datos
                            {
                                LblError.Visible = true;
                                archivo.Close();
                            }
                        }
                        else    //si no recupero ningun dato
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
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                conexion.Close();
                adaptador.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    MessageBox.Show("hay algo");
                    return true;
                }
                else
                    return false;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
            return false;
        }
        public DataTable ObtenerDatos(string query)       //metodo que devuelve un dato de tipo DataReader, devolviendo una fila completa de datos
        {
            MySqlCommand comando = new MySqlCommand(query, conexion);
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                conexion.Close();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return null;
            }
        }
    }
}
