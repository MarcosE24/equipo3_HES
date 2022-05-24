using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class Consultas : Form
    {
        Conexion conexion = new Conexion();
        DateTime tiempo = new DateTime();
        string[] fecha;
        public Consultas()
        {
            InitializeComponent();
            CargarEspecialidad();
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            //armar la query de esta manera: ci, descripcion, medico, hora, fecha, especialidad, sala, estado
            if (TbxCi.Text != "" && CbxHora.Text != "" && TbxFecha.Text != "" && CbxEspecialidad.Text != "")
            {
                string query = "insert into consulta(ci,especialidad,medico,hora,fecha,sala,estado,descripcion) values(" + TbxCi.Text + ",\"" + CbxEspecialidad.Text + "\",\"" + LblDoctor.Text + "\",\"" + CbxHora.Text + "\",\"" + TbxFecha.Text + "\"," + LblSala.Text + ",\"reservado\",\"" + TbxDescripcion.Text + "\");";
                conexion.SinRetorno(query);
            }
            else
                MessageBox.Show("Todos los campos son requeridos");
        }
        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            tiempo = Calendario.SelectionStart;
            if (tiempo>=DateTime.Now.Date)   //solo puede elegir desde la fecha actualen adelante
            {
                //MessageBox.Show("entra");
                fecha = tiempo.ToString().Split(' ');
                TbxFecha.Text = fecha[0];
            }
        }
        void ObtenerHoras(object sender, EventArgs e)
        {
            int i;
            CbxHora.Items.Clear();
            DataTable tabla = conexion.ObtenerDatos("select * from disponibilidad where fecha=\"" + fecha[0] + "\";");
            for (i = 0; i < 16; i++)
            {
                if (tabla.Rows[0][i + 2].ToString() == "libre")
                { 
                    CbxHora.Items.Add(Horas(i + 2));
                }
            }
        }
        void CargarEspecialidad()
        {
            int i;
            DataTable tabla = conexion.ObtenerDatos("select nombre from especialidad;");
            for(i=0;i<tabla.Rows.Count;i++)
            {
                CbxEspecialidad.Items.Add(tabla.Rows[i][0].ToString());
            }
        }
        public string Horas(int i)
        {
            switch(i)
            {
                case 2:
                    return "8:00";
                case 3:
                    return "8:30";
                case 4:
                    return "9:00";
                case 5:
                    return "9:30";
                case 6:
                    return "10:00";
                case 7:
                    return "10:30";
                case 8:
                    return "11:00";
                case 9:
                    return "11:30";
                case 10:
                    return "13:30";
                case 11:
                    return "14:00";
                case 12:
                    return "14:30";
                case 13:
                    return "15:00";
                case 14:
                    return "15:30";
                case 15:
                    return "16:00";
                case 16:
                    return "16:30";
                case 17:
                    return "17:00";
            }
            return null;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
