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
   public class ADNT_TMONEDAS : IADNT_TMONEDAS<ENT_TMONEDAS>
    {
        public System.Collections.Generic.List<ENT_TMONEDAS> getListarTMONEDAS(string pStrmnd_cod)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TMONEDAS> oTMONEDAS = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TMONEDAS";
            CMD.Parameters.Add(new SqlParameter("@pmnd_cod", SqlDbType.VarChar)).Value = pStrmnd_cod == null || pStrmnd_cod == "" ? DBNull.Value : (object)pStrmnd_cod;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntmnd_cod = dtR.GetOrdinal("mnd_cod");
                int lIntmnd_des = dtR.GetOrdinal("mnd_des");
                int lIntmnd_sigla = dtR.GetOrdinal("mnd_sigla");
                int lIntmnd_abrev = dtR.GetOrdinal("mnd_abrev");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTMONEDAS = new List<ENT_TMONEDAS>();
                    while (dtR.Read())
                    {
                        ENT_TMONEDAS oENT_TMONEDAS = new ENT_TMONEDAS();
                        dtR.GetValues (Valores);
                        oENT_TMONEDAS.mnd_cod = Convert.IsDBNull(Valores[lIntmnd_cod]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntmnd_cod]);
                        oENT_TMONEDAS.mnd_des = Convert.IsDBNull(Valores[lIntmnd_des]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntmnd_des]);
                        oENT_TMONEDAS.mnd_sigla = Convert.IsDBNull(Valores[lIntmnd_sigla]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntmnd_sigla]);
                        oENT_TMONEDAS.mnd_abrev = Convert.IsDBNull(Valores[lIntmnd_abrev]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntmnd_abrev]);
                        oTMONEDAS.Add (oENT_TMONEDAS);
                    }
                }
            }
            return oTMONEDAS;
        }
    }
}
