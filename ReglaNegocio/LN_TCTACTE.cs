using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TCTACTE
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TCTACTE> getListarTCTACTE(int? pIntid_ctacte,string pStrc_ctacte)
            {
                return new ADNT_TCTACTE().getListarTCTACTE(pIntid_ctacte,pStrc_ctacte);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE().setActualizarTCTACTE( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE().setInsertarTCTACTE( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE().setEliminarTCTACTE( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
