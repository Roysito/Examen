using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TCTACTE<T>
    {
        System.Collections.Generic.List<T> getListarTCTACTE(int? pIntid_ctacte,string pStrc_ctacte);
    }
}
