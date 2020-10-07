using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Capa_Logica;

namespace Pry_WorkshopSena
{
    public partial class Frm_Dependencia : Form
    {
        public Frm_Dependencia()
        {
            InitializeComponent();
        }

        private void BunifuGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        protected void Func_GuardarDependencia()
        {
            ClsInventario Objdependencia = new ClsInventario();
            Objdependencia.descripcion = TxtDescripcion.Text;
            Objdependencia.Nomenclatura = Txt_Asignar.Text;
            Objdependencia.nit_empresa = LblNit.Text;
            Objdependencia.Fun_GuardarDependencias();
            MessageBox.Show("La Dependencia " + TxtDescripcion.Text + " ha sido creado exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Func_GuardarDependencia();
        }
    }
}
