using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TEMPRESAS
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TEMPRESAS> getListarTEMPRESAS(string pStremp_codigo)
            {
                return new ADNT_TEMPRESAS().getListarTEMPRESAS(pStremp_codigo);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TEMPRESAS().setActualizarTEMPRESAS( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TEMPRESAS().setInsertarTEMPRESAS( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TEMPRESAS().setEliminarTEMPRESAS( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
