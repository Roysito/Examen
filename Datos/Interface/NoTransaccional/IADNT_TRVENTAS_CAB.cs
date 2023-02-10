using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TRVENTAS_CAB<T>
    {
        System.Collections.Generic.List<T> getListarTRVENTAS_CAB(string pStrtrv_empresa,string pStrtrv_periodo,string pStrtrv_tipo,string pStrtrv_registro);
    }
}
