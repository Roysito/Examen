using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TCTACTE_TIPO<T>
    {
        bool setInsertarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTCTACTE_TIPO(ENT_TCTACTE_TIPO pEntCab, out int pIntRowsAfect);
    }
}
