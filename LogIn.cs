using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConsultorioDraMartinez
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "server=localhost;port=3306;uid=root;pwd='';database=dbconsultorio";
            MySqlConnection conection = new MySqlConnection(conexion);

            try
            {
                //conection.Open();
                //MessageBox.Show("Conectado exitosamente.");
                //conection.Close();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conectado sin éxito." + ex.Message);
            }
        }
    }
}
