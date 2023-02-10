using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TCTACTE_TIPO
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TCTACTE_TIPO> getListarTCTACTE_TIPO(int? pIntid_ctacte_tipo)
            {
                return new ADNT_TCTACTE_TIPO().getListarTCTACTE_TIPO(pIntid_ctacte_tipo);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO().setInsertarTCTACTE_TIPO( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO().setActualizarTCTACTE_TIPO( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO().setEliminarTCTACTE_TIPO( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
