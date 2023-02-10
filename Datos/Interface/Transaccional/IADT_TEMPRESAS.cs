using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TEMPRESAS<T>
    {
        bool setInsertarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect);
        bool setActualizarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect);
        bool setEliminarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect);
    }
}
