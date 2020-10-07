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
    public partial class FrmPrincipal : Form
    {
        String folder = Path.Combine(Application.StartupPath, "Img");
        OpenFileDialog file = new OpenFileDialog();
        public String fileName, filename2,filename3,filename4,ruta_default1,ruta_default2,ruta_default3,ruta_defaul4;
        public string nombrefoto;
        
        public FrmPrincipal()
        {
            InitializeComponent();
            Func_Inicio2(); 
            Func_Inicio();
            Func_CargarRol1();
            FuncBuscarNit();
           
        }


        /////////////////////////////////////////////// Cargar Nit De la Empresa//////////////////////////////////////////////////////////7
        protected void FuncBuscarNit()
        {
            ClsUsuario ObjNit = new ClsUsuario();
            ObjNit.func_BuscarNit();
            if (ObjNit.sw == 1)
            {
                LblNit.Text = ObjNit.nit2;
                LblNombreEmpresa.Text = ObjNit.Nombre;
            }

        }



        /// ////////////////////////////////////////////////////// Funcion inicio ///////////////////////////////////////////////////////////////////


        protected void Func_Registrar()
        {
            Pnl_Registro.Visible = true;
            Pnl_Registro.Location = new Point(220, 75);
            Pnl_Registro.Size = new Size(893, 525);
            Btn_Registro.Enabled = false;
            Btn_OrdenTrabajo.Enabled = false;
            Btn_HVMaquinas.Enabled = false;
            Btn_ProgramarMantenimiento.Enabled = false;
            Btn_InventarioGeneral.Enabled = false;
            Btn_Solicitudes.Enabled = false;
            Btn_InventarioGeneral.Enabled = false;
            Ptb_Actualizar_PnlOT.Enabled = false;
            pictureBox9.Enabled = false;
            Btn_Informes.Enabled = false;
            PnlHojadeVida.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_RegistroEmpresa.Visible = false;
            lblUsuario_.Visible = false;
            txtUsuario.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_Registroinventario.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            btnMas_Opciones.Enabled = false;
            Btn_InventarioGeneral.Enabled = false;
            Btn_InventarioRegistrado.Enabled = false;
          
           
        }
     
        protected void Func_PanelEmpresa()
        {
            Pnl_RegistroEmpresa.Visible = true;
            Pnl_RegistroEmpresa.Location = new Point(0, 1);
            Pnl_RegistroEmpresa.Size = new Size(1110, 600);
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_Registroinventario.Visible = false;
        }
        protected void Func_PanelInicio()
        {
            Pnl_InicioSession.Location = new Point(0,0);
            Pnl_InicioSession.Size = new Size(1110, 600);
            Pnl_InicioSession.Visible = true;
        }
        ///////////////////////////////////// Funcion de panel de diseño ///////////////
        protected void Func_DiseñoPanel()
        {
            Pnl_Inicio.Visible = false;
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = true;
            Pnl_Pagina_En_Diseño.Location = new Point(220, 75);
            Pnl_Pagina_En_Diseño.Size = new Size(893, 525);
            Pnl_FrmMiEmpresa.Visible = false;
        }
        //Termina Funcion
        protected void Func_Inicio2()
        {
            ClsUsuario ObjInicio = new ClsUsuario();
            ObjInicio.Func_Iniciar2();
            if (ObjInicio.cant2 > 0)
            {
                Func_Registrar();
            }
            else
            {
                Func_PanelEmpresa();

            }

        }


        protected void Func_Inicio()
        {
            ClsUsuario ObjInicio = new ClsUsuario();
            ObjInicio.Func_Iniciar();
            if (ObjInicio.cant > 0)
            {
                Func_PanelInicio();
            }

        }

        /// /////////////////////////////////////////////////////////////////// Termina Funcion///////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////// Funciones no importantes//////////////////////////////////////////////
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessag(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Rectangle sizeGriprectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        //Fin

        private void PtbCerrar_Click(object sender, EventArgs e)
        {
            FrmValidacionSalida ObjSalir = new FrmValidacionSalida();
            ObjSalir.Show();
        }

        private void PtbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessag(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessag(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        /// /////////////////////////////////////////////////////// termiana funciones no importante////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////////////////////////Panel Registro///////////////////////////////////////////////////////


        protected void FuncPanelRegistroUsuario()
        {
            Pnl_MasOpciones.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_Registroinventario.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
        }
        private void Btn_Registro_Click(object sender, EventArgs e)
        {

            Pnl_Inicio.Visible = false;
            Pnl_Registro.Visible = true;
            Pnl_Registro.Location = new Point(220, 75);
            Pnl_Registro.Size = new Size(893, 525);
            Func_CargarRol1();
            FuncPanelRegistroUsuario();
            ptb_ActualizarUsuario.Enabled = false;
        }
        /// /////////////////////////////////////////////////// Home/////////////////////////////////////////////////
        protected void func_OcultarPanelHOME()
        {
            Pnl_Registro.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Registroinventario.Visible = false;
            Pnl_RegistroEmpresa.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
        }
        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Pnl_Inicio.Visible = true;
            Pnl_Inicio.Location = new Point(220, 75);
            Pnl_Inicio.Size = new Size(893, 525);
            func_OcultarPanelHOME();
        }
        protected void FuncPanelOrdenTrabajo()
        {
            Pnl_Inicio.Visible = false;
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            Pnl_Registroinventario.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            

        }
       
        /// ////////////////////////////////////////////////PANEL ORDEN DE TRABAJO/////////////////////////////////////////////
        
        protected void Func_CargarAmbiente_OrdenTra()
        {
            ClsInventario ObjAmbiente = new ClsInventario();
            ObjAmbiente.Func_CargarAmbiente();
            Cbx_Ambiente2_PnlOrdenTrabajo.DataSource = ObjAmbiente.dt_ambiente;
            Cbx_Ambiente2_PnlOrdenTrabajo.DisplayMember = "Descripcion";
            Cbx_Ambiente2_PnlOrdenTrabajo.ValueMember = "PKId";
        }

        protected void Func_CargarDependencia_OrdenTra()
        {
            ClsInventario ObjDepemdencia = new ClsInventario();
            ObjDepemdencia.funcConsultarDependencias();
            CbxDependencia_PnlOrdenTrabajo.DataSource = ObjDepemdencia.dt_dependencia;
            CbxDependencia_PnlOrdenTrabajo.DisplayMember = "Descripcion";
            CbxDependencia_PnlOrdenTrabajo.ValueMember = "PKId";
        }
        
        protected void FuncCargarTipoEquipo()
        {
            ClsInventario ObjTipo = new ClsInventario();
            ObjTipo.FuncConsultarTipo();
            Cbx_TipoEquipo_PnlOT.DataSource = ObjTipo.dt_Tipo;
            Cbx_TipoEquipo_PnlOT.DisplayMember = "Descripcion";
            Cbx_TipoEquipo_PnlOT.ValueMember = "PKId";

        }

        protected void FuncCargarMantenimiento()
        {
            Cls_OrdenTrabajo ObjMantenimiento = new Cls_OrdenTrabajo();
            ObjMantenimiento.Func_CargarMantenimiento();
            Cbx_TipoAct_PnlOT.DataSource = ObjMantenimiento.dt_TipoActividad;
            Cbx_TipoAct_PnlOT.DisplayMember = "Desacripcion";
            Cbx_TipoAct_PnlOT.ValueMember = "PKId";
        }

        protected void Func_CargarPrioridad()
        {
            Cls_OrdenTrabajo ObjPrioridad = new Cls_OrdenTrabajo();
            ObjPrioridad.FuncCargarPrioridad();
            Cbx_NivelPrioridad_PnlOT.DataSource = ObjPrioridad.dt_NivelPrioridad;
            Cbx_NivelPrioridad_PnlOT.DisplayMember = "Descripcion";
            Cbx_NivelPrioridad_PnlOT.ValueMember = "PKId";

        }

        protected void funcCargarRegional()
        {
            Cls_OrdenTrabajo ObjRegional = new Cls_OrdenTrabajo();
            ObjRegional.funcCargarRegional();
            CbxCentroRegional_PnlOrdenTrabajo.DataSource = ObjRegional.dt_regional;
            CbxCentroRegional_PnlOrdenTrabajo.DisplayMember = "Descripcion";
            CbxCentroRegional_PnlOrdenTrabajo.ValueMember = "PKId";
        }

        private void Btn_OrdenTrabajo_Click(object sender, EventArgs e)
        {
            PNL_OrdenDeTrabajo.Visible = true;
            PNL_OrdenDeTrabajo.Location = new Point(220, 75);
            PNL_OrdenDeTrabajo.Size = new Size(893, 525);
            FuncPanelOrdenTrabajo();
            Func_CargarAmbiente_OrdenTra();
            Func_CargarDependencia_OrdenTra();
            FuncCargarTipoEquipo();
            FuncCargarMantenimiento();
            Func_CargarPrioridad();
            funcCargarRegional();

        }

        /// ////////////////////////////////////////////// Panel Registro///////////////////////////////////////////////////////////////////////////////////////////

        protected void Func_LimpiarControles()
        {
            Txt_Identificacion.Clear();
            Txt_Primer_Nombre.Clear();
            TxtS_Nombre.Clear();
            TxtP_Apellido.Clear();
            TxtS_Apellido.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();
            Txt_Identificacion.ReadOnly = false;
            CbxRol.SelectedIndex = 0;
            txtUsuario.Clear();
            lblUsuario_.Visible = false;
            txtUsuario.Visible = false;
            Txt_Identificacion.Focus();
        }
        protected void Fun_Guardar()
        {
            if (((((Txt_Identificacion.Text == "") || (Txt_Primer_Nombre.Text == "") || (TxtP_Apellido.Text == "") || (TxtTelefono.Text == "") || (TxtCorreo.Text == "") || (TxtDireccion.Text == "")))))
            {
                MessageBox.Show("Debe diligenciar toda la Informacion", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClsUsuario ObjUsuario = new ClsUsuario();
                ObjUsuario.Id = Txt_Identificacion.Text;
                ObjUsuario.Primer_Nombre = Txt_Primer_Nombre.Text;
                ObjUsuario.Segundo_nombre = TxtS_Nombre.Text;
                ObjUsuario.Primer_Apellido = TxtP_Apellido.Text;
                ObjUsuario.Segundo_Apellido = TxtS_Apellido.Text;
                ObjUsuario.Telefono = TxtTelefono.Text;
                ObjUsuario.Correo = TxtCorreo.Text;
                ObjUsuario.Rol = Convert.ToString(CbxRol.SelectedValue);
                ObjUsuario.direccion = TxtDireccion.Text;
                //ObjUsuario.Usuario = TxtUsuario.Text;
                ObjUsuario.Fun_Guardar();
                MessageBox.Show("El usuario " + Txt_Primer_Nombre.Text + " ha sido creado exitosamente Verifique su informacion en el correo digitado", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        protected void Func_EnviarCorreo()
        {
            ClsEnviarCorreo ObjCorreo = new ClsEnviarCorreo();
            ObjCorreo.destinatario = TxtCorreo.Text;
            ObjCorreo.asunto = "Creación de Usuario";
            ObjCorreo.mensaje = "Sr(a) " + Txt_Primer_Nombre.Text + " \n le informamos que su usuario y contraseña han sido creados con éxito.\nUsuario: " + TxtCorreo.Text +
                "\nContraseña: " + Txt_Identificacion.Text +
                "\nFecha: " + DateTime.Now.ToLongDateString() + " Hora: " + DateTime.Now.ToLongTimeString();
            ObjCorreo.Func_Enviar();
        }
        protected void Func_CargarRol1()
        {
            ClsUsuario ObjRol = new ClsUsuario();
            ObjRol.FuncRol();
            CbxRol.DataSource = ObjRol.dt_Rol;
            CbxRol.ValueMember = "PKId";
            CbxRol.DisplayMember = "Descripcion";
        }
        private void PtbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPHostEntry hots = System.Net.Dns.GetHostEntry("www.google.com");
                Func_BuscarPersona();
                Func_EnviarCorreo();
            }
            catch
            {
                MessageBox.Show("El usuario " + Txt_Primer_Nombre.Text + " No pudo ser registrado verifique su conexion a internet", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void PtbNuevo_Click(object sender, EventArgs e)
        {
            Func_LimpiarControles();
        }
        protected void FuncPanelHOJAVmaquinas()
        {
            Pnl_MasOpciones.Visible = false;
            Pnl_Inicio.Visible = false;
            Pnl_Registro.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_Registroinventario.Visible = false;
            Pnl_Inventario.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
        }
        private void Btn_HVMaquinas_Click(object sender, EventArgs e)
        {

            FuncPanelHOJAVmaquinas();
            FunConsultarAmbiente();
            PnlHojadeVida.Visible = true;
            PnlHojadeVida.Location = new Point(220, 75);
            PnlHojadeVida.Size = new Size(893, 525);
        }
        protected void Func_BuscarPersona()
        {
            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.Id = Txt_Identificacion.Text;
            ObjUsuario.Fun_Buscar();
            if (ObjUsuario.sw == 1)
            {
               
                Txt_Primer_Nombre.Text = ObjUsuario.Primer_Nombre;
                TxtS_Nombre.Text = ObjUsuario.Segundo_nombre;
                TxtP_Apellido.Text = ObjUsuario.Primer_Apellido;
                TxtS_Apellido.Text = ObjUsuario.Segundo_Apellido;
                TxtTelefono.Text = ObjUsuario.Telefono;
                TxtCorreo.Text = ObjUsuario.Correo;
                CbxRol.Text = ObjUsuario.Rol;
                TxtDireccion.Text = ObjUsuario.direccion;
                txtUsuario.Text = ObjUsuario.Usuario;
                Txt_Identificacion.ReadOnly = true;

            }
            else
            {
                Fun_Guardar();
            }



        }
        private void Txt_Identificacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FuncBuscarNo_Encuentra();
            }
        }
        protected void FuncBuscarNo_Encuentra()
        {

            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.Id = Txt_Identificacion.Text;
            ObjUsuario.Fun_Buscar();
            if (ObjUsuario.sw == 1)
            {
                Txt_Primer_Nombre.Text = ObjUsuario.Primer_Nombre;
                TxtS_Nombre.Text = ObjUsuario.Segundo_nombre;
                TxtP_Apellido.Text = ObjUsuario.Primer_Apellido;
                TxtS_Apellido.Text = ObjUsuario.Segundo_Apellido;
                TxtTelefono.Text = ObjUsuario.Telefono;
                TxtCorreo.Text = ObjUsuario.Correo;
                CbxRol.Text = ObjUsuario.Rol;
                TxtDireccion.Text = ObjUsuario.direccion;
                txtUsuario.Text = ObjUsuario.Usuario;
                Txt_Identificacion.ReadOnly = true;
                lblUsuario_.Visible = true;
                txtUsuario.Visible = true;
                ptb_ActualizarUsuario.Enabled = true;
            }
            else
            {
                MessageBox.Show("Esta persona no se encuentra registrada", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PictureBox9_Click(object sender, EventArgs e)
        {
            FuncBuscarNo_Encuentra();
        }
        //////////////////////////////////////////////Inicia panel Login /////////////////////////////////////////////////////////////////////////

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtUsuarios_Enter(object sender, EventArgs e)
        {
            if (TxtUsuarios.Text == "Usuario")
            {
                TxtUsuarios.Text = "";
                TxtUsuarios.ForeColor = Color.Black;
            }
        }

        private void TxtUsuarios_Leave(object sender, EventArgs e)
        {
            if (TxtUsuarios.Text == "")
            {
                TxtUsuarios.Text = "Usuario";
                TxtUsuarios.ForeColor = Color.Black;
            }
        }

        private void Ptb_Info_Click(object sender, EventArgs e)
        {

            FrmInfo ObjInfo = new FrmInfo();
            ObjInfo.ShowDialog();
        }

        /// //////////////////////////////////////////////////////////////////Panel Login////////////////////////////////////////////////////////////////////////
        protected void func_ValidarPanelLogin()
        {
            Pnl_Inicio.Visible = true;
            Pnl_Registro.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            Pnl_Inicio.Location = new Point(220, 75);
            Pnl_Inicio.Size = new Size(893, 525);
            Pnl_InicioSession.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Btn_Registro.Enabled = true;
            Btn_HVMaquinas.Enabled = true;
            Btn_OrdenTrabajo.Enabled = true;
            Btn_ProgramarMantenimiento.Enabled = true;
            Btn_Solicitudes.Enabled = true;
            Btn_InventarioGeneral.Enabled = true;
            Btn_Informes.Enabled = true;
            PnlConfiguracion.Visible = false;
            btnMas_Opciones.Enabled = true;
            Btn_InventarioRegistrado.Enabled = true;
        }
        protected void Func_Ingreso()
        {
            ClsLogin ObjLogin = new ClsLogin();
            ObjLogin.Usuario = TxtUsuarios.Text;
            ObjLogin.contraseña = TxtContraseña.Text;
            ObjLogin.Func_Ingreso();
            if (ObjLogin.sw == 1)
            {

                FrmPrincipal ObjMenu = new FrmPrincipal();
                ObjMenu.func_ValidarPanelLogin();
                ObjMenu.LblUsuario.Text = TxtUsuarios.Text;
                ObjMenu.LblNombre.Text = ObjLogin.nombre;
                ObjMenu.lblcontraseña.Text = ObjLogin.contraseña;
                ObjMenu.lblcorreo.Text = ObjLogin.correo;
                ObjMenu.Show();
                Hide();
                if (ObjLogin.rol == 1)
                {
                    func_ValidarPanelLogin();
                }
                if (ObjLogin.rol == 2)
                {
                    ObjMenu.Btn_Registro.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectas", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Func_Ingreso();
        }

        private void TxtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Func_Ingreso();
            }
        }

        /// ///////// Boton cerrar cession///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        protected void Func_CerrarSesion()
        {
            Pnl_InicioSession.Location = new Point(0, 0);
            Pnl_InicioSession.Size = new Size(1110, 600);
            Pnl_InicioSession.Visible = true;
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_Registroinventario.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Func_CerrarSesion();
        }

        ///////////////////////////////////////////////// Termina Panel Login ///////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////// Actualizar Persona ///////////////////////////////////////////////////////////////////////////////////////////

        protected void Func_ActualizarPersona()
        {
            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.Id = Txt_Identificacion.Text;
            ObjUsuario.Primer_Nombre = Txt_Primer_Nombre.Text;
            ObjUsuario.Segundo_nombre = TxtS_Nombre.Text;
            ObjUsuario.Primer_Apellido = TxtP_Apellido.Text;
            ObjUsuario.Segundo_Apellido = TxtS_Apellido.Text;
            ObjUsuario.Telefono = TxtTelefono.Text;
            ObjUsuario.direccion = TxtDireccion.Text;
            ObjUsuario.Func_Actualizar();
            MessageBox.Show("Sus datos han sido actualizados con exito", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //////BOTON ACTUALIZAR PERSONA - FRM REGISTRO
        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Func_ActualizarPersona();
            Func_LimpiarControles();

        }
        ////////////////////////////////Funcion Placeholder Empresa///////////////////////////////////////////////////////////////////////////////////
        private void Ptb_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ptb_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TxtNIT_Enter(object sender, EventArgs e)
        {
            if (TxtNIT.Text == "Número de Identificacion Tributaria")
            {
                TxtNIT.Text = "";
                TxtNIT.ForeColor = Color.DimGray;
            }
        }

        private void TxtNIT_Leave(object sender, EventArgs e)
        {
            if (TxtNIT.Text == "")
            {
                TxtNIT.Text = "Número de Identificacion Tributaria";
                TxtNIT.ForeColor = Color.DimGray;
            }
        }

        private void TxtNombreEmpresa_Enter(object sender, EventArgs e)
        {
            if (TxtNombreEmpresa.Text == "Nombre de la empresa")
            {
                TxtNombreEmpresa.Text = "";
                TxtNombreEmpresa.ForeColor = Color.DimGray;
            }
        }

        private void TxtNombreEmpresa_Leave(object sender, EventArgs e)
        {
            if (TxtNombreEmpresa.Text == "")
            {
                TxtNombreEmpresa.Text = "Nombre de la empresa";
                TxtNombreEmpresa.ForeColor = Color.DimGray;
            }
        }

        private void Txt_TelefonoEmpresa_Enter(object sender, EventArgs e)
        {
            if (Txt_TelefonoEmpresa.Text == "Telefono")
            {
                Txt_TelefonoEmpresa.Text = "";
                Txt_TelefonoEmpresa.ForeColor = Color.DimGray;
            }
        }

        private void Txt_TelefonoEmpresa_Leave(object sender, EventArgs e)
        {
            if (Txt_TelefonoEmpresa.Text == "")
            {
                Txt_TelefonoEmpresa.Text = "Telefono";
                Txt_TelefonoEmpresa.ForeColor = Color.DimGray;
            }
        }

        private void Txt_CorreoInstitucional_Enter(object sender, EventArgs e)
        {
            if (Txt_CorreoInstitucional.Text == "Correo electronico")
            {
                Txt_CorreoInstitucional.Text = "";
                Txt_CorreoInstitucional.ForeColor = Color.DimGray;
            }
        }

        private void Txt_CorreoInstitucional_Leave(object sender, EventArgs e)
        {
            if (Txt_CorreoInstitucional.Text == "")
            {
                Txt_CorreoInstitucional.Text = "Correo electronico";
                Txt_CorreoInstitucional.ForeColor = Color.DimGray;
            }
        }

        private void Txt_DireccionEmpresa_Enter(object sender, EventArgs e)
        {
            if (Txt_DireccionEmpresa.Text == "Direccion")
            {
                Txt_DireccionEmpresa.Text = "";
                Txt_DireccionEmpresa.ForeColor = Color.DimGray;
            }
        }

        private void Txt_DireccionEmpresa_Leave(object sender, EventArgs e)
        {
            if (Txt_DireccionEmpresa.Text == "")
            {
                Txt_DireccionEmpresa.Text = "Direccion";
                Txt_DireccionEmpresa.ForeColor = Color.DimGray;
            }
        }
        /// //////////////////////////////////////////////**Termina Funcion Placeholder Empresa**//////////////////////////////////////////////////////////////////

        /// ////////////////////////////////////////////// Funcion Registrar Empresa//////////////////////////////////////////////////////////////////

        protected void FunGuardarEmpresa()
        {
            if ((((TxtNIT.Text == "") || (TxtNombreEmpresa.Text == "") || (Txt_TelefonoEmpresa.Text == "") || (Txt_CorreoInstitucional.Text == "") || (Txt_DireccionEmpresa.Text == ""))))
            {
                MessageBox.Show("Debe diligenciar toda la Informacion", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClsUsuario ObjEmpresa = new ClsUsuario();
                ObjEmpresa.nit = TxtNIT.Text;
                ObjEmpresa.Nombre = TxtNombreEmpresa.Text;
                ObjEmpresa.Telefono = Txt_TelefonoEmpresa.Text;
                ObjEmpresa.Correo = Txt_CorreoInstitucional.Text;
                ObjEmpresa.direccion = Txt_DireccionEmpresa.Text;
                ObjEmpresa.FuncGuardarEmpresa();
                MessageBox.Show("Su empresa " + TxtNombreEmpresa.Text + " ha sido creado exitosamente", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_RegistrarEmpresa_Click(object sender, EventArgs e)
        {
            FunGuardarEmpresa();
            Func_Inicio2();
        }
        /////////////////////////////////////////////////////////Termina funcion registrar empresa/////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////**INICIA FUNCION CONTROL DE ESCRITURA**/////////////////////////////////////////////////////////

        private void Txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_TelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /////////////////////////////////////////////////////////**TERMINA FUNCION CONTROL DE ESCRITURA**/////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////**AQUI BOTONES INFOROMES, PROGRAMAR/MTTO,INVENTARIO,SOLICITUDES**/////////////////////////////////////////////////////////

        private void Btn_Informes_Click(object sender, EventArgs e)
        {
            Func_DiseñoPanel();
            Func_PanelesProgramarMto();
        }
        
        protected void Func_PanelesProgramarMto()
        {
            Pnl_Inicio.Visible = false;
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            Pnl_Registroinventario.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
        }

        private void Btn_ProgramarMantenimiento_Click(object sender, EventArgs e)
        {
            Func_DiseñoPanel();
            Func_PanelesProgramarMto();
           
            
        }

        /// /////////////////////////////////////////////////////////////// FUNCIONES PANEL INVENTARIO///////////////////////////////////////////////////////////////////////////////////////
        protected void funcConsultarTipo()
        {
            ClsInventario ObjTipo = new ClsInventario();
            ObjTipo.FuncConsultarTipo();
            CbxTipoMaquina.DataSource = ObjTipo.dt_Tipo;
            CbxTipoMaquina.ValueMember = "PKId";
            CbxTipoMaquina.DisplayMember = "Descripcion";
        }

         protected void FuncConsultarNivel1()
        {
          ClsInventario ObjNivel = new ClsInventario();
          ObjNivel.FuncConsultarNivel();
         CbxNivel.DataSource = ObjNivel.dt_Nivel;
         CbxNivel.ValueMember = "PKId";
         CbxNivel.DisplayMember = "Descripcion";

        }
        protected void FuncConsultarDependencias()
        {
          ClsInventario ObjDependencia = new ClsInventario();
          ObjDependencia.funcConsultarDependencias();
          CbxDependecia.DataSource = ObjDependencia.dt_dependencia;
          CbxDependecia.ValueMember = "PKId";
          CbxDependecia.DisplayMember = "Descripcion";
        }

        protected void FunCargarAmbiente()
        {
             
            ClsInventario ObjDependencia = new ClsInventario();
            ObjDependencia.Func_CargarAmbiente();
            CbxAmbienteAprendizaje.DataSource = ObjDependencia.dt_ambiente;
            CbxAmbienteAprendizaje.ValueMember = "PKId";
            CbxAmbienteAprendizaje.DisplayMember = "Descripcion";
        }
        
        protected void FuncNumeroInventario()
        {
            ClsInventario ObjInventario = new ClsInventario();
            ObjInventario.FuncNumeroInventario();
           if(ObjInventario.sw==1)
            {
                LblNroInventario.Text = ObjInventario.ContInventario;
            }
        }

        protected void FuncvalidarInventario()
        {
            Pnl_Registro.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Inventario.Location = new Point(220, 75);
            Pnl_Inventario.Size = new Size(893, 525);
            Pnl_Inventario.Visible = true;
            Pnl_Registroinventario.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_Inicio.Visible = false;
            Pnl_Inicio.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
        }
        private void Btn_InventarioGeneral_Click(object sender, EventArgs e)
        {
            FuncNumeroInventario();
            FuncvalidarInventario();
            funcConsultarTipo();
             FuncConsultarNivel1();
            FuncConsultarDependencias();
            FunCargarAmbiente();
            btn_Fotos.Enabled = false;
        }

        private void Btn_Solicitudes_Click(object sender, EventArgs e)
        {
            Func_DiseñoPanel();
            Func_PanelesProgramarMto();
        }

        private void TxtS_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtP_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtS_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnCambiar_Contraseña_Click(object sender, EventArgs e)
        {
            FrmConfiguracion ObjContraseña = new FrmConfiguracion();
            ClsLogin ObjLogin = new ClsLogin();
            ObjContraseña.LblUsuario2.Text = LblUsuario.Text;
            ObjContraseña.lblcontraseña2.Text = lblcontraseña.Text;
            ObjContraseña.lblcorreo2.Text = lblcorreo.Text;
            ObjContraseña.LblNombre2.Text = LblNombre.Text;
            ObjContraseña.ShowDialog();
        }

        /// ///////////////////////////////////////////////// Listar Registros del Inventario///////////////////////////////////////////////////////////////////////////////////////////

        protected void FuncPanelRegistro_inventario()
        {
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_MasOpciones.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
        }
        private void PtbRegistroinv_Click(object sender, EventArgs e)
        {
            Pnl_Registroinventario.Visible = true;
            Pnl_Registroinventario.Location = new Point(220, 75);
            Pnl_Registroinventario.Size = new Size(893, 525);
            FuncPanelRegistro_inventario();

        }

        private void RegresarInventar_Click(object sender, EventArgs e)
        {
            Pnl_Inventario.Location = new Point(220, 75);
            Pnl_Inventario.Size = new Size(893, 525);
            Pnl_Inventario.Visible = true;
            Pnl_Registroinventario.Visible = false;

        }
        
        private void Ptb_F1_Click(object sender, EventArgs e)
        {
            Ptb_F1.Dispose();
            file.Filter = "Archivos JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
              
                Ptb_F1.Image = Image.FromFile(file.FileName);

            }
           
        }

        private void Ptb_F2_Click(object sender, EventArgs e)
        {
            Ptb_F2.Image.Dispose();
            file.Filter = "Archivos JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Ptb_F2.Image = Image.FromFile(file.FileName);

            }
        }

        private void Ptb_F3_Click(object sender, EventArgs e)
        {
            Ptb_F3.Image.Dispose();
            file.Filter = "Archivos JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Ptb_F3.Image = Image.FromFile(file.FileName);

            }
        }

        private void Ptb_F4_Click(object sender, EventArgs e)
        {
            Ptb_F4.Image.Dispose();
            file.Filter = "Archivos JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Ptb_F4.Image = Image.FromFile(file.FileName);

            }
        }

  
        /// /////////////////////// Registro Fotografico/////////////////
         protected void FuncValidarBotonesMaquina()
        {
            Txt_CodigoPhotoMaquina.Visible = true;
            txtNombreMaquinaFoto.Visible = true;
            Btb_BuscarPhotos.Visible = true;
            Ptb_GuardarPhoto.Visible = true;
            PtbNuevoRegistroMaquina.Visible = true;
            label76.Visible = true;
            label68.Visible = true;
            label77.Visible = true;
            label59.Visible = true;
            Ptb_F1.Enabled = true;
            Ptb_F2.Enabled = true;
            Ptb_F3.Enabled = true;
            Ptb_F4.Enabled = true;
            Btn_Actualizar_Ruta1.Visible = false;
            BtnActualizar_Ruta2.Visible = false;
            Btn_Actulizar_Ruta3.Visible = false;
            BtnActualizar_Ruta4.Visible = false;
            Ptb_Return.Visible = true;

        }
    private void Button3_Click(object sender, EventArgs e)
        {
            Pnl_RegisterPhotography.Location = new Point(220,75);
            Pnl_RegisterPhotography.Size = new Size(893, 525);
            Pnl_RegisterPhotography.Visible = true;
            Pnl_Inventario.Visible = false;
            Pnl_Registro.Visible = false;
            Func_RutaDefaultFotos();
            FuncValidarBotonesMaquina();
            PtbAtras2.Visible = false;

        }
        protected void funcPanelmasOpciones()
        {
            Pnl_Registro.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_Registroinventario.Visible = false;
            PnlHojadeVida.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
        
    }
        private void BtnMas_Opciones_Click(object sender, EventArgs e)
        {
            Pnl_MasOpciones.Visible = true;
            Pnl_MasOpciones.Size = new Size(893, 525);
            Pnl_MasOpciones.Location = new Point(220, 75);
            funcPanelmasOpciones();
  
        }

        protected void Func_PanelInventarioRegistrado()
        {
            Pnl_Inventario.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
            Pnl_Registro.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_MasOpciones.Visible = false;
            Pnl_FrmMiEmpresa.Visible = false;
            PNL_OrdenDeTrabajo.Visible = false;

            
        }
        protected void Func_CargarInventario()
        {
            ClsInventario ObjInventario = new ClsInventario();
            ObjInventario.Func_cargarInventario();
            Dtg_RegistroInventario.DataSource = ObjInventario.dt_inventario;
        }
        private void Btn_InventarioRegistrado_Click(object sender, EventArgs e)
        {
            Pnl_Registroinventario.Visible = true;
            Pnl_Registroinventario.Location = new Point(220, 75);
            Pnl_Registroinventario.Size = new Size(893, 525);
            Func_PanelInventarioRegistrado();
            Func_CargarInventario();
        }

        private void Btn_RegresarRegistro_Click(object sender, EventArgs e)
        {
            Pnl_Inventario.Location = new Point(220, 75);
            Pnl_Inventario.Size = new Size(893, 525);
            Pnl_Inventario.Visible = true;
            Pnl_RegisterPhotography.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PnlConfiguracion.Visible = true;
            Pnl_MasOpciones.Visible = false;
            PnlConfiguracion.Location = new Point(220, 75);
            PnlConfiguracion.Size = new Size(893, 525);
        }
        /////////////////////////////////////////////////////////**AQUI TERMINAN LOS BOTONES**/////////////////////////////////////////////////////////


            ////////////////////////////////  Panel configuracion ////////////////////////////////////////////////////////////////////
            
      
        private void PtbAdd_Dependencia_Click(object sender, EventArgs e)
        {
            Frm_Dependencia ObjDependencia = new Frm_Dependencia();
            ClsUsuario ObjNit = new ClsUsuario();
            ObjDependencia.LblNit.Text = LblNit.Text;
            ObjDependencia.ShowDialog();
        }

        private void PtbCambiar_contraseña_Click(object sender, EventArgs e)
        {
            FrmConfiguracion ObjContraseña = new FrmConfiguracion();
            ClsLogin ObjLogin = new ClsLogin();
            ObjContraseña.LblUsuario2.Text = LblUsuario.Text;
            ObjContraseña.lblcontraseña2.Text = lblcontraseña.Text;
            ObjContraseña.lblcorreo2.Text = lblcorreo.Text;
            ObjContraseña.LblNombre2.Text = LblNombre.Text;
            ObjContraseña.ShowDialog();
        }

        private void Ptb_AddAmbiente_Click(object sender, EventArgs e)
        {
            FrmAmbiente ObjAmbiente = new FrmAmbiente();
            ObjAmbiente.ShowDialog();
        }
        //////////////////////////////////////////// Formulario Inventario ///////////////////////////////////////////////////////////////////
        protected void Func_GuardarInventario()
        {
            if((((Txt_CodigoInventario.Text=="")||(TxtNombreMaquina.Text=="")||(TxtSerieMaquina.Text=="")||(TxtModelo.Text=="")||(TxtCaracteristicas_Maquina.Text==""))))
            {
                MessageBox.Show("Debe diligenciar toda la informacion", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClsInventario ObjInventario = new ClsInventario();
                ObjInventario.Codigo = Txt_CodigoInventario.Text;
                ObjInventario.Nombre = TxtNombreMaquina.Text;
                ObjInventario.Caracteristicas = TxtCaracteristicas_Maquina.Text;
                ObjInventario.Serie = TxtSerieMaquina.Text;
                ObjInventario.Tipo = Convert.ToString(CbxTipoMaquina.SelectedValue);
                ObjInventario.Nivel = Convert.ToString(CbxNivel.SelectedValue);
                ObjInventario.estado = "3";
                ObjInventario.Dependencias = Convert.ToString(CbxDependecia.SelectedValue);
                ObjInventario.Valor = TxtValor_Inventario.Text;
                ObjInventario.Modelo = TxtModelo.Text;
                ObjInventario.Ambientes = Convert.ToString(CbxAmbienteAprendizaje.SelectedValue);
                ObjInventario.FuncGenerarInventario();
                MessageBox.Show("La maquina " + Txt_CodigoInventario.Text + " ha sido creado exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }
        protected void FuncLimpiarControles()
        {
            Txt_CodigoInventario.Clear();
            TxtNombreMaquina.Clear();
            TxtCaracteristicas_Maquina.Clear();
            TxtSerieMaquina.Clear();
            CbxTipoMaquina.SelectedIndex = 0;
            CbxNivel.SelectedIndex = 0;
            CbxDependecia.SelectedIndex = 0;
            TxtValor_Inventario.Clear();
            TxtModelo.Clear();
            CbxAmbienteAprendizaje.SelectedIndex = 0;
            Txt_CodigoInventario.Focus();
            Txt_CodigoInventario.ReadOnly = false;
        }
        protected void Func_ActualizarInventario()
        {
            ClsInventario ObjActualizar = new ClsInventario();
            ObjActualizar.Codigo = Txt_CodigoInventario.Text;
            ObjActualizar.Caracteristicas = TxtCaracteristicas_Maquina.Text;
            ObjActualizar.Tipo = Convert.ToString(CbxTipoMaquina.SelectedValue);
            ObjActualizar.Nivel = Convert.ToString (CbxNivel.SelectedValue);
            ObjActualizar.Dependencias = Convert.ToString(CbxDependecia.SelectedValue);
            ObjActualizar.Valor = TxtValor_Inventario.Text;
            ObjActualizar.Ambientes = Convert.ToString(CbxAmbienteAprendizaje.SelectedValue);
            ObjActualizar.Func_ActualizarInventario();
            MessageBox.Show("La maquina ha sido actualizado exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected void FuncBuscarInventario()
        {
            ClsInventario ObjInventario = new ClsInventario();
            ObjInventario.Codigo = Txt_CodigoInventario.Text;
            ObjInventario.Func_BuscarInventario();
            if (ObjInventario.sw==1)
            {
                TxtNombreMaquina.Text = ObjInventario.Nombre;
                TxtCaracteristicas_Maquina.Text = ObjInventario.Caracteristicas;
                TxtSerieMaquina.Text = ObjInventario.Serie;
                CbxTipoMaquina.SelectedValue = ObjInventario.Tipo;
                CbxNivel.SelectedValue = ObjInventario.Nivel;
                CbxDependecia.SelectedValue = ObjInventario.Dependencias;
                TxtValor_Inventario.Text = ObjInventario.Valor;
                TxtModelo.Text = ObjInventario.Modelo;
                CbxAmbienteAprendizaje.SelectedValue = ObjInventario.Ambientes;
                Txt_CodigoInventario.ReadOnly = true;
                btn_Fotos.Enabled = true;
            }
            else
            {
               // MessageBox.Show("La Maquina no se encuentra inventariada ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Func_GuardarInventario();
            }

        }
        private void PtbGuardarInventario_Click(object sender, EventArgs e)
        {
            Func_CargarInventario();
            FuncBuscarInventario();
            FuncNumeroInventario();
            btn_Fotos.Enabled = true;
        }
        
        private void Ptb_NuevoInventario_Click(object sender, EventArgs e)
        {
            FuncLimpiarControles();
            btn_Fotos.Enabled = false;
        }

        private void Ptb_ActualizarInventario_Click(object sender, EventArgs e)
        {
            Func_ActualizarInventario();
            FuncLimpiarControles();

        }

        private void PtbBuscarMaquina_Click(object sender, EventArgs e)
        {
            FuncBuscarInventario();
            
        }

        private void TxtValor_Inventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNombreMaquina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
       
        /// //////////////////////////////////////// Buscar Nombre y Fotos de la maquina ///////////////////////////////////////////////
        protected void FuncCargarNombreMaquina()
        {
            ClsInventario ObjNombre = new ClsInventario();
            ObjNombre.Codigo = Txt_CodigoPhotoMaquina.Text;
            ObjNombre.Func_BuscarInventario();
            if(ObjNombre.sw==1)
            {
                txtNombreMaquinaFoto.Text = ObjNombre.Nombre;
            }
            else
            {
                MessageBox.Show("La maquina no se encuentra inventariada ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PtbNuevoRegistroMaquina_Click(object sender, EventArgs e)
        {
            Func_RutaDefaultFotos();
            Txt_CodigoPhotoMaquina.Clear();
            txtNombreMaquinaFoto.Clear();
            Btn_Actualizar_Ruta1.Visible = false;
            BtnActualizar_Ruta2.Visible = false;
            Btn_Actulizar_Ruta3.Visible = false;
            BtnActualizar_Ruta4.Visible = false;
        }

        private void Dtg_RegistroInventario_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void Dtg_RegistroInventario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int fila = Dtg_RegistroInventario.CurrentRow.Index;
                ClsInventario ObjFoto = new ClsInventario();
                ObjFoto.Codigo = Convert.ToString(Dtg_RegistroInventario.Rows[fila].Cells[0].Value);
                ObjFoto.Func_ConsultarRegistroFotografico();
                Pnl_RegisterPhotography.Visible = true;
                Pnl_RegisterPhotography.Location = new Point(220, 75);
                Pnl_RegisterPhotography.Size = new Size(893, 525);
                Pnl_Registroinventario.Visible = false;
                string foto, foto2, foto3, foto4;
                foto = ObjFoto.ruta1;
                foto2 = ObjFoto.ruta2;
                foto3 = ObjFoto.ruta3;
                foto4 = ObjFoto.ruta4;
                Ptb_F1.Image = Image.FromFile(foto);
                Ptb_F2.Image = Image.FromFile(foto2);
                Ptb_F3.Image = Image.FromFile(foto3);
                Ptb_F4.Image = Image.FromFile(foto4);
                Txt_CodigoPhotoMaquina.Visible = false;
                txtNombreMaquinaFoto.Visible = false;
                Btb_BuscarPhotos.Visible = false;
                Ptb_GuardarPhoto.Visible = false;
                Btn_Actualizar_Ruta1.Visible = false;
                BtnActualizar_Ruta2.Visible = false;
                Btn_Actulizar_Ruta3.Visible = false;
                BtnActualizar_Ruta4.Visible = false;
                PtbNuevoRegistroMaquina.Visible = false;
                label76.Visible = false;
                label68.Visible = false;
                label77.Visible = false;
                label59.Visible = false;
                Ptb_F1.Enabled = false;
                Ptb_F2.Enabled = false;
                Ptb_F3.Enabled = false;
                Ptb_F4.Enabled = false;
                Btn_Actualizar_Ruta1.Visible = false;
                BtnActualizar_Ruta2.Visible = false;
                Btn_Actulizar_Ruta3.Visible = false;
                BtnActualizar_Ruta4.Visible = false;
                Ptb_Return.Visible = false;
                PtbAtras2.Visible = true;
            }
            catch
            {

            }
        }

        /// /////////////////////////////////////////////////////////////Funcion Actualizar foto desde la carpeta destino////////////////////////////////////
        private void Btn_Actualizar_Ruta1_Click(object sender, EventArgs e)
        {
            Ptb_F1.Image.Dispose();
            String vOrigen = file.FileName;
            String vDestino = folder;
            nombrefoto = Path.GetFileName(Txt_CodigoPhotoMaquina.Text + "-1");
            //MessageBox.Show(nombreArchivo);
            System.IO.File.Copy(vOrigen, vDestino + "/" + nombrefoto + ".jpg", true);
            MessageBox.Show("Su foto ha sido actualizada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        protected void FuncPanelMiempresa()
        {
            Pnl_Registro.Visible = false;
            PnlHojadeVida.Visible = false;
            Pnl_Pagina_En_Diseño.Visible = false;
            Pnl_MasOpciones.Visible = false;
            PnlConfiguracion.Visible = false;
            Pnl_Inventario.Visible = false;
            Pnl_RegisterPhotography.Visible = false;
        }
        private void PtbMi_Empresa_Click(object sender, EventArgs e)
        {
            Pnl_FrmMiEmpresa.Visible = true;
            Pnl_FrmMiEmpresa.Location = new Point(220, 75);
            Pnl_FrmMiEmpresa.Size = new Size(893, 525);
            FuncPanelMiempresa();
            FunBuscarEmpresa();
        }

        protected void Func_ConsultarRegistroFotografico()
        {
            ClsInventario ObjFoto = new ClsInventario();
            ObjFoto.Codigo = Txt_CodigoPhotoMaquina.Text;
            ObjFoto.Func_ConsultarRegistroFotografico();
            if (ObjFoto.sw == 1)
            {
                string foto, foto2, foto3, foto4;
                foto = ObjFoto.ruta1;
                foto2 = ObjFoto.ruta2;
                foto3 = ObjFoto.ruta3;
                foto4 = ObjFoto.ruta4;
                Ptb_F1.Image = Image.FromFile(foto);
                Ptb_F2.Image = Image.FromFile(foto2);
                Ptb_F3.Image = Image.FromFile(foto3);
                Ptb_F4.Image = Image.FromFile(foto4);
                LblRuta1.Text = ObjFoto.ruta1;
                LblRuta2.Text = ObjFoto.ruta2;
                LblRuta3.Text = ObjFoto.ruta3;
                LblRuta4.Text = ObjFoto.ruta4;
                Btn_Actualizar_Ruta1.Visible = true;
                BtnActualizar_Ruta2.Visible = true;
                Btn_Actulizar_Ruta3.Visible = true;
                BtnActualizar_Ruta4.Visible = true;
            }

        }
        private void Btb_BuscarPhotos_Click(object sender, EventArgs e)
        {
            FuncCargarNombreMaquina();
            Func_ConsultarRegistroFotografico();
        }

        private void Ptb_ActualizarEmpresa_Click(object sender, EventArgs e)
        {
            Func_ActializarEmpres();
        }

        private void Ptb_Return_Click(object sender, EventArgs e)
        {
            Pnl_Inventario.Location = new Point(220, 75);
            Pnl_Inventario.Size = new Size(893, 525);
            Pnl_Inventario.Visible = true;
            Pnl_RegisterPhotography.Visible = false;
        }

        private void PtbAtras2_Click(object sender, EventArgs e)
        {

            Pnl_Registroinventario.Location = new Point(220, 75);
            Pnl_Registroinventario.Size = new Size(893, 525);
            Pnl_Registroinventario.Visible = true;
            Pnl_RegisterPhotography.Visible = false;
        }

        private void PtbHome_MiEmpresa_Click(object sender, EventArgs e)
        {
            PnlConfiguracion.Visible = true;
            Pnl_FrmMiEmpresa.Visible = false;
            PnlConfiguracion.Location = new Point(220, 75);
            PnlConfiguracion.Size = new Size(893, 525);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pnl_MasOpciones.Visible = true;
            Pnl_MasOpciones.Size = new Size(893, 525);
            Pnl_MasOpciones.Location = new Point(220, 75);
            funcPanelmasOpciones();
        }

        private void BtnActualizar_Ruta2_Click(object sender, EventArgs e)
        {
            Ptb_F2.Image.Dispose();
            String vOrigen = file.FileName;
            String vDestino = folder;
            nombrefoto = Path.GetFileName(Txt_CodigoPhotoMaquina.Text + "-2");
            //MessageBox.Show(nombreArchivo);
            System.IO.File.Copy(vOrigen, vDestino + "/" + nombrefoto + ".jpg", true);
            MessageBox.Show("Su foto ha sido actualizada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Actulizar_Ruta3_Click(object sender, EventArgs e)
        {
            Ptb_F3.Image.Dispose();
            String vOrigen = file.FileName;
            String vDestino = folder;
            nombrefoto = Path.GetFileName(Txt_CodigoPhotoMaquina.Text + "-3");
            //MessageBox.Show(nombreArchivo);
            System.IO.File.Copy(vOrigen, vDestino + "/" + nombrefoto + ".jpg", true);
            MessageBox.Show("Su foto ha sido actualizada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ptb_F1_Click_1(object sender, EventArgs e)
        {
            Ptb_F1.Image.Dispose();
            file.Filter = "Archivos JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Ptb_F1.Image = Image.FromFile(file.FileName);

            }
        }
        /// ////////////////////////////////// Buscar Hoja de Vida ////////////////////////////////////////////

        protected void Func_BuscarFotohojaDeVida()
        {
            ClsInventario ObjFoto = new ClsInventario();
            ObjFoto.Codigo = TxtCodigoEquipo_PnlHojadeVida.Text;
            ObjFoto.Func_ConsultarRegistroFotografico();
            if (ObjFoto.sw == 1)
            {
                string foto;
                foto = ObjFoto.ruta1;
                Ptb_FotoMaquina_PnlHojadeVida.Image = Image.FromFile(foto);
            }
        }
        
        protected void FunConsultarAmbiente()
        {
            ClsInventario ObjDependencia = new ClsInventario();
            ObjDependencia.Func_CargarAmbiente();
            CbxAmbienteAprendizaje1.DataSource = ObjDependencia.dt_ambiente;
            CbxAmbienteAprendizaje1.ValueMember = "PKId";
            CbxAmbienteAprendizaje1.DisplayMember = "Descripcion";
        }
        protected void Func_BuscarHojadeVida()
        {
            ClsInventario ObjInventario = new ClsInventario();
            ObjInventario.Codigo = TxtCodigoEquipo_PnlHojadeVida.Text;
            ObjInventario.Func_BuscarInventario();
            if (ObjInventario.sw == 1)
            {
                TxtNombreMaquina_PnlHojadeVida.Text = ObjInventario.Nombre;
                CbxAmbienteAprendizaje1.SelectedValue = ObjInventario.Ambientes;
                TxtSerie_PnlHojadeVida.Text = ObjInventario.Serie;
                TxtCostoEquipo_PnlHojadeVida.Text = ObjInventario.Valor;
                TxtModelo_PnlHojadeVida.Text = ObjInventario.Modelo;            }
            else
            {
                MessageBox.Show("La Maquina no se encuentra inventariada ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TxtCodigoEquipo_PnlHojadeVida_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_BuscarHojadeVida();
                Func_BuscarFotohojaDeVida();
            }
        }
       
        /// /////////////////////////////////// Asignar Repuestos Orden de trabajo/////////////////////////////////////////////
       
        private void PtbAsignarFrmRepuestos_PnlOrdenTrabajo_Click(object sender, EventArgs e)
        {
            FrmRepuestos ObjRepuestos = new FrmRepuestos();
            ObjRepuestos.Show();
        }

        private void Ptb_Menu_BarradeControles_Click(object sender, EventArgs e)
        {
            Pnl_MasOpciones.Visible = true;
            Pnl_MasOpciones.Size = new Size(893, 525);
            Pnl_MasOpciones.Location = new Point(220, 75);
            funcPanelmasOpciones();
        }
        protected void Func_GuardarOrdenTrabajo()
        {
            if (((((Txt_CodInventario_PnlOT.Text == "") || (TxtActividadesEjec_PnlOrdenTrabajo.Text == "") || (TxtReporte_PnlOrdenTrabajo.Text == "") || (TxtNroHoras_PnlOrdenTrabajo.Text == "") || (CbxTecnico_Encargado_PnlOrdenTrabajo.Text == "") || (TxtValor_PnlOrdenTrabajo.Text == ""))))) 
            {
                MessageBox.Show("Debe diligenciar toda la información ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cls_OrdenTrabajo ObjordenTrabajo = new Cls_OrdenTrabajo();
                ObjordenTrabajo.Codigo_Maquina = Txt_CodInventario_PnlOT.Text;
                ObjordenTrabajo.regional = Convert.ToString(CbxCentroRegional_PnlOrdenTrabajo.SelectedValue);
                ObjordenTrabajo.solicitud = LblNro_Solicitud.Text;
                ObjordenTrabajo.Fecha_Apertura = Dtp_Apertura_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.Fecha_Cierre = Dtp_Cierre_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.tipo_equipo = Convert.ToString(Cbx_TipoEquipo_PnlOT.SelectedValue);
                ObjordenTrabajo.tipo_actividad = Convert.ToString(Cbx_TipoAct_PnlOT.SelectedValue);
                ObjordenTrabajo.prioridad = Convert.ToString(Cbx_NivelPrioridad_PnlOT.SelectedValue);
                ObjordenTrabajo.actividad_ejecutar = TxtActividadesEjec_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.reporte_tecnico = TxtReporte_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.No_horas = TxtNroHoras_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.nombre_tecnico = CbxTecnico_Encargado_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.Valor = TxtValor_PnlOrdenTrabajo.Text;
                ObjordenTrabajo.mecanico = Check_Mecanico.Text;
                ObjordenTrabajo.electrico = Check_Electronico.Text;
                ObjordenTrabajo.hidraulco = Check_Hidraulico.Text;
                ObjordenTrabajo.neumatico = Check_Neumatico.Text;
                ObjordenTrabajo.locativo = Check_Locativo.Text;
                ObjordenTrabajo.electronico = Check_Electronico.Text;
                ObjordenTrabajo.otro = Check_OtroSistema.Text;
                ObjordenTrabajo.FuncGuargarOrdenTrabajo();
                MessageBox.Show("Su orden de trabaho  ha sido creada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        private void Ptb_Guardar_PnlOT_Click(object sender, EventArgs e)
        {
            Func_GuardarOrdenTrabajo();
        }

        private void Ptb_LoginMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Ptb_CerrarLogin_Click(object sender, EventArgs e)
        {
            FrmValidacionSalida ObjSalir = new FrmValidacionSalida();
            ObjSalir.Show();
        }

        private void BtnActualizar_Ruta4_Click(object sender, EventArgs e)
        {
            Ptb_F4.Image.Dispose();
            String vOrigen = file.FileName;
            String vDestino = folder;
            nombrefoto = Path.GetFileName(Txt_CodigoPhotoMaquina.Text + "-4");
            //MessageBox.Show(nombreArchivo);
            System.IO.File.Copy(vOrigen, vDestino + "/" + nombrefoto + ".jpg", true);
            MessageBox.Show("Su foto ha sido actualizada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// /////////////////////////////////// Guardar Registro Fotografico Maquinas /////////////////////////////////////////////
        protected void FuncGuardarFotos1()
        {
            nombrefoto = Path.GetFileName(Txt_CodigoPhotoMaquina.Text + "-1");
            fileName = Path.Combine(folder,  Txt_CodigoPhotoMaquina.Text + "-1" + ".jpg");
            filename2 = Path.Combine(folder, Txt_CodigoPhotoMaquina.Text + "-2" + ".jpg");
            filename3 = Path.Combine(folder, Txt_CodigoPhotoMaquina.Text + "-3" + ".jpg");
            filename4 = Path.Combine(folder, Txt_CodigoPhotoMaquina.Text + "-4" + ".jpg");
            Ptb_F1.Image.Save(fileName);
            Ptb_F2.Image.Save(filename2);
            Ptb_F3.Image.Save(filename3);
            Ptb_F4.Image.Save(filename4);

        }
        protected void Func_RutaDefaultFotos()
        {
            ruta_default1 = fileName = Path.Combine(folder, "default.png");
            Ptb_F1.Image = Image.FromFile(ruta_default1);
            ruta_default2 = filename2 = Path.Combine(folder, "default.png");
            Ptb_F2.Image = Image.FromFile(ruta_default1);
            ruta_default3 = filename3 = Path.Combine(folder, "default.png");
            Ptb_F3.Image = Image.FromFile(ruta_default3);
            ruta_defaul4 = filename4 = Path.Combine(folder, "default.png");
            Ptb_F4.Image = Image.FromFile(ruta_defaul4);
          
        }
      

        protected void FuncGuardarRegistroFoto()
        {
            ClsInventario ObjFoto = new ClsInventario();
            FuncGuardarFotos1();
            ObjFoto.Codigo = Txt_CodigoPhotoMaquina.Text;
            ObjFoto.ruta1 = fileName;
            ObjFoto.ruta2 = filename2;
            ObjFoto.ruta3 = filename3;
            ObjFoto.ruta4 = filename4;
            ObjFoto.FuncGuardarFotos();
            MessageBox.Show("Registro fotografico Guardado ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void Ptb_GuardarPhoto_Click(object sender, EventArgs e)
        {
            FuncGuardarRegistroFoto();
        }
        protected void FunBuscarEmpresa()
        {
            ClsInventario ObjInventario = new ClsInventario();
            ObjInventario.Nit = LblNit.Text;
            ObjInventario.FuncBuscarEmpresa();
            if (ObjInventario.sw == 1)
            {
                Txt_VerNIT_FrmMiempresa.Text = ObjInventario.Nit;
                Txt_VerEmpresa_FrmMiempresa.Text = ObjInventario.Nombre;
                Txt_VerTelefono_FrmMiEmpresa.Text = ObjInventario.Telefono;
                Txt_VerCorreo_MiEmpresa.Text = ObjInventario.Correo;
                Txt_VerDireccion_FrmMiEmpresa.Text = ObjInventario.Direccion;
            }
        }
        protected void Func_ActializarEmpres()
        {
            ClsInventario ObjActualizar = new ClsInventario();
            ObjActualizar.Nit = Txt_VerNIT_FrmMiempresa.Text;
            ObjActualizar.Nombre = Txt_VerEmpresa_FrmMiempresa.Text;
            ObjActualizar.Telefono = Txt_VerTelefono_FrmMiEmpresa.Text;
            ObjActualizar.Correo = Txt_VerCorreo_MiEmpresa.Text;
            ObjActualizar.Direccion = Txt_VerDireccion_FrmMiEmpresa.Text;
            ObjActualizar.FunActualizarEmpresa();
            MessageBox.Show("La empresa ha sido actualizada exitosamente ", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    } 
}

    

    

