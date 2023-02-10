using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceosDatos.AccesoDatos.NoTransaccional;
using CapaAcceosDatos.AccesoDatos.Transaccional;
namespace CapaLogicaNegocio
{
    public class LN_TUNIDAD_MEDIDA
    {
        #region "No Transaccional"
            public static System.Collections.Generic.List<ENT_TUNIDAD_MEDIDA> getListarTUNIDAD_MEDIDA(int? pIntid_unidad_medida)
            {
                return new ADNT_TUNIDAD_MEDIDA().getListarTUNIDAD_MEDIDA(pIntid_unidad_medida);
            }
        #endregion
        #region "Transaccional"
            public static bool setInsertarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TUNIDAD_MEDIDA().setInsertarTUNIDAD_MEDIDA( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setActualizarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
            {
                return new ADT_TUNIDAD_MEDIDA().setActualizarTUNIDAD_MEDIDA( pEntCab, pLisDet, out pIntRowsAfect);
            }
            public static bool setEliminarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, out int pIntRowsAfect)
            {
                return new ADT_TUNIDAD_MEDIDA().setEliminarTUNIDAD_MEDIDA( pEntCab, out pIntRowsAfect);
            }
        #endregion
    }
}
