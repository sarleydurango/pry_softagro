using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using System.Data.SqlClient;

namespace Capa_Logica
{
    public class Cls_OrdenTrabajo
    {
        public string Id, Primer_Nombre, Segundo_nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Rol,sistema,NumeroOr;
        public String regional, solicitud,ambiente,dependencia;
        public int mecanico, electrico, neumatico, locativo, hidraulco, electronico, otro,solicitud2, estado;
        public String prioridad, Codigo_Maquina, tipo_equipo, tipo_actividad, nivel_prioridad, actividad_ejecutar, reporte_tecnico;
        public String nombre_tecnico, No_horas, Valor, observaciones_internas, Fecha_Apertura, Fecha_Cierre;
        public int sw = 0;
        public DataTable dt_regional = new DataTable();
        public DataTable dt_TipoActividad = new DataTable();
        public DataTable dt_NivelPrioridad = new DataTable();
        public DataTable dt_Tecnico = new DataTable();
        public DataTable dt_solicitudes = new DataTable();
        public DataTable dt_ordenT = new DataTable();

        protected void FuncGuardar_odentrabajo()
        {
            ClsConexion ObjConet = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_Guardar_OrdenTrabajo", ObjConet.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo_Maquina", Codigo_Maquina);
            con.Parameters.AddWithValue("@regional", regional);
            con.Parameters.AddWithValue("@solicitud", solicitud);
            con.Parameters.AddWithValue("@fecha_apertura", Fecha_Apertura);
            con.Parameters.AddWithValue("@tipo", tipo_equipo);
            con.Parameters.AddWithValue("@tipo_mantenimiento", tipo_actividad);
            con.Parameters.AddWithValue("@prioridad", prioridad);
            con.Parameters.AddWithValue("@actividad_ejecutar", actividad_ejecutar);
            con.Parameters.AddWithValue("@reporte_tecnico", reporte_tecnico);
            con.Parameters.AddWithValue("@horas", No_horas);
            con.Parameters.AddWithValue("@tecnico", nombre_tecnico);
            con.Parameters.AddWithValue("@valor", Valor);
            con.Parameters.AddWithValue("@mecanico", mecanico);
            con.Parameters.AddWithValue("@electrico", electrico);
            con.Parameters.AddWithValue("@hidraulico", hidraulco);
            con.Parameters.AddWithValue("@neumatico", neumatico);
            con.Parameters.AddWithValue("@locativo", locativo);
            con.Parameters.AddWithValue("@electronico", electronico );
            con.Parameters.AddWithValue("@otro", otro);
            con.Parameters.AddWithValue("@dependencia", dependencia);
            con.Parameters.AddWithValue("@ambiente", ambiente);

            ObjConet.connection.Open();
            con.ExecuteNonQuery();
            ObjConet.connection.Close();
        }

        protected void func_CargarTipoMantenimiento()
        {
            ClsConexion ObjConet =new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarTipoMantenimiento", ObjConet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ObjConet.connection.Open();
            da.Fill(dt_TipoActividad);
            ObjConet.connection.Close();
        }

        protected void FUNC_CargarNivelPrioridad()
        {
            ClsConexion ObjConet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarPrioridad", ObjConet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ObjConet.connection.Open();
            da.Fill(dt_NivelPrioridad);
            ObjConet.connection.Close();
        }
        protected void Func_CargarRegional()
        {
            ClsConexion ObjCoonet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarRegional", ObjCoonet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ObjCoonet.connection.Open();
            da.Fill(dt_regional);
            ObjCoonet.connection.Close();

        }

        protected void Func_GuardarTecnicos()
        {
            ClsConexion ObjConet = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarTecnicos", ObjConet.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", Id);
            con.Parameters.AddWithValue("@primer_nombre", Primer_Nombre);
            con.Parameters.AddWithValue("@primer_apellido", Primer_Apellido);
            con.Parameters.AddWithValue("@telefono", Telefono);
            con.Parameters.AddWithValue("@correo", Correo);
            ObjConet.connection.Open();
            con.ExecuteNonQuery();
            ObjConet.connection.Close();

        }

        protected void Func_CargarTecnicos()
        {
            ClsConexion ObjConnet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarTecnico", ObjConnet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ObjConnet.connection.Open();
            da.Fill(dt_Tecnico);
            ObjConnet.connection.Close();
        }

        protected void Func_CargarSolicitudes()
        {
            ClsConexion ObjConnet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarSolicitudes", ObjConnet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ObjConnet.connection.Open();
            da.Fill(dt_solicitudes);
            ObjConnet.connection.Close();
        }
        protected void Func_NumeroOrdenTrabajo()
        {
            ClsConexion objconnet = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_CargarOrdenTrabajo", objconnet.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo_maquina", Codigo_Maquina);
            objconnet.connection.Open();
            Lectura = con.ExecuteReader(); 
            if(Lectura.Read() == true)
            {
                NumeroOr = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            objconnet.connection.Close();
        }

        protected void Func_Imprimir1()
        {
            ClsConexion objconnet = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ImprimirOrdenTrabajo", objconnet.connection);
            con.Parameters.AddWithValue("@Codigo_Maquina", NumeroOr);
            con.CommandType = CommandType.StoredProcedure;
            objconnet.connection.Open();
            Lectura = con.ExecuteReader();
            if(Lectura.Read() == true)
            {
                regional = Convert.ToString(Lectura[0]);
                dependencia = Convert.ToString(Lectura[1]);
                ambiente = Convert.ToString(Lectura[2]);
                solicitud = Convert.ToString(Lectura[3]);
                Codigo_Maquina = Convert.ToString(Lectura[4]);
                tipo_equipo = Convert.ToString(Lectura[5]);
                tipo_actividad= Convert.ToString(Lectura[6]);
                prioridad = Convert.ToString(Lectura[7]);
                actividad_ejecutar = Convert.ToString(Lectura[8]);
                nombre_tecnico = Convert.ToString(Lectura[9]);
                sw = 1;
            }
            objconnet.connection.Close();
        }

        protected void FuncConsultarOrdenesTrabajo()
        {
            ClsConexion connet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarOrdenTrabajoRealizada", connet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            connet.connection.Open();
            da.Fill(dt_ordenT);
            connet.connection.Close();
        }
        public void Func_ConsultarOt()
        { FuncConsultarOrdenesTrabajo(); }
        public void FuncImprimir()
        { Func_Imprimir1(); }
        public void Func_CargarNumeOrdenImprimir()
        { Func_NumeroOrdenTrabajo(); }
        public void FuncCargarSolicitudes()
        { Func_CargarSolicitudes(); }
        public void FuncCargarTecnicos()
        { Func_CargarTecnicos(); }
        public void FuncGuardarTecnicos()
        { Func_GuardarTecnicos(); }
        public void Func_CargarMantenimiento()
        { func_CargarTipoMantenimiento(); }
        public void FuncCargarPrioridad()
        { FUNC_CargarNivelPrioridad(); }
        public void funcCargarRegional()
        { Func_CargarRegional(); }
        public void FuncGuargarOrdenTrabajo()
        { FuncGuardar_odentrabajo(); }

    }
}
