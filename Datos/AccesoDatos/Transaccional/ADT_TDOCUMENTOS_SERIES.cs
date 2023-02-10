using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TDOCUMENTOS_SERIES : IADT_TDOCUMENTOS_SERIES<ENT_TDOCUMENTOS_SERIES>
    {
        public bool setInsertarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TDOCUMENTOS_SERIES" ;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_empresa", SqlDbType.VarChar)).Value = pEntidad.tdocs_empresa == null || pEntidad.tdocs_empresa == "" ? DBNull.Value : (object)pEntidad.tdocs_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_codigo", SqlDbType.VarChar)).Value = pEntidad.tdocs_codigo == null || pEntidad.tdocs_codigo == "" ? DBNull.Value : (object)pEntidad.tdocs_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_serie", SqlDbType.VarChar)).Value = pEntidad.tdocs_serie == null || pEntidad.tdocs_serie == "" ? DBNull.Value : (object)pEntidad.tdocs_serie;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_numerador", SqlDbType.VarChar)).Value = pEntidad.tdocs_numerador == null || pEntidad.tdocs_numerador == "" ? DBNull.Value : (object)pEntidad.tdocs_numerador;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_serie_predeterminada", SqlDbType.Bit)).Value = pEntidad.tdocs_serie_predeterminada == null || pEntidad.tdocs_serie_predeterminada == false ? DBNull.Value : (object)pEntidad.tdocs_serie_predeterminada;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TDOCUMENTOS_SERIES" ;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_empresa", SqlDbType.VarChar)).Value = pEntidad.tdocs_empresa == null || pEntidad.tdocs_empresa == "" ? DBNull.Value : (object)pEntidad.tdocs_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_codigo", SqlDbType.VarChar)).Value = pEntidad.tdocs_codigo == null || pEntidad.tdocs_codigo == "" ? DBNull.Value : (object)pEntidad.tdocs_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_serie", SqlDbType.VarChar)).Value = pEntidad.tdocs_serie == null || pEntidad.tdocs_serie == "" ? DBNull.Value : (object)pEntidad.tdocs_serie;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_numerador", SqlDbType.VarChar)).Value = pEntidad.tdocs_numerador == null || pEntidad.tdocs_numerador == "" ? DBNull.Value : (object)pEntidad.tdocs_numerador;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_serie_predeterminada", SqlDbType.Bit)).Value = pEntidad.tdocs_serie_predeterminada == null || pEntidad.tdocs_serie_predeterminada == false ? DBNull.Value : (object)pEntidad.tdocs_serie_predeterminada;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTDOCUMENTOS_SERIES(ENT_TDOCUMENTOS_SERIES pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TDOCUMENTOS_SERIES" ;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_empresa", SqlDbType.VarChar)).Value = pEntidad.tdocs_empresa == null || pEntidad.tdocs_empresa == "" ? DBNull.Value : (object)pEntidad.tdocs_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_codigo", SqlDbType.VarChar)).Value = pEntidad.tdocs_codigo == null || pEntidad.tdocs_codigo == "" ? DBNull.Value : (object)pEntidad.tdocs_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptdocs_serie", SqlDbType.VarChar)).Value = pEntidad.tdocs_serie == null || pEntidad.tdocs_serie == "" ? DBNull.Value : (object)pEntidad.tdocs_serie;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS_SERIES" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
