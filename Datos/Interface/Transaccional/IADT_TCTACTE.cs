using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TCTACTE<T>
    {
        bool setInsertarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect);
        bool setActualizarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect);
        bool setEliminarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect);
    }
}
