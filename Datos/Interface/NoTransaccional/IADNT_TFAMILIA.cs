using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TFAMILIA<T>
    {
        System.Collections.Generic.List<T> getListarTFAMILIA(int? pIntid_familia);
    }
}
