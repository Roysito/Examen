using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion
{
    public class DBCCapaDatos
    {
        #region "Variables"
        public static string pStrConString = ConfigurationManager.ConnectionStrings["CON"].ConnectionString.ToString().Trim();
        public DBCCapaDatos()
        {
            pStrConString = ConfigurationManager.ConnectionStrings["CON"].ConnectionString.ToString().Trim();
        }
        #endregion
    }
}
