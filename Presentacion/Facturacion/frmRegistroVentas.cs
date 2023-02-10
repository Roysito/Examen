using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaValidacionesRem.Converciones;
using CapaValidacionesRem.Texto;
using CapaValidacionesRem.Validaciones;
using CapaUtilitariosRem.Ventanas;
using CapaUtilitariosRem.DataGridView;
using CapaLogicaNegocio;
//using CapaEntidadNegocio;
using CapaEntidades;
using CapaLogicaNegocio;
using Presentacion.Ayudas;
using Presentacion.Clases;
using Clases;

namespace Presentacion.Facturacion
{
    public partial class frmRegistroVentas : Form
    {
        #region "Variables"
        //g = variables goblales, v = variables publicas, i = variable interna del formulario, l = variable local dentro del metodo, p = parametro del metodo, ?x = variable arreglo donde (x) es la variable (v,g,i...)
        decimal iIntFlgOcultar = 0;
        CapaValidacionesRem.Converciones.Convertir iConvertir = new CapaValidacionesRem.Converciones.Convertir();
        UT_Mensajes iUT_Telerik = new UT_Mensajes();
        UT_DataGridView iUT_ExGrid = new UT_DataGridView();
        Validar iValidar = new Validar();
        int Col_trv_periodo;
        int Col_trv_tipo;
        int Col_trv_registro;
        int Col_trv_entidad;
        int Col_trv_idvendedor;
        int Col_trv_idformapago;
        int Col_trv_tdoc;
        int Col_trv_sdoc;
        int Col_trv_ndoc;
        int Col_trv_femision;
        int Col_trv_fvencimiento;
        int Col_trv_moneda;
        int Col_trv_tcambio;
        int Col_trv_dctos;
        int Col_trv_vventa;
        int Col_trv_igv;
        int Col_trv_total;
        int Col_trv_aigv;
        int Col_trv_flag;
        int Col_trv_pigv;

