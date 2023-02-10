using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CapaAcceosDatos.Interface.NoTransaccional
{
   interface IADNT_TRVENTAS_DET<T>
    {
        System.Collections.Generic.List<T> getListarTRVENTAS_DET(string pStrtrvd_empresa,string pStrtrvd_periodo,string pStrtrvd_tipo,string pStrtrvd_registro,int? pInttrvd_nroitm);
    }
}
