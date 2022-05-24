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
    public partial class Paciente : Form
    {
        Conexion conexion = new Conexion();
        public Paciente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(TbxCi.Text!="")
            {
                DgwVista.DataSource = conexion.ObtenerDatos("select * from usuarios where ci = " + TbxCi.Text);
            }
        }
    }
}
