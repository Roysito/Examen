using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TARTICULO
    {
      public int? id_articulo { get; set; }         //Id Articulo
      public string c_articulo { get; set; }         //C�digo
      public string t_articulo { get; set; }         //Descripci�n
      public string t_articulo_tecnico { get; set; }         //Descripci�n T�cnico
      public string t_articulo_adicional { get; set; }         //Descripci�n Adicional
      public decimal? n_stock_minimo { get; set; }         //Stock Minimo
      public decimal? n_stock_maximo { get; set; }         //Stock Maximo
      public int? id_unidad_medida { get; set; }         //Id Unidad de Medida
      public int? f_estado { get; set; }         //Flag Estado Activo
      public string t_marca { get; set; }         //Marca
      public string c_digemid { get; set; }         //C�digo DIGEMID
    }
}
