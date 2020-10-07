using Capa_Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Logica
{
    public class ClsUsuario
    {
        public string Id, Primer_Nombre, Segundo_nombre,Primer_Apellido,Segundo_Apellido, Telefono, Correo, Rol, Usuario, direccion,nit, nit2,Nombre;
        public int cant, cant2;
        public DataTable dt_Rol = new DataTable();
        public int sw = 0;

        /// //////////////////////////////////////////////////////////// Func Guardar Persona////////////////////////////////////
        protected void Func_RegistrarUsuario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarPersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", Id);
            con.Parameters.AddWithValue("@primer_nombre", Primer_Nombre);
            con.Parameters.AddWithValue("@segundo_nombre", Segundo_nombre);
            con.Parameters.AddWithValue("@primer_apellido", Primer_Apellido);
            con.Parameters.AddWithValue("@segundo_apellido", Segundo_Apellido);
            con.Parameters.AddWithValue("@telefono", Telefono);
            con.Parameters.AddWithValue("@correo", Correo);
            con.Parameters.AddWithValue("@direccion", direccion);
            con.Parameters.AddWithValue("@rol", Rol);
            con.Parameters.AddWithValue("@empresa", nit2);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        /// /////////////////////////////////////////////////////////////// Funcion Cargar Rol//////////////////////////////////////
        protected void Func_CargarRol()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarRol", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_Rol);
            objconexion.connection.Close();
        }

        /// //////////////////////////////////////////// BUSCAR Persona /////////////////////////////////////////////////////////////
        protected void Func_BuscarPersona()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarPersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", Id);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Primer_Nombre = Convert.ToString(Lectura[0]);
                Segundo_nombre = Convert.ToString(Lectura[1]);
                Primer_Apellido = Convert.ToString(Lectura[2]);
                Segundo_Apellido = Convert.ToString(Lectura[3]);
                Telefono = Convert.ToString(Lectura[4]);
                Correo = Convert.ToString(Lectura[5]);
                direccion = Convert.ToString(Lectura[6]);
                Rol = Convert.ToString(Lectura[8]);
                Usuario = Convert.ToString(Lectura[7]);
                sw = 1;
               
            }
            
            objconect.connection.Close();
        }
       
        /// ////////////////////////////////////////////////////////////////// Validar inicio login//////////////////////////////////////////////////
       
        protected void Func_Inicio2()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Validar_Inicio2", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                cant2 = Convert.ToInt32(Lectura[0]);
                sw = 1;
            }
        }
        
        /// //////////////////////////////////////////////////// validar inicio empresa//////////////////////////////////////////////////////////////
        
        protected void Func_Inicio()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ValidarInicio", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                cant = Convert.ToInt32(Lectura[0]);
                sw = 1;
            }
        }
        ///////////////////////////////////////////////// Actualizar Persona ///////////////////////////////////////////////////////////////////////////////////////////

        protected void fun_ActualizarPersonas()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarPersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", Id);
            con.Parameters.AddWithValue("@primer_nombre", Primer_Nombre);
            con.Parameters.AddWithValue("@segundo_nombre", Segundo_nombre);
            con.Parameters.AddWithValue("@primer_apellido", Primer_Apellido);
            con.Parameters.AddWithValue("@segundo_apellido", Segundo_Apellido);
            con.Parameters.AddWithValue("@telefono", Telefono);
            con.Parameters.AddWithValue("@direccion", direccion);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        
        /// //////////////////////////////////////////////////////////////////////////////// Funcion Registrar Empresa//////////////////////////////////////
       
            protected void Func_RegistrarEmpresa()
        {

            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarEmpresa", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@nit", nit);
            con.Parameters.AddWithValue("@nombre", Nombre);
            con.Parameters.AddWithValue("@telefono", Telefono);
            con.Parameters.AddWithValue("@correo", Correo);
            con.Parameters.AddWithValue("@direccion", direccion);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }

        protected void FuncCargarNit()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_CargarNitEmpresa", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                nit2 = Convert.ToString(Lectura[0]);
                Nombre = Convert.ToString(Lectura[1]);
                sw = 1;
            }
        }

        public void func_BuscarNit()
        { FuncCargarNit(); }

        public void FuncGuardarEmpresa()
        {  Func_RegistrarEmpresa();}
        public void Func_Iniciar2()
        {  Func_Inicio2(); }
        public void Func_Actualizar()
        { fun_ActualizarPersonas(); }
        public void Func_Iniciar()
        { Func_Inicio(); }
        public void Fun_Buscar()
        { Func_BuscarPersona();}
        public void Fun_Guardar()
        { Func_RegistrarUsuario();}
        public void FuncRol()
        {Func_CargarRol();}
    }
}
