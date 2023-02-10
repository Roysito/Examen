using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TFAMILIA
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TFAMILIA> getListarTFAMILIA(int? pIntid_familia)
            {
                return new ADNT_TFAMILIA().getListarTFAMILIA(pIntid_familia);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TFAMILIA().setInsertarTFAMILIA( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TFAMILIA().setActualizarTFAMILIA( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTFAMILIA(ENT_TFAMILIA pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TFAMILIA().setEliminarTFAMILIA( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
