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
    public partial class Disponibilidad : Form
    {
        Conexion conexion = new Conexion();
        StreamReader archivo = new StreamReader(@"Rol.txt");
        string[] operador;
        public Disponibilidad()
        {
            InitializeComponent();
        }
        private void Disponibilidad_Load(object sender, EventArgs e)
        {
            operador = archivo.ReadLine().Split(',');
            if(conexion.VerificarDato("select * from dias where ci=" + operador[1]))
                DgwVistaDias.DataSource = conexion.ObtenerDatos("select * from dias where ci=" + operador[1]);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (RbtnMatutino.Checked == true)
            {
                Dias("1/2/3/4/5/6/7/8");
            }
            if(RbtnVespertino.Checked==true)
            {
                Dias("9/10/11/12/13/14/15/16");
            }
            if(RbtnDiurno.Checked == true)
            {
                Dias("1/2/3/4/5/6/7/8/9/10/11/12/13/14/15/16");
            }
            if(RbtnOtro.Checked==true)
            {
                int inicio = IndiceHora(CbxHoraInicio.Text);
                int final = IndiceHora(CbxHoraFinal.Text);
                if (inicio < final && inicio > 0 && final > 0)
                {
                    int i;
                    string hora = "";
                    for(i=inicio;i<=final;i++)
                    {
                        hora =hora + i + "/";
                    }
                    Dias(hora);
                }
                else
                    MessageBox.Show("Debe de Elegir un horario acorde, o uno que este en la lista");
            }
        }
        void Dias(string horario)
        {
            if (RbtnLunes.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Lunes) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnMartes.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Martes) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnMiercoles.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Miercoles) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnJueves.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Jueves) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnViernes.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Viernes) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnSabado.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Sabado) values(" + operador[1] + ",\"" + horario + "\";");
            }
            if (RbtnDomingo.Checked == true)
            {
                conexion.SinRetorno("insert into dias(Ci,Domingo) values(" + operador[1] + ",\"" + horario + "\";");
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int IndiceHora(string hora)
        {
            switch(hora)
            {
                case "8:00":
                    return 1;
                case "8:30":
                    return 2;
                case "9:00":
                    return 3;
                case "9:30":
                    return 4;
                case "10:00":
                    return 5;
                case "10:30":
                    return 6;
                case "11:00":
                    return 7;
                case "11:30":
                    return 8;
                case "13:30":
                    return 9;
                case "14:00":
                    return 10;
                case "14:30":
                    return 11;
                case "15:00":
                    return 12;
                case "15:30":
                    return 13;
                case "16:00":
                    return 14;
                case "16:30":
                    return 15;
                case "17:00":
                    return 16;
            }
            return 0;
        }

        private void DgwVistaDias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
