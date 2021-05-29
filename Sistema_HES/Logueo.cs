using System.Windows.Forms;

namespace Sistema_HES
{
    public partial class Logueo : Form
    {
        Conexion conexion = new Conexion();
        public Logueo()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            if (conexion.Ini_Sesion(TbxCi.Text, TbxContraseña.Text, LblError))
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
        }

        private void LblRegistrar_Click(object sender, System.EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            //this.Hide();
        }
    }
}
