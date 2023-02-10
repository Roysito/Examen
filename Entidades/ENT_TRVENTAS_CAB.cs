using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CapaEntidades
{
    public class ENT_TRVENTAS_CAB
    {
      public string trv_empresa { get; set; }         //Codigo Compañia
      public string trv_periodo { get; set; }         //Periodo
      public string trv_tipo { get; set; }         //Nivel Venta
      public string trv_registro { get; set; }         //Número Registro
      public int? trv_entidad { get; set; }         //Id Ctacte
      public int? trv_idvendedor { get; set; }         //Id Vendedor
      public int? trv_idformapago { get; set; }         //Id Forma Pago
      public string trv_tdoc { get; set; }         //Código Documento
      public string trv_sdoc { get; set; }         //Serie Documento
      public string trv_ndoc { get; set; }         //Número Documento
      public DateTime? trv_femision { get; set; }         //Fecha Emisión
      public DateTime? trv_fvencimiento { get; set; }         //Fecha Vencimiento
      public string trv_moneda { get; set; }         //Código Moneda
      public decimal? trv_tcambio { get; set; }         //Tipo de Cambio
      public decimal? trv_dctos { get; set; }         //Total Descuentos
      public decimal? trv_vventa { get; set; }         //Base Imponible
      public decimal? trv_igv { get; set; }         //Igv
      public decimal? trv_total { get; set; }         //Total Venta
      public int? trv_aigv { get; set; }         //Afeco a Igv
      public int? trv_flag { get; set; }         //Flag Anulado
      public decimal? trv_pigv { get; set; }         //Porcentaje Igv
    }
}
