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
    public partial class FrmImpresion : Form
    {
        public FrmImpresion()
        {
            InitializeComponent();
        }

        protected void funcImprimir()
        {
            Cls_OrdenTrabajo objconsultar = new Cls_OrdenTrabajo();
            objconsultar.NumeroOr = LblNumero.Text;
            objconsultar.FuncImprimir();
            if(objconsultar.sw == 1)
            {
                LblCentroRegional.Text = objconsultar.regional;
                LblDependencia.Text = objconsultar.dependencia;
                LblAmbienteAprendizaje.Text = objconsultar.ambiente;
                LblNSolicitud.Text = objconsultar.solicitud;
                LblCodigoIncentario.Text = objconsultar.Codigo_Maquina;
                LblTipoEquipo.Text = objconsultar.tipo_equipo;
                LblTipoActividad.Text = objconsultar.tipo_actividad;
                LblNivelPrioridad.Text = objconsultar.prioridad;
                LblTecnicoEncargado.Text = objconsultar.nombre_tecnico;
                TxtActividadesEjec_PnlOrdenTrabajo.Text = objconsultar.actividad_ejecutar;
                TxtObservacionesInternas.Text = objconsultar.observaciones_internas;
                TxtActividadesEjec_PnlOrdenTrabajo.ReadOnly = true;
                txtReporteTecnico.ReadOnly = true;
            }
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            funcImprimir();
        }

        private void FrmImpresion_Load(object sender, EventArgs e)
        {
            funcImprimir();
        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bap, 0, 0);
        }

        Bitmap bap;

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bap = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ag = Graphics.FromImage(bap);
            ag.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
