using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TCTACTE_TIPO_DOCUMENTO<T>
    {
        System.Collections.Generic.List<T> getListarTCTACTE_TIPO_DOCUMENTO(int? pIntid_ctacte_tipo_documento);
    }
}
