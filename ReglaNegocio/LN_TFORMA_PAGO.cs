using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TFORMA_PAGO
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TFORMA_PAGO> getListarTFORMA_PAGO(int? pIntid_forma_pago,string pStrc_forma_pago)
            {
                return new ADNT_TFORMA_PAGO().getListarTFORMA_PAGO(pIntid_forma_pago,pStrc_forma_pago);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TFORMA_PAGO().setActualizarTFORMA_PAGO( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TFORMA_PAGO().setInsertarTFORMA_PAGO( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TFORMA_PAGO().setEliminarTFORMA_PAGO( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
