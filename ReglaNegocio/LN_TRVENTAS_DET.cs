using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TRVENTAS_DET
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TRVENTAS_DET> getListarTRVENTAS_DET(string pStrtrvd_empresa,string pStrtrvd_periodo,string pStrtrvd_tipo,string pStrtrvd_registro,int? pInttrvd_nroitm)
            {
                return new ADNT_TRVENTAS_DET().getListarTRVENTAS_DET(pStrtrvd_empresa,pStrtrvd_periodo,pStrtrvd_tipo,pStrtrvd_registro,pInttrvd_nroitm);
            }
        #endregion
        #region "Transaccional"
        #endregion
    }
}
