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
        StreamReader lector = new StreamReader(@"Rol.txt");
        string[] vector;
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            vector = lector.ReadLine().Split(',');
            CargaDatos();
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
                    conexion.SinRetorno("update usuarios set ci=\"" + TbxCi.Text + "\",nombre=\"" + TbxNombre.Text + "\",apellido=\"" + TbxApellido.Text + "\",contraseña=\"" + TbxContraseña.Text + "\",edad=" + TbxEdad.Text + ",direccion=\"" + TbxDireccion.Text + "\",correo=\"" + TbxCorreo.Text + "\",telefono=\"" + TbxTelefono.Text + "\" where ci=" + vector[0] + ";");
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
        void CargaDatos()   //funcion que carga los datos de la persona que tiene abierta la sesion actual
        {
            //armar la asignacion en el sgte orden: ci, nombre, apellido, contraseña, edad, direccion, correo, telefono, rol.
            DataTable tabla = conexion.ObtenerDatos("select * from " + vector[0] + " where ci=" + vector[1]);
            TbxCi.Text = tabla.Rows[0][0].ToString();
            TbxNombre.Text = tabla.Rows[0][1].ToString();
            TbxApellido.Text = tabla.Rows[0][2].ToString();
            TbxContraseña.Text = tabla.Rows[0][3].ToString();
            TbxEdad.Text = tabla.Rows[0][4].ToString();
            TbxDireccion.Text = tabla.Rows[0][5].ToString();
            TbxCorreo.Text = tabla.Rows[0][6].ToString();
            TbxTelefono.Text = tabla.Rows[0][7].ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(BtnCerrar.Text=="Cerrar")
            {
                this.Close();
            }
            else
            {
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
        }
    }
}
