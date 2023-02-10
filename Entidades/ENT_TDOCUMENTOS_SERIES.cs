using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TDOCUMENTOS_SERIES
    {
      public string tdocs_empresa { get; set; }         //Codigo de Compañia
      public string tdocs_codigo { get; set; }         //Codigo Tipo Documento
      public string tdocs_serie { get; set; }         //Serie
      public string tdocs_numerador { get; set; }         //Número
      public bool tdocs_serie_predeterminada { get; set; }         //
    }
}
