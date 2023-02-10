using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TDOCUMENTOS<T>
    {
        System.Collections.Generic.List<T> getListarTDOCUMENTOS(string pStrtdoc_empresa,string pStrtdoc_codigo);
    }
}
