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
   public class ADNT_TDOCUMENTOS_SERIES : IADNT_TDOCUMENTOS_SERIES<ENT_TDOCUMENTOS_SERIES>
    {
        public System.Collections.Generic.List<ENT_TDOCUMENTOS_SERIES> getListarTDOCUMENTOS_SERIES(string pStrtdocs_empresa,string pStrtdocs_codigo,string pStrtdocs_serie)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TDOCUMENTOS_SERIES> oTDOCUMENTOS_SERIES = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TDOCUMENTOS_SERIES";
            CMD.Parameters.Add(new SqlParameter("@ptdocs_empresa", SqlDbType.VarChar)).Value = pStrtdocs_empresa == null || pStrtdocs_empresa == "" ? DBNull.Value : (object)pStrtdocs_empresa;
            CMD.Parameters.Add(new SqlParameter("@ptdocs_codigo", SqlDbType.VarChar)).Value = pStrtdocs_codigo == null || pStrtdocs_codigo == "" ? DBNull.Value : (object)pStrtdocs_codigo;
            CMD.Parameters.Add(new SqlParameter("@ptdocs_serie", SqlDbType.VarChar)).Value = pStrtdocs_serie == null || pStrtdocs_serie == "" ? DBNull.Value : (object)pStrtdocs_serie;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lInttdocs_empresa = dtR.GetOrdinal("tdocs_empresa");
                int lInttdocs_codigo = dtR.GetOrdinal("tdocs_codigo");
                int lInttdocs_serie = dtR.GetOrdinal("tdocs_serie");
                int lInttdocs_numerador = dtR.GetOrdinal("tdocs_numerador");
                int lInttdocs_serie_predeterminada = dtR.GetOrdinal("tdocs_serie_predeterminada");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTDOCUMENTOS_SERIES = new List<ENT_TDOCUMENTOS_SERIES>();
                    while (dtR.Read())
                    {
                        ENT_TDOCUMENTOS_SERIES oENT_TDOCUMENTOS_SERIES = new ENT_TDOCUMENTOS_SERIES();
                        dtR.GetValues (Valores);
                        oENT_TDOCUMENTOS_SERIES.tdocs_empresa = Convert.IsDBNull(Valores[lInttdocs_empresa]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdocs_empresa]);
                        oENT_TDOCUMENTOS_SERIES.tdocs_codigo = Convert.IsDBNull(Valores[lInttdocs_codigo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdocs_codigo]);
                        oENT_TDOCUMENTOS_SERIES.tdocs_serie = Convert.IsDBNull(Valores[lInttdocs_serie]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdocs_serie]);
                        oENT_TDOCUMENTOS_SERIES.tdocs_numerador = Convert.IsDBNull(Valores[lInttdocs_numerador]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdocs_numerador]);
                        oENT_TDOCUMENTOS_SERIES.tdocs_serie_predeterminada = Convert.IsDBNull(Valores[lInttdocs_serie_predeterminada]) == true ? Convert.ToBoolean(null) : Convert.ToBoolean(Valores[lInttdocs_serie_predeterminada]);
                        oTDOCUMENTOS_SERIES.Add (oENT_TDOCUMENTOS_SERIES);
                    }
                }
            }
            return oTDOCUMENTOS_SERIES;
        }
    }
}
