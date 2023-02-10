using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TEMPRESAS
    {
      public string emp_codigo { get; set; }         //C�digo
      public string emp_razonsocial { get; set; }         //Raz�n Social
      public string emp_razoncomercial { get; set; }         //Raz�n Comercial
      public string emp_direccion { get; set; }         //Direcci�n
      public string emp_ruc { get; set; }         //Ruc
      public string emp_telefonos { get; set; }         //Tel�fonos
      public string emp_paginaweb { get; set; }         //P�gina Web
      public string emp_gerente { get; set; }         //Gerente
      public string emp_docugerente { get; set; }         //Descripci�n Documento Identidad Gerente General
      public string emp_numdocugerente { get; set; }         //N�mero de Documento Identidad Gerente General
      public bool emp_activo { get; set; }         //Flag Activo
      public Image? emp_logo { get; set; }         //Logo
    }
}
