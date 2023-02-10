using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TFAMILIA : IADT_TFAMILIA<ENT_TFAMILIA>
    {
        public bool setInsertarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
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
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;
                CMDcab_delete.Connection = oCN2;
                CMDcab_delete.Transaction = oTransaction;
                CMDcab_delete.CommandType = CommandType.StoredProcedure;
                CMDcab_delete.CommandText = "SPU_ELIMINAR_TFAMILIA" ;
                CMDcab_delete.Parameters.Add(new SqlParameter("@pid_familia", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;

                CMDcab_insert.Connection = oCN2;
                CMDcab_insert.Transaction = oTransaction;
                CMDcab_insert.CommandType = CommandType.StoredProcedure;
                CMDcab_insert.CommandText = "SPU_INSERTAR_TFAMILIA" ;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pid_familia", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pc_familia", SqlDbType.VarChar)).Value = pEntCab.c_familia == null || pEntCab.c_familia == "" ? DBNull.Value : (object)pEntCab.c_familia;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pt_familia", SqlDbType.VarChar)).Value = pEntCab.t_familia == null || pEntCab.t_familia == "" ? DBNull.Value : (object)pEntCab.t_familia;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFAMILIA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CMDdet_delete.Dispose();
                    CMDcab_delete.Dispose();
                }
            }
        }
        public bool setActualizarTFAMILIA(ENT_TFAMILIA pEntCab, List<ENT_TRVENTAS_DET> pLisDet, out int pIntRowsAfect)
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
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;

                CMDcab_insert.Connection = oCN2;
                CMDcab_insert.Transaction = oTransaction;
                CMDcab_insert.CommandType = CommandType.StoredProcedure;
                CMDcab_insert.CommandText = "SPU_ACTUALIZAR_TFAMILIA" ;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pid_familia", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pc_familia", SqlDbType.VarChar)).Value = pEntCab.c_familia == null || pEntCab.c_familia == "" ? DBNull.Value : (object)pEntCab.c_familia;
                CMDcab_insert.Parameters.Add(new SqlParameter("@pt_familia", SqlDbType.VarChar)).Value = pEntCab.t_familia == null || pEntCab.t_familia == "" ? DBNull.Value : (object)pEntCab.t_familia;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFAMILIA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    CMDdet_delete.Dispose();
                }
            }
        }
        public bool setEliminarTFAMILIA(ENT_TFAMILIA pEntCab, out int pIntRowsAfect)
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
                CMDdet_delete.Parameters.Add(new SqlParameter("@p", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;
                CMDcab_delete.Connection = oCN2;
                CMDcab_delete.Transaction = oTransaction;
                CMDcab_delete.CommandType = CommandType.StoredProcedure;
                CMDcab_delete.CommandText = "SPU_ELIMINAR_TFAMILIA" ;
                CMDcab_delete.Parameters.Add(new SqlParameter("@pid_familia", SqlDbType.Int)).Value = pEntCab.id_familia == null || pEntCab.id_familia == 0 ? DBNull.Value : (object)pEntCab.id_familia;

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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFAMILIA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
