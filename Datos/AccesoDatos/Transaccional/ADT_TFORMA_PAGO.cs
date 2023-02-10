using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TFORMA_PAGO : IADT_TFORMA_PAGO<ENT_TFORMA_PAGO>
    {
        public bool setInsertarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TFORMA_PAGO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_forma_pago", SqlDbType.Int)).Value = pEntidad.id_forma_pago == null || pEntidad.id_forma_pago == 0 ? DBNull.Value : (object)pEntidad.id_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pc_forma_pago", SqlDbType.VarChar)).Value = pEntidad.c_forma_pago == null || pEntidad.c_forma_pago == "" ? DBNull.Value : (object)pEntidad.c_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pt_forma_pago", SqlDbType.VarChar)).Value = pEntidad.t_forma_pago == null || pEntidad.t_forma_pago == "" ? DBNull.Value : (object)pEntidad.t_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pn_dias", SqlDbType.Int)).Value = pEntidad.n_dias == null || pEntidad.n_dias == 0 ? DBNull.Value : (object)pEntidad.n_dias;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TFORMA_PAGO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_forma_pago", SqlDbType.Int)).Value = pEntidad.id_forma_pago == null || pEntidad.id_forma_pago == 0 ? DBNull.Value : (object)pEntidad.id_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pc_forma_pago", SqlDbType.VarChar)).Value = pEntidad.c_forma_pago == null || pEntidad.c_forma_pago == "" ? DBNull.Value : (object)pEntidad.c_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pt_forma_pago", SqlDbType.VarChar)).Value = pEntidad.t_forma_pago == null || pEntidad.t_forma_pago == "" ? DBNull.Value : (object)pEntidad.t_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pn_dias", SqlDbType.Int)).Value = pEntidad.n_dias == null || pEntidad.n_dias == 0 ? DBNull.Value : (object)pEntidad.n_dias;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTFORMA_PAGO(ENT_TFORMA_PAGO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TFORMA_PAGO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_forma_pago", SqlDbType.Int)).Value = pEntidad.id_forma_pago == null || pEntidad.id_forma_pago == 0 ? DBNull.Value : (object)pEntidad.id_forma_pago;
                CMD.Parameters.Add(new SqlParameter("@pc_forma_pago", SqlDbType.VarChar)).Value = pEntidad.c_forma_pago == null || pEntidad.c_forma_pago == "" ? DBNull.Value : (object)pEntidad.c_forma_pago;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TFORMA_PAGO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
