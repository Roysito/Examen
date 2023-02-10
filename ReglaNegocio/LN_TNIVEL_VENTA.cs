using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TNIVEL_VENTA
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TNIVEL_VENTA> getListarTNIVEL_VENTA(string pStrtven_empresa,string pStrtven_codigo)
            {
                return new ADNT_TNIVEL_VENTA().getListarTNIVEL_VENTA(pStrtven_empresa,pStrtven_codigo);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TNIVEL_VENTA().setActualizarTNIVEL_VENTA( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TNIVEL_VENTA().setInsertarTNIVEL_VENTA( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TNIVEL_VENTA().setEliminarTNIVEL_VENTA( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
