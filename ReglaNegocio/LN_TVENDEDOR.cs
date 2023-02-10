using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TVENDEDOR
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TVENDEDOR> getListarTVENDEDOR(int? pIntid_vendedor,string pStrc_vendedor)
            {
                return new ADNT_TVENDEDOR().getListarTVENDEDOR(pIntid_vendedor,pStrc_vendedor);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TVENDEDOR().setActualizarTVENDEDOR( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TVENDEDOR().setInsertarTVENDEDOR( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TVENDEDOR().setEliminarTVENDEDOR( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
