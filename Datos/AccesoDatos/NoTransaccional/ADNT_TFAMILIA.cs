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
   public class ADNT_TFAMILIA : IADNT_TFAMILIA<ENT_TFAMILIA>
    {
        public System.Collections.Generic.List<ENT_TFAMILIA> getListarTFAMILIA(int? pIntid_familia)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TFAMILIA> oTFAMILIA = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TFAMILIA";
            CMD.Parameters.Add(new SqlParameter("@pid_familia", SqlDbType.Int)).Value = pIntid_familia == null || pIntid_familia == 0 ? DBNull.Value : (object)pIntid_familia;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_familia = dtR.GetOrdinal("id_familia");
                int lIntc_familia = dtR.GetOrdinal("c_familia");
                int lIntt_familia = dtR.GetOrdinal("t_familia");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTFAMILIA = new List<ENT_TFAMILIA>();
                    while (dtR.Read())
                    {
                        ENT_TFAMILIA oENT_TFAMILIA = new ENT_TFAMILIA();
                        dtR.GetValues (Valores);
                        oENT_TFAMILIA.id_familia = Convert.IsDBNull(Valores[lIntid_familia]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_familia]);
                        oENT_TFAMILIA.c_familia = Convert.IsDBNull(Valores[lIntc_familia]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_familia]);
                        oENT_TFAMILIA.t_familia = Convert.IsDBNull(Valores[lIntt_familia]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_familia]);
                        oTFAMILIA.Add (oENT_TFAMILIA);
                    }
                }
            }
            return oTFAMILIA;
        }
    }
}
