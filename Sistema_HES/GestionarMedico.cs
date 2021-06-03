using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class GestionarMedico : Form
    {
        Conexion conexion = new Conexion();
        public GestionarMedico()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (conexion.VerificarDato("selec*from medio where Ci = " + TbxCi.Text))
            {
                if (TbxCi.Text != "" && TbxNombre.Text != "" && TbxApellido.Text != "" && CbxEspecialidad.Text != "" && TbxTelefono.Text != "" && CbxSala.Text != "" && CbxEstado.Text != "" && TbxCodigo.Text != "" && TbxCorreo.Text != "")
                {
                    string query = "im=nsert into medico values (\"" + TbxCi.Text + "\", \"" + TbxNombre.Text + "\",\"" + TbxApellido.Text + "\",\"" + CbxEspecialidad.Text + "\",\"" + TbxTelefono.Text + "\",\"" + CbxSala.Text + "\",\"" + CbxEstado.Text + "\",\"" + TbxCodigo.Text + "\",\"" + TbxCorreo.Text + "\",\" pendiente \")";
                    conexion.SinRetorno(query);
                }
                else
                {
                    MessageBox.Show("Es necesario rellenar todos los campos. Por favor verifique y rellene los campos que faltan");
                }


            }
            else
            {
                MessageBox.Show("El Doctor ya esta en la base de datos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Logueo logueo = new Logueo();
            logueo.Show();
            this.Hide();
        }
    }
}
