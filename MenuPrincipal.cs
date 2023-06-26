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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestCitas_Click(object sender, EventArgs e)
        {
            OpcAgendarCita oAC = new OpcAgendarCita();
            oAC.Show();
        }
    }
}
