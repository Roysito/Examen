using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TRVENTAS_CAB
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TRVENTAS_CAB> getListarTRVENTAS_CAB(string pStrtrv_empresa,string pStrtrv_periodo,string pStrtrv_tipo,string pStrtrv_registro)
            {
                return new ADNT_TRVENTAS_CAB().getListarTRVENTAS_CAB(pStrtrv_empresa,pStrtrv_periodo,pStrtrv_tipo,pStrtrv_registro);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TRVENTAS_CAB().setInsertarTRVENTAS_CAB( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TRVENTAS_CAB().setActualizarTRVENTAS_CAB( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TRVENTAS_CAB().setEliminarTRVENTAS_CAB( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
