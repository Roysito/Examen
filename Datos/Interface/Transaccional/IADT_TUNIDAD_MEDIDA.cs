using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TUNIDAD_MEDIDA<T>
    {
        bool setInsertarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTUNIDAD_MEDIDA(ENT_TUNIDAD_MEDIDA pEntCab, out int pIntRowsAfect);
    }
}
