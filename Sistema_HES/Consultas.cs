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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            //armar la query de esta manera: ci, descripcion, medico, hora, fecha, area, sala, estado
            string query = "insert into usuarios values(\"" + TbxCi.Text + "\",\"" + TbxDescripcion.Text + "\",\"" + TbxDoctor.Text + "\",\"" + TbxConsultar.Text + "\",\" pendiente\")";
            //falta definir la fecha, hora y la sala
        }
    }
}
