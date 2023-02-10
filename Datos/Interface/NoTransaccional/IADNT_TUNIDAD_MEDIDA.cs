using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TUNIDAD_MEDIDA<T>
    {
        System.Collections.Generic.List<T> getListarTUNIDAD_MEDIDA(int? pIntid_unidad_medida);
    }
}
