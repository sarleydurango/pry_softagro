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
  public  class Cls_Hoja_de_Vida
    {
        public string Codigo, Fecha, Trabajo_Realizado, TP, TM, Costo_material, Costo_manoObra, N_OrdenTrabajo;


        protected void Func_GuardarHojadevida_Maquina()
        {
            ClsConexion connet = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarHojadevida_Maquina", connet.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@cogio_inventario", Codigo);
            con.Parameters.AddWithValue("@fecha", Fecha);
            con.Parameters.AddWithValue("@trabajo_realizado", Trabajo_Realizado);
            con.Parameters.AddWithValue("@TP", TP);
            con.Parameters.AddWithValue("@TM", TM);
            con.Parameters.AddWithValue("@Costo_Material", Costo_material);
            con.Parameters.AddWithValue("@costo_manoObra", Costo_manoObra);
            con.Parameters.AddWithValue("@orden_trabajo", N_OrdenTrabajo);
            connet.connection.Open();
            con.ExecuteNonQuery();
            connet.connection.Close();
         
        }
        public void Func_GenerarHojaVida()
        { Func_GuardarHojadevida_Maquina(); }
    }
}
