using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class Pendientes : Form
    {
        Conexion conexion = new Conexion();
        StreamReader lector = new StreamReader(@"Rol.txt");
        string[] operador;
        int fila;
        DataTable tabla;
        public Pendientes()
        {
            InitializeComponent();
            operador = lector.ReadLine().Split(',');
            tabla = conexion.ObtenerDatos("select nombre from medico where ci=" + operador[1]);
            CargaVista();
        }
        void CargaVista()
        {
            DgwVista.DataSource = conexion.ObtenerDatos("select * from consulta where medico=\"" + tabla.Rows[0][0].ToString() + "\";");
        }
        private void DgwVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = DgwVista.CurrentRow.Index;
            BtnAtendido.Enabled = true;
        }
        private void BtnAtendido_Click(object sender, EventArgs e)
        {
            if(tabla!=null)
            {
                conexion.SinRetorno("update consulta set estado= 'atendido' where codigo=" + DgwVista.Rows[fila].Cells[0].Value.ToString());
                CargaVista();
            }
        }
    }
}
