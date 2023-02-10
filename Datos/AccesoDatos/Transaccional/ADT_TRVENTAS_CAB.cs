using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TRVENTAS_CAB : IADT_TRVENTAS_CAB<ENT_TRVENTAS_CAB>
    {
        public bool setInsertarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
        {
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMDdet_delete = new SqlCommand();
            SqlCommand CMDcab_delete = new SqlCommand();
            SqlCommand CMDcab_insert = new SqlCommand();
            SqlCommand CMDdet_insert = new SqlCommand();
            using (SqlConnection oCN2 = new SqlConnection(conexion.DBCCapaDatos.pStrConString))
            {
                oCN2.Open();
                SqlTransaction oTransaction = oCN2.BeginTransaction();
                CMDdet_delete.Connection = oCN2;
                CMDdet_delete.Transaction = oTransaction;
                CMDdet_delete.CommandType = CommandType.StoredProcedure;
                CMDdet_delete.CommandText = "SPU_ELIMINAR_TRVENTAS_DET" ;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;
                CMDcab_delete.Connection = oCN2;
                CMDcab_delete.Transaction = oTransaction;
                CMDcab_delete.CommandType = CommandType.StoredProcedure;
                CMDcab_delete.CommandText = "SPU_ELIMINAR_TRVENTAS_CAB" ;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_empresa", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_periodo", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_tipo", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_registro", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;

                CMDcab_insert.Connection = oCN2;
                CMDcab_insert.Transaction = oTransaction;
                CMDcab_insert.CommandType = CommandType.StoredProcedure;
                CMDcab_insert.CommandText = "SPU_INSERTAR_TRVENTAS_CAB" ;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_empresa", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_periodo", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tipo", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_registro", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_entidad", SqlDbType.Int)).Value = pEntCab.trv_entidad == null || pEntCab.trv_entidad == 0 ? DBNull.Value : (object)pEntCab.trv_entidad;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_idvendedor", SqlDbType.Int)).Value = pEntCab.trv_idvendedor == null || pEntCab.trv_idvendedor == 0 ? DBNull.Value : (object)pEntCab.trv_idvendedor;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_idformapago", SqlDbType.Int)).Value = pEntCab.trv_idformapago == null || pEntCab.trv_idformapago == 0 ? DBNull.Value : (object)pEntCab.trv_idformapago;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tdoc", SqlDbType.VarChar)).Value = pEntCab.trv_tdoc == null || pEntCab.trv_tdoc == "" ? DBNull.Value : (object)pEntCab.trv_tdoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_sdoc", SqlDbType.VarChar)).Value = pEntCab.trv_sdoc == null || pEntCab.trv_sdoc == "" ? DBNull.Value : (object)pEntCab.trv_sdoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_ndoc", SqlDbType.VarChar)).Value = pEntCab.trv_ndoc == null || pEntCab.trv_ndoc == "" ? DBNull.Value : (object)pEntCab.trv_ndoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_femision", SqlDbType.DateTime)).Value = pEntCab.trv_femision == null || pEntCab.trv_femision == default(DateTime) ? DBNull.Value : (object)pEntCab.trv_femision;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_fvencimiento", SqlDbType.DateTime)).Value = pEntCab.trv_fvencimiento == null || pEntCab.trv_fvencimiento == default(DateTime) ? DBNull.Value : (object)pEntCab.trv_fvencimiento;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_moneda", SqlDbType.VarChar)).Value = pEntCab.trv_moneda == null || pEntCab.trv_moneda == "" ? DBNull.Value : (object)pEntCab.trv_moneda;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tcambio", SqlDbType.Decimal)).Value = pEntCab.trv_tcambio == null || pEntCab.trv_tcambio == 0 ? DBNull.Value : (object)pEntCab.trv_tcambio;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_dctos", SqlDbType.Decimal)).Value = pEntCab.trv_dctos == null || pEntCab.trv_dctos == 0 ? DBNull.Value : (object)pEntCab.trv_dctos;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_vventa", SqlDbType.Decimal)).Value = pEntCab.trv_vventa == null || pEntCab.trv_vventa == 0 ? DBNull.Value : (object)pEntCab.trv_vventa;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_igv", SqlDbType.Decimal)).Value = pEntCab.trv_igv == null || pEntCab.trv_igv == 0 ? DBNull.Value : (object)pEntCab.trv_igv;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_total", SqlDbType.Decimal)).Value = pEntCab.trv_total == null || pEntCab.trv_total == 0 ? DBNull.Value : (object)pEntCab.trv_total;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_aigv", SqlDbType.Int)).Value = pEntCab.trv_aigv == null || pEntCab.trv_aigv == 0 ? DBNull.Value : (object)pEntCab.trv_aigv;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_flag", SqlDbType.Int)).Value = pEntCab.trv_flag == null || pEntCab.trv_flag == 0 ? DBNull.Value : (object)pEntCab.trv_flag;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_pigv", SqlDbType.Decimal)).Value = pEntCab.trv_pigv == null || pEntCab.trv_pigv == 0 ? DBNull.Value : (object)pEntCab.trv_pigv;
                try
                {
                    vIntResultado = CMDdet_delete.ExecuteNonQuery();
                    vIntResultado = CMDcab_delete.ExecuteNonQuery();
                    vIntResultado = CMDcab_insert.ExecuteNonQuery();
                    foreach (var lLisDet in pLisDet)
                    {
                        CMDdet_insert = new SqlCommand();
                        CMDdet_insert.Connection = oCN2;
                        CMDdet_insert.Transaction = oTransaction;
                        CMDdet_insert.CommandType = CommandType.StoredProcedure;
                        CMDdet_insert.CommandText = "SPU_INSERTAR_TRVENTAS_DET" ;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_empresa", SqlDbType.VarChar)).Value = lLisDet.trvd_empresa == null || lLisDet.trvd_empresa == "" ? DBNull.Value : (object)lLisDet.trvd_empresa;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_periodo", SqlDbType.VarChar)).Value = lLisDet.trvd_periodo == null || lLisDet.trvd_periodo == "" ? DBNull.Value : (object)lLisDet.trvd_periodo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_tipo", SqlDbType.VarChar)).Value = lLisDet.trvd_tipo == null || lLisDet.trvd_tipo == "" ? DBNull.Value : (object)lLisDet.trvd_tipo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_registro", SqlDbType.VarChar)).Value = lLisDet.trvd_registro == null || lLisDet.trvd_registro == "" ? DBNull.Value : (object)lLisDet.trvd_registro;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_nroitm", SqlDbType.Int)).Value = lLisDet.trvd_nroitm == null || lLisDet.trvd_nroitm == 0 ? DBNull.Value : (object)lLisDet.trvd_nroitm;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_idarticulo", SqlDbType.Int)).Value = lLisDet.trvd_idarticulo == null || lLisDet.trvd_idarticulo == 0 ? DBNull.Value : (object)lLisDet.trvd_idarticulo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_cant", SqlDbType.Decimal)).Value = lLisDet.trvd_cant == null || lLisDet.trvd_cant == 0 ? DBNull.Value : (object)lLisDet.trvd_cant;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_preun", SqlDbType.Decimal)).Value = lLisDet.trvd_preun == null || lLisDet.trvd_preun == 0 ? DBNull.Value : (object)lLisDet.trvd_preun;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_pdcto", SqlDbType.Decimal)).Value = lLisDet.trvd_pdcto == null || lLisDet.trvd_pdcto == 0 ? DBNull.Value : (object)lLisDet.trvd_pdcto;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_dcto", SqlDbType.Decimal)).Value = lLisDet.trvd_dcto == null || lLisDet.trvd_dcto == 0 ? DBNull.Value : (object)lLisDet.trvd_dcto;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_vvta", SqlDbType.Decimal)).Value = lLisDet.trvd_vvta == null || lLisDet.trvd_vvta == 0 ? DBNull.Value : (object)lLisDet.trvd_vvta;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_igv", SqlDbType.Decimal)).Value = lLisDet.trvd_igv == null || lLisDet.trvd_igv == 0 ? DBNull.Value : (object)lLisDet.trvd_igv;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_tot", SqlDbType.Decimal)).Value = lLisDet.trvd_tot == null || lLisDet.trvd_tot == 0 ? DBNull.Value : (object)lLisDet.trvd_tot;
                        vIntResultado = CMDdet_insert.ExecuteNonQuery();
                    }
                    if (vIntResultado > 0)
                    {
                        vIntResultadoExecute += 1;
                        //pIntRowsAfect = oCN.GetParameterValue(CMD, "pITEM").ToString;
                    }
                    if (vIntResultadoExecute == 1)
                    {
                        oTransaction.Commit();
                    }
                    else
                    {
                        oTransaction.Rollback();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    oTransaction.Rollback();
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TRVENTAS_CAB" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CMDdet_delete.Dispose();
                    CMDcab_delete.Dispose();
                }
            }
        }
        public bool setActualizarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
        {
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMDdet_delete = new SqlCommand();
            SqlCommand CMDcab_insert = new SqlCommand();
            SqlCommand CMDdet_insert = new SqlCommand();
            using (SqlConnection oCN2 = new SqlConnection(conexion.DBCCapaDatos.pStrConString))
            {
                oCN2.Open();
                SqlTransaction oTransaction = oCN2.BeginTransaction();
                CMDdet_delete.Connection = oCN2;
                CMDdet_delete.Transaction = oTransaction;
                CMDdet_delete.CommandType = CommandType.StoredProcedure;
                CMDdet_delete.CommandText = "SPU_ELIMINAR_TRVENTAS_DET" ;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;

                CMDcab_insert.Connection = oCN2;
                CMDcab_insert.Transaction = oTransaction;
                CMDcab_insert.CommandType = CommandType.StoredProcedure;
                CMDcab_insert.CommandText = "SPU_ACTUALIZAR_TRVENTAS_CAB" ;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_empresa", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_periodo", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tipo", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_registro", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_entidad", SqlDbType.Int)).Value = pEntCab.trv_entidad == null || pEntCab.trv_entidad == 0 ? DBNull.Value : (object)pEntCab.trv_entidad;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_idvendedor", SqlDbType.Int)).Value = pEntCab.trv_idvendedor == null || pEntCab.trv_idvendedor == 0 ? DBNull.Value : (object)pEntCab.trv_idvendedor;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_idformapago", SqlDbType.Int)).Value = pEntCab.trv_idformapago == null || pEntCab.trv_idformapago == 0 ? DBNull.Value : (object)pEntCab.trv_idformapago;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tdoc", SqlDbType.VarChar)).Value = pEntCab.trv_tdoc == null || pEntCab.trv_tdoc == "" ? DBNull.Value : (object)pEntCab.trv_tdoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_sdoc", SqlDbType.VarChar)).Value = pEntCab.trv_sdoc == null || pEntCab.trv_sdoc == "" ? DBNull.Value : (object)pEntCab.trv_sdoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_ndoc", SqlDbType.VarChar)).Value = pEntCab.trv_ndoc == null || pEntCab.trv_ndoc == "" ? DBNull.Value : (object)pEntCab.trv_ndoc;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_femision", SqlDbType.DateTime)).Value = pEntCab.trv_femision == null || pEntCab.trv_femision == default(DateTime) ? DBNull.Value : (object)pEntCab.trv_femision;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_fvencimiento", SqlDbType.DateTime)).Value = pEntCab.trv_fvencimiento == null || pEntCab.trv_fvencimiento == default(DateTime) ? DBNull.Value : (object)pEntCab.trv_fvencimiento;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_moneda", SqlDbType.VarChar)).Value = pEntCab.trv_moneda == null || pEntCab.trv_moneda == "" ? DBNull.Value : (object)pEntCab.trv_moneda;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_tcambio", SqlDbType.Decimal)).Value = pEntCab.trv_tcambio == null || pEntCab.trv_tcambio == 0 ? DBNull.Value : (object)pEntCab.trv_tcambio;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_dctos", SqlDbType.Decimal)).Value = pEntCab.trv_dctos == null || pEntCab.trv_dctos == 0 ? DBNull.Value : (object)pEntCab.trv_dctos;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_vventa", SqlDbType.Decimal)).Value = pEntCab.trv_vventa == null || pEntCab.trv_vventa == 0 ? DBNull.Value : (object)pEntCab.trv_vventa;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_igv", SqlDbType.Decimal)).Value = pEntCab.trv_igv == null || pEntCab.trv_igv == 0 ? DBNull.Value : (object)pEntCab.trv_igv;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_total", SqlDbType.Decimal)).Value = pEntCab.trv_total == null || pEntCab.trv_total == 0 ? DBNull.Value : (object)pEntCab.trv_total;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_aigv", SqlDbType.Int)).Value = pEntCab.trv_aigv == null || pEntCab.trv_aigv == 0 ? DBNull.Value : (object)pEntCab.trv_aigv;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_flag", SqlDbType.Int)).Value = pEntCab.trv_flag == null || pEntCab.trv_flag == 0 ? DBNull.Value : (object)pEntCab.trv_flag;
                CMDcab_insert.Parameters.Add(new SqlParameter("@ptrv_pigv", SqlDbType.Decimal)).Value = pEntCab.trv_pigv == null || pEntCab.trv_pigv == 0 ? DBNull.Value : (object)pEntCab.trv_pigv;
                try
                {
                    vIntResultado = CMDdet_delete.ExecuteNonQuery();
                    vIntResultado = CMDcab_insert.ExecuteNonQuery();
                    foreach (var lLisDet in pLisDet)
                    {
                        CMDdet_insert = new SqlCommand();
                        CMDdet_insert.Connection = oCN2;
                        CMDdet_insert.Transaction = oTransaction;
                        CMDdet_insert.CommandType = CommandType.StoredProcedure;
                        CMDdet_insert.CommandText = "SPU_INSERTAR_TRVENTAS_DET" ;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_empresa", SqlDbType.VarChar)).Value = lLisDet.trvd_empresa == null || lLisDet.trvd_empresa == "" ? DBNull.Value : (object)lLisDet.trvd_empresa;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_periodo", SqlDbType.VarChar)).Value = lLisDet.trvd_periodo == null || lLisDet.trvd_periodo == "" ? DBNull.Value : (object)lLisDet.trvd_periodo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_tipo", SqlDbType.VarChar)).Value = lLisDet.trvd_tipo == null || lLisDet.trvd_tipo == "" ? DBNull.Value : (object)lLisDet.trvd_tipo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_registro", SqlDbType.VarChar)).Value = lLisDet.trvd_registro == null || lLisDet.trvd_registro == "" ? DBNull.Value : (object)lLisDet.trvd_registro;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_nroitm", SqlDbType.Int)).Value = lLisDet.trvd_nroitm == null || lLisDet.trvd_nroitm == 0 ? DBNull.Value : (object)lLisDet.trvd_nroitm;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_idarticulo", SqlDbType.Int)).Value = lLisDet.trvd_idarticulo == null || lLisDet.trvd_idarticulo == 0 ? DBNull.Value : (object)lLisDet.trvd_idarticulo;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_cant", SqlDbType.Decimal)).Value = lLisDet.trvd_cant == null || lLisDet.trvd_cant == 0 ? DBNull.Value : (object)lLisDet.trvd_cant;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_preun", SqlDbType.Decimal)).Value = lLisDet.trvd_preun == null || lLisDet.trvd_preun == 0 ? DBNull.Value : (object)lLisDet.trvd_preun;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_pdcto", SqlDbType.Decimal)).Value = lLisDet.trvd_pdcto == null || lLisDet.trvd_pdcto == 0 ? DBNull.Value : (object)lLisDet.trvd_pdcto;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_dcto", SqlDbType.Decimal)).Value = lLisDet.trvd_dcto == null || lLisDet.trvd_dcto == 0 ? DBNull.Value : (object)lLisDet.trvd_dcto;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_vvta", SqlDbType.Decimal)).Value = lLisDet.trvd_vvta == null || lLisDet.trvd_vvta == 0 ? DBNull.Value : (object)lLisDet.trvd_vvta;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_igv", SqlDbType.Decimal)).Value = lLisDet.trvd_igv == null || lLisDet.trvd_igv == 0 ? DBNull.Value : (object)lLisDet.trvd_igv;
                        CMDdet_insert.Parameters.Add(new SqlParameter("@ptrvd_tot", SqlDbType.Decimal)).Value = lLisDet.trvd_tot == null || lLisDet.trvd_tot == 0 ? DBNull.Value : (object)lLisDet.trvd_tot;
                        vIntResultado = CMDdet_insert.ExecuteNonQuery();
                    }
                    if (vIntResultado > 0)
                    {
                        vIntResultadoExecute += 1;
                        //pIntRowsAfect = oCN.GetParameterValue(CMD, "pITEM").ToString;
                    }
                    if (vIntResultadoExecute == 1)
                    {
                        oTransaction.Commit();
                    }
                    else
                    {
                        oTransaction.Rollback();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    oTransaction.Rollback();
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TRVENTAS_CAB" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CMDdet_delete.Dispose();
                }
            }
        }
        public bool setEliminarTRVENTAS_CAB(ENT_TRVENTAS_CAB pEntCab, out int pIntRowsAfect)
        {
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMDdet_delete = new SqlCommand();
            SqlCommand CMDcab_delete = new SqlCommand();
            using (SqlConnection oCN2 = new SqlConnection(conexion.DBCCapaDatos.pStrConString))
            {
                oCN2.Open();
                SqlTransaction oTransaction = oCN2.BeginTransaction();
                CMDdet_delete.Connection = oCN2;
                CMDdet_delete.Transaction = oTransaction;
                CMDdet_delete.CommandType = CommandType.StoredProcedure;
                CMDdet_delete.CommandText = "SPU_ELIMINAR_TRVENTAS_DET" ;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;
                CMDcab_delete.Connection = oCN2;
                CMDcab_delete.Transaction = oTransaction;
                CMDcab_delete.CommandType = CommandType.StoredProcedure;
                CMDcab_delete.CommandText = "SPU_ELIMINAR_TRVENTAS_CAB" ;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_empresa", SqlDbType.VarChar)).Value = pEntCab.trv_empresa == null || pEntCab.trv_empresa == "" ? DBNull.Value : (object)pEntCab.trv_empresa;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_periodo", SqlDbType.VarChar)).Value = pEntCab.trv_periodo == null || pEntCab.trv_periodo == "" ? DBNull.Value : (object)pEntCab.trv_periodo;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_tipo", SqlDbType.VarChar)).Value = pEntCab.trv_tipo == null || pEntCab.trv_tipo == "" ? DBNull.Value : (object)pEntCab.trv_tipo;
                CMDcab_delete.Parameters.Add(new SqlParameter("@ptrv_registro", SqlDbType.VarChar)).Value = pEntCab.trv_registro == null || pEntCab.trv_registro == "" ? DBNull.Value : (object)pEntCab.trv_registro;

                try
                {
                    vIntResultado = CMDdet_delete.ExecuteNonQuery();
                    vIntResultado = CMDcab_delete.ExecuteNonQuery();
                    if (vIntResultado > 0)
                    {
                        vIntResultadoExecute += 1;
                        //pIntRowsAfect = oCN.GetParameterValue(CMD, "pITEM").ToString;
                    }
                    if (vIntResultadoExecute == 1)
                    {
                        oTransaction.Commit();
                    }
                    else
                    {
                        oTransaction.Rollback();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    oTransaction.Rollback();
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TRVENTAS_CAB" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CMDdet_delete.Dispose();
                    CMDcab_delete.Dispose();
                }
            }
        }
    }
}
