using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_Logica
{
   public class ClsLogin
    {
        public String Usuario, Contraseña, nombre, contraseña, estado,correo;
        public int rol, sw = 0;
        public SqlCommand con; SqlDataReader Lectura;
        public DataTable dt = new DataTable();

        protected void FuncLogin()
        {

            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Login", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@usuario", Usuario);
            con.Parameters.AddWithValue("@contraseña", contraseña);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                rol = Convert.ToInt32(Lectura[0]);
                Usuario = Convert.ToString(Lectura[1]);
                nombre = Convert.ToString(Lectura[2]);
                contraseña = Convert.ToString(Lectura[3]);
                estado = Convert.ToString(Lectura[4]);
                correo = Convert.ToString(Lectura[5]);
                sw = 1;
            }

        }
        protected void Func_CambiarContraseña()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_CambiarContraseña", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@usuario", Usuario);
            con.Parameters.AddWithValue("@contraseña", contraseña);

            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        public void Func_Contraseña()
        { Func_CambiarContraseña(); }
    
    public void Func_Ingreso()
        { FuncLogin(); }
    }
 
}
