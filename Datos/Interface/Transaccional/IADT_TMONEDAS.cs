using CapaEntidades;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace CapaAcceosDatos.Interface.Transaccional
{
   interface IADT_TMONEDAS<T>
    {
        bool setInsertarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect);
        bool setActualizarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect);
        bool setEliminarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect);
    }
}
