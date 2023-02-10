using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TDOCUMENTOS
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TDOCUMENTOS> getListarTDOCUMENTOS(string pStrtdoc_empresa,string pStrtdoc_codigo)
            {
                return new ADNT_TDOCUMENTOS().getListarTDOCUMENTOS(pStrtdoc_empresa,pStrtdoc_codigo);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS().setActualizarTDOCUMENTOS( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS().setInsertarTDOCUMENTOS( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS().setEliminarTDOCUMENTOS( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
