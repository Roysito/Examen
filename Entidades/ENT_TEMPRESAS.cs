using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TEMPRESAS
    {
      public string emp_codigo { get; set; }         //Código
      public string emp_razonsocial { get; set; }         //Razón Social
      public string emp_razoncomercial { get; set; }         //Razón Comercial
      public string emp_direccion { get; set; }         //Dirección
      public string emp_ruc { get; set; }         //Ruc
      public string emp_telefonos { get; set; }         //Teléfonos
      public string emp_paginaweb { get; set; }         //Página Web
      public string emp_gerente { get; set; }         //Gerente
      public string emp_docugerente { get; set; }         //Descripción Documento Identidad Gerente General
      public string emp_numdocugerente { get; set; }         //Número de Documento Identidad Gerente General
      public bool emp_activo { get; set; }         //Flag Activo
      public Image? emp_logo { get; set; }         //Logo
    }
}
