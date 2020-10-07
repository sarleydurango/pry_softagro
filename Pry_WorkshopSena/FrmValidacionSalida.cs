using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_WorkshopSena
{
    public partial class FrmValidacionSalida : Form
    {
        public FrmValidacionSalida()
        {
            InitializeComponent();
        }

        private void Btn_SalirApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_NoApp_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
