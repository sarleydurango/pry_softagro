using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Capa_Logica
{
    public class Cls_Solicitudes
    {
        public int Mecanico, Electrico, Electronico, Locativo, Hidraulico, Neumatico, Otro;
        public string numeroSolicitud, Tipo, TipoMto, Prioridad, Servicio_Solicitado, Diagnostico_Tecnico, Usuario, Regional, Ambiente, Dependencias, Codig_Inven, Nivel,Nombre;
        public int Si, No, Lubricacion, DesgastePorUso, Malreparada, MalOperada, Accidental, Negligencia, Falla_OtroEquipo, Sobrecarga, RepuestosInadecuados;
        public DataTable dtFiltro = new DataTable();
        public DataTable dt_estado = new DataTable();

        public int sw = 0;

        protected void Func_CargarNSolicitud()
        {
            ClsConexion objconnet = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_CargarNSolicitud", objconnet.connection);
            con.CommandType = CommandType.StoredProcedure;
            objconnet.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                numeroSolicitud = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            objconnet.connection.Close();
        }

        protected void Func_GuardarSolicitudes()
        {
            ClsConexion objconnet = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarSolicitud", objconnet.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@tipo", Tipo);
            con.Parameters.AddWithValue("@tipoMto ", TipoMto);
            con.Parameters.AddWithValue("@prioridad", Prioridad);
            con.Parameters.AddWithValue("@servicio_solicitado ", Servicio_Solicitado);
            con.Parameters.AddWithValue("@diagnostico_tecnico ", Diagnostico_Tecnico);
            con.Parameters.AddWithValue("@usuario", Usuario);
            con.Parameters.AddWithValue("@si ", Si);
            con.Parameters.AddWithValue("@no", No);
            con.Parameters.AddWithValue("@Lubricacion", Lubricacion);
            con.Parameters.AddWithValue("@desgaste_uso", DesgastePorUso);
            con.Parameters.AddWithValue("@malReparada", Malreparada);
            con.Parameters.AddWithValue("@malOperada ", MalOperada);
            con.Parameters.AddWithValue("@accidental ", Accidental);
            con.Parameters.AddWithValue("@negligencia", Negligencia);
            con.Parameters.AddWithValue("@fallaOtroEquipo", Falla_OtroEquipo);
            con.Parameters.AddWithValue("@sobrecargar", Sobrecarga);
            con.Parameters.AddWithValue("@repuestosInadecuados", RepuestosInadecuados);
            con.Parameters.AddWithValue("@regional", Regional);
            con.Parameters.AddWithValue("@ambientes", Ambiente);
            con.Parameters.AddWithValue("@dependencia", Dependencias);
            con.Parameters.AddWithValue("@codigo", Codig_Inven);
            con.Parameters.AddWithValue("@mecanico", Mecanico);
            con.Parameters.AddWithValue("@electrico", Electrico);
            con.Parameters.AddWithValue("@hidraulico", Hidraulico);
            con.Parameters.AddWithValue("@neumatico", Neumatico);
            con.Parameters.AddWithValue("@locativo", Locativo);
            con.Parameters.AddWithValue("@electronico", Electronico);
            con.Parameters.AddWithValue("@otro", Otro);
            objconnet.connection.Open();
            con.ExecuteNonQuery();
            objconnet.connection.Close();
        }

        protected void Func_BuscarCodigoMaquina()
        {
            ClsConexion objconnet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_FiltroEquipos", objconnet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@nombre", Nombre);
            objconnet.connection.Open();
            da.Fill(dtFiltro);
            objconnet.connection.Close();
        }

        protected void Func_CargarEstado_Solicitud()
        {
            ClsConexion connet = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarEstadoSolicitud", connet.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            connet.connection.Open();
            da.Fill(dt_estado);
            connet.connection.Close();

        }
        public void Func_CargarEstado_Sol()
        { Func_CargarEstado_Solicitud(); }
        public void Func_CargarCodigo()
        { Func_BuscarCodigoMaquina(); }
        public void Func_GenerarSolicitud()
        { Func_GuardarSolicitudes(); }
        public void Func_CargarSolicitud()
        { Func_CargarNSolicitud(); }
    }
}
