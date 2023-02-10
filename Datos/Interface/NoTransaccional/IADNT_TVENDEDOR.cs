using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TVENDEDOR<T>
    {
        System.Collections.Generic.List<T> getListarTVENDEDOR(int? pIntid_vendedor,string pStrc_vendedor);
    }
}
