using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TFORMA_PAGO<T>
    {
        bool setInsertarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect);
        bool setActualizarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect);
        bool setEliminarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect);
    }
}
