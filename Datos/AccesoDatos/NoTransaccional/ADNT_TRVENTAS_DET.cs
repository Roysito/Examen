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
   public class ADNT_TRVENTAS_DET : IADNT_TRVENTAS_DET<ENT_TRVENTAS_DET>
    {
        public System.Collections.Generic.List<ENT_TRVENTAS_DET> getListarTRVENTAS_DET(string pStrtrvd_empresa,string pStrtrvd_periodo,string pStrtrvd_tipo,string pStrtrvd_registro,int? pInttrvd_nroitm)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TRVENTAS_DET> oTRVENTAS_DET = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TRVENTAS_DET";
            CMD.Parameters.Add(new SqlParameter("@ptrvd_empresa", SqlDbType.VarChar)).Value = pStrtrvd_empresa == null || pStrtrvd_empresa == "" ? DBNull.Value : (object)pStrtrvd_empresa;
            CMD.Parameters.Add(new SqlParameter("@ptrvd_periodo", SqlDbType.VarChar)).Value = pStrtrvd_periodo == null || pStrtrvd_periodo == "" ? DBNull.Value : (object)pStrtrvd_periodo;
            CMD.Parameters.Add(new SqlParameter("@ptrvd_tipo", SqlDbType.VarChar)).Value = pStrtrvd_tipo == null || pStrtrvd_tipo == "" ? DBNull.Value : (object)pStrtrvd_tipo;
            CMD.Parameters.Add(new SqlParameter("@ptrvd_registro", SqlDbType.VarChar)).Value = pStrtrvd_registro == null || pStrtrvd_registro == "" ? DBNull.Value : (object)pStrtrvd_registro;
            CMD.Parameters.Add(new SqlParameter("@ptrvd_nroitm", SqlDbType.Int)).Value = pInttrvd_nroitm == null || pInttrvd_nroitm == 0 ? DBNull.Value : (object)pInttrvd_nroitm;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lInttrvd_empresa = dtR.GetOrdinal("trvd_empresa");
                int lInttrvd_periodo = dtR.GetOrdinal("trvd_periodo");
                int lInttrvd_tipo = dtR.GetOrdinal("trvd_tipo");
                int lInttrvd_registro = dtR.GetOrdinal("trvd_registro");
                int lInttrvd_nroitm = dtR.GetOrdinal("trvd_nroitm");
                int lInttrvd_idarticulo = dtR.GetOrdinal("trvd_idarticulo");
                int lInttrvd_cant = dtR.GetOrdinal("trvd_cant");
                int lInttrvd_preun = dtR.GetOrdinal("trvd_preun");
                int lInttrvd_pdcto = dtR.GetOrdinal("trvd_pdcto");
                int lInttrvd_dcto = dtR.GetOrdinal("trvd_dcto");
                int lInttrvd_vvta = dtR.GetOrdinal("trvd_vvta");
                int lInttrvd_igv = dtR.GetOrdinal("trvd_igv");
                int lInttrvd_tot = dtR.GetOrdinal("trvd_tot");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTRVENTAS_DET = new List<ENT_TRVENTAS_DET>();
                    while (dtR.Read())
                    {
                        ENT_TRVENTAS_DET oENT_TRVENTAS_DET = new ENT_TRVENTAS_DET();
                        dtR.GetValues (Valores);
                        oENT_TRVENTAS_DET.trvd_empresa = Convert.IsDBNull(Valores[lInttrvd_empresa]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrvd_empresa]);
                        oENT_TRVENTAS_DET.trvd_periodo = Convert.IsDBNull(Valores[lInttrvd_periodo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrvd_periodo]);
                        oENT_TRVENTAS_DET.trvd_tipo = Convert.IsDBNull(Valores[lInttrvd_tipo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrvd_tipo]);
                        oENT_TRVENTAS_DET.trvd_registro = Convert.IsDBNull(Valores[lInttrvd_registro]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttrvd_registro]);
                        oENT_TRVENTAS_DET.trvd_nroitm = Convert.IsDBNull(Valores[lInttrvd_nroitm]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrvd_nroitm]);
                        oENT_TRVENTAS_DET.trvd_idarticulo = Convert.IsDBNull(Valores[lInttrvd_idarticulo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttrvd_idarticulo]);
                        oENT_TRVENTAS_DET.trvd_cant = Convert.IsDBNull(Valores[lInttrvd_cant]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_cant]);
                        oENT_TRVENTAS_DET.trvd_preun = Convert.IsDBNull(Valores[lInttrvd_preun]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_preun]);
                        oENT_TRVENTAS_DET.trvd_pdcto = Convert.IsDBNull(Valores[lInttrvd_pdcto]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_pdcto]);
                        oENT_TRVENTAS_DET.trvd_dcto = Convert.IsDBNull(Valores[lInttrvd_dcto]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_dcto]);
                        oENT_TRVENTAS_DET.trvd_vvta = Convert.IsDBNull(Valores[lInttrvd_vvta]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_vvta]);
                        oENT_TRVENTAS_DET.trvd_igv = Convert.IsDBNull(Valores[lInttrvd_igv]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_igv]);
                        oENT_TRVENTAS_DET.trvd_tot = Convert.IsDBNull(Valores[lInttrvd_tot]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lInttrvd_tot]);
                        oTRVENTAS_DET.Add (oENT_TRVENTAS_DET);
                    }
                }
            }
            return oTRVENTAS_DET;
        }
    }
}
