using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TFORMA_PAGO
    {
      public int? id_forma_pago { get; set; }         //Id
      public string c_forma_pago { get; set; }         //C�digo
      public string t_forma_pago { get; set; }         //Descripci�n
      public int? n_dias { get; set; }         //D�as de la Forma de Pago
    }
}
