using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TDOCUMENTOS_SERIES<T>
    {
        System.Collections.Generic.List<T> getListarTDOCUMENTOS_SERIES(string pStrtdocs_empresa,string pStrtdocs_codigo,string pStrtdocs_serie);
    }
}
