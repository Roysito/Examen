using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TSUPERVISOR
    {
      public int? id_supervisor { get; set; }         //Id
      public string c_supervisor { get; set; }         //Código
      public string t_supervisor { get; set; }         //Nombre
      public string t_supervisor_abrev { get; set; }         //Nombre Abreviado
    }
}
