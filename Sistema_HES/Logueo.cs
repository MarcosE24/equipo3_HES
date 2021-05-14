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

            if(conexion.Ini_Sesion(TbxCi.Text, TbxContraseña.Text, LblError))
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
        }

        /*private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool ban = false;   //Bandera para salir del bucle verificacion
            string consulta = "select contraseña from usuarios where nombre=\"" + txtNombre.Text + "\";";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //Abriendo la conexion y realizando la verificacion
            try
            {
                conexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read() || ban == false)
                    {
                        string contraseña = leer.GetString(0);
                        if (contraseña == txtContraseña.Text)
                        {
                            string dato = conn.GuardarDato("select desempeño from usuarios where contraseña=" + contraseña);
                            archivo.WriteLine(dato);
                            ban = true;
                            Inicio inicio = new Inicio();
                            inicio.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show(consulta);
        }*/
    }
}
