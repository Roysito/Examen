using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TNIVEL_VENTA
    {
      public string tven_empresa { get; set; }         //C�digo de Compa�ia
      public string tven_codigo { get; set; }         //C�digo
      public string tven_sigla { get; set; }         //Sigla o Abreviatura
      public string tven_descripcion { get; set; }         //Descripci�n
      public int? tven_activo { get; set; }         //Flag Activo
    }
}
