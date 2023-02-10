using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TNIVEL_VENTA<T>
    {
        System.Collections.Generic.List<T> getListarTNIVEL_VENTA(string pStrtven_empresa,string pStrtven_codigo);
    }
}
