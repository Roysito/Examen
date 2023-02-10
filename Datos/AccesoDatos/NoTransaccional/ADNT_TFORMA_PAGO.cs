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
   public class ADNT_TFORMA_PAGO : IADNT_TFORMA_PAGO<ENT_TFORMA_PAGO>
    {
        public System.Collections.Generic.List<ENT_TFORMA_PAGO> getListarTFORMA_PAGO(int? pIntid_forma_pago,string pStrc_forma_pago)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TFORMA_PAGO> oTFORMA_PAGO = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TFORMA_PAGO";
            CMD.Parameters.Add(new SqlParameter("@pid_forma_pago", SqlDbType.Int)).Value = pIntid_forma_pago == null || pIntid_forma_pago == 0 ? DBNull.Value : (object)pIntid_forma_pago;
            CMD.Parameters.Add(new SqlParameter("@pc_forma_pago", SqlDbType.VarChar)).Value = pStrc_forma_pago == null || pStrc_forma_pago == "" ? DBNull.Value : (object)pStrc_forma_pago;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_forma_pago = dtR.GetOrdinal("id_forma_pago");
                int lIntc_forma_pago = dtR.GetOrdinal("c_forma_pago");
                int lIntt_forma_pago = dtR.GetOrdinal("t_forma_pago");
                int lIntn_dias = dtR.GetOrdinal("n_dias");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTFORMA_PAGO = new List<ENT_TFORMA_PAGO>();
                    while (dtR.Read())
                    {
                        ENT_TFORMA_PAGO oENT_TFORMA_PAGO = new ENT_TFORMA_PAGO();
                        dtR.GetValues (Valores);
                        oENT_TFORMA_PAGO.id_forma_pago = Convert.IsDBNull(Valores[lIntid_forma_pago]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_forma_pago]);
                        oENT_TFORMA_PAGO.c_forma_pago = Convert.IsDBNull(Valores[lIntc_forma_pago]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_forma_pago]);
                        oENT_TFORMA_PAGO.t_forma_pago = Convert.IsDBNull(Valores[lIntt_forma_pago]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_forma_pago]);
                        oENT_TFORMA_PAGO.n_dias = Convert.IsDBNull(Valores[lIntn_dias]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntn_dias]);
                        oTFORMA_PAGO.Add (oENT_TFORMA_PAGO);
                    }
                }
            }
            return oTFORMA_PAGO;
        }
    }
}
