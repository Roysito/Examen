using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TCTACTE
    {
      public int? id_ctacte { get; set; }         //Id
      public int? id_ctacte_tipo { get; set; }         //Id Tipo
      public string c_ctacte { get; set; }         //Código
      public int? id_ctacte_tipo_documento { get; set; }         //Id Tipo Documento
      public string c_numero_documento { get; set; }         //Numero Documento
      public string t_ape_pat { get; set; }         //Apellidos Paternos
      public string t_ape_mat { get; set; }         //Apellidos Maternos
      public string t_nombre1 { get; set; }         //Nombre-1
      public string t_nombre2 { get; set; }         //Nombre-2
      public string t_razon_social { get; set; }         //Razón Social
      public string t_nombre_comercial { get; set; }         //Nombre Comercial
      public string t_cargo { get; set; }         //Descripción del Cargo
    }
}
