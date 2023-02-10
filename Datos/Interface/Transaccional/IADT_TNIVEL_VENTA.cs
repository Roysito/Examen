using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TNIVEL_VENTA<T>
    {
        bool setInsertarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect);
        bool setActualizarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect);
        bool setEliminarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect);
    }
}
