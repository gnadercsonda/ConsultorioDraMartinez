using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsultorioDraMartinez
{
    public partial class OpcAgendarCita : Form
    {
        AccesoDatos.AccesoDatos AD = new AccesoDatos.AccesoDatos();

        public OpcAgendarCita()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string xFecha, xHora, xNombre, xApellido;
            int xDocumento, xCategoria, xEspecialidad, xProfesional;

            xFecha = dtpDate.Value.ToString("yyyy-MM-dd");
            xHora = dtpDate.Value.ToString("HH:mm");
            xNombre = txtName.Text;
            xApellido = txtLasNa.Text;
            xDocumento = Convert.ToInt32(txtId.Text);
            xCategoria = Convert.ToInt32(cmbCateg.Text);
            xEspecialidad = Convert.ToInt32(cmbEspec.Text);
            xProfesional = Convert.ToInt32(cmbProf.Text);

            string conexion = "server=localhost;port=3306;uid=root;pwd='';database=dbconsultorio";
            MySqlConnection conection = new MySqlConnection(conexion);

            try
            {
                conection.Open();

                string insertar = "INSERT INTO citas (fecha_cita, hora_cita, id_paciente, id_profesional, id_especialidad) values(@fecha, @hora, @id_pac, @id_prof, @id_espec)" ;
                MySqlCommand cmd = new MySqlCommand(insertar, conection);

                cmd.Parameters.AddWithValue("@fecha", xFecha);
                cmd.Parameters.AddWithValue("@hora", xHora);
                cmd.Parameters.AddWithValue("@id_pac", xDocumento);
                cmd.Parameters.AddWithValue("@id_prof", xProfesional);
                cmd.Parameters.AddWithValue("@id_espec", xEspecialidad);

                cmd.ExecuteNonQuery();

                conection.Close();

                MessageBox.Show("Se realizó agendamiento exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error controlado" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
    }
}
