using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TVENDEDOR : IADT_TVENDEDOR<ENT_TVENDEDOR>
    {
        public bool setInsertarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TVENDEDOR" ;
                CMD.Parameters.Add(new SqlParameter("@pid_vendedor", SqlDbType.Int)).Value = pEntidad.id_vendedor == null || pEntidad.id_vendedor == 0 ? DBNull.Value : (object)pEntidad.id_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pid_supervisor", SqlDbType.Int)).Value = pEntidad.id_supervisor == null || pEntidad.id_supervisor == 0 ? DBNull.Value : (object)pEntidad.id_supervisor;
                CMD.Parameters.Add(new SqlParameter("@pc_vendedor", SqlDbType.VarChar)).Value = pEntidad.c_vendedor == null || pEntidad.c_vendedor == "" ? DBNull.Value : (object)pEntidad.c_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pt_vendedor", SqlDbType.VarChar)).Value = pEntidad.t_vendedor == null || pEntidad.t_vendedor == "" ? DBNull.Value : (object)pEntidad.t_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pf_activo", SqlDbType.Int)).Value = pEntidad.f_activo == null || pEntidad.f_activo == 0 ? DBNull.Value : (object)pEntidad.f_activo;
                CMD.Parameters.Add(new SqlParameter("@pt_telefono", SqlDbType.VarChar)).Value = pEntidad.t_telefono == null || pEntidad.t_telefono == "" ? DBNull.Value : (object)pEntidad.t_telefono;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre_vendedor", SqlDbType.VarChar)).Value = pEntidad.t_nombre_vendedor == null || pEntidad.t_nombre_vendedor == "" ? DBNull.Value : (object)pEntidad.t_nombre_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pt_dni", SqlDbType.VarChar)).Value = pEntidad.t_dni == null || pEntidad.t_dni == "" ? DBNull.Value : (object)pEntidad.t_dni;
                CMD.Parameters.Add(new SqlParameter("@pt_domicilio", SqlDbType.VarChar)).Value = pEntidad.t_domicilio == null || pEntidad.t_domicilio == "" ? DBNull.Value : (object)pEntidad.t_domicilio;
                CMD.Parameters.Add(new SqlParameter("@pt_zona", SqlDbType.VarChar)).Value = pEntidad.t_zona == null || pEntidad.t_zona == "" ? DBNull.Value : (object)pEntidad.t_zona;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TVENDEDOR" ;
                CMD.Parameters.Add(new SqlParameter("@pid_vendedor", SqlDbType.Int)).Value = pEntidad.id_vendedor == null || pEntidad.id_vendedor == 0 ? DBNull.Value : (object)pEntidad.id_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pid_supervisor", SqlDbType.Int)).Value = pEntidad.id_supervisor == null || pEntidad.id_supervisor == 0 ? DBNull.Value : (object)pEntidad.id_supervisor;
                CMD.Parameters.Add(new SqlParameter("@pc_vendedor", SqlDbType.VarChar)).Value = pEntidad.c_vendedor == null || pEntidad.c_vendedor == "" ? DBNull.Value : (object)pEntidad.c_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pt_vendedor", SqlDbType.VarChar)).Value = pEntidad.t_vendedor == null || pEntidad.t_vendedor == "" ? DBNull.Value : (object)pEntidad.t_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pf_activo", SqlDbType.Int)).Value = pEntidad.f_activo == null || pEntidad.f_activo == 0 ? DBNull.Value : (object)pEntidad.f_activo;
                CMD.Parameters.Add(new SqlParameter("@pt_telefono", SqlDbType.VarChar)).Value = pEntidad.t_telefono == null || pEntidad.t_telefono == "" ? DBNull.Value : (object)pEntidad.t_telefono;
                CMD.Parameters.Add(new SqlParameter("@pt_nombre_vendedor", SqlDbType.VarChar)).Value = pEntidad.t_nombre_vendedor == null || pEntidad.t_nombre_vendedor == "" ? DBNull.Value : (object)pEntidad.t_nombre_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pt_dni", SqlDbType.VarChar)).Value = pEntidad.t_dni == null || pEntidad.t_dni == "" ? DBNull.Value : (object)pEntidad.t_dni;
                CMD.Parameters.Add(new SqlParameter("@pt_domicilio", SqlDbType.VarChar)).Value = pEntidad.t_domicilio == null || pEntidad.t_domicilio == "" ? DBNull.Value : (object)pEntidad.t_domicilio;
                CMD.Parameters.Add(new SqlParameter("@pt_zona", SqlDbType.VarChar)).Value = pEntidad.t_zona == null || pEntidad.t_zona == "" ? DBNull.Value : (object)pEntidad.t_zona;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTVENDEDOR(ENT_TVENDEDOR pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TVENDEDOR" ;
                CMD.Parameters.Add(new SqlParameter("@pid_vendedor", SqlDbType.Int)).Value = pEntidad.id_vendedor == null || pEntidad.id_vendedor == 0 ? DBNull.Value : (object)pEntidad.id_vendedor;
                CMD.Parameters.Add(new SqlParameter("@pc_vendedor", SqlDbType.VarChar)).Value = pEntidad.c_vendedor == null || pEntidad.c_vendedor == "" ? DBNull.Value : (object)pEntidad.c_vendedor;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TVENDEDOR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
