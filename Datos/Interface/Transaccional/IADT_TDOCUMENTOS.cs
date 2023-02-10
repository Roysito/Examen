using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TDOCUMENTOS<T>
    {
        bool setInsertarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect);
        bool setActualizarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect);
        bool setEliminarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect);
    }
}
