using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TMONEDAS
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TMONEDAS> getListarTMONEDAS(string pStrmnd_cod)
            {
                return new ADNT_TMONEDAS().getListarTMONEDAS(pStrmnd_cod);
            }
        #endregion
        #region "Transaccional"
            public static bool setActualizarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TMONEDAS().setActualizarTMONEDAS( pEntidad, out pIntRowsAfect);
            }
            public static bool setInsertarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TMONEDAS().setInsertarTMONEDAS( pEntidad, out pIntRowsAfect);
            }
            public static bool setEliminarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
            {
                return new ADT_TMONEDAS().setEliminarTMONEDAS( pEntidad, out pIntRowsAfect);
            }
        #endregion
    }
}
