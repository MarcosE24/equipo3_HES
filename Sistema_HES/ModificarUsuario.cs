using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_HES
{
    public partial class ModificarUsuario : Form
    {
        Conexion conexion = new Conexion();
        StreamReader archivo = new StreamReader(@"Rol.txt");
        string[] vector;
        public ModificarUsuario()
        {
            InitializeComponent();
            //vector = archivo.ReadLine().Split(',');
            archivo.Close();
            CargaDatos();
        }
        void CargaDatos()   //funcion que carga los datos de la persona que tiene abierta la sesion actual
        {
            //armar la asignacion en el sgte orden: ci, nombre, apellido, contraseña, edad, direccion, correo, telefono, rol.
            //MySqlDataReader lector = conexion.ObtenerDatos("select * from " + vector[1] + " where ci=" + vector[0]);
            MySqlDataReader lector = conexion.ObtenerDatos("select * from usuarios where ci=4833308;");
            TbxCi.Text = Convert.ToString(lector[0]);
            TbxNombre.Text = Convert.ToString(lector[1]);
            TbxApellido.Text = Convert.ToString(lector[2]);
            TbxContraseña.Text = Convert.ToString(lector[3]);
            TbxEdad.Text = Convert.ToString(lector[4]);
            TbxDireccion.Text = Convert.ToString(lector[5]);
            TbxCorreo.Text = Convert.ToString(lector[6]);
            TbxTelefono.Text = Convert.ToString(lector[7]);
        }

        private void BtnEditar_Click(object sender, EventArgs e)    //metodo que dependiendo de la etiqueta edita y guarda la informacion, desabilita los textbox's y cambia de etiqueta a los botones
        {
            //ci, nombre, apellido, contraseña, edad, direccion, correo, telefono, rol.
            if (BtnEditar.Text=="Editar")
            {
                BtnEditar.Text = "Guardar";
                BtnCerrar.Text = "Cancelar";
                TbxCi.Enabled = true;
                TbxNombre.Enabled = true;
                TbxApellido.Enabled = true;
                TbxContraseña.Enabled = true;
                TbxEdad.Enabled = true;
                TbxDireccion.Enabled = true;
                TbxCorreo.Enabled = true;
                TbxTelefono.Enabled = true;
            }
            else
            {
                if (TbxCi.Text != "" && TbxNombre.Text != "" && TbxApellido.Text != "" && TbxContraseña.Text != "" && TbxEdad.Text != "" && TbxDireccion.Text != "" && TbxCorreo.Text != "" && TbxTelefono.Text != "")
                {
                    conexion.SinRetorno("update " + vector[1] + " set ci=\"" + TbxCi.Text + "\",nombre=\"" + TbxNombre.Text + "\",apellido=\"" + TbxApellido.Text + "\",contraseña=\"" + TbxContraseña.Text + "\",edad=" + TbxEdad.Text + ",direccion=\"" + TbxDireccion.Text + "\",correo=\"" + TbxCorreo.Text + "\",telefono=\"" + TbxTelefono.Text + "\" where ci=" + vector[0] + ";");
                    CargaDatos();
                    BtnEditar.Text = "Editar";
                    BtnCerrar.Text = "Cerrar";
                    TbxCi.Enabled = false;
                    TbxNombre.Enabled = false;
                    TbxApellido.Enabled = false;
                    TbxContraseña.Enabled = false;
                    TbxEdad.Enabled = false;
                    TbxDireccion.Enabled = false;
                    TbxCorreo.Enabled = false;
                    TbxTelefono.Enabled = false;
                }
                else
                    MessageBox.Show("Todos los campos son necesarios, debe de llenarlos todos.");
                
            }
        }
    }
}
