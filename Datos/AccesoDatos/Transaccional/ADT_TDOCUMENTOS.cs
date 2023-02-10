using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TDOCUMENTOS : IADT_TDOCUMENTOS<ENT_TDOCUMENTOS>
    {
        public bool setInsertarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TDOCUMENTOS" ;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_empresa", SqlDbType.VarChar)).Value = pEntidad.tdoc_empresa == null || pEntidad.tdoc_empresa == "" ? DBNull.Value : (object)pEntidad.tdoc_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_codigo", SqlDbType.VarChar)).Value = pEntidad.tdoc_codigo == null || pEntidad.tdoc_codigo == "" ? DBNull.Value : (object)pEntidad.tdoc_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_sigla", SqlDbType.VarChar)).Value = pEntidad.tdoc_sigla == null || pEntidad.tdoc_sigla == "" ? DBNull.Value : (object)pEntidad.tdoc_sigla;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_descripcion", SqlDbType.VarChar)).Value = pEntidad.tdoc_descripcion == null || pEntidad.tdoc_descripcion == "" ? DBNull.Value : (object)pEntidad.tdoc_descripcion;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TDOCUMENTOS" ;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_empresa", SqlDbType.VarChar)).Value = pEntidad.tdoc_empresa == null || pEntidad.tdoc_empresa == "" ? DBNull.Value : (object)pEntidad.tdoc_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_codigo", SqlDbType.VarChar)).Value = pEntidad.tdoc_codigo == null || pEntidad.tdoc_codigo == "" ? DBNull.Value : (object)pEntidad.tdoc_codigo;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_sigla", SqlDbType.VarChar)).Value = pEntidad.tdoc_sigla == null || pEntidad.tdoc_sigla == "" ? DBNull.Value : (object)pEntidad.tdoc_sigla;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_descripcion", SqlDbType.VarChar)).Value = pEntidad.tdoc_descripcion == null || pEntidad.tdoc_descripcion == "" ? DBNull.Value : (object)pEntidad.tdoc_descripcion;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTDOCUMENTOS(ENT_TDOCUMENTOS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TDOCUMENTOS" ;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_empresa", SqlDbType.VarChar)).Value = pEntidad.tdoc_empresa == null || pEntidad.tdoc_empresa == "" ? DBNull.Value : (object)pEntidad.tdoc_empresa;
                CMD.Parameters.Add(new SqlParameter("@ptdoc_codigo", SqlDbType.VarChar)).Value = pEntidad.tdoc_codigo == null || pEntidad.tdoc_codigo == "" ? DBNull.Value : (object)pEntidad.tdoc_codigo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TDOCUMENTOS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
