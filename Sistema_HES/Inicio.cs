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
    public partial class Inicio : Form
    {
        Form FormActivo = null;
        public Inicio()
        {
            InitializeComponent();
            PnlSubConsulta.Visible = false;
            PnlSubMedico.Visible = false;
            PnlSubAdministrar.Visible = false;
        }
        void AbrirFormHijo(Form FormHijo)   //funcion para abrir un form dentro de panel contenedor, cerrando si hay alguno activo
        {
            if(FormActivo!= null)
            {
                FormActivo.Close();
            }
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(FormHijo);
            FormHijo.BringToFront();
            FormHijo.Show();
        }
        void  MostrarSubMenu(Panel SubMenu)     //funcion que muestra un sub menu y lo oculta si esta visible
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        void OcultarSubMenu()   //funcion para ocultar un submenu
        {
            if (PnlSubAdministrar.Visible == true)
                PnlSubAdministrar.Visible = false;
            if (PnlSubConsulta.Visible == true)
                PnlSubConsulta.Visible = false;
            if (PnlSubMedico.Visible == true)
                PnlSubMedico.Visible = false;
        }
        private void BtnConsulta_Click(object sender, EventArgs e)  //evento que muestra u oculta el submenu de consulta
        {
            MostrarSubMenu(PnlSubConsulta);
        }
        private void BtnAgenda_Click(object sender, EventArgs e)    //evento que muestra u oculta el submenu de medico
        {
            MostrarSubMenu(PnlSubMedico);
        }
        private void BtnAdministrar_Click(object sender, EventArgs e)   //evento que muestra u oculta el submenu de administracion
        {
            MostrarSubMenu(PnlSubAdministrar);
        }
        private void BtnNuevoConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultas());
        }
        private void BtnModificarConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ModificarConsulta());
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevoMedico_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditarMedico_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Disponibilidad());
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminMedico_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestionarMedico());
        }

        private void BtnSala_Click(object sender, EventArgs e)
        {

        }

        private void BtnSistema_Click(object sender, EventArgs e)
        {

        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ModificarUsuario());
        }
    }
}