using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Pry_WorkshopSena
{
    public partial class FrmAmbiente : Form
    {
        public FrmAmbiente()
        {
            InitializeComponent();
        }
        protected void Func_AgregarAmbiente()
        {
            ClsInventario ObjAmbiente = new ClsInventario();
            ObjAmbiente.Descripcion = Txt_Asignar.Text;
            ObjAmbiente.Fun_AgregarAmbiente();
            MessageBox.Show("El Ambiente " + Txt_Asignar.Text + " ha sido creado exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_AsignarAmbiente_Click(object sender, EventArgs e)
        {
            Func_AgregarAmbiente();
        }
    }
}
