using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TDOCUMENTOS_SERIES<T>
    {
        bool setInsertarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect);
        bool setActualizarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect);
        bool setEliminarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect);
    }
}
