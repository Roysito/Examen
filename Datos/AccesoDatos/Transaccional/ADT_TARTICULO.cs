using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;
using CapaAcceosDatos.Interface.Transaccional;
using CapaEntidades;
using System.Collections.Generic;
namespace CapaAcceosDatos.AccesoDatos.Transaccional
{
   public class ADT_TARTICULO : IADT_TARTICULO<ENT_TARTICULO>
    {
        public bool setInsertarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_INSERTAR_TARTICULO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_articulo", SqlDbType.Int)).Value = pEntidad.id_articulo == null || pEntidad.id_articulo == 0 ? DBNull.Value : (object)pEntidad.id_articulo;
                CMD.Parameters.Add(new SqlParameter("@pc_articulo", SqlDbType.VarChar)).Value = pEntidad.c_articulo == null || pEntidad.c_articulo == "" ? DBNull.Value : (object)pEntidad.c_articulo;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo", SqlDbType.VarChar)).Value = pEntidad.t_articulo == null || pEntidad.t_articulo == "" ? DBNull.Value : (object)pEntidad.t_articulo;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo_tecnico", SqlDbType.VarChar)).Value = pEntidad.t_articulo_tecnico == null || pEntidad.t_articulo_tecnico == "" ? DBNull.Value : (object)pEntidad.t_articulo_tecnico;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo_adicional", SqlDbType.VarChar)).Value = pEntidad.t_articulo_adicional == null || pEntidad.t_articulo_adicional == "" ? DBNull.Value : (object)pEntidad.t_articulo_adicional;
                CMD.Parameters.Add(new SqlParameter("@pn_stock_minimo", SqlDbType.Decimal)).Value = pEntidad.n_stock_minimo == null || pEntidad.n_stock_minimo == 0 ? DBNull.Value : (object)pEntidad.n_stock_minimo;
                CMD.Parameters.Add(new SqlParameter("@pn_stock_maximo", SqlDbType.Decimal)).Value = pEntidad.n_stock_maximo == null || pEntidad.n_stock_maximo == 0 ? DBNull.Value : (object)pEntidad.n_stock_maximo;
                CMD.Parameters.Add(new SqlParameter("@pid_unidad_medida", SqlDbType.Int)).Value = pEntidad.id_unidad_medida == null || pEntidad.id_unidad_medida == 0 ? DBNull.Value : (object)pEntidad.id_unidad_medida;
                CMD.Parameters.Add(new SqlParameter("@pf_estado", SqlDbType.Int)).Value = pEntidad.f_estado == null || pEntidad.f_estado == 0 ? DBNull.Value : (object)pEntidad.f_estado;
                CMD.Parameters.Add(new SqlParameter("@pt_marca", SqlDbType.VarChar)).Value = pEntidad.t_marca == null || pEntidad.t_marca == "" ? DBNull.Value : (object)pEntidad.t_marca;
                CMD.Parameters.Add(new SqlParameter("@pc_digemid", SqlDbType.VarChar)).Value = pEntidad.c_digemid == null || pEntidad.c_digemid == "" ? DBNull.Value : (object)pEntidad.c_digemid;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setActualizarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ACTUALIZAR_TARTICULO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_articulo", SqlDbType.Int)).Value = pEntidad.id_articulo == null || pEntidad.id_articulo == 0 ? DBNull.Value : (object)pEntidad.id_articulo;
                CMD.Parameters.Add(new SqlParameter("@pc_articulo", SqlDbType.VarChar)).Value = pEntidad.c_articulo == null || pEntidad.c_articulo == "" ? DBNull.Value : (object)pEntidad.c_articulo;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo", SqlDbType.VarChar)).Value = pEntidad.t_articulo == null || pEntidad.t_articulo == "" ? DBNull.Value : (object)pEntidad.t_articulo;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo_tecnico", SqlDbType.VarChar)).Value = pEntidad.t_articulo_tecnico == null || pEntidad.t_articulo_tecnico == "" ? DBNull.Value : (object)pEntidad.t_articulo_tecnico;
                CMD.Parameters.Add(new SqlParameter("@pt_articulo_adicional", SqlDbType.VarChar)).Value = pEntidad.t_articulo_adicional == null || pEntidad.t_articulo_adicional == "" ? DBNull.Value : (object)pEntidad.t_articulo_adicional;
                CMD.Parameters.Add(new SqlParameter("@pn_stock_minimo", SqlDbType.Decimal)).Value = pEntidad.n_stock_minimo == null || pEntidad.n_stock_minimo == 0 ? DBNull.Value : (object)pEntidad.n_stock_minimo;
                CMD.Parameters.Add(new SqlParameter("@pn_stock_maximo", SqlDbType.Decimal)).Value = pEntidad.n_stock_maximo == null || pEntidad.n_stock_maximo == 0 ? DBNull.Value : (object)pEntidad.n_stock_maximo;
                CMD.Parameters.Add(new SqlParameter("@pid_unidad_medida", SqlDbType.Int)).Value = pEntidad.id_unidad_medida == null || pEntidad.id_unidad_medida == 0 ? DBNull.Value : (object)pEntidad.id_unidad_medida;
                CMD.Parameters.Add(new SqlParameter("@pf_estado", SqlDbType.Int)).Value = pEntidad.f_estado == null || pEntidad.f_estado == 0 ? DBNull.Value : (object)pEntidad.f_estado;
                CMD.Parameters.Add(new SqlParameter("@pt_marca", SqlDbType.VarChar)).Value = pEntidad.t_marca == null || pEntidad.t_marca == "" ? DBNull.Value : (object)pEntidad.t_marca;
                CMD.Parameters.Add(new SqlParameter("@pc_digemid", SqlDbType.VarChar)).Value = pEntidad.c_digemid == null || pEntidad.c_digemid == "" ? DBNull.Value : (object)pEntidad.c_digemid;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                oCN.Dispose();
                oCN.Close();
                oCN.Dispose();
            }
        }
        public bool setEliminarTARTICULO(ENT_TARTICULO pEntidad, out int pIntRowsAfect)
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
                CMD.CommandText = "SPU_ELIMINAR_TARTICULO" ;
                CMD.Parameters.Add(new SqlParameter("@pid_articulo", SqlDbType.Int)).Value = pEntidad.id_articulo == null || pEntidad.id_articulo == 0 ? DBNull.Value : (object)pEntidad.id_articulo;
                CMD.Parameters.Add(new SqlParameter("@pc_articulo", SqlDbType.VarChar)).Value = pEntidad.c_articulo == null || pEntidad.c_articulo == "" ? DBNull.Value : (object)pEntidad.c_articulo;
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
                    MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR AL INSERTAR EN TARTICULO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
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
