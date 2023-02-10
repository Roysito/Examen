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
   public class ADNT_TCTACTE_TIPO_DOCUMENTO : IADNT_TCTACTE_TIPO_DOCUMENTO<ENT_TCTACTE_TIPO_DOCUMENTO>
    {
        public System.Collections.Generic.List<ENT_TCTACTE_TIPO_DOCUMENTO> getListarTCTACTE_TIPO_DOCUMENTO(int? pIntid_ctacte_tipo_documento)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TCTACTE_TIPO_DOCUMENTO> oTCTACTE_TIPO_DOCUMENTO = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TCTACTE_TIPO_DOCUMENTO";
            CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo_documento", SqlDbType.Int)).Value = pIntid_ctacte_tipo_documento == null || pIntid_ctacte_tipo_documento == 0 ? DBNull.Value : (object)pIntid_ctacte_tipo_documento;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_ctacte_tipo_documento = dtR.GetOrdinal("id_ctacte_tipo_documento");
                int lIntc_ctacte_tipo_documento = dtR.GetOrdinal("c_ctacte_tipo_documento");
                int lIntt_ctacte_tipo_documento = dtR.GetOrdinal("t_ctacte_tipo_documento");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTCTACTE_TIPO_DOCUMENTO = new List<ENT_TCTACTE_TIPO_DOCUMENTO>();
                    while (dtR.Read())
                    {
                        ENT_TCTACTE_TIPO_DOCUMENTO oENT_TCTACTE_TIPO_DOCUMENTO = new ENT_TCTACTE_TIPO_DOCUMENTO();
                        dtR.GetValues (Valores);
                        oENT_TCTACTE_TIPO_DOCUMENTO.id_ctacte_tipo_documento = Convert.IsDBNull(Valores[lIntid_ctacte_tipo_documento]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_ctacte_tipo_documento]);
                        oENT_TCTACTE_TIPO_DOCUMENTO.c_ctacte_tipo_documento = Convert.IsDBNull(Valores[lIntc_ctacte_tipo_documento]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_ctacte_tipo_documento]);
                        oENT_TCTACTE_TIPO_DOCUMENTO.t_ctacte_tipo_documento = Convert.IsDBNull(Valores[lIntt_ctacte_tipo_documento]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_ctacte_tipo_documento]);
                        oTCTACTE_TIPO_DOCUMENTO.Add (oENT_TCTACTE_TIPO_DOCUMENTO);
                    }
                }
            }
            return oTCTACTE_TIPO_DOCUMENTO;
        }
    }
}
