using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TDOCUMENTOS_SERIES
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TDOCUMENTOS_SERIES> getListarTDOCUMENTOS_SERIES(string pStrtdocs_empresa,string pStrtdocs_codigo,string pStrtdocs_serie)
            {
                return new ADNT_TDOCUMENTOS_SERIES().getListarTDOCUMENTOS_SERIES(pStrtdocs_empresa,pStrtdocs_codigo,pStrtdocs_serie);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS_SERIES().setActualizarTDOCUMENTOS_SERIES( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS_SERIES().setInsertarTDOCUMENTOS_SERIES( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TDOCUMENTOS_SERIES().setEliminarTDOCUMENTOS_SERIES( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
