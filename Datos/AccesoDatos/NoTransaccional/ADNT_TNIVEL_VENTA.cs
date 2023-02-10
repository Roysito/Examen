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
   public class ADNT_TNIVEL_VENTA : IADNT_TNIVEL_VENTA<ENT_TNIVEL_VENTA>
    {
        public System.Collections.Generic.List<ENT_TNIVEL_VENTA> getListarTNIVEL_VENTA(string pStrtven_empresa,string pStrtven_codigo)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TNIVEL_VENTA> oTNIVEL_VENTA = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TNIVEL_VENTA";
            CMD.Parameters.Add(new SqlParameter("@ptven_empresa", SqlDbType.VarChar)).Value = pStrtven_empresa == null || pStrtven_empresa == "" ? DBNull.Value : (object)pStrtven_empresa;
            CMD.Parameters.Add(new SqlParameter("@ptven_codigo", SqlDbType.VarChar)).Value = pStrtven_codigo == null || pStrtven_codigo == "" ? DBNull.Value : (object)pStrtven_codigo;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lInttven_empresa = dtR.GetOrdinal("tven_empresa");
                int lInttven_codigo = dtR.GetOrdinal("tven_codigo");
                int lInttven_sigla = dtR.GetOrdinal("tven_sigla");
                int lInttven_descripcion = dtR.GetOrdinal("tven_descripcion");
                int lInttven_activo = dtR.GetOrdinal("tven_activo");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTNIVEL_VENTA = new List<ENT_TNIVEL_VENTA>();
                    while (dtR.Read())
                    {
                        ENT_TNIVEL_VENTA oENT_TNIVEL_VENTA = new ENT_TNIVEL_VENTA();
                        dtR.GetValues (Valores);
                        oENT_TNIVEL_VENTA.tven_empresa = Convert.IsDBNull(Valores[lInttven_empresa]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttven_empresa]);
                        oENT_TNIVEL_VENTA.tven_codigo = Convert.IsDBNull(Valores[lInttven_codigo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttven_codigo]);
                        oENT_TNIVEL_VENTA.tven_sigla = Convert.IsDBNull(Valores[lInttven_sigla]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttven_sigla]);
                        oENT_TNIVEL_VENTA.tven_descripcion = Convert.IsDBNull(Valores[lInttven_descripcion]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lInttven_descripcion]);
                        oENT_TNIVEL_VENTA.tven_activo = Convert.IsDBNull(Valores[lInttven_activo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lInttven_activo]);
                        oTNIVEL_VENTA.Add (oENT_TNIVEL_VENTA);
                    }
                }
            }
            return oTNIVEL_VENTA;
        }
    }
}
