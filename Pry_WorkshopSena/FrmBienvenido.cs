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
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }
        protected void Func_Inicio()
        {
            this.Hide();
            //FrmPrincipal ObjInicio = new FrmPrincipal();
            //ObjInicio.ShowDialog();
            FrmPrincipal Objbienvenido = new FrmPrincipal();
            Objbienvenido.Show();
        }
        private void Aparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            BarraCargante.Value += 1;
            if (BarraCargante.Value == 100)
            {
                Aparecer.Stop();
                Animacion.Start();
                Func_Inicio();
            }
        }

        private void Animacion_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {

                Animacion.Stop();
               // this.Close();
            }
        }

        private void FrmBienvenido_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Aparecer.Start();
        }
    }
}
