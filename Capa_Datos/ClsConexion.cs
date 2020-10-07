using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace Capa_Datos
{
    public class ClsConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB020OHN;Initial Catalog=DBWOPSA;Integrated Security=True");
    }
}