        int Col_Det_trvd_idarticulo;
        int Col_Det_trvd_idarticulo_Ayu;
        int Col_Det_trvd_idarticulo_Des;
        int Col_Det_trvd_cant;
        int Col_Det_trvd_preun;
        int Col_Det_trvd_pdcto;
        int Col_Det_trvd_dcto;
        int Col_Det_trvd_vvta;
        int Col_Det_trvd_igv;
        int Col_Det_trvd_tot;
        public string vStrRestricciones = "";
        bool iBolDetener = false;
        bool iBolCambiaEstatus = false;
        bool iBolCellStateChanged;
        bool iBolModoEdicion;
        byte iIntModo;
        int iIntItem = 0;
        Point iPanloc = new Point(0, 0);
        Point iCurloc = new Point(0, 0);
        ENT_TRVENTAS_CAB iEntENT_TRVENTAS_CAB;
        List<ENT_TRVENTAS_CAB> iLisENT_TRVENTAS_CAB = null;
        ENT_TRVENTAS_DET iEntENT_TRVENTAS_DET;
        List<ENT_TRVENTAS_DET> iLisENT_TRVENTAS_DET = null;
        #endregion
        public frmRegistroVentas()
        {
            InitializeComponent();
        }
        #region "Eventos"
        private void frmRegistroVentas_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (iBolModoEdicion)
            {
                MessageBox.Show(GlobalesVariables._finaliceedicion, GlobalesVariables._nombreaplicacion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }
        private void frmRegistroVentas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (this.Tlb_Deshacer.Enabled == true)
                    OpcionDeshacer();
                else
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }
        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.RadSplitContainer2.FixedPanel = FixedPanel.Panel1;
            iBolDetener = false;
            iBolCambiaEstatus = true;
            ConfigGridPrincipal();
            ConfigGridFiltro();
            ConfigGridDetalles();
            setControlMenu(true);
            //OC_Stb_User.Text = gChUSUARIO;
            //Stb_Programa.Text = this.Name;
            //OC_Stb_Compania.Text = ""; 
            //OC_Stb_Servidor.Text = iConvertir.aString("Servidor") + ":" + gChQNsys;
            //OC_Stb_Sesion.Text = iConvertir.aString("Sesi�n") + ":" + gChQTrab;
            //OC_Stb_Aplicacion.Text = gChModuloGeneral;
            getDatosPrincipales();
            getEntidadesUser();
            this.Cursor = Cursors.Default;
        }
        private void Mnu_Adicionar_Click(object sender, EventArgs e)
        {
            OpcionNuevo();
        }
        private void Mnu_Modificar_Click(object sender, EventArgs e)
        {
            OpcionModificar();
        }
        private void Mnu_Guardar_Click(object sender, EventArgs e)
        {
            OpcionGuardar();
        }
        private void Mnu_Deshacer_Click(object sender, EventArgs e)
        {
            OpcionDeshacer();
        }
        private void Mnu_Eliminar_Click(object sender, EventArgs e)
        {
            OpcionEliminar();
        }
        private void Mnu_Duplicar_Click(object sender, EventArgs e)
        {
            OpcionDuplicar();
        }
        private void Tlb_Adicionar_Click(object sender, EventArgs e)
        {
            OpcionNuevo();
        }
        private void Tlb_Modificar_Click(object sender, EventArgs e)
        {
            OpcionModificar();
        }
        private void Tlb_Guardar_Click(object sender, EventArgs e)
        {
            OpcionGuardar();
        }
        private void Tlb_Deshacer_Click(object sender, EventArgs e)
        {
            OpcionDeshacer();
        }
        private void Tlb_Eliminar_Click(object sender, EventArgs e)
        {
            OpcionEliminar();
        }
        private void Tlb_Duplicar_Click(object sender, EventArgs e)
        {
            OpcionDuplicar();
        }
        private void Mnu_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void Mnu_Criterios_Mostrar_Click(object sender, EventArgs e)
        {
            setMostrarFiltro(true);
        }
        private void Mnu_Criterios_Ocultar_Click(object sender, EventArgs e)
        {
            setMostrarFiltro(false);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            PanelFiltros.Location = new Point((iPanloc.X - iCurloc.X) + Cursor.Position.X, (iPanloc.Y - iCurloc.Y) + Cursor.Position.Y);
        }
        private void Lbl_Criterios_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Start();
            EstablecePosicion();
        }
        private void Lbl_Criterios_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Timer1.Stop();
            EstablecePosicion();
        }
        private void Mnu_FiltrosCerrar_Click(object sender, EventArgs e)
        {
            setMostrarFiltro(false);
        }
        private void Mnu_FiltrosBuscar_Click(object sender, EventArgs e)
        {
            getDatosPrincipales();
            setMostrarFiltro(false);
        }
        private void Mnu_Filtros_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Start();
            EstablecePosicion();
        }
        private void Mnu_Filtros_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Timer1.Stop();
            EstablecePosicion();
        }
        private void Mnu_Detener_Click(object sender, EventArgs e)
        {
            if (iUT_Telerik.setRadMensajePregunta("�Seguro que desea Detener el Proceso en Curso ? ", "Buscar...") == true)
            {
                iBolDetener = true;
            }
        }
        private void Mnu_Imprimir_Click(object sender, EventArgs e)
        {
            //frmReImprimir MiFrmImprimir = new frmReImprimir();
            //clsEnviosExcel vClsEnviaExcel = new clsEnviosExcel();
            //if (iBolCambiaEstatus == false) return;
            //MiFrmImprimir.vNomFrm = this.Name;
            //MiFrmImprimir.ShowDialog();
            //switch (MiFrmImprimir.pInOpcion)
            //{
            //    case 1: //Excel
            //        vClsEnviaExcel.EnviarA(this, AcxControl, this.Text, 0, false, false, MiFrmImprimir.pChSeparador, MiFrmImprimir.pChIncluir, "EXCEL");
            //        break;
            //    case 2: //CSV
            //        vClsEnviaExcel.EnviarA(this, AcxControl, this.Text, 0, false, false, MiFrmImprimir.pChSeparador, MiFrmImprimir.pChIncluir, "CSV");
            //        break;
            //    case 3: //TXT
            //        vClsEnviaExcel.EnviarA(this, AcxControl, this.Text, 0, false, false, MiFrmImprimir.pChSeparador, MiFrmImprimir.pChIncluir, "TXT");
            //        break;
            //    case 4: //PDF
            //        vClsEnviaExcel.EnviarA(this, AcxControl, this.Text, 0, false, false, MiFrmImprimir.pChSeparador, MiFrmImprimir.pChIncluir, "PDF");
            //        break;
            //}
        }
        private void Tlb_Consultar_Click(object sender, EventArgs e)
        {
            iIntFlgOcultar = 0; GuardarAncho();
            setOpcionConsultar(false);
        }
        private void Tlb_Cerrar_Click(object sender, EventArgs e)
        {
            setOpcionConsultar(true);
        }
        private void Mnu_Recargar_Click(object sender, EventArgs e)
        {
            getDatosPrincipales();
        }
        private void AcxControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.KeyCode == Keys.Shift)
            {
                SendKeys.Send("{ TAB}");
            }
        }
        private void AcxControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AcxControl.Rows.Count == 0) return;
            if (AcxControl.CurrentRow is null) return;
            int ItemSeleccionado;
            ItemSeleccionado = e.RowIndex;
            if (ItemSeleccionado != 0)
            {
                OpcionModificar();
            }
        }
        private void AcxControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iIntItem = AcxControl.CurrentRow.Index;
        }
        private void AcxControl_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }
        private void AcxControl_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void AcxControl_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }
        private void Tlb_D_Nuevo_Click_1(object sender, EventArgs e)
        {
            int lIntItem = 0;
            if (getValidacionFicha() == false) return;
            lIntItem = AcxDetalles.Rows.Add(0, "", "");
            for (int lInI = 0; lInI < AcxDetalles.Columns.Count; lInI++)
            {
                AcxDetalles.Rows[lIntItem].Cells[lInI].Value = "";
            }
            AcxDetalles.BeginEdit(true);
            AcxDetalles.CurrentCell = AcxDetalles.Rows[lIntItem].Cells[1];
        }
        private void Tlb_D_Duplica_Click_1(object sender, EventArgs e)
        {
            int lIntItem = 0;
            int lIntItemH = 0;
            if (getValidacionFicha() == false) return;
            int lInI;
            lIntItemH = AcxDetalles.CurrentRow.Index;
            if (AcxDetalles.CurrentRow.Index >= 0)
            {
                lIntItem = AcxDetalles.Rows.Add(0, "", "");
                for (lInI = 0; lInI < AcxDetalles.Columns.Count; lInI++)
                {
                    AcxDetalles.Rows[lIntItem].Cells[lInI].Value = AcxDetalles.Rows[lIntItemH].Cells[lInI].Value;
                    AcxDetalles.Rows[lIntItem].Cells[lInI].Tag = AcxDetalles.Rows[lIntItemH].Cells[lInI].Tag;
                }
                AcxDetalles.CurrentCell = AcxDetalles.Rows[lIntItem].Cells[1];
                AcxDetalles.BeginEdit(true);
            }
            else
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Duplicar"));
            }
        }
        private void AcxDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.KeyCode == Keys.Shift)
            {
                SendKeys.Send("{ TAB}");
            }
        }
        private void AcxDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void AcxDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iIntItem = AcxDetalles.CurrentRow.Index;
            if (this.AcxDetalles.CurrentRow != null)
            {
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_idarticulo_Ayu".ToUpper()) //Id Articulo
                {
                    AyudaTARTICULO_trvd_idarticulo_Detalle();
                }
                GlobalesVariables._IsPulsaF1CeldaGrid = false;
            }
        }
        private void AcxDetalles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.AcxDetalles.CurrentRow != null)
            {
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_idarticulo".ToUpper()) //Id Articulo
                {
                    AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
                GlobalesVariables._IsPulsaF1CeldaGrid = false;
            }
        }
        private void AcxDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalesVariables._IsPulsaF1CeldaGrid == false && this.AcxDetalles.CurrentRow != null)
            {
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_idarticulo".ToUpper()) //Id Articulo
                {
                    if (iConvertir.aString(AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString() != "")
                    {
                        if (AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
                        {
                            ValidaTARTICULO_trvd_idarticulo_Detalle();
                        }
                    }
                    else
                    {
                        this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = "";
                        this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = "";
                        this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Des].Value = "";
                    }
                }
                GlobalesVariables._IsPulsaF1CeldaGrid = false;
            }
            if (GlobalesVariables._IsPulsaF1CeldaGrid && this.AcxDetalles.CurrentRow != null)
            {
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_idarticulo".ToUpper()) //Id Articulo
                {
                    AyudaTARTICULO_trvd_idarticulo_Detalle();
                }
            }
        }
        private void AcxDetalles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox && (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_idarticulo".ToUpper())) //Id Articulo
            {
                ((TextBox)e.Control).CharacterCasing = CharacterCasing.Upper;
                ((TextBox)e.Control).KeyDown += new KeyEventHandler(Emula_KeyDown);
            }
        }
        private void AcxDetalles_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_nroitm".ToUpper()) //Correlativo
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_idarticulo".ToUpper()) //Id Articulo
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_cant".ToUpper()) //Cantidad
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_preun".ToUpper()) //Precio Unitario
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_pdcto".ToUpper()) //% Descuento
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_dcto".ToUpper()) //Monto Descuento
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_vvta".ToUpper()) //Base Imponible
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_igv".ToUpper()) //Igv
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_tot".ToUpper()) //Total Venta
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite n�meros", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
        }
        private void Tlb_D_Elimina_Click(object sender, EventArgs e)
        {
            int lIntItem = 0;
            int POSITION;
            if (AcxDetalles.CurrentRow != null)
            {
                POSITION = AcxDetalles.CurrentRow.Index;
                lIntItem = AcxDetalles.CurrentRow.Index;
                if (iUT_Telerik.setRadMensajePregunta(iConvertir.aString("�Seguro que desea eliminar el registro actual ? "), iConvertir.aString("Eliminar")) == true)
                {
                    AcxDetalles.Rows.RemoveAt(lIntItem);
                    if (POSITION > 0)
                    {
                        AcxDetalles.Rows[POSITION - 1].Selected = true;
                        AcxDetalles.CurrentCell = AcxDetalles.Rows[POSITION - 1].Cells[1];
                    }
                }
            }
            else
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Eliminar"));
            }
        }
        private void mnuOcultar_Click(object sender, EventArgs e)
        {
            GuardarAncho();
        }
        #region Eventos_Ayuda_Validaciones
        private void Btntrv_idvendedor_Click(object sender, EventArgs e)
        {
            AyudaTVENDEDOR_trv_idvendedor();
        }
        private void Btntrv_idformapago_Click(object sender, EventArgs e)
        {
            AyudaTFORMA_PAGO_trv_idformapago();
        }
        private void Btntrv_tdoc_Click(object sender, EventArgs e)
        {
            AyudaTDOCUMENTOS_trv_tdoc();
        }
        private void Btntrv_sdoc_Click(object sender, EventArgs e)
        {
            AyudaTDOCUMENTOS_SERIES_trv_sdoc();
        }
        private void Txttrv_idvendedor_GotFocus(object sender, EventArgs e)
        {
            Txttrv_idvendedor.Tag = Txttrv_idvendedor.Text;
        }
        private void Txttrv_idformapago_GotFocus(object sender, EventArgs e)
        {
            Txttrv_idformapago.Tag = Txttrv_idformapago.Text;
        }
        private void Txttrv_tdoc_GotFocus(object sender, EventArgs e)
        {
            Txttrv_tdoc.Tag = Txttrv_tdoc.Text;
        }
        private void Txttrv_sdoc_GotFocus(object sender, EventArgs e)
        {
            Txttrv_sdoc.Tag = Txttrv_sdoc.Text;
        }
        private void Txttrv_idvendedor_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_idvendedor.Text != "")
            {
                if (iConvertir.aString(Txttrv_idvendedor.Text) != iConvertir.aString(Txttrv_idvendedor.Tag))
                {
                    ValidaTVENDEDOR_trv_idvendedor();
                }
            }
            else
            {
                Btntrv_idvendedor.Tag = "";
                Txttrv_idvendedor.Text = "";
                Txttrv_idvendedor_Des.Text = "";
            }
        }
        private void Txttrv_idformapago_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_idformapago.Text != "")
            {
                if (iConvertir.aString(Txttrv_idformapago.Text) != iConvertir.aString(Txttrv_idformapago.Tag))
                {
                    ValidaTFORMA_PAGO_trv_idformapago();
                }
            }
            else
            {
                Btntrv_idformapago.Tag = "";
                Txttrv_idformapago.Text = "";
                Txttrv_idformapago_Des.Text = "";
            }
        }
        private void Txttrv_tdoc_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_tdoc.Text != "")
            {
                if (iConvertir.aString(Txttrv_tdoc.Text) != iConvertir.aString(Txttrv_tdoc.Tag))
                {
                    ValidaTDOCUMENTOS_trv_tdoc();
                }
            }
            else
            {
                Btntrv_tdoc.Tag = "";
                Txttrv_tdoc.Text = "";
                Txttrv_tdoc_Des.Text = "";
            }
        }
        private void Txttrv_sdoc_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_sdoc.Text != "")
            {
                if (iConvertir.aString(Txttrv_sdoc.Text) != iConvertir.aString(Txttrv_sdoc.Tag))
                {
                    ValidaTDOCUMENTOS_SERIES_trv_sdoc();
                }
            }
            else
            {
                Btntrv_sdoc.Tag = "";
                Txttrv_sdoc.Text = "";
                Txttrv_sdoc_Des.Text = "";
            }
        }
        private void Txttrv_idvendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTVENDEDOR_trv_idvendedor();
        }
        private void Txttrv_idformapago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTFORMA_PAGO_trv_idformapago();
        }
        private void Txttrv_tdoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTDOCUMENTOS_trv_tdoc();
        }
        private void Txttrv_sdoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTDOCUMENTOS_SERIES_trv_sdoc();
        }
        #endregion Eventos_Ayuda_Validaciones
        #endregion
        #region "Metodos"
        internal void getEntidadesUser()
        {
        }
        public void setControlMenu(bool pBolHabilitado)
        {
            Mnu_Adicionar.Enabled = pBolHabilitado;
            Mnu_Modificar.Enabled = pBolHabilitado;
            Mnu_Guardar.Enabled = !pBolHabilitado;
            Mnu_Deshacer.Enabled = !pBolHabilitado;
            Mnu_Eliminar.Enabled = pBolHabilitado;
            Mnu_Duplicar.Enabled = pBolHabilitado;
            Mnu_Salir.Enabled = pBolHabilitado;
            Mnu_Imprimir.Enabled = pBolHabilitado;
            Mnu_Recargar.Enabled = pBolHabilitado;
            Mnu_Criterios_Mostrar.Enabled = pBolHabilitado;
            Mnu_Criterios_Ocultar.Enabled = pBolHabilitado;
            Tlb_Adicionar.Enabled = Mnu_Adicionar.Enabled;
            Tlb_Modificar.Enabled = Mnu_Modificar.Enabled;
            Tlb_Guardar.Enabled = Mnu_Guardar.Enabled;
            Tlb_Deshacer.Enabled = Mnu_Deshacer.Enabled;
            Tlb_Eliminar.Enabled = Mnu_Eliminar.Enabled;
            Tlb_Duplicar.Enabled = Mnu_Duplicar.Enabled;
            Tlb_Consultar.Enabled = pBolHabilitado;
            iBolModoEdicion = !pBolHabilitado;
            mnuOcultar.Visible = !pBolHabilitado;
            AcxDetalles.ReadOnly = pBolHabilitado;
            if (pBolHabilitado)
            {
                TabPage1.Parent = TabControl1;
                TabPage2.Parent = null;
            }
            else
            {
                TabPage1.Parent = null;
                TabPage2.Parent = TabControl1;
                setMostrarFiltro(false);
            }
            if (pBolHabilitado != false)
                AcxDetalles.Rows.Clear();
        }
        public void setOpcionConsultar(bool pBolHabilitar)
        {
            iIntFlgOcultar = 0;
            GuardarAncho();
            if (AcxControl.CurrentRow is null)
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Modificar"));
                return;
            }
            if (pBolHabilitar == false)
            {
                setMostrarFiltro(false);
                getDatosDetalles();
            }
            Mnu_Adicionar.Enabled = pBolHabilitar;
            Mnu_Modificar.Enabled = pBolHabilitar;
            Mnu_Eliminar.Enabled = pBolHabilitar;
            Mnu_Duplicar.Enabled = pBolHabilitar;
            Mnu_Imprimir.Enabled = pBolHabilitar;
            Mnu_Recargar.Enabled = pBolHabilitar;
            Tlb_Adicionar.Enabled = pBolHabilitar;
            Tlb_Modificar.Enabled = pBolHabilitar;
            Tlb_Eliminar.Enabled = pBolHabilitar;
            Tlb_Duplicar.Enabled = pBolHabilitar;
            Tlb_Consultar.Visible = pBolHabilitar;
            Tlb_Cerrar.Visible = !pBolHabilitar;
            mnuOcultar.Visible = !pBolHabilitar;
            if (pBolHabilitar)
            {
                TabPage1.Parent = TabControl1;
                TabPage2.Parent = null;
            }
            else
            {
                TabPage1.Parent = null;
                TabPage2.Parent = TabControl1;
            }
            Mnu_Criterios_Mostrar.Enabled = pBolHabilitar;
            Mnu_Criterios_Ocultar.Enabled = pBolHabilitar;
        }
        private void setDatosInicializa()
        {
            iBolCambiaEstatus = false;
            Txttrv_empresa.Text = "";
            Txttrv_periodo.Text = "";
            Txttrv_tipo.Text = "";
            Txttrv_registro.Text = "";
            Txttrv_entidad.Text = "";
            Txttrv_idvendedor.Text = "";
            Txttrv_idvendedor_Des.Text = "";
            Txttrv_idformapago.Text = "";
            Txttrv_idformapago_Des.Text = "";
            Txttrv_tdoc.Text = "";
            Txttrv_tdoc_Des.Text = "";
            Txttrv_sdoc.Text = "";
            Txttrv_sdoc_Des.Text = "";
            Txttrv_ndoc.Text = "";
            Txttrv_femision.Text = "";
            Txttrv_fvencimiento.Text = "";
            Txttrv_moneda.Text = "";
            Txttrv_tcambio.Text = "";
            Txttrv_dctos.Text = "";
            Txttrv_vventa.Text = "";
            Txttrv_igv.Text = "";
            Txttrv_total.Text = "";
            Txttrv_aigv.Text = "";
            Txttrv_flag.Text = "";
            Txttrv_pigv.Text = "";
            iBolCambiaEstatus = true;
        }
        private void getDatosDetalles()
        {
            int lIntItem = 0;
            if (AcxControl.CurrentRow is null)
            {
                setDatosInicializa();
                return;
            }
            lIntItem = AcxControl.CurrentRow.Index;
            this.Cursor = Cursors.WaitCursor;
            iBolCambiaEstatus = false;
            if (this.Visible) this.Cursor = Cursors.WaitCursor;
            iLisENT_TRVENTAS_CAB = LN_TRVENTAS_CAB.getListarTRVENTAS_CAB(GlobalesVariables.company, iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_periodo].Value), iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_tipo].Value), iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_registro].Value));
            if (!(iLisENT_TRVENTAS_CAB == null))
            {
                foreach (ENT_TRVENTAS_CAB Lista in iLisENT_TRVENTAS_CAB)
                {
                    Txttrv_empresa.Text = Convert.ToString(Lista.trv_empresa).ToString();
                    Txttrv_periodo.Text = Convert.ToString(Lista.trv_periodo).ToString();
                    Txttrv_tipo.Text = Convert.ToString(Lista.trv_tipo).ToString();
                    Txttrv_registro.Text = Convert.ToString(Lista.trv_registro).ToString();
                    Txttrv_entidad.Text = Convert.ToInt32(Lista.trv_entidad).ToString();
                    Txttrv_idvendedor.Text = Convert.ToInt32(Lista.trv_idvendedor).ToString();
                    Btntrv_idvendedor.Tag = Convert.ToInt32(Lista.trv_idvendedor).ToString();
                    Txttrv_idvendedor_Des.Text = "";
                    Txttrv_idformapago.Text = Convert.ToInt32(Lista.trv_idformapago).ToString();
                    Btntrv_idformapago.Tag = Convert.ToInt32(Lista.trv_idformapago).ToString();
                    Txttrv_idformapago_Des.Text = "";
                    Txttrv_tdoc.Text = Convert.ToString(Lista.trv_tdoc).ToString();
                    Btntrv_tdoc.Tag = Convert.ToString(Lista.trv_tdoc).ToString();
                    Txttrv_tdoc_Des.Text = "";
                    Txttrv_sdoc.Text = Convert.ToString(Lista.trv_sdoc).ToString();
                    Btntrv_sdoc.Tag = Convert.ToString(Lista.trv_sdoc).ToString();
                    Txttrv_sdoc_Des.Text = "";
                    Txttrv_ndoc.Text = Convert.ToString(Lista.trv_ndoc).ToString();
                    Txttrv_femision.Text = Convert.ToDateTime(Lista.trv_femision).ToString();
                    Txttrv_fvencimiento.Text = Convert.ToDateTime(Lista.trv_fvencimiento).ToString();
                    Txttrv_moneda.Text = Convert.ToString(Lista.trv_moneda).ToString();
                    Txttrv_tcambio.Text = Convert.ToDecimal(Lista.trv_tcambio).ToString();
                    Txttrv_dctos.Text = Convert.ToDecimal(Lista.trv_dctos).ToString();
                    Txttrv_vventa.Text = Convert.ToDecimal(Lista.trv_vventa).ToString();
                    Txttrv_igv.Text = Convert.ToDecimal(Lista.trv_igv).ToString();
                    Txttrv_total.Text = Convert.ToDecimal(Lista.trv_total).ToString();
                    Txttrv_aigv.Text = Convert.ToInt32(Lista.trv_aigv).ToString();
                    Txttrv_flag.Text = Convert.ToInt32(Lista.trv_flag).ToString();
                    Txttrv_pigv.Text = Convert.ToDecimal(Lista.trv_pigv).ToString();
                    Application.DoEvents();
                }
            }
            iLisENT_TRVENTAS_DET = LN_TRVENTAS_DET.getListarTRVENTAS_DET(GlobalesVariables.company, iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_periodo].Value), iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_tipo].Value), iConvertir.aString(AcxControl.Rows[AcxControl.CurrentRow.Index].Cells[Col_trv_registro].Value), null);
            if (iLisENT_TRVENTAS_DET.ToList().Count() > 0)
            {
                AcxDetalles.Rows.Clear();
                foreach (ENT_TRVENTAS_DET Lista in iLisENT_TRVENTAS_DET)
                {
                    lIntItem = AcxDetalles.Rows.Add(0, "", "");
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo].Value = Convert.ToInt32(Lista.trvd_idarticulo);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_cant].Value = Convert.ToDecimal(Lista.trvd_cant);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_preun].Value = Convert.ToDecimal(Lista.trvd_preun);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_pdcto].Value = Convert.ToDecimal(Lista.trvd_pdcto);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_dcto].Value = Convert.ToDecimal(Lista.trvd_dcto);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_vvta].Value = Convert.ToDecimal(Lista.trvd_vvta);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_igv].Value = Convert.ToDecimal(Lista.trvd_igv);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_tot].Value = Convert.ToDecimal(Lista.trvd_tot);
                    Application.DoEvents();
                    if (iBolDetener)
                    {
                        break;
                    }
                }
            }
            iBolCambiaEstatus = true;
            this.Cursor = Cursors.Default;
            lIntItem = 0;
            if (AcxDetalles.Rows.Count > 0)
            {
                AcxDetalles.Rows[lIntItem].Selected = true;
            }
            if (this.Visible) this.Cursor = Cursors.Default;
        }
        public void setMostrarFiltro(bool pBlMOstrar)
        {
            if (PanelFiltros.Visible == pBlMOstrar) return;
            if (pBlMOstrar)
            {
                Mnu_Criterios_Mostrar.Visible = false;
                Mnu_Criterios_Ocultar.Visible = true;
                PanelFiltros.Visible = pBlMOstrar;
                PanelFiltros.Left = 224;
                PanelFiltros.Top = 27;
            }
            else
            {
                Mnu_Criterios_Mostrar.Visible = true;
                Mnu_Criterios_Ocultar.Visible = false;
                PanelFiltros.Visible = false;
            }
        }
        private void EstablecePosicion()
        {
            iPanloc = PanelFiltros.Location;
            iCurloc = System.Windows.Forms.Cursor.Position;
        }
        public void OpcionNuevo()
        {
            //if (getAddRestriccion(vStrRestricciones) == false) return;
            iIntModo = 1;
            setControlMenu(false);
            iIntFlgOcultar = 0; GuardarAncho();
            setDatosInicializa();
        }
        public void OpcionModificar()
        {
            int lIntItem = 0;
            //if (getUpdRestriccion(vStrRestricciones) == false) return;
            if (AcxControl.CurrentRow != null)
            {
                lIntItem = AcxControl.CurrentRow.Index;
                iIntFlgOcultar = 0; GuardarAncho();
                iIntModo = 2;
                setControlMenu(false);
                getDatosDetalles();
                //AcxFicha.Focus();
                //AcxFicha.Edit();
            }
            else
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Modificar"));
            }
        }
        public void OpcionGuardar()
        {
            if (getValidacion())
            {
                setControlMenu(true);
            }
        }
        public void OpcionDeshacer()
        {
            if (iBolModoEdicion)
            {
                if (MessageBox.Show("Formulario est� en edici�n, finalice para cerrar ", GlobalesVariables._nombreaplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    setControlMenu(true);
                }
            }
        }
        public void OpcionEliminar()
        {
            //if (getDelRestriccion(vStrRestricciones) == false) return;
            int lIntItem = 0;
            int POSITION;
            bool lBlRelacionado;
            string lChClave;
            try
            {
                if (AcxControl.CurrentRow != null)
                {
                    POSITION = AcxControl.CurrentRow.Index;
                    lIntItem = AcxControl.CurrentRow.Index;
                    lBlRelacionado = false;
                    if (iUT_Telerik.setRadMensajePregunta(iConvertir.aString("�Seguro que desea anular el registro actual ? "), iConvertir.aString("Anular")) == true)
                    {
                        AcxControl.Rows.RemoveAt(AcxControl.CurrentRow.Index);
                        if (AcxControl.Rows.Count > 0)
                        {
                            AcxControl.Rows[POSITION].Selected = true;
                        }
                    }
                }
                else
                {
                    iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Anular"));
                }
                return;
            }
            catch (Exception ex)
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Errores encontrados") + ":  " + Convert.ToString(13) + Convert.ToString(13) + ex.Message + Convert.ToString(13) + Convert.ToString(13) + iConvertir.aString("Nota: Si el problema persiste, por favor contacte con su Cliente."), "E");
                return;
            };
        }
        public void OpcionDuplicar()
        {
            int lIntItem = 0;
            //if (getAddRestriccion(vStrRestricciones) == false) return;
            if (AcxControl.CurrentRow != null)
            {
                lIntItem = AcxControl.CurrentRow.Index;
                iIntFlgOcultar = 1; GuardarAncho();
                iIntModo = 3;
                setControlMenu(false);
                getDatosDetalles();
            }
            else
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Duplicar"));
            }
        }
        public void ConfigGridPrincipal()
        {
            iUT_ExGrid.setInicializaDataGridView(AcxControl, true, true, false, false, true);
            Col_trv_periodo = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_periodo", "Periodo", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_periodo
            Col_trv_tipo = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_tipo", "Nivel Venta", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_tipo
            Col_trv_registro = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_registro", "N�mero Registro", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_registro
            Col_trv_entidad = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_entidad", "Id Ctacte", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_entidad
            Col_trv_idvendedor = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_idvendedor", "Id Vendedor", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_idvendedor
            Col_trv_idformapago = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_idformapago", "Id Forma Pago", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_idformapago
            Col_trv_tdoc = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_tdoc", "C�digo Documento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_tdoc
            Col_trv_sdoc = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_sdoc", "Serie Documento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_sdoc
            Col_trv_ndoc = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_ndoc", "N�mero Documento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_ndoc
            Col_trv_femision = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_femision", "Fecha Emisi�n", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_femision
            Col_trv_fvencimiento = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_fvencimiento", "Fecha Vencimiento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_fvencimiento
            Col_trv_moneda = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_moneda", "C�digo Moneda", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_moneda
            Col_trv_tcambio = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_tcambio", "Tipo de Cambio", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_tcambio
            Col_trv_dctos = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_dctos", "Total Descuentos", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_dctos
            Col_trv_vventa = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_vventa", "Base Imponible", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_vventa
            Col_trv_igv = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_igv", "Igv", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_igv
            Col_trv_total = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_total", "Total Venta", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_total
            Col_trv_aigv = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_aigv", "Afeco a Igv", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_aigv
            Col_trv_flag = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_flag", "Flag Anulado", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_flag
            Col_trv_pigv = iUT_ExGrid.getA�adeColumna(AcxControl, "trv_pigv", "Porcentaje Igv", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_pigv
            AcxControl.ReadOnly = false;
        }
        public void ConfigGridDetalles()
        {
            iUT_ExGrid.setInicializaDataGridView(AcxDetalles, true, true, false, false, true);
            Col_Det_trvd_idarticulo = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_idarticulo", "Id Articulo", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_idarticulo
            Col_Det_trvd_idarticulo_Ayu = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_idarticulo_Ayu", "...", 30, true, true, "BUTTON", 0, 0, "CENTRO", "", ""); //trvd_idarticulo
            Col_Det_trvd_idarticulo_Des = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_idarticulo_Des", "Descripci�n", 400, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_Det_trvd_cant = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_cant", "Cantidad", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_cant
            Col_Det_trvd_preun = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_preun", "Precio Unitario", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_preun
            Col_Det_trvd_pdcto = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_pdcto", "% Descuento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_pdcto
            Col_Det_trvd_dcto = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_dcto", "Monto Descuento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_dcto
            Col_Det_trvd_vvta = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_vvta", "Base Imponible", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_vvta
            Col_Det_trvd_igv = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_igv", "Igv", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_igv
            Col_Det_trvd_tot = iUT_ExGrid.getA�adeColumna(AcxDetalles, "trvd_tot", "Total Venta", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_tot
            AcxDetalles.ReadOnly = false;
        }
        public void ConfigGridFiltro()
        {
        }
        public void getDatosPrincipales()
        {
            int lIntItem = 0;
            List<ENT_TRVENTAS_CAB> lLisENT_TRVENTAS_CAB = null;
            if (this.Visible)
            {
                this.Cursor = Cursors.WaitCursor;
                if (iBolCambiaEstatus == false) return;
            }
            if (this.Visible) this.Cursor = Cursors.WaitCursor;
            lLisENT_TRVENTAS_CAB = LN_TRVENTAS_CAB.getListarTRVENTAS_CAB(GlobalesVariables.company, null, null, null);
            Mnu_Detener.Visible = true;
            AcxControl.Rows.Clear();
            iBolCambiaEstatus = false;
            if ((lLisENT_TRVENTAS_CAB != null))
            {
                foreach (var Lista in lLisENT_TRVENTAS_CAB)
                {
                    lIntItem = AcxControl.Rows.Add(0, "", "");
                    AcxControl.Rows[lIntItem].Cells[Col_trv_periodo].Value = Convert.ToString(Lista.trv_periodo);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value = Convert.ToString(Lista.trv_tipo);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_registro].Value = Convert.ToString(Lista.trv_registro);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value = Convert.ToInt32(Lista.trv_entidad);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value = Convert.ToInt32(Lista.trv_idvendedor);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value = Convert.ToInt32(Lista.trv_idformapago);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = Convert.ToString(Lista.trv_tdoc);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_sdoc].Value = Convert.ToString(Lista.trv_sdoc);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_ndoc].Value = Convert.ToString(Lista.trv_ndoc);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_femision].Value = Convert.ToDateTime(Lista.trv_femision);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_fvencimiento].Value = Convert.ToDateTime(Lista.trv_fvencimiento);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = Convert.ToString(Lista.trv_moneda);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_tcambio].Value = Convert.ToDecimal(Lista.trv_tcambio);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_dctos].Value = Convert.ToDecimal(Lista.trv_dctos);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_vventa].Value = Convert.ToDecimal(Lista.trv_vventa);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_igv].Value = Convert.ToDecimal(Lista.trv_igv);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_total].Value = Convert.ToDecimal(Lista.trv_total);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_aigv].Value = Convert.ToInt32(Lista.trv_aigv);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_flag].Value = Convert.ToInt32(Lista.trv_flag);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_pigv].Value = Convert.ToDecimal(Lista.trv_pigv);
                    if (iBolDetener) break;
                }
                AcxControl.Visible = true;
            }
            iBolCambiaEstatus = true;
            lIntItem = 0;
            if (AcxControl.Rows.Count > 0)
            {
                AcxControl.Rows[lIntItem].Selected = true;
            }
            Mnu_Detener.Visible = false;
            if (this.Visible) this.Cursor = Cursors.Default;
        }
        public bool getValidacion()
        {
            int lIntItem = 0;
            int lIntColu = 0;
            string vChMsg = "";
            AcxDetalles.EndEdit();
            if (getValidacionFicha() == false)
            {
                return false;
            }
            if (getValidacionDetalle() == false)
            {
                return false;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (iIntModo != 2)
                {
                    List<ENT_TRVENTAS_CAB> lLisTRVENTAS_CAB = null;
                    lLisTRVENTAS_CAB = LN_TRVENTAS_CAB.getListarTRVENTAS_CAB(Convert.ToString(Txttrv_empresa.Text.ToString().Trim()), Convert.ToString(Txttrv_periodo.Text.ToString().Trim()), Convert.ToString(Txttrv_tipo.Text.ToString().Trim()), Convert.ToString(Txttrv_registro.Text.ToString().Trim()));
                    if ((lLisTRVENTAS_CAB.ToList().Count() > 0))
                    {
                        vChMsg = iConvertir.aString("Clave de Registro especificada ya existe");
                        goto ContinuarAqui;
                    }
                }
            ContinuarAqui:
                if (iConvertir.aString(vChMsg).Trim() != "")
                {
                    this.Cursor = Cursors.Default;
                    TabControl1.SelectedIndex = 0;
                    //if (lIntItem != 0)
                    //{
                    //AcxFicha.Items.EnsureVisibleItem(lIntItem);
                    //AcxFicha.Items.SelectItem[lIntItem] = true;
                    //}
                    iUT_Telerik.setRadMensaje(vChMsg, "I", "Mensaje de la Aplicaci�n");
                    //AcxFicha.EnsureVisibleColumn(lIntColu);
                    //AcxFicha.SearchColumnIndex = lIntColu;
                    //AcxFicha.FocusColumnIndex = lIntColu;
                    //AcxFicha.Focus();
                    //AcxFicha.Edit();
                    return false;
                }
                if (setGrabarDatos() == false)
                {
                    this.Cursor = Cursors.Default;
                    return false;
                }
                if (iIntModo != 2)
                {
                    lIntItem = AcxControl.Rows.Add();
                }
                else
                {
                    lIntItem = AcxControl.CurrentRow.Index;
                }
                AcxControl.Rows[lIntItem].Cells[Col_trv_periodo].Value = Convert.ToString(Txttrv_periodo.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value = Convert.ToString(Txttrv_tipo.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_registro].Value = Convert.ToString(Txttrv_registro.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value = Convert.ToInt32(Txttrv_entidad.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value = Convert.ToInt32(Txttrv_idvendedor.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value = Convert.ToInt32(Txttrv_idformapago.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = Convert.ToString(Txttrv_tdoc.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_sdoc].Value = Convert.ToString(Txttrv_sdoc.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_ndoc].Value = Convert.ToString(Txttrv_ndoc.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_femision].Value = Convert.ToDateTime(Txttrv_femision.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_fvencimiento].Value = Convert.ToDateTime(Txttrv_fvencimiento.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = Convert.ToString(Txttrv_moneda.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tcambio].Value = Convert.ToDecimal(Txttrv_tcambio.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_dctos].Value = Convert.ToDecimal(Txttrv_dctos.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_vventa].Value = Convert.ToDecimal(Txttrv_vventa.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_igv].Value = Convert.ToDecimal(Txttrv_igv.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_total].Value = Convert.ToDecimal(Txttrv_total.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_aigv].Value = Convert.ToInt32(Txttrv_aigv.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_flag].Value = Convert.ToInt32(Txttrv_flag.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_pigv].Value = Convert.ToDecimal(Txttrv_pigv.Text);
                AcxControl.CurrentCell = AcxControl.Rows[lIntItem].Cells[1];
                iBolCambiaEstatus = false;
                this.Cursor = Cursors.Default;
                iBolCambiaEstatus = true;
                return true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                iUT_Telerik.setRadMensaje(ex.Message);
                return false;
            }
        }
        internal bool setGrabarDatos()
        {
            int lIntItem = 0;
            int lIntReturn = 0;
            List<ENT_TRVENTAS_DET> lLisENT_TRVENTAS_DET = new List<ENT_TRVENTAS_DET>();
            ENT_TRVENTAS_CAB lENT_TRVENTAS_CAB;
            ENT_TRVENTAS_DET lENT_TRVENTAS_DET;
            int lIntFila = 0;
            try
            {
                lENT_TRVENTAS_CAB = new ENT_TRVENTAS_CAB();
                lENT_TRVENTAS_CAB.trv_empresa = Convert.ToString(Txttrv_empresa.Text);
                lENT_TRVENTAS_CAB.trv_periodo = Convert.ToString(Txttrv_periodo.Text);
                lENT_TRVENTAS_CAB.trv_tipo = Convert.ToString(Txttrv_tipo.Text);
                lENT_TRVENTAS_CAB.trv_registro = Convert.ToString(Txttrv_registro.Text);
                lENT_TRVENTAS_CAB.trv_entidad = Convert.ToInt32(Txttrv_entidad.Text);
                lENT_TRVENTAS_CAB.trv_idvendedor = Convert.ToInt32(Txttrv_idvendedor.Text);
                lENT_TRVENTAS_CAB.trv_idformapago = Convert.ToInt32(Txttrv_idformapago.Text);
                lENT_TRVENTAS_CAB.trv_tdoc = Convert.ToString(Txttrv_tdoc.Text);
                lENT_TRVENTAS_CAB.trv_sdoc = Convert.ToString(Txttrv_sdoc.Text);
                lENT_TRVENTAS_CAB.trv_ndoc = Convert.ToString(Txttrv_ndoc.Text);
                lENT_TRVENTAS_CAB.trv_femision = Convert.ToDateTime(Txttrv_femision.Text);
                lENT_TRVENTAS_CAB.trv_fvencimiento = Convert.ToDateTime(Txttrv_fvencimiento.Text);
                lENT_TRVENTAS_CAB.trv_moneda = Convert.ToString(Txttrv_moneda.Text);
                lENT_TRVENTAS_CAB.trv_tcambio = Convert.ToDecimal(Txttrv_tcambio.Text);
                lENT_TRVENTAS_CAB.trv_dctos = Convert.ToDecimal(Txttrv_dctos.Text);
                lENT_TRVENTAS_CAB.trv_vventa = Convert.ToDecimal(Txttrv_vventa.Text);
                lENT_TRVENTAS_CAB.trv_igv = Convert.ToDecimal(Txttrv_igv.Text);
                lENT_TRVENTAS_CAB.trv_total = Convert.ToDecimal(Txttrv_total.Text);
                lENT_TRVENTAS_CAB.trv_aigv = Convert.ToInt32(Txttrv_aigv.Text);
                lENT_TRVENTAS_CAB.trv_flag = Convert.ToInt32(Txttrv_flag.Text);
                lENT_TRVENTAS_CAB.trv_pigv = Convert.ToDecimal(Txttrv_pigv.Text);
                for (int lIntRow = 0; lIntRow < AcxDetalles.Rows.Count; lIntRow++)
                {
                    lIntFila = lIntRow;
                    lENT_TRVENTAS_DET = new ENT_TRVENTAS_DET();
                    lENT_TRVENTAS_DET.trvd_empresa = Convert.ToString(Txttrv_empresa.Text);
                    lENT_TRVENTAS_DET.trvd_periodo = Convert.ToString(Txttrv_periodo.Text);
                    lENT_TRVENTAS_DET.trvd_tipo = Convert.ToString(Txttrv_tipo.Text);
                    lENT_TRVENTAS_DET.trvd_registro = Convert.ToString(Txttrv_registro.Text);
                    lENT_TRVENTAS_DET.trvd_nroitm = lIntRow + 1;
                    lENT_TRVENTAS_DET.trvd_idarticulo = Convert.ToInt32(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_idarticulo].Value);
                    lENT_TRVENTAS_DET.trvd_cant = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_cant].Value);
                    lENT_TRVENTAS_DET.trvd_preun = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_preun].Value);
                    lENT_TRVENTAS_DET.trvd_pdcto = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_pdcto].Value);
                    lENT_TRVENTAS_DET.trvd_dcto = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_dcto].Value);
                    lENT_TRVENTAS_DET.trvd_vvta = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_vvta].Value);
                    lENT_TRVENTAS_DET.trvd_igv = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_igv].Value);
                    lENT_TRVENTAS_DET.trvd_tot = Convert.ToDecimal(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_tot].Value);
                    lLisENT_TRVENTAS_DET.Add(lENT_TRVENTAS_DET);
                }
                if (LN_TRVENTAS_CAB.setInsertarTRVENTAS_CAB(lENT_TRVENTAS_CAB, lLisENT_TRVENTAS_DET, out lIntReturn))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                iUT_Telerik.setRadMensaje(ex.Message);
                return false;
            }
        }
        internal int DetalleNuevoItem()
        {
            int lIntItem = 0;
            List<int> lLisNuevoCodigo = new List<int>();
            if (AcxDetalles.Rows.Count > 0)
            {
                for (int x = 0; x < AcxDetalles.Rows.Count; x++)
                {
                    lIntItem = x;
                    lLisNuevoCodigo.Add(x);
                }
            }
            else
            {
                lLisNuevoCodigo.Add(0);
            }
            return lLisNuevoCodigo.Max() + 1;
        }
        public bool getValidacionFicha()
        {
            int lIntColu = 0;
            int lIntItem = 0;
            string vChMsg = "";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_empresa.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_empresa.Text + " ]";
                        Txttrv_empresa.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_periodo.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_periodo.Text + " ]";
                        Txttrv_periodo.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_tipo.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_tipo.Text + " ]";
                        Txttrv_tipo.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_registro.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_registro.Text + " ]";
                        Txttrv_registro.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_entidad.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_entidad.Text + " ]";
                        Txttrv_entidad.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_idvendedor.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_idvendedor.Text + " ]";
                        Txttrv_idvendedor.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_idformapago.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_idformapago.Text + " ]";
                        Txttrv_idformapago.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_tdoc.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_tdoc.Text + " ]";
                        Txttrv_tdoc.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_sdoc.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_sdoc.Text + " ]";
                        Txttrv_sdoc.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_ndoc.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_ndoc.Text + " ]";
                        Txttrv_ndoc.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_femision.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_femision.Text + " ]";
                        Txttrv_femision.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_fvencimiento.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_fvencimiento.Text + " ]";
                        Txttrv_fvencimiento.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_moneda.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_moneda.Text + " ]";
                        Txttrv_moneda.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_tcambio.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_tcambio.Text + " ]";
                        Txttrv_tcambio.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_dctos.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_dctos.Text + " ]";
                        Txttrv_dctos.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_vventa.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_vventa.Text + " ]";
                        Txttrv_vventa.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_igv.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_igv.Text + " ]";
                        Txttrv_igv.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_total.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_total.Text + " ]";
                        Txttrv_total.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_aigv.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_aigv.Text + " ]";
                        Txttrv_aigv.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_flag.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_flag.Text + " ]";
                        Txttrv_flag.Focus();
                        goto ContinuarAqui;
                    }
                }
                if (vChMsg == "")
                {
                    if (iValidar.EsVacio(Txttrv_pigv.Text))
                    {
                        vChMsg = "Debe especificar [ " + Lbltrv_pigv.Text + " ]";
                        Txttrv_pigv.Focus();
                        goto ContinuarAqui;
                    }
                }
            ContinuarAqui:
                if (iConvertir.aString(vChMsg).Trim() != "")
                {
                    this.Cursor = Cursors.Default;
                    TabControl1.SelectedIndex = 0;
                    //if (lIntItem != 0)
                    //{
                    //AcxFicha.Items.EnsureVisibleItem(lIntItem);
                    //AcxFicha.Items.SelectItem[lIntItem] = true;
                    //}
                    iUT_Telerik.setRadMensaje(vChMsg, "I", "Mensaje de la Aplicaci�n");
                    //AcxFicha.EnsureVisibleColumn(lIntColu);
                    //AcxFicha.SearchColumnIndex = lIntColu;
                    //AcxFicha.FocusColumnIndex = lIntColu;
                    //AcxFicha.Focus();
                    //AcxFicha.Edit();
                    return false;
                }
                iBolCambiaEstatus = false;
                this.Cursor = Cursors.Default;
                iBolCambiaEstatus = true;
                return true;
            }
            catch (Exception ex)
            {
                iUT_Telerik.setRadMensaje(ex.Message);
                this.Cursor = Cursors.Default;
                return false;
            }
        }
        public bool getValidacionDetalle()
        {
            int lIntAxgItem = 0;
            int lIntColumna = 0;
            string lStrMsg = "";
            try
            {
                if (lStrMsg == "")
                {
                    lIntColumna = 1; //ITEM
                    if (AcxDetalles.Rows.Count <= 0)
                    {
                        lStrMsg = iConvertir.aString("Debe especificar al menos un item en el detalle");
                        goto ContinuarAqui;
                    }
                }
                for (int x = 0; x < AcxDetalles.Rows.Count; x++)
                {
                    lIntAxgItem = x;
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_idarticulo;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_cant;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_preun;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_pdcto;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_dcto;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_vvta;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_igv;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                    if (lStrMsg == "")
                    {
                        lIntColumna = Col_Det_trvd_tot;
                        if (iValidar.EsVacio(AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Value))
                        {
                            lStrMsg = "Debe especificar" + ": " + AcxDetalles.Columns[lIntColumna].HeaderText;
                            goto ContinuarAqui;
                        }
                    }
                }
            ContinuarAqui:
                if (lStrMsg != "")
                {
                    this.Cursor = Cursors.Default;
                    iUT_Telerik.setRadMensaje(lStrMsg, "I");
                    if (lIntAxgItem != 0)
                    {
                        AcxDetalles.Rows[lIntAxgItem].Cells[lIntColumna].Selected = true; ;
                    }
                    AcxDetalles.Focus();
                    AcxDetalles.RefreshEdit();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                iUT_Telerik.setRadMensaje(ex.Message);
                return false;
            }
        }
        private void GuardarAncho()
        {
        }
        private void Emula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && GlobalesVariables._IsPulsaF1CeldaGrid != true)
            {
                GlobalesVariables._IsPulsaF1CeldaGrid = true;
                SendKeys.Send("{tab}");
            }
        }
        #region Metodos_Ayuda_Validaciones
        private void AyudaTVENDEDOR_trv_idvendedor()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("id_vendedor", "Id", 166, true, true, "TEXT", 10, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_vendedor", "C�digo", 166, true, true, "TEXT", 10, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_nombre_vendedor", "Nombres", 166, true, true, "TEXT", 200, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Vendedores";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TVENDEDOR.getListarTVENDEDOR(null,null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_idvendedor.Text = xlStrValores[1].Trim();
                //Txttrv_idvendedor_Des.Text = xlStrValores[1].Trim();
                ValidaTVENDEDOR_trv_idvendedor();
            }
        }
        private void AyudaTFORMA_PAGO_trv_idformapago()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_forma_pago", "C�digo", 166, true, true, "TEXT", 3, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_forma_pago", "Descripci�n", 400, true, true, "TEXT", 100, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Forma de Pagos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TFORMA_PAGO.getListarTFORMA_PAGO(null, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_idformapago.Text = xlStrValores[0].Trim();
                //Txttrv_idformapago_Des.Text = xlStrValores[1].Trim();
                ValidaTFORMA_PAGO_trv_idformapago();
            }
        }
        private void AyudaTDOCUMENTOS_trv_tdoc()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_empresa", "Codigo de Compa�ia", 166, true, true, "TEXT", 2, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_codigo", "C�digo", 166, true, true, "TEXT", 3, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_sigla", "Sigla", 166, true, true, "TEXT", 3, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_descripcion", "Descripci�n", 166, true, true, "TEXT", 60, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Tipos de Documentos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TDOCUMENTOS.getListarTDOCUMENTOS(null, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_tdoc.Text = xlStrValores[0].Trim();
                //Txttrv_tdoc_Des.Text = xlStrValores[1].Trim();
                ValidaTDOCUMENTOS_trv_tdoc();
            }
        }
        private void AyudaTDOCUMENTOS_SERIES_trv_sdoc()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdocs_codigo", "Codigo Tipo Documento", 166, true, true, "TEXT", 3, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdocs_serie", "Serie", 166, true, true, "TEXT", 4, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdocs_numerador", "N�mero", 166, true, true, "TEXT", 8, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Serie de Documentos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TDOCUMENTOS_SERIES.getListarTDOCUMENTOS_SERIES(GlobalesVariables.company, iConvertir.aString(Btntrv_tdoc.Tag), null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_sdoc.Text = xlStrValores[1].Trim();
                //Txttrv_sdoc_Des.Text = xlStrValores[1].Trim();
                ValidaTDOCUMENTOS_SERIES_trv_sdoc();
            }
        }
        private void AyudaTARTICULO_trvd_idarticulo_Detalle()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("id_articulo", "Id Articulo", 166, true, true, "TEXT", 10, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_articulo", "C�digo", 166, true, true, "TEXT", 20, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_articulo", "Descripci�n", 166, true, true, "TEXT", 240, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_articulo_tecnico", "Descripci�n T�cnico", 166, true, true, "TEXT", 240, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_marca", "Marca", 166, true, true, "TEXT", 50, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda Tabla de Articulos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TARTICULO.getListarTARTICULO(null,null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = xlStrValores[1].Trim();
                //Txttrvd_idarticulo_Des.Text = xlStrValores[1].Trim();
                ValidaTARTICULO_trvd_idarticulo_Detalle();
            }
        }
        private void ValidaTVENDEDOR_trv_idvendedor()
        {
            var vEntities = (from LE in LN_TVENDEDOR.getListarTVENDEDOR(null, Txttrv_idvendedor.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_idvendedor.Tag = vEntities.ToList()[0].id_vendedor.ToString();
                Txttrv_idvendedor.Text = vEntities.ToList()[0].c_vendedor.ToString();
                Txttrv_idvendedor_Des.Text = vEntities.ToList()[0].t_vendedor.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_idvendedor.Text);
                Btntrv_idvendedor.Tag = "";
                Txttrv_idvendedor.Text = "";
                Txttrv_idvendedor_Des.Text = "";
            }
        }
        private void ValidaTFORMA_PAGO_trv_idformapago()
        {
            var vEntities = (from LE in LN_TFORMA_PAGO.getListarTFORMA_PAGO(null, Txttrv_idformapago.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_idformapago.Tag = vEntities.ToList()[0].id_forma_pago.ToString();
                Txttrv_idformapago.Text = vEntities.ToList()[0].c_forma_pago.ToString();
                Txttrv_idformapago_Des.Text = vEntities.ToList()[0].t_forma_pago.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_idformapago.Text);
                Btntrv_idformapago.Tag = "";
                Txttrv_idformapago.Text = "";
                Txttrv_idformapago_Des.Text = "";
            }
        }
        private void ValidaTDOCUMENTOS_trv_tdoc()
        {
            var vEntities = (from LE in LN_TDOCUMENTOS.getListarTDOCUMENTOS(Txttrv_tdoc.Text, Txttrv_tdoc.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_tdoc.Tag = vEntities.ToList()[0].ToString();
                Txttrv_tdoc.Text = vEntities.ToList()[0].ToString();
                Txttrv_tdoc_Des.Text = vEntities.ToList()[0].ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_tdoc.Text);
                Btntrv_tdoc.Tag = "";
                Txttrv_tdoc.Text = "";
                Txttrv_tdoc_Des.Text = "";
            }
        }
        private void ValidaTDOCUMENTOS_SERIES_trv_sdoc()
        {
            var vEntities = (from LE in LN_TDOCUMENTOS_SERIES.getListarTDOCUMENTOS_SERIES(GlobalesVariables.company, iConvertir.aString(Btntrv_tdoc.Tag), Txttrv_sdoc.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_sdoc.Tag = vEntities.ToList()[0].tdocs_serie.ToString();
                Txttrv_sdoc.Text = vEntities.ToList()[0].tdocs_serie.ToString();
                Txttrv_sdoc_Des.Text = vEntities.ToList()[0].tdocs_serie.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_sdoc.Text);
                Btntrv_sdoc.Tag = "";
                Txttrv_sdoc.Text = "";
                Txttrv_sdoc_Des.Text = "";
            }
        }
        private void ValidaTARTICULO_trvd_idarticulo_Detalle()
        {
            var vEntities = (from LE in LN_TARTICULO.getListarTARTICULO(null, iConvertir.aString(this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value)) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = vEntities.ToList()[0].id_articulo.ToString();
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = vEntities.ToList()[0].c_articulo.ToString();
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo + 1].Value = vEntities.ToList()[0].t_articulo.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + this.AcxDetalles.Columns[Col_Det_trvd_idarticulo].HeaderText);
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = "";
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = "";
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Des].Value = "";
            }
        }
        #endregion Metodos_Ayuda_Validaciones
        #endregion
    }
}
