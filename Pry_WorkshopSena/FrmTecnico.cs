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
using System.IO;


namespace Pry_WorkshopSena
{
    public partial class FrmTecnico : Form
    {
        public FrmTecnico()
        {
            InitializeComponent();
        }

        protected void FuncGuardarTecnicos()
        {
            if (((((TxtIdentificacion.Text == "") || (TxtNombres.Text == "") || (TxtApellidos.Text == "") || (TxtNroTelefono.Text == "") || (TxtCorreo.Text == "")))))
            {
                MessageBox.Show("Debe diligenciar toda la informacion", "Validacion de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cls_OrdenTrabajo ObjTecnicos = new Cls_OrdenTrabajo();
                ObjTecnicos.Id = TxtNroTelefono.Text;
                ObjTecnicos.Primer_Nombre = TxtNombres.Text;
                ObjTecnicos.Primer_Apellido = TxtApellidos.Text;
                ObjTecnicos.Telefono = TxtNroTelefono.Text;
                ObjTecnicos.Correo = TxtCorreo.Text;
                ObjTecnicos.FuncGuardarTecnicos();
                MessageBox.Show("Registro Exitoso", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }


        }

        private void Ptb_Guardar_Click(object sender, EventArgs e)
        {
            FuncGuardarTecnicos();
        }

        protected void Func_Nuevo()
        {
            TxtIdentificacion.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtNroTelefono.Text = "";
            TxtCorreo.Text = "";
        }
        private void Ptb_Nuevo_Click(object sender, EventArgs e)
        {
            Func_Nuevo();
        }
    }
}
