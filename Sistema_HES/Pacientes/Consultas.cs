using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace Sistema_HES
{
    public partial class Consultas : Form
    {
        Conexion conexion = new Conexion();
        DateTime tiempo = new DateTime();
        string[] fecha;
        int ci_medico=0;
        
        public Consultas()
        {
            InitializeComponent();
            CargarEspecialidad();
        }

        private void BtnReservar_Click(object sender, EventArgs e)      //Registra una nueva consulta en la tabla consultas
        {
            //armar la query de esta manera: ci, descripcion, medico, hora, fecha, especialidad, sala, estado
            if (TbxCi.Text != "" && CbxHora.Text != "" && TbxFecha.Text != "" && CbxEspecialidad.Text != "")
            {
                string query = "insert into consulta(ci,especialidad,medico,hora,fecha,sala,estado,descripcion) values(" + TbxCi.Text + ",\"" + CbxEspecialidad.Text + "\",\"" + LblDoctor.Text + "\",\"" + CbxHora.Text + "\",\"" + TbxFecha.Text + "\"," + LblSala.Text + ",\"reservado\",\"" + TbxDescripcion.Text + "\");";
                conexion.SinRetorno(query);     //Se lanza la query del insert
            }
            else
                MessageBox.Show("Todos los campos son requeridos");
        }

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)       //Evento que se desencadena la elegir una fecha en el calendario
        {
            if ( ci_medico!= 0)     //primero se debe seleccionar el medico
            {
                tiempo = Calendario.SelectionStart;
                if (tiempo >= DateTime.Now.Date)   //solo puede elegir desde la fecha actual en adelante
                {
                    if (VerificarDias())
                    {
                        fecha = tiempo.ToString().Split(' ');
                        TbxFecha.Text = fecha[0];
                    }
                    else
                        MessageBox.Show("El dia elegido no es un dia habil del medico, por favor, vea la lista a la derecha del calendario");
                }
                else
                    MessageBox.Show("Por favor, seleccione una fecha correcta en adelante");
            }
            else
                MessageBox.Show("Antes de ingresar la fecha, por favor ingrese una especialidad");
        }

        void ObtenerHoras(object sender, EventArgs e)       //
        {
            int i;
            if (conexion.VerificarDato(" select * from disponibilidad where fecha=" + fecha[0]))    //verifica si la fecha ya existe en la tabla, sino exite crea una nueva
            {
                CbxHora.Items.Clear();
                DataTable tabla = conexion.ObtenerDatos("select * from disponibilidad where fecha=\"" + fecha[0] + "\";");
                for (i = 0; i < 16; i++)
                {
                    if (tabla.Rows[0][i + 2].ToString() == "")
                    {
                        CbxHora.Items.Add(Horas(i + 2));
                    }
                }
            }
            else
            {
                conexion.SinRetorno("insert into disponibilidad (fecha, id_medico) values (\"" + fecha[0] + "\"," + ci_medico + ");");
                CbxHora.Items.Clear();
                DataTable tabla = conexion.ObtenerDatos("select * from disponibilidad where fecha=\"" + fecha[0] + "\";");
                for (i = 0; i < 16; i++)
                {
                    if (tabla.Rows[0][i + 2].ToString() == "")
                    {
                        CbxHora.Items.Add(Horas(i + 2));
                    }
                }
            }
        }

        void CargarEspecialidad()   //Carga la especialidad al CbxEspecialidad
        {
            int i;
            DataTable tabla = conexion.ObtenerDatos("select especialidad from medico;");
            for(i=0;i<tabla.Rows.Count;i++)
            {
                CbxEspecialidad.Items.Add(tabla.Rows[i][0].ToString());
            }
        }

        public string Horas(int i)      //Se convierten los numero a horas, fue una idea para establecer la relacion y que guardar en una tabla fuera as facil
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

        private void BtnCerrar_Click(object sender, EventArgs e)        //funcion para el evento de cerrar
        {
            this.Close();
        }

        private void CargaMedicoSala(object sender, EventArgs e)    //Consulta para mostrar el nombre del medico y a que sala pertence
        {
            DataTable tabla = conexion.ObtenerDatos("select nombre, ci, sala from medico where especialidad=\"" + CbxEspecialidad.Text + "\"");
            LblDoctor.Text = tabla.Rows[0][0].ToString();
            LblSala.Text = tabla.Rows[0][2].ToString();
            ci_medico = int.Parse(tabla.Rows[0][1].ToString());
            DiasDisponible();
        }

        private void DiasDisponible()       //Metodo que consulta la tabla de disponibilidad del medico y carga el LbxDias
        {
            int i;
            int j;
            LbxDias.Items.Clear();
            string query = "select * from  dias where Ci=" + ci_medico;
            DataTable tabla = conexion.ObtenerDatos(query);
            if (tabla != null)
            {
                for (i = 0; i < tabla.Rows.Count; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        if(tabla.Rows[i][j].ToString() != "")
                        {
                            LbxDias.Items.Add(Dias(j));
                        }
                    }
                }
            }
        }

        private string Dias(int i)      //Metodo que ayuda a cargar los dias habiles del medico en el LbxDias
        {
            string dias = "";
            switch (i)
            {
                case 2:
                    dias = "lunes";
                    break;
                case 3:
                    dias = "martes";
                    break;
                case 4:
                    dias = "miércoles";
                    break;
                case 5:
                    dias = "jueves";
                    break;
                case 6:
                    dias = "viernes";
                    break;
                case 7:
                    dias = "sábado";
                    break;
                case 8:
                    dias = "domingo";
                    break;
            }
            return dias;
        }

        private bool VerificarDias()        //Metodo que comprueba que el medico trabaje el dia elegido
        {
            int i;
            for (i = 0; i < LbxDias.Items.Count; i++)
            {
                if (tiempo.ToString("dddd", new CultureInfo("es-ES")) == LbxDias.Items[i].ToString())
                    return true;
            }
            return false;
        }
    }
}
