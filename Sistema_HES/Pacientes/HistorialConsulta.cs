using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_HES
{
    public partial class HistorialConsulta : Form
    {
        Conexion conexion = new Conexion();
        StreamReader lector = new StreamReader(@"Rol.txt");
        string[] operador;
        public HistorialConsulta()
        {
            InitializeComponent();
            CargaVista();
        }
        void CargaVista()
        {
            operador = lector.ReadLine().Split(',');
            DgwVista.DataSource = conexion.ObtenerDatos("select * from consulta where ci=" + operador[1]);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
