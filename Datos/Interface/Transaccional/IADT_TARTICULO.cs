using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TARTICULO<T>
    {
        bool setInsertarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect);
        bool setActualizarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect);
        bool setEliminarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect);
    }
}
