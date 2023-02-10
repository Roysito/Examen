using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TRVENTAS_CAB<T>
    {
        bool setInsertarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, out int pIntRowsAfect);
    }
}
