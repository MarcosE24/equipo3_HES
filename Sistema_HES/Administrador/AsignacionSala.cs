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
    
    public partial class AsignacionSala : Form
    {
        Conexion conexion = new Conexion();
        public AsignacionSala()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (CbxDoctor.Text != "" && CbxEspecialidad.Text != "" && TbxCodigo.Text != "" && TbxSala.Text != "")
            {
                string query = "insert into medico values (\"" + CbxDoctor.Text + "\", \"" + CbxEspecialidad.Text + "\",\"" + TbxCodigo.Text + "\",\"" + TbxSala.Text + "\",\" pendiente \")";
                conexion.SinRetorno(query);
            }
            else
            {
                MessageBox.Show("Es necesario rellenar todos los campos. Por favor verifique y rellene los campos que faltan");
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
