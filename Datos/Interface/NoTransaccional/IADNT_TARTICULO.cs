using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TARTICULO<T>
    {
        System.Collections.Generic.List<T> getListarTARTICULO(int? pIntid_articulo,string pStrc_articulo);
    }
}
