using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class GestionSala : Form
    {
        Conexion conexion = new Conexion();
        int fila;
        public GestionSala()
        {
            InitializeComponent();
            CargaVista();
        }
        void CargaVista()
        {
            DgwVista.DataSource = conexion.ObtenerDatos("select * from sala");
        }

        private void DgwVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BtnEditar.Text=="Editar")
            {
                fila = DgwVista.CurrentRow.Index;
                TbxNombre.Text = DgwVista.Rows[fila].Cells[1].Value.ToString();
                TbxArea.Text = DgwVista.Rows[fila].Cells[2].Value.ToString();
                TbxNumero.Text = DgwVista.Rows[fila].Cells[0].Value.ToString();
                BtnEditar.Text = "Guardar";
            }
            else
            {
                if(TbxNumero.Text=="" && TbxNombre.Text=="" && TbxArea.Text=="")
                {
                    conexion.SinRetorno("delete from sala where id=" + DgwVista.Rows[fila].Cells[1].Value.ToString() + " and sala=\"" + DgwVista.Rows[fila].Cells[0].Value.ToString() + "\" and area=\"" + DgwVista.Rows[fila].Cells[2].Value.ToString() + "\";");
                    conexion.SinRetorno("insert into sala values(" + TbxNumero.Text + ",\"" + TbxNombre.Text + "\",\"" + TbxArea.Text + "\";");
                    BtnEditar.Enabled = false;
                    BtnEliminar.Enabled = false;
                    BtnAgregar.Enabled = true;
                    CargaVista();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }    
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.SinRetorno("delete from sala where id=" + DgwVista.Rows[fila].Cells[1].Value.ToString() + " and sala=\"" + DgwVista.Rows[fila].Cells[0].Value.ToString() + "\" and area=\"" + DgwVista.Rows[fila].Cells[2].Value.ToString() + "\";");
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
            CargaVista();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TbxNumero.Text != "" && TbxNombre.Text != "" && TbxArea.Text != "")
            {
                conexion.SinRetorno("insert into sala values(" + TbxNumero.Text + ",\"" + TbxNombre.Text + "\",\"" + TbxArea.Text + "\");");
            }
            CargaVista();
        }

        private void GestionSala_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
