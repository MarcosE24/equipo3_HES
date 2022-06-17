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
            if (conexion.Ini_Sesion(TbxCi.Text, TbxContraseña.Text, LblError))      // El metodo devuelve un valor booleano en caso de que de false salta el texto de error, si el true entra en el if
            {
                Inicio inicio = new Inicio();                                                                   // Abrimos la ventana
                inicio.Show();
                this.Hide();
            }
        }

        private void LblRegistrar_Click(object sender, System.EventArgs e)
        {
            Registro registro = new Registro();                                                         // Abrimos la ventana para registrar usuario
            registro.Show();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
