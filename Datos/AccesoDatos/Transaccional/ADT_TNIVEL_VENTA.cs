using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TNIVEL_VENTA : IADT_TNIVEL_VENTA<ENT_TNIVEL_VENTA>
    {
        public bool setInsertarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
        {
            SqlConnection oCN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            oCN.Open();
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMD = new SqlCommand();
            SqlTransaction oTransaction = oCN.BeginTransaction();
            try
            {
                CMD.Connection = oCN;
                CMD.Transaction = oTransaction;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "SPU_INSERTAR_TNIVEL_VENTA" ;
                CMD.Parameters.Add(new SqlParameter("@ptven_empresa", SqlDbType.VarChar)).Value = pEntidad.tven_empresa == null || pEntidad.tven_empresa == "" ? DBNull.Value : (object)pEntidad.tven_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptven_codigo", SqlDbType.VarChar)).Value = pEntidad.tven_codigo == null || pEntidad.tven_codigo == "" ? DBNull.Value : (object)pEntidad.tven_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptven_sigla", SqlDbType.VarChar)).Value = pEntidad.tven_sigla == null || pEntidad.tven_sigla == "" ? DBNull.Value : (object)pEntidad.tven_sigla;
                CMD.Parameters.Add(new SqlParameter("@ptven_descripcion", SqlDbType.VarChar)).Value = pEntidad.tven_descripcion == null || pEntidad.tven_descripcion == "" ? DBNull.Value : (object)pEntidad.tven_descripcion;
                CMD.Parameters.Add(new SqlParameter("@ptven_activo", SqlDbType.Int)).Value = pEntidad.tven_activo == null || pEntidad.tven_activo == 0 ? DBNull.Value : (object)pEntidad.tven_activo;
                //using (SqlConnection oCN2 =new SqlConnection(conexion.DBCCapaDatos.pStrConString))
                //{
                    //oCN2.Open();
                    //SqlTransaction oTransaction = oCN2.BeginTransaction();
                    try
                    {
                        vIntResultado = CMD.ExecuteNonQuery();
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
        {
            SqlConnection oCN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            oCN.Open();
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMD = new SqlCommand();
            SqlTransaction oTransaction = oCN.BeginTransaction();
            try
            {
                CMD.Connection = oCN;
                CMD.Transaction = oTransaction;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "SPU_ACTUALIZAR_TNIVEL_VENTA" ;
                CMD.Parameters.Add(new SqlParameter("@ptven_empresa", SqlDbType.VarChar)).Value = pEntidad.tven_empresa == null || pEntidad.tven_empresa == "" ? DBNull.Value : (object)pEntidad.tven_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptven_codigo", SqlDbType.VarChar)).Value = pEntidad.tven_codigo == null || pEntidad.tven_codigo == "" ? DBNull.Value : (object)pEntidad.tven_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptven_sigla", SqlDbType.VarChar)).Value = pEntidad.tven_sigla == null || pEntidad.tven_sigla == "" ? DBNull.Value : (object)pEntidad.tven_sigla;
                CMD.Parameters.Add(new SqlParameter("@ptven_descripcion", SqlDbType.VarChar)).Value = pEntidad.tven_descripcion == null || pEntidad.tven_descripcion == "" ? DBNull.Value : (object)pEntidad.tven_descripcion;
                CMD.Parameters.Add(new SqlParameter("@ptven_activo", SqlDbType.Int)).Value = pEntidad.tven_activo == null || pEntidad.tven_activo == 0 ? DBNull.Value : (object)pEntidad.tven_activo;
                //using (SqlConnection oCN2 =new SqlConnection(conexion.DBCCapaDatos.pStrConString))
                //{
                    //oCN2.Open();
                    //SqlTransaction oTransaction = oCN2.BeginTransaction();
                    try
                    {
                        vIntResultado = CMD.ExecuteNonQuery();
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTNIVEL_VENTA(ENT_TNIVEL_VENTA pEntidad, out int pIntRowsAfect)
        {
            SqlConnection oCN = new SqlConnection(conexion.DBCCapaDatos.pStrConString);
            oCN.Open();
            int vIntResultado;
            int vIntResultadoExecute = 0;
            pIntRowsAfect = 0;
            SqlCommand CMD = new SqlCommand();
            SqlTransaction oTransaction = oCN.BeginTransaction();
            try
            {
                CMD.Connection = oCN;
                CMD.Transaction = oTransaction;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "SPU_ELIMINAR_TNIVEL_VENTA" ;
                CMD.Parameters.Add(new SqlParameter("@ptven_empresa", SqlDbType.VarChar)).Value = pEntidad.tven_empresa == null || pEntidad.tven_empresa == "" ? DBNull.Value : (object)pEntidad.tven_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptven_codigo", SqlDbType.VarChar)).Value = pEntidad.tven_codigo == null || pEntidad.tven_codigo == "" ? DBNull.Value : (object)pEntidad.tven_codigo;
                //using (SqlConnection oCN2 =new SqlConnection(conexion.DBCCapaDatos.pStrConString))
                //{
                    //oCN2.Open();
                    //SqlTransaction oTransaction = oCN2.BeginTransaction();
                    try
                    {
                        vIntResultado = CMD.ExecuteNonQuery();
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TNIVEL_VENTA" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
    }
}
