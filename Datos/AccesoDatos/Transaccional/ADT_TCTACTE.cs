using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TCTACTE : IADT_TCTACTE<ENT_TCTACTE>
    {
        public bool setInsertarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TCTACTE" ;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte", SqlDbType.Int)).Value = pEntidad.id_ctacte == null || pEntidad.id_ctacte == 0 ? DBNull.Value : (object)pEntidad.id_ctacte;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo", SqlDbType.Int)).Value = pEntidad.id_ctacte_tipo == null || pEntidad.id_ctacte_tipo == 0 ? DBNull.Value : (object)pEntidad.id_ctacte_tipo;
                CMD.Parameters.Add(new SqlParameter("@pc_ctacte", SqlDbType.VarChar)).Value = pEntidad.c_ctacte == null || pEntidad.c_ctacte == "" ? DBNull.Value : (object)pEntidad.c_ctacte;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo_documento", SqlDbType.Int)).Value = pEntidad.id_ctacte_tipo_documento == null || pEntidad.id_ctacte_tipo_documento == 0 ? DBNull.Value : (object)pEntidad.id_ctacte_tipo_documento;
                CMD.Parameters.Add(new SqlParameter("@pc_numero_documento", SqlDbType.VarChar)).Value = pEntidad.c_numero_documento == null || pEntidad.c_numero_documento == "" ? DBNull.Value : (object)pEntidad.c_numero_documento;
                CMD.Parameters.Add(new SqlParameter("@pt_ape_pat", SqlDbType.VarChar)).Value = pEntidad.t_ape_pat == null || pEntidad.t_ape_pat == "" ? DBNull.Value : (object)pEntidad.t_ape_pat;
                CMD.Parameters.Add(new SqlParameter("@pt_ape_mat", SqlDbType.VarChar)).Value = pEntidad.t_ape_mat == null || pEntidad.t_ape_mat == "" ? DBNull.Value : (object)pEntidad.t_ape_mat;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre1", SqlDbType.VarChar)).Value = pEntidad.t_nombre1 == null || pEntidad.t_nombre1 == "" ? DBNull.Value : (object)pEntidad.t_nombre1;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre2", SqlDbType.VarChar)).Value = pEntidad.t_nombre2 == null || pEntidad.t_nombre2 == "" ? DBNull.Value : (object)pEntidad.t_nombre2;
                CMD.Parameters.Add(new SqlParameter("@pt_razon_social", SqlDbType.VarChar)).Value = pEntidad.t_razon_social == null || pEntidad.t_razon_social == "" ? DBNull.Value : (object)pEntidad.t_razon_social;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre_comercial", SqlDbType.VarChar)).Value = pEntidad.t_nombre_comercial == null || pEntidad.t_nombre_comercial == "" ? DBNull.Value : (object)pEntidad.t_nombre_comercial;
                CMD.Parameters.Add(new SqlParameter("@pt_cargo", SqlDbType.VarChar)).Value = pEntidad.t_cargo == null || pEntidad.t_cargo == "" ? DBNull.Value : (object)pEntidad.t_cargo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TCTACTE" ;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte", SqlDbType.Int)).Value = pEntidad.id_ctacte == null || pEntidad.id_ctacte == 0 ? DBNull.Value : (object)pEntidad.id_ctacte;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo", SqlDbType.Int)).Value = pEntidad.id_ctacte_tipo == null || pEntidad.id_ctacte_tipo == 0 ? DBNull.Value : (object)pEntidad.id_ctacte_tipo;
                CMD.Parameters.Add(new SqlParameter("@pc_ctacte", SqlDbType.VarChar)).Value = pEntidad.c_ctacte == null || pEntidad.c_ctacte == "" ? DBNull.Value : (object)pEntidad.c_ctacte;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte_tipo_documento", SqlDbType.Int)).Value = pEntidad.id_ctacte_tipo_documento == null || pEntidad.id_ctacte_tipo_documento == 0 ? DBNull.Value : (object)pEntidad.id_ctacte_tipo_documento;
                CMD.Parameters.Add(new SqlParameter("@pc_numero_documento", SqlDbType.VarChar)).Value = pEntidad.c_numero_documento == null || pEntidad.c_numero_documento == "" ? DBNull.Value : (object)pEntidad.c_numero_documento;
                CMD.Parameters.Add(new SqlParameter("@pt_ape_pat", SqlDbType.VarChar)).Value = pEntidad.t_ape_pat == null || pEntidad.t_ape_pat == "" ? DBNull.Value : (object)pEntidad.t_ape_pat;
                CMD.Parameters.Add(new SqlParameter("@pt_ape_mat", SqlDbType.VarChar)).Value = pEntidad.t_ape_mat == null || pEntidad.t_ape_mat == "" ? DBNull.Value : (object)pEntidad.t_ape_mat;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre1", SqlDbType.VarChar)).Value = pEntidad.t_nombre1 == null || pEntidad.t_nombre1 == "" ? DBNull.Value : (object)pEntidad.t_nombre1;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre2", SqlDbType.VarChar)).Value = pEntidad.t_nombre2 == null || pEntidad.t_nombre2 == "" ? DBNull.Value : (object)pEntidad.t_nombre2;
                CMD.Parameters.Add(new SqlParameter("@pt_razon_social", SqlDbType.VarChar)).Value = pEntidad.t_razon_social == null || pEntidad.t_razon_social == "" ? DBNull.Value : (object)pEntidad.t_razon_social;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre_comercial", SqlDbType.VarChar)).Value = pEntidad.t_nombre_comercial == null || pEntidad.t_nombre_comercial == "" ? DBNull.Value : (object)pEntidad.t_nombre_comercial;
                CMD.Parameters.Add(new SqlParameter("@pt_cargo", SqlDbType.VarChar)).Value = pEntidad.t_cargo == null || pEntidad.t_cargo == "" ? DBNull.Value : (object)pEntidad.t_cargo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTCTACTE(ENT_TCTACTE pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TCTACTE" ;
                CMD.Parameters.Add(new SqlParameter("@pid_ctacte", SqlDbType.Int)).Value = pEntidad.id_ctacte == null || pEntidad.id_ctacte == 0 ? DBNull.Value : (object)pEntidad.id_ctacte;
                CMD.Parameters.Add(new SqlParameter("@pc_ctacte", SqlDbType.VarChar)).Value = pEntidad.c_ctacte == null || pEntidad.c_ctacte == "" ? DBNull.Value : (object)pEntidad.c_ctacte;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TCTACTE" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
