using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TCTACTE_TIPO_DOCUMENTO<T>
    {
        bool setInsertarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setActualizarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect);
        bool setEliminarTCTACTE_TIPO_DOCUMENTO(ENT_TCTACTE_TIPO_DOCUMENTO pEntCab, out int pIntRowsAfect);
    }
}
