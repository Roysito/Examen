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
   public class ADNT_TCTACTE_TIPO : IADNT_TCTACTE_TIPO<ENT_TCTACTE_TIPO>
    {
        public System.Collections.Generic.List<ENT_TCTACTE_TIPO> getListarTCTACTE_TIPO(int? pIntid_ctacte_tipo)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TCTACTE_TIPO> oTCTACTE_TIPO = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TCTACTE_TIPO";
            CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo", SqlDbType.Int)).Value = pIntid_ctacte_tipo == null || pIntid_ctacte_tipo == 0 ? DBNull.Value : (object)pIntid_ctacte_tipo;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_ctacte_tipo = dtR.GetOrdinal("id_ctacte_tipo");
                int lIntc_ctacte_tipo = dtR.GetOrdinal("c_ctacte_tipo");
                int lIntt_ctacte_tipo = dtR.GetOrdinal("t_ctacte_tipo");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTCTACTE_TIPO = new List<ENT_TCTACTE_TIPO>();
                    while (dtR.Read())
                    {
                        ENT_TCTACTE_TIPO oENT_TCTACTE_TIPO = new ENT_TCTACTE_TIPO();
                        dtR.GetValues (Valores);
                        oENT_TCTACTE_TIPO.id_ctacte_tipo = Convert.IsDBNull(Valores[lIntid_ctacte_tipo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_ctacte_tipo]);
                        oENT_TCTACTE_TIPO.c_ctacte_tipo = Convert.IsDBNull(Valores[lIntc_ctacte_tipo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_ctacte_tipo]);
                        oENT_TCTACTE_TIPO.t_ctacte_tipo = Convert.IsDBNull(Valores[lIntt_ctacte_tipo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_ctacte_tipo]);
                        oTCTACTE_TIPO.Add (oENT_TCTACTE_TIPO);
                    }
                }
            }
            return oTCTACTE_TIPO;
        }
    }
}
