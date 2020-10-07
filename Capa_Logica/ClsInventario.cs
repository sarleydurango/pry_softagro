using Capa_Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Logica
{
  public   class ClsInventario
    {
        public String Codigo, Nombre, Caracteristicas, Serie, Tipo, Nivel, Dependencias, Valor, Modelo, Ambientes,ruta1,ruta2,ruta3,ruta4;
        public string descripcion, Nomenclatura, nit_empresa, Descripcion,estado,Nit,Telefono,Correo,Direccion, ContInventario;
        public int sw = 0;
        public DataTable dt_Tipo = new DataTable();
        public DataTable dt_dependencia = new DataTable();
        public DataTable dt_Nivel = new DataTable();
        public DataTable dt_ambiente = new DataTable();
        public DataTable dt_inventario = new DataTable();
        protected void FuncGuardarInventario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarInventario", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", Codigo);
            con.Parameters.AddWithValue("@nombre", Nombre);
            con.Parameters.AddWithValue("@caracteristicas", Caracteristicas);
            con.Parameters.AddWithValue("@Serie", Serie);
            con.Parameters.AddWithValue("@tipo", Tipo);
            con.Parameters.AddWithValue("@nivel", Nivel);
            con.Parameters.AddWithValue("@estado", estado);
            con.Parameters.AddWithValue("@dependencia", Dependencias);
            con.Parameters.AddWithValue("@valor", Valor);
            con.Parameters.AddWithValue("@Modelo", Modelo);
            con.Parameters.AddWithValue("@ambientes", Ambientes);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void FuncActualizarInventario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarInventario", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", Codigo);
            con.Parameters.AddWithValue("@caracteristicas", Caracteristicas);
            con.Parameters.AddWithValue("@tipo", Tipo);
            con.Parameters.AddWithValue("@nivel", Nivel);
            con.Parameters.AddWithValue("@dependencia", Dependencias);
            con.Parameters.AddWithValue("@valor", Valor);
            con.Parameters.AddWithValue("@ambientes", Ambientes);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void FuncBuscarInventario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarInventario", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", Codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
               // Codigo = Convert.ToString(Lectura[0]);
                Nombre = Convert.ToString(Lectura[1]);
                Caracteristicas = Convert.ToString(Lectura[2]);
                Serie = Convert.ToString(Lectura[3]);
                Tipo = Convert.ToString(Lectura[4]);
                Nivel = Convert.ToString(Lectura[5]);
                Dependencias = Convert.ToString(Lectura[7]);
                Valor = Convert.ToString(Lectura[8]);
                Modelo = Convert.ToString(Lectura[9]);
                Ambientes = Convert.ToString(Lectura[10]);
                sw = 1;

            }

            objconect.connection.Close();
        }
        protected void FuncGuardarRegistroFotografico()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarRegistro_Fotografico", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo_Inven", Codigo);
            con.Parameters.AddWithValue("@Ruta1", ruta1);
            con.Parameters.AddWithValue("@Ruta2", ruta2);
            con.Parameters.AddWithValue("@Ruta3", ruta3);
            con.Parameters.AddWithValue("@Ruta4", ruta4);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void FuncCargarRegistroFotografico()
        {
            {
                ClsConexion objconect = new ClsConexion();
                SqlCommand con; SqlDataReader Lectura;
                con = new SqlCommand("SP_ConsltarRegistroFotografico", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo_Maquina", Codigo);
                objconect.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    ruta1 = Convert.ToString(Lectura[0]);
                    ruta2 = Convert.ToString(Lectura[1]);
                    ruta3 = Convert.ToString(Lectura[2]);
                    ruta4 = Convert.ToString(Lectura[3]);
                    sw = 1;

                }

                objconect.connection.Close();
            }
        }
        protected void FuncCargarTipo()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_Tipo", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_Tipo);
            objconexion.connection.Close();
        }
        protected void FuncCargarNivel()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_Nivel", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_Nivel);
            objconexion.connection.Close();
        }
        protected void FuncCargarDependencias()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_Dependencias", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_dependencia);
            objconexion.connection.Close();
        }
        protected void Func_GuardarDependencias()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarDependencias", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@descripcion", descripcion);
            con.Parameters.AddWithValue("@nomenclatura", Nomenclatura);
            con.Parameters.AddWithValue("@nit_empresa", nit_empresa);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void Func_GuardarAmbiente()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_Guardar_Ambientes", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@descripcion", Descripcion);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void FuncCargarAmbientes()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarAmbiente", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_ambiente);
            objconexion.connection.Close();
        }
        protected void FuncCargarDatosInventario()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarDatos_Inventario", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_inventario);
            objconexion.connection.Close();
        }
        protected void Func_BucarEmpresa()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarEmpresa", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Nit", Nit);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Nit = Convert.ToString(Lectura[0]);
                Nombre = Convert.ToString(Lectura[1]);
                Telefono = Convert.ToString(Lectura[2]);
                Correo = Convert.ToString(Lectura[3]);
                Direccion = Convert.ToString(Lectura[4]);
                sw = 1;

            }

            objconect.connection.Close();
        }
        protected void Func_ActualizarEmpresa()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarEmpresa", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Nit", Nit);
            con.Parameters.AddWithValue("@nombre", Nombre);
            con.Parameters.AddWithValue("@telefono", Telefono);
            con.Parameters.AddWithValue("@correo", Correo);
            con.Parameters.AddWithValue("@direccion", Direccion);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }

        protected void Func_Numerode_Inventario()
        {
            {
                ClsConexion objconect = new ClsConexion();
                SqlCommand con; SqlDataReader Lectura;
                con = new SqlCommand("SP_VerNumerode_Inventario", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                objconect.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    ContInventario = Convert.ToString(Lectura[0]);
                    sw = 1;

                }

                objconect.connection.Close();
            }
        }
        /// /////////////////////////////////////////////////////Funciones Publicas///////////////////////////////////////////////////
        
      public void FuncNumeroInventario()
        { Func_Numerode_Inventario(); }
        public void FunActualizarEmpresa()
        { Func_ActualizarEmpresa(); }
        public void FuncBuscarEmpresa()
        { Func_BucarEmpresa(); }
        public void Func_cargarInventario()
        { FuncCargarDatosInventario(); }
        public void Func_CargarAmbiente()
        { FuncCargarAmbientes(); }
        public void Fun_AgregarAmbiente()
        { Func_GuardarAmbiente(); }
        public void Fun_GuardarDependencias()
        { Func_GuardarDependencias();}
        public void FuncGuardarFotos()
        { FuncGuardarRegistroFotografico(); }
        public void FuncConsultarTipo()
        { FuncCargarTipo(); }
        public void FuncConsultarNivel()
        { FuncCargarNivel(); }
        public void funcConsultarDependencias()
        { FuncCargarDependencias(); }
        public void FuncGenerarInventario()
        { FuncGuardarInventario(); }
        public void Func_ActualizarInventario()
        { FuncActualizarInventario(); }
        public void Func_BuscarInventario()
        { FuncBuscarInventario(); }
        public void Func_ConsultarRegistroFotografico()
        { FuncCargarRegistroFotografico();}
    }
}
