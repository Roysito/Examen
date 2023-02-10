using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TARTICULO
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TARTICULO> getListarTARTICULO(int? pIntid_articulo,string pStrc_articulo)
            {
                return new ADNT_TARTICULO().getListarTARTICULO(pIntid_articulo,pStrc_articulo);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TARTICULO().setActualizarTARTICULO( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TARTICULO().setInsertarTARTICULO( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TARTICULO().setEliminarTARTICULO( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
