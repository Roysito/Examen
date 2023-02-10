using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TVENDEDOR<T>
    {
        bool setInsertarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect);
        bool setActualizarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect);
        bool setEliminarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect);
    }
}
