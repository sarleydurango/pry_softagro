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
    public partial class FrmCodigoEquipos : Form
    {
        public FrmCodigoEquipos()
        {
            InitializeComponent();
        }

        private void PtbCerrar_Click(object sender, EventArgs e)
        {

        }
        
        protected void Func_CargarEquipos()
        {
            Cls_Solicitudes objequipos = new Cls_Solicitudes();
            objequipos.Nombre = Txt_Nombre.Text;
            objequipos.Func_CargarCodigo();
            DtgCodigoEquipos.DataSource = objequipos.dtFiltro;
        }

        private void Txt_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_CargarEquipos();
            }
        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            Func_CargarEquipos();
        }
    }
}
