using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Sistema_HES
{
    public partial class ModificarConsulta : Form
    {
        Conexion conexion = new Conexion();
        Consultas consultas = new Consultas();
        DateTime tiempo = new DateTime();
        string[] fecha;
        string fechavieja;
        StreamReader lector = new StreamReader(@"Rol.txt");
        string[] operador;
        public ModificarConsulta()
        {
            InitializeComponent();
            operador = lector.ReadLine().Split(',');

        }

        private void ModificarConsulta_Load(object sender, EventArgs e)
        {
            CargaVista();
            DgwListaConsulta.ClearSelection();
            CargarEspecialidad();
        }

        void CargaVista()   //metodo que carga la vista de tabla
        {
            DgwListaConsulta.DataSource = conexion.VistaTabla("select * from consulta where ci="+operador[1]+" and estado=\"reservado\";");
        }
        
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int fila = DgwListaConsulta.CurrentRow.Index;
            if (BtnEditar.Text=="Editar")
            {
                CbxEspecialidad.Text = DgwListaConsulta.Rows[fila].Cells[2].Value.ToString();
                LblMedico.Text = DgwListaConsulta.Rows[fila].Cells[3].Value.ToString();
                TbxFecha.Text = DgwListaConsulta.Rows[fila].Cells[5].Value.ToString();
                CbxHora.Text = DgwListaConsulta.Rows[fila].Cells[4].Value.ToString();
                TbxDescripcion.Text = DgwListaConsulta.Rows[fila].Cells[8].Value.ToString();
                label4.Enabled = true;
                CbxEspecialidad.Enabled = true;
                label3.Enabled = true;
                LblMedico.Enabled = true;
                label2.Enabled = true;
                TbxFecha.Enabled = true;
                label5.Enabled = true;
                CbxHora.Enabled = true;
                label6.Enabled = true;
                TbxDescripcion.Enabled = true;
                BtnCerrar.Text = "Cancelar";
                BtnEditar.Text = "Guardar";
                Calendario.Enabled = true;
                BtnEliminar.Enabled = false;
                fechavieja = TbxFecha.Text;
            }
            else
            {
                if (FechaMargen())
                {
                    if (CbxEspecialidad.Text != "" && TbxFecha.Text != "" && CbxHora.Text != "")
                    {
                        conexion.SinRetorno("update consulta set especialidad=\"" + CbxEspecialidad.Text + "\",medico=\"" + LblMedico.Text + "\",hora=\"" + CbxHora.Text + "\",fecha=\"" + TbxFecha.Text + "\",descripcion=\"" + TbxDescripcion.Text + "\" where codigo=" + DgwListaConsulta.Rows[fila].Cells[0].Value.ToString() + ";");
                        CargaVista();
                        CbxEspecialidad.Text = "";
                        LblMedico.Text = "";
                        TbxFecha.Text = "";
                        CbxHora.Text = "";
                        TbxDescripcion.Text = "";
                        label4.Enabled = false;
                        CbxEspecialidad.Enabled = false;
                        label3.Enabled = false;
                        LblMedico.Enabled = false;
                        label2.Enabled = false;
                        TbxFecha.Enabled = false;
                        label5.Enabled = false;
                        CbxHora.Enabled = false;
                        label6.Enabled = false;
                        TbxDescripcion.Enabled = false;
                        BtnCerrar.Text = "Cerrar";
                        BtnEditar.Text = "Editar";
                        BtnEditar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        Calendario.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Ya no puede cambiar la fecha de la cita una vez que queda menos 48 horas");
            }
        }
        
        private void DgwListaConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(BtnEditar.Enabled != true && BtnEliminar.Enabled != true)
            {
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int fila = DgwListaConsulta.CurrentRow.Index;
            conexion.SinRetorno("delete from consulta where codigo=" + DgwListaConsulta.Rows[fila].Cells[0].Value.ToString());
            CargaVista();
            BtnEliminar.Enabled = false;
            BtnEditar.Enabled = false;
        }

        void CargarEspecialidad()
        {
            int i;
            DataTable tabla = conexion.ObtenerDatos("select nombre from especialidad;");
            for (i = 0; i < tabla.Rows.Count; i++)
            {
                CbxEspecialidad.Items.Add(tabla.Rows[i][0].ToString());
            }
        }

        void ObtenerHoras()
        {
            int i;
            CbxHora.Items.Clear();
            DataTable tabla = conexion.ObtenerDatos("select * from disponibilidad where fecha=\"" + fecha[0] + "\";");
            if(tabla.Rows.Count>=1)
            {
                for (i = 0; i < 16; i++)
                {
                    if (tabla.Rows[0][i + 2].ToString() == "libre")
                    {
                        CbxHora.Items.Add(consultas.Horas(i + 2));
                    }
                }
            }
            else
            {
                for (i = 0; i < 16; i++)
                {
                    CbxHora.Items.Add(consultas.Horas(i + 2));
                }
            }
        }

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            tiempo = Calendario.SelectionStart;
            if (tiempo > DateTime.Now.Date)   //solo puede elegir desde la fecha actual en adelante
            {
                fecha = tiempo.ToString().Split(' ');
                TbxFecha.Text = fecha[0];
                ObtenerHoras();
            }
        }
        
        bool FechaMargen()
        {
            DateTime fecha1 = Convert.ToDateTime(fechavieja.Replace('/', '-') + " 00:00:01");
            TimeSpan fechadif = fecha1 - DateTime.Now;
            if (fechadif.Days >= 2)
                return true;
            return false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
