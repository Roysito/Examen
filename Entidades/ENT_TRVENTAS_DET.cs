using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TRVENTAS_DET
    {
      public string trvd_empresa { get; set; }         //Codigo Compañia
      public string trvd_periodo { get; set; }         //Periodo
      public string trvd_tipo { get; set; }         //Nivel Ventas
      public string trvd_registro { get; set; }         //Número Registro
      public int? trvd_nroitm { get; set; }         //Correlativo
      public int? trvd_idarticulo { get; set; }         //Id Articulo
      public decimal? trvd_cant { get; set; }         //Cantidad
      public decimal? trvd_preun { get; set; }         //Precio Unitario
      public decimal? trvd_pdcto { get; set; }         //% Descuento
      public decimal? trvd_dcto { get; set; }         //Monto Descuento
      public decimal? trvd_vvta { get; set; }         //Base Imponible
      public decimal? trvd_igv { get; set; }         //Igv
      public decimal? trvd_tot { get; set; }         //Total Venta
    }
}
