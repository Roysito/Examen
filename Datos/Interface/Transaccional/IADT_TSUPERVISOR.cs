using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TSUPERVISOR<T>
    {
        bool setInsertarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTSUPERVISOR(ENT_TSUPERVISOR pEntCab, out int pIntRowsAfect);
    }
}
