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
   public class ADNT_TVENDEDOR : IADNT_TVENDEDOR<ENT_TVENDEDOR>
    {
        public System.Collections.Generic.List<ENT_TVENDEDOR> getListarTVENDEDOR(int? pIntid_vendedor,string pStrc_vendedor)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TVENDEDOR> oTVENDEDOR = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TVENDEDOR";
            CMD.Parameters.Add(new SqlParameter("@pid_vendedor", SqlDbType.Int)).Value = pIntid_vendedor == null || pIntid_vendedor == 0 ? DBNull.Value : (object)pIntid_vendedor;
            CMD.Parameters.Add(new SqlParameter("@pc_vendedor", SqlDbType.VarChar)).Value = pStrc_vendedor == null || pStrc_vendedor == "" ? DBNull.Value : (object)pStrc_vendedor;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_vendedor = dtR.GetOrdinal("id_vendedor");
                int lIntid_supervisor = dtR.GetOrdinal("id_supervisor");
                int lIntc_vendedor = dtR.GetOrdinal("c_vendedor");
                int lIntt_vendedor = dtR.GetOrdinal("t_vendedor");
                int lIntf_activo = dtR.GetOrdinal("f_activo");
                int lIntt_telefono = dtR.GetOrdinal("t_telefono");
                int lIntt_nombre_vendedor = dtR.GetOrdinal("t_nombre_vendedor");
                int lIntt_dni = dtR.GetOrdinal("t_dni");
                int lIntt_domicilio = dtR.GetOrdinal("t_domicilio");
                int lIntt_zona = dtR.GetOrdinal("t_zona");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTVENDEDOR = new List<ENT_TVENDEDOR>();
                    while (dtR.Read())
                    {
                        ENT_TVENDEDOR oENT_TVENDEDOR = new ENT_TVENDEDOR();
                        dtR.GetValues (Valores);
                        oENT_TVENDEDOR.id_vendedor = Convert.IsDBNull(Valores[lIntid_vendedor]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_vendedor]);
                        oENT_TVENDEDOR.id_supervisor = Convert.IsDBNull(Valores[lIntid_supervisor]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_supervisor]);
                        oENT_TVENDEDOR.c_vendedor = Convert.IsDBNull(Valores[lIntc_vendedor]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_vendedor]);
                        oENT_TVENDEDOR.t_vendedor = Convert.IsDBNull(Valores[lIntt_vendedor]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_vendedor]);
                        oENT_TVENDEDOR.f_activo = Convert.IsDBNull(Valores[lIntf_activo]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntf_activo]);
                        oENT_TVENDEDOR.t_telefono = Convert.IsDBNull(Valores[lIntt_telefono]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_telefono]);
                        oENT_TVENDEDOR.t_nombre_vendedor = Convert.IsDBNull(Valores[lIntt_nombre_vendedor]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_nombre_vendedor]);
                        oENT_TVENDEDOR.t_dni = Convert.IsDBNull(Valores[lIntt_dni]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_dni]);
                        oENT_TVENDEDOR.t_domicilio = Convert.IsDBNull(Valores[lIntt_domicilio]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_domicilio]);
                        oENT_TVENDEDOR.t_zona = Convert.IsDBNull(Valores[lIntt_zona]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_zona]);
                        oTVENDEDOR.Add (oENT_TVENDEDOR);
                    }
                }
            }
            return oTVENDEDOR;
        }
    }
}
