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
    public partial class OrdenTrabajoRealizada : Form
    {
        public OrdenTrabajoRealizada()
        {
            InitializeComponent();
            Func_ConsultarOt();
        }

        protected void Func_ConsultarOt()
        {
            Cls_OrdenTrabajo objorden = new Cls_OrdenTrabajo();
            objorden.Func_ConsultarOt();
            DtgOrdenTrabajoRalizada.DataSource = objorden.dt_ordenT;
        }

        private void DtgOrdenTrabajoRalizada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int fila = DtgOrdenTrabajoRalizada.CurrentRow.Index;
                FrmImpresion objimprimir = new FrmImpresion();
                objimprimir.LblNumero.Text = Convert.ToString(DtgOrdenTrabajoRalizada.Rows[fila].Cells[0].Value);
                objimprimir.Show();
            }
            catch (Exception)

            { }
        }

        private void PtbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
