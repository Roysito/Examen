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
   public class ADNT_TEMPRESAS : IADNT_TEMPRESAS<ENT_TEMPRESAS>
    {
        public System.Collections.Generic.List<ENT_TEMPRESAS> getListarTEMPRESAS(string pStremp_codigo)
        {
            SqlConnection CN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            CN.Open();
            SqlCommand CMD = new SqlCommand();
            List<ENT_TEMPRESAS> oTEMPRESAS = null;
            CMD.Connection = CN;
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.CommandText = "SPU_LISTAR_TEMPRESAS";
            CMD.Parameters.Add(new SqlParameter("@pemp_codigo", SqlDbType.VarChar)).Value = pStremp_codigo == null || pStremp_codigo == "" ? DBNull.Value : (object)pStremp_codigo;
            using(SqlDataReader dtR = CMD.ExecuteReader())
            {
                int lIntemp_codigo = dtR.GetOrdinal("emp_codigo");
                int lIntemp_razonsocial = dtR.GetOrdinal("emp_razonsocial");
                int lIntemp_razoncomercial = dtR.GetOrdinal("emp_razoncomercial");
                int lIntemp_direccion = dtR.GetOrdinal("emp_direccion");
                int lIntemp_ruc = dtR.GetOrdinal("emp_ruc");
                int lIntemp_telefonos = dtR.GetOrdinal("emp_telefonos");
                int lIntemp_paginaweb = dtR.GetOrdinal("emp_paginaweb");
                int lIntemp_gerente = dtR.GetOrdinal("emp_gerente");
                int lIntemp_docugerente = dtR.GetOrdinal("emp_docugerente");
                int lIntemp_numdocugerente = dtR.GetOrdinal("emp_numdocugerente");
                int lIntemp_activo = dtR.GetOrdinal("emp_activo");
                int lIntemp_logo = dtR.GetOrdinal("emp_logo");
                object[] Valores = new object[dtR.FieldCount];
                if (dtR.RecordsAffected != 0)
                {
                    oTEMPRESAS = new List<ENT_TEMPRESAS>();
                    while (dtR.Read())
                    {
                        ENT_TEMPRESAS oENT_TEMPRESAS = new ENT_TEMPRESAS();
                        dtR.GetValues (Valores);
                        oENT_TEMPRESAS.emp_codigo = Convert.IsDBNull(Valores[lIntemp_codigo]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_codigo]);
                        oENT_TEMPRESAS.emp_razonsocial = Convert.IsDBNull(Valores[lIntemp_razonsocial]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_razonsocial]);
                        oENT_TEMPRESAS.emp_razoncomercial = Convert.IsDBNull(Valores[lIntemp_razoncomercial]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_razoncomercial]);
                        oENT_TEMPRESAS.emp_direccion = Convert.IsDBNull(Valores[lIntemp_direccion]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_direccion]);
                        oENT_TEMPRESAS.emp_ruc = Convert.IsDBNull(Valores[lIntemp_ruc]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_ruc]);
                        oENT_TEMPRESAS.emp_telefonos = Convert.IsDBNull(Valores[lIntemp_telefonos]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_telefonos]);
                        oENT_TEMPRESAS.emp_paginaweb = Convert.IsDBNull(Valores[lIntemp_paginaweb]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_paginaweb]);
                        oENT_TEMPRESAS.emp_gerente = Convert.IsDBNull(Valores[lIntemp_gerente]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_gerente]);
                        oENT_TEMPRESAS.emp_docugerente = Convert.IsDBNull(Valores[lIntemp_docugerente]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_docugerente]);
                        oENT_TEMPRESAS.emp_numdocugerente = Convert.IsDBNull(Valores[lIntemp_numdocugerente]) == true ? Convert.ToString(null) : Convert.ToString(Valores[lIntemp_numdocugerente]);
                        oENT_TEMPRESAS.emp_activo = Convert.IsDBNull(Valores[lIntemp_activo]) == true ? Convert.ToBoolean(null) : Convert.ToBoolean(Valores[lIntemp_activo]);
                        //oENT_TEMPRESAS.emp_logo = Convert.IsDBNull(Valores[lIntemp_logo]) == true ? null : (Valores[lIntemp_logo]);
                        oTEMPRESAS.Add (oENT_TEMPRESAS);
                    }
                }
            }
            return oTEMPRESAS;
        }
    }
}
