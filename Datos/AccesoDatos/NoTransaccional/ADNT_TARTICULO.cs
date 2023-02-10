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
   public class ADNT_TARTICULO : IADNT_TARTICULO<ENT_TARTICULO>
    {
        public System.Collections.Generic.List<ENT_TARTICULO> getListarTARTICULO(int? pIntid_articulo,string pStrc_articulo)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TARTICULO> oTARTICULO = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TARTICULO";
            CMD.Parameters.Add(new SqlParameter("@pid_articulo", SqlDbType.Int)).Value = pIntid_articulo == null || pIntid_articulo == 0 ? DBNull.Value : (object)pIntid_articulo;
            CMD.Parameters.Add(new SqlParameter("@pc_articulo", SqlDbType.VarChar)).Value = pStrc_articulo == null || pStrc_articulo == "" ? DBNull.Value : (object)pStrc_articulo;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_articulo = dtR.GetOrdinal("id_articulo");
                int lIntc_articulo = dtR.GetOrdinal("c_articulo");
                int lIntt_articulo = dtR.GetOrdinal("t_articulo");
                int lIntt_articulo_tecnico = dtR.GetOrdinal("t_articulo_tecnico");
                int lIntt_articulo_adicional = dtR.GetOrdinal("t_articulo_adicional");
                int lIntn_stock_minimo = dtR.GetOrdinal("n_stock_minimo");
                int lIntn_stock_maximo = dtR.GetOrdinal("n_stock_maximo");
                int lIntid_unidad_medida = dtR.GetOrdinal("id_unidad_medida");
                int lIntf_estado = dtR.GetOrdinal("f_estado");
                int lIntt_marca = dtR.GetOrdinal("t_marca");
                int lIntc_digemid = dtR.GetOrdinal("c_digemid");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTARTICULO = new List<ENT_TARTICULO>();
                    while (dtR.Read())
                    {
                        ENT_TARTICULO oENT_TARTICULO = new ENT_TARTICULO();
                        dtR.GetValues (Valores);
                        oENT_TARTICULO.id_articulo = Convert.IsDBNull(Valores[lIntid_articulo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_articulo]);
                        oENT_TARTICULO.c_articulo = Convert.IsDBNull(Valores[lIntc_articulo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_articulo]);
                        oENT_TARTICULO.t_articulo = Convert.IsDBNull(Valores[lIntt_articulo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_articulo]);
                        oENT_TARTICULO.t_articulo_tecnico = Convert.IsDBNull(Valores[lIntt_articulo_tecnico]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_articulo_tecnico]);
                        oENT_TARTICULO.t_articulo_adicional = Convert.IsDBNull(Valores[lIntt_articulo_adicional]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_articulo_adicional]);
                        oENT_TARTICULO.n_stock_minimo = Convert.IsDBNull(Valores[lIntn_stock_minimo]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lIntn_stock_minimo]);
                        oENT_TARTICULO.n_stock_maximo = Convert.IsDBNull(Valores[lIntn_stock_maximo]) == true ? Convert.ToDecimal(null) : Convert.ToDecimal(Valores[lIntn_stock_maximo]);
                        oENT_TARTICULO.id_unidad_medida = Convert.IsDBNull(Valores[lIntid_unidad_medida]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_unidad_medida]);
                        oENT_TARTICULO.f_estado = Convert.IsDBNull(Valores[lIntf_estado]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntf_estado]);
                        oENT_TARTICULO.t_marca = Convert.IsDBNull(Valores[lIntt_marca]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_marca]);
                        oENT_TARTICULO.c_digemid = Convert.IsDBNull(Valores[lIntc_digemid]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_digemid]);
                        oTARTICULO.Add (oENT_TARTICULO);
                    }
                }
            }
            return oTARTICULO;
        }
    }
}
