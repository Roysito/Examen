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
   public class ADNT_TCTACTE : IADNT_TCTACTE<ENT_TCTACTE>
    {
        public System.Collections.Generic.List<ENT_TCTACTE> getListarTCTACTE(int? pIntid_ctacte,string pStrc_ctacte)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TCTACTE> oTCTACTE = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TCTACTE";
            CMD.Parameters.Add(new SqlParameter("@pid_ctacte", SqlDbType.Int)).Value = pIntid_ctacte == null || pIntid_ctacte == 0 ? DBNull.Value : (object)pIntid_ctacte;
            CMD.Parameters.Add(new SqlParameter("@pc_ctacte", SqlDbType.VarChar)).Value = pStrc_ctacte == null || pStrc_ctacte == "" ? DBNull.Value : (object)pStrc_ctacte;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_ctacte = dtR.GetOrdinal("id_ctacte");
                int lIntid_ctacte_tipo = dtR.GetOrdinal("id_ctacte_tipo");
                int lIntc_ctacte = dtR.GetOrdinal("c_ctacte");
                int lIntid_ctacte_tipo_documento = dtR.GetOrdinal("id_ctacte_tipo_documento");
                int lIntc_numero_documento = dtR.GetOrdinal("c_numero_documento");
                int lIntt_ape_pat = dtR.GetOrdinal("t_ape_pat");
                int lIntt_ape_mat = dtR.GetOrdinal("t_ape_mat");
                int lIntt_nombre1 = dtR.GetOrdinal("t_nombre1");
                int lIntt_nombre2 = dtR.GetOrdinal("t_nombre2");
                int lIntt_razon_social = dtR.GetOrdinal("t_razon_social");
                int lIntt_nombre_comercial = dtR.GetOrdinal("t_nombre_comercial");
                int lIntt_cargo = dtR.GetOrdinal("t_cargo");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTCTACTE = new List<ENT_TCTACTE>();
                    while (dtR.Read())
                    {
                        ENT_TCTACTE oENT_TCTACTE = new ENT_TCTACTE();
                        dtR.GetValues (Valores);
                        oENT_TCTACTE.id_ctacte = Convert.IsDBNull(Valores[lIntid_ctacte]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_ctacte]);
                        oENT_TCTACTE.id_ctacte_tipo = Convert.IsDBNull(Valores[lIntid_ctacte_tipo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_ctacte_tipo]);
                        oENT_TCTACTE.c_ctacte = Convert.IsDBNull(Valores[lIntc_ctacte]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_ctacte]);
                        oENT_TCTACTE.id_ctacte_tipo_documento = Convert.IsDBNull(Valores[lIntid_ctacte_tipo_documento]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_ctacte_tipo_documento]);
                        oENT_TCTACTE.c_numero_documento = Convert.IsDBNull(Valores[lIntc_numero_documento]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_numero_documento]);
                        oENT_TCTACTE.t_ape_pat = Convert.IsDBNull(Valores[lIntt_ape_pat]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_ape_pat]);
                        oENT_TCTACTE.t_ape_mat = Convert.IsDBNull(Valores[lIntt_ape_mat]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_ape_mat]);
                        oENT_TCTACTE.t_nombre1 = Convert.IsDBNull(Valores[lIntt_nombre1]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_nombre1]);
                        oENT_TCTACTE.t_nombre2 = Convert.IsDBNull(Valores[lIntt_nombre2]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_nombre2]);
                        oENT_TCTACTE.t_razon_social = Convert.IsDBNull(Valores[lIntt_razon_social]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_razon_social]);
                        oENT_TCTACTE.t_nombre_comercial = Convert.IsDBNull(Valores[lIntt_nombre_comercial]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_nombre_comercial]);
                        oENT_TCTACTE.t_cargo = Convert.IsDBNull(Valores[lIntt_cargo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_cargo]);
                        oTCTACTE.Add (oENT_TCTACTE);
                    }
                }
            }
            return oTCTACTE;
        }
    }
}
