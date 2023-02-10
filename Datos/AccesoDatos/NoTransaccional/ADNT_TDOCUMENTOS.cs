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
   public class ADNT_TDOCUMENTOS : IADNT_TDOCUMENTOS<ENT_TDOCUMENTOS>
    {
        public System.Collections.Generic.List<ENT_TDOCUMENTOS> getListarTDOCUMENTOS(string pStrtdoc_empresa,string pStrtdoc_codigo)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TDOCUMENTOS> oTDOCUMENTOS = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TDOCUMENTOS";
            CMD.Parameters.Add(new SqlParameter("@ptdoc_empresa", SqlDbType.VarChar)).Value = pStrtdoc_empresa == null || pStrtdoc_empresa == "" ? DBNull.Value : (object)pStrtdoc_empresa;
            CMD.Parameters.Add(new SqlParameter("@ptdoc_codigo", SqlDbType.VarChar)).Value = pStrtdoc_codigo == null || pStrtdoc_codigo == "" ? DBNull.Value : (object)pStrtdoc_codigo;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lInttdoc_empresa = dtR.GetOrdinal("tdoc_empresa");
                int lInttdoc_codigo = dtR.GetOrdinal("tdoc_codigo");
                int lInttdoc_sigla = dtR.GetOrdinal("tdoc_sigla");
                int lInttdoc_descripcion = dtR.GetOrdinal("tdoc_descripcion");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTDOCUMENTOS = new List<ENT_TDOCUMENTOS>();
                    while (dtR.Read())
                    {
                        ENT_TDOCUMENTOS oENT_TDOCUMENTOS = new ENT_TDOCUMENTOS();
                        dtR.GetValues (Valores);
                        oENT_TDOCUMENTOS.tdoc_empresa = Convert.IsDBNull(Valores[lInttdoc_empresa]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdoc_empresa]);
                        oENT_TDOCUMENTOS.tdoc_codigo = Convert.IsDBNull(Valores[lInttdoc_codigo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdoc_codigo]);
                        oENT_TDOCUMENTOS.tdoc_sigla = Convert.IsDBNull(Valores[lInttdoc_sigla]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdoc_sigla]);
                        oENT_TDOCUMENTOS.tdoc_descripcion = Convert.IsDBNull(Valores[lInttdoc_descripcion]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttdoc_descripcion]);
                        oTDOCUMENTOS.Add (oENT_TDOCUMENTOS);
                    }
                }
            }
            return oTDOCUMENTOS;
        }
    }
}
