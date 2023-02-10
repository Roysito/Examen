using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TFAMILIA<T>
    {
        bool setInsertarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTFAMILIA(ENT_TFAMILIA pEntCab, out int pIntRowsAfect);
    }
}
