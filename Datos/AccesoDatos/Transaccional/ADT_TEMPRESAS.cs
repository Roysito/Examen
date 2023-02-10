using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TEMPRESAS : IADT_TEMPRESAS<ENT_TEMPRESAS>
    {
        public bool setInsertarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TEMPRESAS" ;
                CMD.Parameters.Add(new SqlParameter("@pemp_codigo", SqlDbType.VarChar)).Value = pEntidad.emp_codigo == null || pEntidad.emp_codigo == "" ? DBNull.Value : (object)pEntidad.emp_codigo;
                CMD.Parameters.Add(new SqlParameter("@pemp_razonsocial", SqlDbType.VarChar)).Value = pEntidad.emp_razonsocial == null || pEntidad.emp_razonsocial == "" ? DBNull.Value : (object)pEntidad.emp_razonsocial;
                CMD.Parameters.Add(new SqlParameter("@pemp_razoncomercial", SqlDbType.VarChar)).Value = pEntidad.emp_razoncomercial == null || pEntidad.emp_razoncomercial == "" ? DBNull.Value : (object)pEntidad.emp_razoncomercial;
                CMD.Parameters.Add(new SqlParameter("@pemp_direccion", SqlDbType.VarChar)).Value = pEntidad.emp_direccion == null || pEntidad.emp_direccion == "" ? DBNull.Value : (object)pEntidad.emp_direccion;
                CMD.Parameters.Add(new SqlParameter("@pemp_ruc", SqlDbType.VarChar)).Value = pEntidad.emp_ruc == null || pEntidad.emp_ruc == "" ? DBNull.Value : (object)pEntidad.emp_ruc;
                CMD.Parameters.Add(new SqlParameter("@pemp_telefonos", SqlDbType.VarChar)).Value = pEntidad.emp_telefonos == null || pEntidad.emp_telefonos == "" ? DBNull.Value : (object)pEntidad.emp_telefonos;
                CMD.Parameters.Add(new SqlParameter("@pemp_paginaweb", SqlDbType.VarChar)).Value = pEntidad.emp_paginaweb == null || pEntidad.emp_paginaweb == "" ? DBNull.Value : (object)pEntidad.emp_paginaweb;
                CMD.Parameters.Add(new SqlParameter("@pemp_gerente", SqlDbType.VarChar)).Value = pEntidad.emp_gerente == null || pEntidad.emp_gerente == "" ? DBNull.Value : (object)pEntidad.emp_gerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_docugerente", SqlDbType.VarChar)).Value = pEntidad.emp_docugerente == null || pEntidad.emp_docugerente == "" ? DBNull.Value : (object)pEntidad.emp_docugerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_numdocugerente", SqlDbType.VarChar)).Value = pEntidad.emp_numdocugerente == null || pEntidad.emp_numdocugerente == "" ? DBNull.Value : (object)pEntidad.emp_numdocugerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_activo", SqlDbType.Bit)).Value = pEntidad.emp_activo == null || pEntidad.emp_activo == false ? DBNull.Value : (object)pEntidad.emp_activo;
                CMD.Parameters.Add(new SqlParameter("@pemp_logo", SqlDbType.Image)).Value = pEntidad.emp_logo == null || pEntidad.emp_logo == default(Image) ? DBNull.Value : (object)pEntidad.emp_logo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TEMPRESAS" ;
                CMD.Parameters.Add(new SqlParameter("@pemp_codigo", SqlDbType.VarChar)).Value = pEntidad.emp_codigo == null || pEntidad.emp_codigo == "" ? DBNull.Value : (object)pEntidad.emp_codigo;
                CMD.Parameters.Add(new SqlParameter("@pemp_razonsocial", SqlDbType.VarChar)).Value = pEntidad.emp_razonsocial == null || pEntidad.emp_razonsocial == "" ? DBNull.Value : (object)pEntidad.emp_razonsocial;
                CMD.Parameters.Add(new SqlParameter("@pemp_razoncomercial", SqlDbType.VarChar)).Value = pEntidad.emp_razoncomercial == null || pEntidad.emp_razoncomercial == "" ? DBNull.Value : (object)pEntidad.emp_razoncomercial;
                CMD.Parameters.Add(new SqlParameter("@pemp_direccion", SqlDbType.VarChar)).Value = pEntidad.emp_direccion == null || pEntidad.emp_direccion == "" ? DBNull.Value : (object)pEntidad.emp_direccion;
                CMD.Parameters.Add(new SqlParameter("@pemp_ruc", SqlDbType.VarChar)).Value = pEntidad.emp_ruc == null || pEntidad.emp_ruc == "" ? DBNull.Value : (object)pEntidad.emp_ruc;
                CMD.Parameters.Add(new SqlParameter("@pemp_telefonos", SqlDbType.VarChar)).Value = pEntidad.emp_telefonos == null || pEntidad.emp_telefonos == "" ? DBNull.Value : (object)pEntidad.emp_telefonos;
                CMD.Parameters.Add(new SqlParameter("@pemp_paginaweb", SqlDbType.VarChar)).Value = pEntidad.emp_paginaweb == null || pEntidad.emp_paginaweb == "" ? DBNull.Value : (object)pEntidad.emp_paginaweb;
                CMD.Parameters.Add(new SqlParameter("@pemp_gerente", SqlDbType.VarChar)).Value = pEntidad.emp_gerente == null || pEntidad.emp_gerente == "" ? DBNull.Value : (object)pEntidad.emp_gerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_docugerente", SqlDbType.VarChar)).Value = pEntidad.emp_docugerente == null || pEntidad.emp_docugerente == "" ? DBNull.Value : (object)pEntidad.emp_docugerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_numdocugerente", SqlDbType.VarChar)).Value = pEntidad.emp_numdocugerente == null || pEntidad.emp_numdocugerente == "" ? DBNull.Value : (object)pEntidad.emp_numdocugerente;
                CMD.Parameters.Add(new SqlParameter("@pemp_activo", SqlDbType.Bit)).Value = pEntidad.emp_activo == null || pEntidad.emp_activo == false ? DBNull.Value : (object)pEntidad.emp_activo;
                CMD.Parameters.Add(new SqlParameter("@pemp_logo", SqlDbType.Image)).Value = pEntidad.emp_logo == null || pEntidad.emp_logo == default(Image) ? DBNull.Value : (object)pEntidad.emp_logo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTEMPRESAS(ENT_TEMPRESAS pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TEMPRESAS" ;
                CMD.Parameters.Add(new SqlParameter("@pemp_codigo", SqlDbType.VarChar)).Value = pEntidad.emp_codigo == null || pEntidad.emp_codigo == "" ? DBNull.Value : (object)pEntidad.emp_codigo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TEMPRESAS" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
