using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TMONEDAS : IADT_TMONEDAS<ENT_TMONEDAS>
    {
        public bool setInsertarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TMONEDAS" ;
                CMD.Parameters.Add(new SqlParameter("@pmnd_cod", SqlDbType.VarChar)).Value = pEntidad.mnd_cod == null || pEntidad.mnd_cod == "" ? DBNull.Value : (object)pEntidad.mnd_cod;
                CMD.Parameters.Add(new SqlParameter("@pmnd_des", SqlDbType.VarChar)).Value = pEntidad.mnd_des == null || pEntidad.mnd_des == "" ? DBNull.Value : (object)pEntidad.mnd_des;
                CMD.Parameters.Add(new SqlParameter("@pmnd_sigla", SqlDbType.VarChar)).Value = pEntidad.mnd_sigla == null || pEntidad.mnd_sigla == "" ? DBNull.Value : (object)pEntidad.mnd_sigla;
                CMD.Parameters.Add(new SqlParameter("@pmnd_abrev", SqlDbType.VarChar)).Value = pEntidad.mnd_abrev == null || pEntidad.mnd_abrev == "" ? DBNull.Value : (object)pEntidad.mnd_abrev;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TMONEDAS" ;
                CMD.Parameters.Add(new SqlParameter("@pmnd_cod", SqlDbType.VarChar)).Value = pEntidad.mnd_cod == null || pEntidad.mnd_cod == "" ? DBNull.Value : (object)pEntidad.mnd_cod;
                CMD.Parameters.Add(new SqlParameter("@pmnd_des", SqlDbType.VarChar)).Value = pEntidad.mnd_des == null || pEntidad.mnd_des == "" ? DBNull.Value : (object)pEntidad.mnd_des;
                CMD.Parameters.Add(new SqlParameter("@pmnd_sigla", SqlDbType.VarChar)).Value = pEntidad.mnd_sigla == null || pEntidad.mnd_sigla == "" ? DBNull.Value : (object)pEntidad.mnd_sigla;
                CMD.Parameters.Add(new SqlParameter("@pmnd_abrev", SqlDbType.VarChar)).Value = pEntidad.mnd_abrev == null || pEntidad.mnd_abrev == "" ? DBNull.Value : (object)pEntidad.mnd_abrev;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTMONEDAS(ENT_TMONEDAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TMONEDAS" ;
                CMD.Parameters.Add(new SqlParameter("@pmnd_cod", SqlDbType.VarChar)).Value = pEntidad.mnd_cod == null || pEntidad.mnd_cod == "" ? DBNull.Value : (object)pEntidad.mnd_cod;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TMONEDAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
