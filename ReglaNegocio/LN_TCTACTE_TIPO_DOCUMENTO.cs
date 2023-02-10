using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TCTACTE_TIPO_DOCUMENTO
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TCTACTE_TIPO_DOCUMENTO> getListarTCTACTE_TIPO_DOCUMENTO(int? pIntid_ctacte_tipo_documento)
            {
                return new ADNT_TCTACTE_TIPO_DOCUMENTO().getListarTCTACTE_TIPO_DOCUMENTO(pIntid_ctacte_tipo_documento);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO_DOCUMENTO().setInsertarTCTACTE_TIPO_DOCUMENTO( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO_DOCUMENTO().setActualizarTCTACTE_TIPO_DOCUMENTO( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TCTACTE_TIPO_DOCUMENTO().setEliminarTCTACTE_TIPO_DOCUMENTO( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
