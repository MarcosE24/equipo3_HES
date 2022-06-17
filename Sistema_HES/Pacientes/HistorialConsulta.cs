using System;
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
        
        void CargaVista()       //carga el DgwVista con los datos obtenidos por el query
        {
            operador = lector.ReadLine().Split(',');
            DgwVista.DataSource = conexion.ObtenerDatos("select * from consulta where ci=" + operador[1]);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)        //funcion para cerrar formulario
        {
            this.Close();
        }
    }
}
