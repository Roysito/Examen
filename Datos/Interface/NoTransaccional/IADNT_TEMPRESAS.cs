using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TEMPRESAS<T>
    {
        System.Collections.Generic.List<T> getListarTEMPRESAS(string pStremp_codigo);
    }
}
