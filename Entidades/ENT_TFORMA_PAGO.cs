using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TFORMA_PAGO
    {
      public int? id_forma_pago { get; set; }         //Id
      public string c_forma_pago { get; set; }         //Código
      public string t_forma_pago { get; set; }         //Descripción
      public int? n_dias { get; set; }         //Días de la Forma de Pago
    }
}
