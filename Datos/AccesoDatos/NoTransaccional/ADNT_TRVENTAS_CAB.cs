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
   public class ADNT_TRVENTAS_CAB : IADNT_TRVENTAS_CAB<ENT_TRVENTAS_CAB>
    {
        public System.Collections.Generic.List<ENT_TRVENTAS_CAB> getListarTRVENTAS_CAB(string pStrtrv_empresa,string pStrtrv_periodo,string pStrtrv_tipo,string pStrtrv_registro)
        {
            SqlConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["CON"].ConnectionString.ToString().Trim());
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TRVENTAS_CAB> oTRVENTAS_CAB = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TRVENTAS_CAB";
            CMD.Parameters.Add(new SqlParameter("@ptrv_empresa", SqlDbType.VarChar)).Value = pStrtrv_empresa == null || pStrtrv_empresa == "" ? DBNull.Value : (object)pStrtrv_empresa;
            CMD.Parameters.Add(new SqlParameter("@ptrv_periodo", SqlDbType.VarChar)).Value = pStrtrv_periodo == null || pStrtrv_periodo == "" ? DBNull.Value : (object)pStrtrv_periodo;
            CMD.Parameters.Add(new SqlParameter("@ptrv_tipo", SqlDbType.VarChar)).Value = pStrtrv_tipo == null || pStrtrv_tipo == "" ? DBNull.Value : (object)pStrtrv_tipo;
            CMD.Parameters.Add(new SqlParameter("@ptrv_registro", SqlDbType.VarChar)).Value = pStrtrv_registro == null || pStrtrv_registro == "" ? DBNull.Value : (object)pStrtrv_registro;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lInttrv_empresa = dtR.GetOrdinal("trv_empresa");
                int lInttrv_periodo = dtR.GetOrdinal("trv_periodo");
                int lInttrv_tipo = dtR.GetOrdinal("trv_tipo");
                int lInttrv_registro = dtR.GetOrdinal("trv_registro");
                int lInttrv_entidad = dtR.GetOrdinal("trv_entidad");
                int lInttrv_idvendedor = dtR.GetOrdinal("trv_idvendedor");
                int lInttrv_idformapago = dtR.GetOrdinal("trv_idformapago");
                int lInttrv_tdoc = dtR.GetOrdinal("trv_tdoc");
                int lInttrv_sdoc = dtR.GetOrdinal("trv_sdoc");
                int lInttrv_ndoc = dtR.GetOrdinal("trv_ndoc");
                int lInttrv_femision = dtR.GetOrdinal("trv_femision");
                int lInttrv_fvencimiento = dtR.GetOrdinal("trv_fvencimiento");
                int lInttrv_moneda = dtR.GetOrdinal("trv_moneda");
                int lInttrv_tcambio = dtR.GetOrdinal("trv_tcambio");
                int lInttrv_dctos = dtR.GetOrdinal("trv_dctos");
                int lInttrv_vventa = dtR.GetOrdinal("trv_vventa");
                int lInttrv_igv = dtR.GetOrdinal("trv_igv");
                int lInttrv_total = dtR.GetOrdinal("trv_total");
                int lInttrv_aigv = dtR.GetOrdinal("trv_aigv");
                int lInttrv_flag = dtR.GetOrdinal("trv_flag");
                int lInttrv_pigv = dtR.GetOrdinal("trv_pigv");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTRVENTAS_CAB = new List<ENT_TRVENTAS_CAB>();
                    while (dtR.Read())
                    {
                        ENT_TRVENTAS_CAB oENT_TRVENTAS_CAB = new ENT_TRVENTAS_CAB();
                        dtR.GetValues (Valores);
                        oENT_TRVENTAS_CAB.trv_empresa = Convert.IsDBNull(Valores[lInttrv_empresa]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_empresa]);
                        oENT_TRVENTAS_CAB.trv_periodo = Convert.IsDBNull(Valores[lInttrv_periodo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_periodo]);
                        oENT_TRVENTAS_CAB.trv_tipo = Convert.IsDBNull(Valores[lInttrv_tipo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_tipo]);
                        oENT_TRVENTAS_CAB.trv_registro = Convert.IsDBNull(Valores[lInttrv_registro]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_registro]);
                        oENT_TRVENTAS_CAB.trv_entidad = Convert.IsDBNull(Valores[lInttrv_entidad]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrv_entidad]);
                        oENT_TRVENTAS_CAB.trv_idvendedor = Convert.IsDBNull(Valores[lInttrv_idvendedor]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrv_idvendedor]);
                        oENT_TRVENTAS_CAB.trv_idformapago = Convert.IsDBNull(Valores[lInttrv_idformapago]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrv_idformapago]);
                        oENT_TRVENTAS_CAB.trv_tdoc = Convert.IsDBNull(Valores[lInttrv_tdoc]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_tdoc]);
                        oENT_TRVENTAS_CAB.trv_sdoc = Convert.IsDBNull(Valores[lInttrv_sdoc]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_sdoc]);
                        oENT_TRVENTAS_CAB.trv_ndoc = Convert.IsDBNull(Valores[lInttrv_ndoc]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_ndoc]);
                        oENT_TRVENTAS_CAB.trv_femision = Convert.IsDBNull(Valores[lInttrv_femision]) == true ? Convert.ToDateTime(null) : Convert.ToDateTime(Valores[lInttrv_femision]);
                        oENT_TRVENTAS_CAB.trv_fvencimiento = Convert.IsDBNull(Valores[lInttrv_fvencimiento]) == true ? Convert.ToDateTime(null) : Convert.ToDateTime(Valores[lInttrv_fvencimiento]);
                        oENT_TRVENTAS_CAB.trv_moneda = Convert.IsDBNull(Valores[lInttrv_moneda]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrv_moneda]);
                        oENT_TRVENTAS_CAB.trv_tcambio = Convert.IsDBNull(Valores[lInttrv_tcambio]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_tcambio]);
                        oENT_TRVENTAS_CAB.trv_dctos = Convert.IsDBNull(Valores[lInttrv_dctos]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_dctos]);
                        oENT_TRVENTAS_CAB.trv_vventa = Convert.IsDBNull(Valores[lInttrv_vventa]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_vventa]);
                        oENT_TRVENTAS_CAB.trv_igv = Convert.IsDBNull(Valores[lInttrv_igv]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_igv]);
                        oENT_TRVENTAS_CAB.trv_total = Convert.IsDBNull(Valores[lInttrv_total]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_total]);
                        oENT_TRVENTAS_CAB.trv_aigv = Convert.IsDBNull(Valores[lInttrv_aigv]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrv_aigv]);
                        oENT_TRVENTAS_CAB.trv_flag = Convert.IsDBNull(Valores[lInttrv_flag]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrv_flag]);
                        oENT_TRVENTAS_CAB.trv_pigv = Convert.IsDBNull(Valores[lInttrv_pigv]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrv_pigv]);
                        oTRVENTAS_CAB.Add (oENT_TRVENTAS_CAB);
                    }
                }
            }
            return oTRVENTAS_CAB;
        }
    }
}
