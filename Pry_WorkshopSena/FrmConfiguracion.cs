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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        protected void Func_Contraseña()
        {
            ClsLogin ObjContraseña = new ClsLogin();
            ObjContraseña.Usuario = LblUsuario2.Text;
            ObjContraseña.contraseña = TxtConfirmarNueva.Text;
       if((TxtContraseña_An.Text == lblcontraseña2.Text) && (TxtNuevaContra.Text == TxtConfirmarNueva.Text))
            {
                ObjContraseña.Func_Contraseña();
                MessageBox.Show("Su Contraseña  ha sido Actualizada con éxito, Revise su nueva contraseña en su correo electronico", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       else
            {
                MessageBox.Show("Las Contraseñas No Cohinciden", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }
        protected void Func_EnviarCorreo()
        {
            ClsEnviarCorreo ObjCorreo = new ClsEnviarCorreo();
            ObjCorreo.destinatario = lblcorreo2.Text;
            ObjCorreo.asunto = "Cambio de Contraseña";
            ObjCorreo.mensaje = "Sr(a) " + LblNombre2.Text + " \n le informamos que su contraseña ha sido Actualizada exitosamente, su nueva contraseña es .\nContraseña: " + TxtConfirmarNueva.Text +
                "\nFecha: " + DateTime.Now.ToLongDateString() + " Hora: " + DateTime.Now.ToLongTimeString();
            ObjCorreo.Func_Enviar();
        }
        private void Btn_Cambiar_Click(object sender, EventArgs e)
        {
            Func_Contraseña();
            Func_EnviarCorreo();
        }
    }
}
