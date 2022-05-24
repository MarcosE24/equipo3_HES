using System;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class Registro : Form
    {
        Conexion conexion = new Conexion();
        public Registro()
        {
            InitializeComponent();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (conexion.VerificarDato("select * from usuarios where ci=" + TbxCi.Text) == false)
            {
                if (TbxCi.Text != "" && TbxNombre.Text != "" && TbxApellido.Text != "" && TbxContraseña.Text != "" && TbxEdad.Text != "" && TbxDireccion.Text != "" && TbxCorreo.Text != "" && TbxTelefono.Text != "")
                {
                    //armar la query en el sgte orden: ci, nombre, apellido, contraseña, edad, direccion, correo, telefono, rol.
                    string query = "insert into usuarios values(\"" + TbxCi.Text + "\",\"" + TbxNombre.Text + "\",\"" + TbxApellido.Text + "\",\"" + TbxContraseña.Text + "\",\"" + TbxEdad.Text + "\",\"" + TbxDireccion.Text + "\",\"" + TbxCorreo.Text + "\",\"" + TbxTelefono.Text + "\",\" paciente\")";
                    conexion.SinRetorno(query);
                    //MessageBox.Show(query);
                }
                else
                    MessageBox.Show("Verifique los campos del Fomulario. Todos los datos son necesarios");
            }
            else
                MessageBox.Show("Sus datos ya estan en la base de datos");
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Logueo logueo = new Logueo();
            logueo.Show();
            this.Hide();
        }
    }
}
