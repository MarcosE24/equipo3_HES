using System;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class GestionarMedico : Form
    {
        Conexion conexion = new Conexion();
        int fila;
        
        public GestionarMedico()
        {
            InitializeComponent();
            CargaVista();
        }
        
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (conexion.VerificarDato("select * from medico where Ci = " + TbxCi.Text))
            {
                MessageBox.Show("El Doctor ya esta en la base de datos");
            }
            else
            {
                if (TbxCi.Text != "" && TbxNombre.Text != "" && TbxApellido.Text != "" && CbxEspecialidad.Text != "" && TbxTelefono.Text != "" && TbxSala.Text != "" && CbxEstado.Text != "" && TbxCodigo.Text != "" && TbxCorreo.Text != "" && TbxContraseña.Text != "")
                {
                    string query = "insert into medico values (" + TbxCi.Text + ", \"" + TbxNombre.Text + "\",\"" + TbxApellido.Text + "\",\"" + CbxEspecialidad.Text + "\",\"" + TbxTelefono.Text + "\",\"" + TbxSala.Text + "\",\"" + CbxEstado.Text + "\",\"" + TbxCodigo.Text + "\",\"" + TbxCorreo.Text + "\",\"" + TbxContraseña.Text + "\");";
                    conexion.SinRetorno(query);
                    CargaVista();
                }
                else
                {
                    MessageBox.Show("Es necesario rellenar todos los campos. Por favor verifique y rellene los campos que faltan");
                }
            }
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DgwVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = DgwVista.CurrentRow.Index;
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            if(DgwVista.Rows[fila].Cells[6].Value.ToString()=="Habilitado")
            {
                BtnDesabilitar.Enabled = true;
            }
            else
                BtnHabilitar.Enabled = true;
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BtnEditar.Text == "Editar")
            {
                TbxCi.Text = DgwVista.Rows[fila].Cells[0].Value.ToString();
                TbxNombre.Text = DgwVista.Rows[fila].Cells[1].Value.ToString();
                TbxApellido.Text = DgwVista.Rows[fila].Cells[2].Value.ToString();
                CbxEspecialidad.Text = DgwVista.Rows[fila].Cells[3].Value.ToString();
                TbxTelefono.Text = DgwVista.Rows[fila].Cells[4].Value.ToString();
                TbxSala.Text = DgwVista.Rows[fila].Cells[5].Value.ToString();
                CbxEstado.Text = DgwVista.Rows[fila].Cells[6].Value.ToString();
                TbxCodigo.Text = DgwVista.Rows[fila].Cells[7].Value.ToString();
                TbxCorreo.Text = DgwVista.Rows[fila].Cells[8].Value.ToString();
                TbxContraseña.Text = DgwVista.Rows[fila].Cells[9].Value.ToString();
                BtnAgregar.Enabled = false;
                BtnCancelar.Text = "Cancelar";
                BtnEditar.Text = "Guardar";
                BtnHabilitar.Enabled = false;
                BtnDesabilitar.Enabled = false;
            }
            else
            {
                if(TbxCi.Text != "" && TbxNombre.Text != "" && TbxApellido.Text != "" && CbxEspecialidad.Text != "" && TbxTelefono.Text != "" && TbxSala.Text != "" && CbxEstado.Text != "" && TbxCodigo.Text != "" && TbxCorreo.Text != "" && TbxContraseña.Text != "")
                {
                    conexion.SinRetorno("delete from medico where ci=" + DgwVista.Rows[fila].Cells[0].Value.ToString());
                    conexion.SinRetorno("insert into medico values(" + TbxCi.Text + ", \"" + TbxNombre.Text + "\",\"" + TbxApellido.Text + "\",\"" + CbxEspecialidad.Text + "\",\"" + TbxTelefono.Text + "\"," + TbxSala.Text + ",\"" + CbxEstado.Text + "\",\"" + TbxCodigo.Text + "\",\"" + TbxCorreo.Text + "\",\"" + TbxContraseña.Text + "\";");
                    TbxCi.Text = "";
                    TbxNombre.Text = "";
                    TbxApellido.Text = "";
                    CbxEspecialidad.Text = "";
                    TbxTelefono.Text = "";
                    TbxSala.Text = "";
                    CbxEstado.Text = "";
                    TbxCodigo.Text = "";
                    TbxCorreo.Text = "";
                    TbxContraseña.Text = "";
                    BtnAgregar.Enabled = true;
                    BtnEditar.Enabled = false;
                    BtnHabilitar.Enabled = false;
                    BtnDesabilitar.Enabled = false;
                    BtnCancelar.Text = "Cerrar";
                }
                else
                {
                    MessageBox.Show("Es necesario rellenar todos los campos. Por favor verifique y rellene los campos que faltan");
                }
            }
        }
        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            if(DgwVista.Rows[fila].Cells[6].Value.ToString() == "Deshabilitado")
            {
                conexion.SinRetorno("update medico set estado=\"Habilitado\" where ci=" + DgwVista.Rows[fila].Cells[0].Value.ToString() + ";");
                BtnHabilitar.Enabled = false;
                BtnAgregar.Enabled = true;
                CargaVista();
            }
        }
        private void BtnDesabilitar_Click(object sender, EventArgs e)
        {
            if (DgwVista.Rows[fila].Cells[6].Value.ToString() == "Habilitado")
            {
                conexion.SinRetorno("update medico set estado=\"Deshabilitado\" where ci=" + DgwVista.Rows[fila].Cells[0].Value.ToString() + ";");
                BtnDesabilitar.Enabled = false;
                BtnAgregar.Enabled = true; 
                CargaVista();
            }
        }
        void CargaVista()
        {
            DgwVista.DataSource = conexion.ObtenerDatos("select * from medico;");
        }
    }
}