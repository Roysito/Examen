using System.Configuration;
using System.Windows.Forms;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Linq;
using CapaAcceosDatos.Interface.NoTransaccional;
namespace CapaAcceosDatos.AccesoDatos.NoTransaccional
{
   public class ADNT_TUNIDAD_MEDIDA : IADNT_TUNIDAD_MEDIDA<ENT_TUNIDAD_MEDIDA>
    {
        public System.Collections.Generic.List<ENT_TUNIDAD_MEDIDA> getListarTUNIDAD_MEDIDA(int? pIntid_unidad_medida)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TUNIDAD_MEDIDA> oTUNIDAD_MEDIDA = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TUNIDAD_MEDIDA";
            CMD.Parameters.Add(new SqlParameter("@pid_unidad_medida", SqlDbType.Int)).Value = pIntid_unidad_medida == null || pIntid_unidad_medida == 0 ? DBNull.Value : (object)pIntid_unidad_medida;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_unidad_medida = dtR.GetOrdinal("id_unidad_medida");
                int lIntc_unidad_medida = dtR.GetOrdinal("c_unidad_medida");
                int lIntt_unidad_medida = dtR.GetOrdinal("t_unidad_medida");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTUNIDAD_MEDIDA = new List<ENT_TUNIDAD_MEDIDA>();
                    while (dtR.Read())
                    {
                        ENT_TUNIDAD_MEDIDA oENT_TUNIDAD_MEDIDA = new ENT_TUNIDAD_MEDIDA();
                        dtR.GetValues (Valores);
                        oENT_TUNIDAD_MEDIDA.id_unidad_medida = Convert.IsDBNull(Valores[lIntid_unidad_medida]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_unidad_medida]);
                        oENT_TUNIDAD_MEDIDA.c_unidad_medida = Convert.IsDBNull(Valores[lIntc_unidad_medida]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_unidad_medida]);
                        oENT_TUNIDAD_MEDIDA.t_unidad_medida = Convert.IsDBNull(Valores[lIntt_unidad_medida]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_unidad_medida]);
                        oTUNIDAD_MEDIDA.Add (oENT_TUNIDAD_MEDIDA);
                    }
                }
            }
            return oTUNIDAD_MEDIDA;
        }
    }
}
