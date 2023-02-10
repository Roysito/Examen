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
   public class ADNT_TSUPERVISOR : IADNT_TSUPERVISOR<ENT_TSUPERVISOR>
    {
        public System.Collections.Generic.List<ENT_TSUPERVISOR> getListarTSUPERVISOR(int? pIntid_supervisor)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TSUPERVISOR> oTSUPERVISOR = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TSUPERVISOR";
            CMD.Parameters.Add(new SqlParameter("@pid_supervisor", SqlDbType.Int)).Value = pIntid_supervisor == null || pIntid_supervisor == 0 ? DBNull.Value : (object)pIntid_supervisor;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntid_supervisor = dtR.GetOrdinal("id_supervisor");
                int lIntc_supervisor = dtR.GetOrdinal("c_supervisor");
                int lIntt_supervisor = dtR.GetOrdinal("t_supervisor");
                int lIntt_supervisor_abrev = dtR.GetOrdinal("t_supervisor_abrev");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTSUPERVISOR = new List<ENT_TSUPERVISOR>();
                    while (dtR.Read())
                    {
                        ENT_TSUPERVISOR oENT_TSUPERVISOR = new ENT_TSUPERVISOR();
                        dtR.GetValues (Valores);
                        oENT_TSUPERVISOR.id_supervisor = Convert.IsDBNull(Valores[lIntid_supervisor]) == true ? Convert.ToInt32(null) : Convert.ToInt32(Valores[lIntid_supervisor]);
                        oENT_TSUPERVISOR.c_supervisor = Convert.IsDBNull(Valores[lIntc_supervisor]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntc_supervisor]);
                        oENT_TSUPERVISOR.t_supervisor = Convert.IsDBNull(Valores[lIntt_supervisor]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_supervisor]);
                        oENT_TSUPERVISOR.t_supervisor_abrev = Convert.IsDBNull(Valores[lIntt_supervisor_abrev]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntt_supervisor_abrev]);
                        oTSUPERVISOR.Add (oENT_TSUPERVISOR);
                    }
                }
            }
            return oTSUPERVISOR;
        }
    }
}
