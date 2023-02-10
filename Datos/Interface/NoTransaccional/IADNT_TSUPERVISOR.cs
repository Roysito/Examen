using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TSUPERVISOR<T>
    {
        System.Collections.Generic.List<T> getListarTSUPERVISOR(int? pIntid_supervisor);
    }
}
