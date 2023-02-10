using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TVENDEDOR
    {
      public int? id_vendedor { get; set; }         //Id
      public int? id_supervisor { get; set; }         //Id Supervisor
      public string c_vendedor { get; set; }         //C�digo
      public string t_vendedor { get; set; }         //Abreviatura Nombres
      public int? f_activo { get; set; }         //Flag Activo
      public string t_telefono { get; set; }         //Tel�fonos
      public string t_nombre_vendedor { get; set; }         //Nombres
      public string t_dni { get; set; }         //Documento Identidad
      public string t_domicilio { get; set; }         //Direcci�n
      public string t_zona { get; set; }         //Zona
    }
}
