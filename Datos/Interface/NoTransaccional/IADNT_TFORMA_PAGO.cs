using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TFORMA_PAGO<T>
    {
        System.Collections.Generic.List<T> getListarTFORMA_PAGO(int? pIntid_forma_pago,string pStrc_forma_pago);
    }
}
