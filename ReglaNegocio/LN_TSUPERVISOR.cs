using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TSUPERVISOR
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TSUPERVISOR> getListarTSUPERVISOR(int? pIntid_supervisor)
            {
                return new ADNT_TSUPERVISOR().getListarTSUPERVISOR(pIntid_supervisor);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TSUPERVISOR().setInsertarTSUPERVISOR( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TSUPERVISOR().setActualizarTSUPERVISOR( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TSUPERVISOR().setEliminarTSUPERVISOR( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
