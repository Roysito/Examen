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
using Telerik.Windows.Documents.Core.TextMeasurer;

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
        int Col_trv_tipo_d;
        int Col_trv_registro;
        int Col_trv_entidad;
        int Col_trv_entidad_c;
        int Col_trv_entidad_d;
        int Col_trv_idvendedor;
        int Col_trv_idvendedor_c;
        int Col_trv_idvendedor_d;
        int Col_trv_idformapago;
        int Col_trv_idformapago_c;
        int Col_trv_idformapago_d;
        int Col_trv_tdoc;
        int Col_trv_tdoc_d;
        int Col_trv_sdoc;
        int Col_trv_ndoc;
        int Col_trv_femision;
        int Col_trv_fvencimiento;
        int Col_trv_moneda;
        int Col_trv_moneda_d;
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
            //OC_Stb_Sesion.Text = iConvertir.aString("Sesión") + ":" + gChQTrab;
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
            if (iUT_Telerik.setRadMensajePregunta("¿Seguro que desea Detener el Proceso en Curso ? ", "Buscar...") == true)
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
            //AcxDetalles.BeginEdit(true);
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
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_cant".ToUpper())
                {
                    AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_preun".ToUpper())
                {
                    AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_pdcto".ToUpper())
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
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_cant".ToUpper())
                {
                    if (iConvertir.aString(AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString() != "")
                    {
                        if (AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
                        {
                            Totales();
                        }
                    }
                }
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_preun".ToUpper())
                {
                    if (iConvertir.aString(AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString() != "")
                    {
                        if (AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
                        {
                            Totales();
                        }
                    }
                }
                if (this.AcxDetalles.Columns[e.ColumnIndex].Name.ToUpper() == "trvd_pdcto".ToUpper())
                {
                    if (iConvertir.aString(AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).ToString() != "")
                    {
                        if (AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
                        {
                            Totales();
                        }
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
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_cant".ToUpper()) //Cantidad
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_preun".ToUpper()) //Precio Unitario
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_pdcto".ToUpper()) //% Descuento
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_dcto".ToUpper()) //Monto Descuento
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_vvta".ToUpper()) //Base Imponible
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_igv".ToUpper()) //Igv
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
                    e.Cancel = true;
                }
                this.AcxDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, iConvertir.aDecimal(e.FormattedValue.ToString()));
                AcxDetalles.RefreshEdit();
            }
            if (this.AcxDetalles.Columns[this.AcxDetalles.CurrentCell.ColumnIndex].Name.ToUpper() == "trvd_tot".ToUpper()) //Total Venta
            {
                if (iValidar.EsNumero(e.FormattedValue.ToString()) == false)
                {
                    iUT_Telerik.setRadMensaje("Solo se permite números", "E");
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
                if (iUT_Telerik.setRadMensajePregunta(iConvertir.aString("¿Seguro que desea eliminar el registro actual ? "), iConvertir.aString("Eliminar")) == true)
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
        private void Btntrv_tipo_Click(object sender, EventArgs e)
        {
            AyudaTNIVEL_VENTA_trv_tipo();
        }
        private void Btntrv_entidad_Click(object sender, EventArgs e)
        {
            AyudaTCTACTE_trv_entidad();
        }
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
        private void Btntrv_moneda_Click(object sender, EventArgs e)
        {
            AyudaTMONEDAS_trv_moneda();
        }
        private void Txttrv_tipo_GotFocus(object sender, EventArgs e)
        {
            Txttrv_tipo.Tag = Txttrv_tipo.Text;
        }
        private void Txttrv_entidad_GotFocus(object sender, EventArgs e)
        {
            Txttrv_entidad.Tag = Txttrv_entidad.Text;
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
        private void Txttrv_moneda_GotFocus(object sender, EventArgs e)
        {
            Txttrv_moneda.Tag = Txttrv_moneda.Text;
        }
        private void Txttrv_tipo_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_tipo.Text != "")
            {
                if (iConvertir.aString(Txttrv_tipo.Text) != iConvertir.aString(Txttrv_tipo.Tag))
                {
                    ValidaTNIVEL_VENTA_trv_tipo();
                }
            }
            else
            {
                Btntrv_tipo.Tag = "";
                Txttrv_tipo.Text = "";
                Txttrv_tipo_Des.Text = "";
            }
        }
        private void Txttrv_entidad_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_entidad.Text != "")
            {
                if (iConvertir.aString(Txttrv_entidad.Text) != iConvertir.aString(Txttrv_entidad.Tag))
                {
                    ValidaTCTACTE_trv_entidad();
                }
            }
            else
            {
                Btntrv_entidad.Tag = "";
                Txttrv_entidad.Text = "";
                Txttrv_entidad_Des.Text = "";
            }
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
                Txttrv_ndoc.Text = "";
            }
        }
        private void Txttrv_moneda_LostFocus(object sender, EventArgs e)
        {
            if (Txttrv_moneda.Text != "")
            {
                if (iConvertir.aString(Txttrv_moneda.Text) != iConvertir.aString(Txttrv_moneda.Tag))
                {
                    ValidaTMONEDAS_trv_moneda();
                }
            }
            else
            {
                Btntrv_moneda.Tag = "";
                Txttrv_moneda.Text = "";
                Txttrv_moneda_Des.Text = "";
            }
        }
        private void Txttrv_tipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTNIVEL_VENTA_trv_tipo();
        }
        private void Txttrv_entidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTCTACTE_trv_entidad();
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
        private void Txttrv_moneda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == GlobalesVariables._teclaayuda)
                AyudaTMONEDAS_trv_moneda();
        }
        #endregion Eventos_Ayuda_Validaciones
        private void Txttrv_periodo_ValueChanged(object sender, EventArgs e)
        {
            GeneraRegistro();
        }
        private void Txttrv_mes_ValueChanged(object sender, EventArgs e)
        {
            GeneraRegistro();
        }
        private void Txttrv_aigv_CheckedChanged(object sender, EventArgs e)
        {
            Totales();
        }
        private void Txttrv_tcambio_ValueChanged(object sender, EventArgs e)
        {
            Totales();
        }
        private void Txttrv_pigv_ValueChanged(object sender, EventArgs e)
        {
            Totales();
        }
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
            if (iIntModo == 2)
                GrpClave.Enabled = false;
            else
                GrpClave.Enabled = true;
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
            Txttrv_periodo.Text = "";
            Txttrv_tipo.Text = "";
            Txttrv_tipo_Des.Text = "";
            Txttrv_registro.Text = "";
            Txttrv_entidad.Text = "";
            Txttrv_entidad_Des.Text = "";
            Txttrv_idvendedor.Text = "";
            Txttrv_idvendedor_Des.Text = "";
            Txttrv_idformapago.Text = "";
            Txttrv_idformapago_Des.Text = "";
            Txttrv_tdoc.Text = "";
            Txttrv_tdoc_Des.Text = "";
            Txttrv_sdoc.Text = "";
            Txttrv_ndoc.Text = "";
            Txttrv_ndoc.Text = "";
            Txttrv_femision.Text = "";
            Txttrv_fvencimiento.Text = "";
            Txttrv_moneda.Text = "";
            Txttrv_moneda_Des.Text = "";
            Txttrv_tcambio.Value = 3.789m;
            Txttrv_dctos.Text = "";
            Txttrv_vventa.Text = "";
            Txttrv_igv.Text = "";
            Txttrv_total.Text = "";
            Txttrv_aigv.Checked = true;
            Txttrv_flag.Checked = true;
            Txttrv_pigv.Value = 18.00m;
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
                    Txttrv_periodo.Value = Convert.ToDateTime("01/" + "01/" + Lista.trv_periodo);
                    Txttrv_tipo.Text = Convert.ToString(Lista.trv_tipo).ToString();
                    Btntrv_tipo.Tag = Convert.ToString(Lista.trv_tipo).ToString();
                    Txttrv_tipo_Des.Text = "";
                    Txttrv_mes.Value = Convert.ToDateTime("01/" + Lista.trv_registro.Substring(0, 2) + "/2023");
                    Txttrv_registro.Text = Convert.ToString(Lista.trv_registro.Substring(2, 6)).ToString();
                    Txttrv_entidad.Text = Convert.ToInt32(Lista.trv_entidad).ToString();
                    Btntrv_entidad.Tag = Convert.ToInt32(Lista.trv_entidad).ToString();
                    Txttrv_entidad_Des.Text = "";
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
                    Txttrv_ndoc.Text = "";
                    Txttrv_ndoc.Text = Convert.ToString(Lista.trv_ndoc).ToString();
                    Txttrv_femision.Text = Convert.ToDateTime(Lista.trv_femision).ToString();
                    Txttrv_fvencimiento.Text = Convert.ToDateTime(Lista.trv_fvencimiento).ToString();
                    Txttrv_moneda.Text = Convert.ToString(Lista.trv_moneda).ToString();
                    Btntrv_moneda.Tag = Convert.ToString(Lista.trv_moneda).ToString();
                    Txttrv_moneda_Des.Text = "";
                    Txttrv_tcambio.Text = Convert.ToDecimal(Lista.trv_tcambio).ToString();
                    Txttrv_dctos.Text = Convert.ToDecimal(Lista.trv_dctos).ToString();
                    Txttrv_vventa.Text = Convert.ToDecimal(Lista.trv_vventa).ToString();
                    Txttrv_igv.Text = Convert.ToDecimal(Lista.trv_igv).ToString();
                    Txttrv_total.Text = Convert.ToDecimal(Lista.trv_total).ToString();
                    Txttrv_aigv.Checked = Convert.ToBoolean(Lista.trv_aigv);
                    Txttrv_flag.Checked = Convert.ToBoolean(Lista.trv_flag);
                    Txttrv_pigv.Text = Convert.ToDecimal(Lista.trv_pigv).ToString();

                    var lLisNivel = (from LE in LN_TNIVEL_VENTA.getListarTNIVEL_VENTA(GlobalesVariables.company, Txttrv_tipo.Text) select LE).ToList();
                    if (lLisNivel.ToList().Count() > 0)
                    {
                        Btntrv_tipo.Tag = lLisNivel.ToList()[0].tven_codigo.ToString();
                        Txttrv_tipo.Text = lLisNivel.ToList()[0].tven_codigo.ToString();
                        Txttrv_tipo_Des.Text = lLisNivel.ToList()[0].tven_descripcion.ToString();
                    }
                    var vLisCtaCte = (from LE in LN_TCTACTE.getListarTCTACTE(iConvertir.aEntero(Btntrv_entidad.Tag), null) select LE).ToList();
                    if (vLisCtaCte.ToList().Count() > 0)
                    {
                        Btntrv_entidad.Tag = vLisCtaCte.ToList()[0].id_ctacte.ToString();
                        Txttrv_entidad.Text = vLisCtaCte.ToList()[0].c_ctacte.ToString();
                        Txttrv_entidad_Des.Text = vLisCtaCte.ToList()[0].t_razon_social.ToString();
                    }
                    var vLisVendedor = (from LE in LN_TVENDEDOR.getListarTVENDEDOR(iConvertir.aEntero(Btntrv_idvendedor.Tag), null) select LE).ToList();
                    if (vLisVendedor.ToList().Count() > 0)
                    {
                        Btntrv_idvendedor.Tag = vLisVendedor.ToList()[0].id_vendedor.ToString();
                        Txttrv_idvendedor.Text = vLisVendedor.ToList()[0].c_vendedor.ToString();
                        Txttrv_idvendedor_Des.Text = vLisVendedor.ToList()[0].t_vendedor.ToString();
                    }
                    var vLisFPago = (from LE in LN_TFORMA_PAGO.getListarTFORMA_PAGO(iConvertir.aEntero(Btntrv_idformapago.Tag), null) select LE).ToList();
                    if (vLisFPago.ToList().Count() > 0)
                    {
                        Btntrv_idformapago.Tag = vLisFPago.ToList()[0].id_forma_pago.ToString();
                        Txttrv_idformapago.Text = vLisFPago.ToList()[0].c_forma_pago.ToString();
                        Txttrv_idformapago_Des.Text = vLisFPago.ToList()[0].t_forma_pago.ToString();
                    }
                    var vTDocu = (from LE in LN_TDOCUMENTOS.getListarTDOCUMENTOS(GlobalesVariables.company, Txttrv_tdoc.Text) select LE).ToList();
                    if (vTDocu.ToList().Count() > 0)
                    {
                        Btntrv_tdoc.Tag = vTDocu.ToList()[0].tdoc_codigo.ToString();
                        Txttrv_tdoc.Text = vTDocu.ToList()[0].tdoc_codigo.ToString();
                        Txttrv_tdoc_Des.Text = vTDocu.ToList()[0].tdoc_descripcion.ToString();
                    }
                    var vLisMoneda = (from LE in LN_TMONEDAS.getListarTMONEDAS(Txttrv_moneda.Text) select LE).ToList();
                    if (vLisMoneda.ToList().Count() > 0)
                    {
                        Btntrv_moneda.Tag = vLisMoneda.ToList()[0].mnd_cod.ToString();
                        Txttrv_moneda.Text = vLisMoneda.ToList()[0].mnd_cod.ToString();
                        Txttrv_moneda_Des.Text = vLisMoneda.ToList()[0].mnd_des.ToString();
                    }
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
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = Convert.ToInt32(Lista.trvd_idarticulo);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_cant].Value = Convert.ToDecimal(Lista.trvd_cant);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_preun].Value = Convert.ToDecimal(Lista.trvd_preun);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_pdcto].Value = Convert.ToDecimal(Lista.trvd_pdcto);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_dcto].Value = Convert.ToDecimal(Lista.trvd_dcto);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_vvta].Value = Convert.ToDecimal(Lista.trvd_vvta);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_igv].Value = Convert.ToDecimal(Lista.trvd_igv);
                    AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_tot].Value = Convert.ToDecimal(Lista.trvd_tot);
                    var vLisArticulo = (from LE in LN_TARTICULO.getListarTARTICULO(iConvertir.aEntero(AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo_Ayu].Tag), null) select LE).ToList();
                    if (vLisArticulo.ToList().Count() > 0)
                    {
                        this.AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = vLisArticulo.ToList()[0].id_articulo.ToString();
                        this.AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo].Value = vLisArticulo.ToList()[0].c_articulo.ToString();
                        this.AcxDetalles.Rows[lIntItem].Cells[Col_Det_trvd_idarticulo_Des].Value = vLisArticulo.ToList()[0].t_articulo.ToString();
                    }
                    Application.DoEvents();
                    if (iBolDetener)
                    {
                        break;
                    }
                }
            }
            Totales();
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
                if (MessageBox.Show("Formulario está en edición, finalice para cerrar ", GlobalesVariables._nombreaplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
            int lIntReturn = 0;

            ENT_TRVENTAS_CAB lENT_TRVENTAS_CAB;

            try
            {
                if (AcxControl.CurrentRow != null)
                {
                    POSITION = AcxControl.CurrentRow.Index;
                    lIntItem = AcxControl.CurrentRow.Index;
                    if (iUT_Telerik.setRadMensajePregunta(iConvertir.aString("¿Seguro que desea anular el registro actual ? "), iConvertir.aString("Anular")) == true)
                    {
                        lENT_TRVENTAS_CAB = new ENT_TRVENTAS_CAB();
                        lENT_TRVENTAS_CAB.trv_empresa = GlobalesVariables.company;
                        lENT_TRVENTAS_CAB.trv_periodo = Convert.ToString(this.AcxControl.Rows[lIntItem].Cells[Col_trv_periodo].Value);
                        lENT_TRVENTAS_CAB.trv_tipo = Convert.ToString(Convert.ToString(this.AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value));
                        lENT_TRVENTAS_CAB.trv_registro = Convert.ToString(Convert.ToString(this.AcxControl.Rows[lIntItem].Cells[Col_trv_registro].Value));
                        if (LN_TRVENTAS_CAB.setEliminarTRVENTAS_CAB(lENT_TRVENTAS_CAB, out lIntReturn) == true)
                            AcxControl.Rows.RemoveAt(lIntItem);
                        if (AcxControl.Rows.Count > 0)
                        {
                            if (POSITION - 1 >= 0)
                                AcxControl.Rows[POSITION-1].Selected = true;
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
                GeneraRegistro();
                ValidaTDOCUMENTOS_SERIES_trv_sdoc();
            }
            else
            {
                iUT_Telerik.setRadMensaje(iConvertir.aString("Debe seleccionar un registro"), "I", iConvertir.aString("Duplicar"));
            }
        }
        public void ConfigGridPrincipal()
        {
            iUT_ExGrid.setInicializaDataGridView(AcxControl, true, true, false, false, true);
            Col_trv_periodo = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_periodo", "Periodo", 80, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_periodo
            Col_trv_tipo = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_tipo", "Nivel Venta", 80, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_tipo
            Col_trv_tipo_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_tipo_d", "Nivel Venta", 200, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_registro = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_registro", "Número Registro", 80, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_registro
            Col_trv_entidad = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_entidad", "Id Ctacte", 0, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_entidad
            Col_trv_entidad_c = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_entidad_c", "Cod. Ctacte", 80, true, true, "TEXT", 0, 0, "CENTRO", "", "");
            Col_trv_entidad_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_entidad_d", "Nom. Ctacte", 350, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_idvendedor = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idvendedor", "Id Vendedor", 0, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_idvendedor
            Col_trv_idvendedor_c = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idvendedor_c", "Cod. Vendedor", 80, true, true, "TEXT", 0, 0, "CENTRO", "", "");
            Col_trv_idvendedor_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idvendedor_d", "Nom. Vendedor", 350, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_idformapago = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idformapago", "Id Forma Pago", 0, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_idformapago
            Col_trv_idformapago_c = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idformapago_c", "Cod. Forma Pago", 80, true, true, "TEXT", 0, 0, "CENTRO", "", "");
            Col_trv_idformapago_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_idformapago_d", "Nom. Forma Pago", 200, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_tdoc = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_tdoc", "Código Documento", 80, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_tdoc
            Col_trv_tdoc_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_tdoc_d", "Nombre Documento", 250, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_sdoc = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_sdoc", "Serie Documento", 80, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_sdoc
            Col_trv_ndoc = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_ndoc", "Número Documento", 100, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_ndoc
            Col_trv_femision = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_femision", "Fecha Emisión", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_femision
            Col_trv_fvencimiento = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_fvencimiento", "Fecha Vencimiento", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trv_fvencimiento
            Col_trv_moneda = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_moneda", "Código Moneda", 0, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_moneda
            Col_trv_moneda_d = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_moneda_d", "Nom. Moneda", 200, true, true, "TEXT", 0, 0, "IZQUIERDA", "", "");
            Col_trv_tcambio = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_tcambio", "Tipo de Cambio", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trv_tcambio
            Col_trv_dctos = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_dctos", "Total Descuentos", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trv_dctos
            Col_trv_vventa = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_vventa", "Base Imponible", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trv_vventa
            Col_trv_igv = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_igv", "Igv", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trv_igv
            Col_trv_total = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_total", "Total Venta", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trv_total
            Col_trv_aigv = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_aigv", "Afeco Igv", 100, true, true, "CHECK", 0, 0, "CENTRO", "", ""); //trv_aigv
            Col_trv_flag = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_flag", "Activo", 100, true, true, "CHECK", 0, 0, "CENTRO", "", ""); //trv_flag
            Col_trv_pigv = iUT_ExGrid.getAñadeColumna(AcxControl, "trv_pigv", "Porcentaje Igv", 100, true, true, "TEXT", 0, 0, "CENTRO", "", ""); //trv_pigv
            AcxControl.ReadOnly = false;
            AcxControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        public void ConfigGridDetalles()
        {
            iUT_ExGrid.setInicializaDataGridView(AcxDetalles, true, true, false, false, true);
            Col_Det_trvd_idarticulo = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_idarticulo", "Id Articulo", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_idarticulo
            Col_Det_trvd_idarticulo_Ayu = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_idarticulo_Ayu", "...", 30, true, true, "BUTTON", 0, 0, "CENTRO", "", ""); //trvd_idarticulo
            Col_Det_trvd_idarticulo_Des = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_idarticulo_Des", "Descripción", 350, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_idarticulo
            Col_Det_trvd_cant = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_cant", "Cantidad", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_cant
            Col_Det_trvd_preun = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_preun", "Precio Unitario", 100, true, true, "TEXT", 0, 0, "IZQUIERDA", "", ""); //trvd_preun
            Col_Det_trvd_pdcto = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_pdcto", "% Descuento", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trvd_pdcto
            Col_Det_trvd_dcto = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_dcto", "Monto Descuento", 0, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trvd_dcto
            Col_Det_trvd_vvta = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_vvta", "Base Imponible", 100, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trvd_vvta
            Col_Det_trvd_igv = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_igv", "Igv", 0, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trvd_igv
            Col_Det_trvd_tot = iUT_ExGrid.getAñadeColumna(AcxDetalles, "trvd_tot", "Total Venta", 0, true, true, "TEXT", 0, 0, "DERECHA", "", ""); //trvd_tot
            AcxDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
                    AcxControl.Rows[lIntItem].Cells[Col_trv_aigv].Value = Convert.ToBoolean(Lista.trv_aigv);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_flag].Value = Convert.ToBoolean(Lista.trv_flag);
                    AcxControl.Rows[lIntItem].Cells[Col_trv_pigv].Value = Convert.ToDecimal(Lista.trv_pigv);

                    var lLisNivel = (from LE in LN_TNIVEL_VENTA.getListarTNIVEL_VENTA(GlobalesVariables.company, iConvertir.aString(AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value)) select LE).ToList();
                    if (lLisNivel.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value = lLisNivel.ToList()[0].tven_codigo.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_tipo_d].Value = lLisNivel.ToList()[0].tven_descripcion.ToString();
                    }
                    var vLisCtaCte = (from LE in LN_TCTACTE.getListarTCTACTE(iConvertir.aEntero(AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value), null) select LE).ToList();
                    if (vLisCtaCte.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value = vLisCtaCte.ToList()[0].id_ctacte.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_entidad_c].Value = vLisCtaCte.ToList()[0].c_ctacte.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_entidad_d].Value = vLisCtaCte.ToList()[0].t_razon_social.ToString();
                    }
                    var vLisVendedor = (from LE in LN_TVENDEDOR.getListarTVENDEDOR(iConvertir.aEntero(AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value), null) select LE).ToList();
                    if (vLisVendedor.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value = vLisVendedor.ToList()[0].id_vendedor.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor_c].Value = vLisVendedor.ToList()[0].c_vendedor.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor_d].Value = vLisVendedor.ToList()[0].t_vendedor.ToString();
                    }
                    var vLisFPago = (from LE in LN_TFORMA_PAGO.getListarTFORMA_PAGO(iConvertir.aEntero(AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value), null) select LE).ToList();
                    if (vLisFPago.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value = vLisFPago.ToList()[0].id_forma_pago.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago_c].Value = vLisFPago.ToList()[0].c_forma_pago.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago_d].Value = vLisFPago.ToList()[0].t_forma_pago.ToString();
                    }
                    var vTDocu = (from LE in LN_TDOCUMENTOS.getListarTDOCUMENTOS(GlobalesVariables.company, iConvertir.aString(AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value)) select LE).ToList();
                    if (vTDocu.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = vTDocu.ToList()[0].tdoc_codigo.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = vTDocu.ToList()[0].tdoc_codigo.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc_d].Value = vTDocu.ToList()[0].tdoc_descripcion.ToString();
                    }
                    var vLisMoneda = (from LE in LN_TMONEDAS.getListarTMONEDAS(iConvertir.aString(AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value)) select LE).ToList();
                    if (vLisMoneda.ToList().Count() > 0)
                    {
                        AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = vLisMoneda.ToList()[0].mnd_cod.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = vLisMoneda.ToList()[0].mnd_cod.ToString();
                        AcxControl.Rows[lIntItem].Cells[Col_trv_moneda_d].Value = vLisMoneda.ToList()[0].mnd_des.ToString();
                    }
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
                    lLisTRVENTAS_CAB = LN_TRVENTAS_CAB.getListarTRVENTAS_CAB(GlobalesVariables.company, Convert.ToString(Txttrv_periodo.Text.ToString().Trim()), Convert.ToString(Txttrv_tipo.Text.ToString().Trim()), Convert.ToString(Txttrv_registro.Text.ToString().Trim()));
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
                    iUT_Telerik.setRadMensaje(vChMsg, "I", "Mensaje de la Aplicación");
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
                AcxControl.Rows[lIntItem].Cells[Col_trv_periodo].Value = Convert.ToString(Txttrv_periodo.Value.ToString("yyyy"));
                AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value = Convert.ToString(Txttrv_tipo.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_registro].Value = Convert.ToString(Txttrv_mes.Value.ToString("MM")) + Convert.ToString(Txttrv_registro.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value = Convert.ToInt32(Btntrv_entidad.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value = Convert.ToInt32(Btntrv_idvendedor.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value = Convert.ToInt32(Btntrv_idformapago.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = Convert.ToString(Btntrv_tdoc.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_sdoc].Value = Convert.ToString(Btntrv_sdoc.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_ndoc].Value = Convert.ToString(Txttrv_ndoc.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_femision].Value = Convert.ToDateTime(Txttrv_femision.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_fvencimiento].Value = Convert.ToDateTime(Txttrv_fvencimiento.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = Convert.ToString(Btntrv_moneda.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tcambio].Value = Convert.ToDecimal(Txttrv_tcambio.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_dctos].Value = Convert.ToDecimal(Txttrv_dctos.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_vventa].Value = Convert.ToDecimal(Txttrv_vventa.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_igv].Value = Convert.ToDecimal(Txttrv_igv.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_total].Value = Convert.ToDecimal(Txttrv_total.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_aigv].Value = Convert.ToInt32(Txttrv_aigv.Checked);
                AcxControl.Rows[lIntItem].Cells[Col_trv_flag].Value = Convert.ToInt32(Txttrv_flag.Checked);
                AcxControl.Rows[lIntItem].Cells[Col_trv_pigv].Value = Convert.ToDecimal(Txttrv_pigv.Value);

                AcxControl.Rows[lIntItem].Cells[Col_trv_tipo].Value = Convert.ToString(Txttrv_tipo.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tipo_d].Value = Convert.ToString(Txttrv_tipo_Des.Text);

                AcxControl.Rows[lIntItem].Cells[Col_trv_entidad].Value = Convert.ToInt32(Btntrv_entidad.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_entidad_c].Value = Convert.ToString(Txttrv_entidad.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_entidad_d].Value = Convert.ToString(Txttrv_entidad_Des.Text);

                AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor].Value = Convert.ToInt32(Btntrv_idvendedor.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor_c].Value = Convert.ToString(Txttrv_idvendedor.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idvendedor_d].Value = Convert.ToString(Txttrv_idvendedor_Des.Text);

                AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago].Value = Convert.ToInt32(Btntrv_idformapago.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago_c].Value = Convert.ToString(Txttrv_idformapago.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_idformapago_d].Value = Convert.ToString(Txttrv_idformapago_Des.Text);

                AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = Convert.ToString(Btntrv_tdoc.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc].Value = Convert.ToString(Txttrv_tdoc.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_tdoc_d].Value = Convert.ToString(Txttrv_tdoc_Des.Text);


                AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = Convert.ToString(Btntrv_moneda.Tag);
                AcxControl.Rows[lIntItem].Cells[Col_trv_moneda].Value = Convert.ToString(Txttrv_moneda.Text);
                AcxControl.Rows[lIntItem].Cells[Col_trv_moneda_d].Value = Convert.ToString(Txttrv_moneda_Des.Text);

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
                lENT_TRVENTAS_CAB.trv_empresa = GlobalesVariables.company;
                lENT_TRVENTAS_CAB.trv_periodo = Convert.ToString(Txttrv_periodo.Text);
                lENT_TRVENTAS_CAB.trv_tipo = Convert.ToString(Btntrv_tipo.Tag);
                lENT_TRVENTAS_CAB.trv_registro = Txttrv_mes.Value.ToString("MM") + Convert.ToString(Txttrv_registro.Text);
                lENT_TRVENTAS_CAB.trv_entidad = Convert.ToInt32(Btntrv_entidad.Tag);
                lENT_TRVENTAS_CAB.trv_idvendedor = Convert.ToInt32(Btntrv_idvendedor.Tag);
                lENT_TRVENTAS_CAB.trv_idformapago = Convert.ToInt32(Btntrv_idformapago.Tag);
                lENT_TRVENTAS_CAB.trv_tdoc = Convert.ToString(Btntrv_tdoc.Tag);
                lENT_TRVENTAS_CAB.trv_sdoc = Convert.ToString(Btntrv_sdoc.Tag);
                lENT_TRVENTAS_CAB.trv_ndoc = Convert.ToString(Txttrv_ndoc.Text);
                lENT_TRVENTAS_CAB.trv_femision = Convert.ToDateTime(Txttrv_femision.Text);
                lENT_TRVENTAS_CAB.trv_fvencimiento = Convert.ToDateTime(Txttrv_fvencimiento.Text);
                lENT_TRVENTAS_CAB.trv_moneda = Convert.ToString(Btntrv_moneda.Tag);
                lENT_TRVENTAS_CAB.trv_tcambio = Convert.ToDecimal(Txttrv_tcambio.Text);
                lENT_TRVENTAS_CAB.trv_dctos = Convert.ToDecimal(Txttrv_dctos.Text);
                lENT_TRVENTAS_CAB.trv_vventa = Convert.ToDecimal(Txttrv_vventa.Text);
                lENT_TRVENTAS_CAB.trv_igv = Convert.ToDecimal(Txttrv_igv.Text);
                lENT_TRVENTAS_CAB.trv_total = Convert.ToDecimal(Txttrv_total.Text);
                if (Txttrv_aigv.Checked == true)
                    lENT_TRVENTAS_CAB.trv_aigv = 1;
                else
                    lENT_TRVENTAS_CAB.trv_aigv = 0;
                if (Txttrv_flag.Checked == true)
                    lENT_TRVENTAS_CAB.trv_flag = 1;
                else
                    lENT_TRVENTAS_CAB.trv_flag = 0;
                lENT_TRVENTAS_CAB.trv_pigv = Convert.ToDecimal(Txttrv_pigv.Text);
                for (int lIntRow = 0; lIntRow < AcxDetalles.Rows.Count; lIntRow++)
                {
                    lIntFila = lIntRow;
                    lENT_TRVENTAS_DET = new ENT_TRVENTAS_DET();

                    lENT_TRVENTAS_DET.trvd_empresa = GlobalesVariables.company;
                    lENT_TRVENTAS_DET.trvd_periodo = Convert.ToString(Txttrv_periodo.Text);
                    lENT_TRVENTAS_DET.trvd_tipo = Convert.ToString(Btntrv_tipo.Tag);
                    lENT_TRVENTAS_DET.trvd_registro = Txttrv_mes.Value.ToString("MM") + Convert.ToString(Txttrv_registro.Text);
                    lENT_TRVENTAS_DET.trvd_nroitm = lIntRow + 1;
                    lENT_TRVENTAS_DET.trvd_idarticulo = Convert.ToInt32(AcxDetalles.Rows[lIntFila].Cells[Col_Det_trvd_idarticulo_Ayu].Tag);
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
                    iUT_Telerik.setRadMensaje(vChMsg, "I", "Mensaje de la Aplicación");
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
        private void AyudaTNIVEL_VENTA_trv_tipo()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tven_codigo", "Código", 166, true, true, "TEXT", 3, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tven_descripcion", "Descripción", 400, true, true, "TEXT", 70, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Nivel de Ventas";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TNIVEL_VENTA.getListarTNIVEL_VENTA(GlobalesVariables.company, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_tipo.Text = xlStrValores[0].Trim();
                //Txttrv_tipo_Des.Text = xlStrValores[1].Trim();
                ValidaTNIVEL_VENTA_trv_tipo();
            }
        }
        private void AyudaTCTACTE_trv_entidad()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_ctacte", "Código", 166, true, true, "TEXT", 10, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_razon_social", "Razón Social", 400, true, true, "TEXT", 250, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Detalle de Cuenta Corriente";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TCTACTE.getListarTCTACTE(null, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_entidad.Text = xlStrValores[0].Trim();
                //Txttrv_entidad_Des.Text = xlStrValores[1].Trim();
                ValidaTCTACTE_trv_entidad();
            }
        }
        private void AyudaTVENDEDOR_trv_idvendedor()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_vendedor", "Código", 166, true, true, "TEXT", 10, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_nombre_vendedor", "Nombres", 400, true, true, "TEXT", 200, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Vendedores";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TVENDEDOR.getListarTVENDEDOR(null, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_idvendedor.Text = xlStrValores[0].Trim();
                //Txttrv_idvendedor_Des.Text = xlStrValores[1].Trim();
                ValidaTVENDEDOR_trv_idvendedor();
            }
        }
        private void AyudaTFORMA_PAGO_trv_idformapago()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_forma_pago", "Código", 166, true, true, "TEXT", 3, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_forma_pago", "Descripción", 400, true, true, "TEXT", 100, 0, "IZQUIERDA", "", "", false));
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
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_codigo", "Código", 166, true, true, "TEXT", 3, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_sigla", "Sigla", 166, true, true, "TEXT", 3, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdoc_descripcion", "Descripción", 400, true, true, "TEXT", 60, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Tipos de Documentos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TDOCUMENTOS.getListarTDOCUMENTOS(GlobalesVariables.company, null).Cast<object>().ToList();
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
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdocs_serie", "Serie", 166, true, true, "TEXT", 4, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("tdocs_numerador", "Número", 166, true, true, "TEXT", 8, 0, "DERECHA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Serie de Documentos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TDOCUMENTOS_SERIES.getListarTDOCUMENTOS_SERIES(GlobalesVariables.company, Txttrv_tdoc.Text, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_sdoc.Text = xlStrValores[0].Trim();
                //Txttrv_sdoc_Des.Text = xlStrValores[1].Trim();
                ValidaTDOCUMENTOS_SERIES_trv_sdoc();
            }
        }
        private void AyudaTMONEDAS_trv_moneda()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("mnd_cod", "Código", 166, true, true, "TEXT", 2, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("mnd_des", "Descripción", 300, true, true, "TEXT", 60, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("mnd_sigla", "Sigla", 166, true, true, "TEXT", 10, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("mnd_abrev", "Abreviatura", 166, true, true, "TEXT", 50, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda de Monedas";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TMONEDAS.getListarTMONEDAS(null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                Txttrv_moneda.Text = xlStrValores[0].Trim();
                //Txttrv_moneda_Des.Text = xlStrValores[1].Trim();
                ValidaTMONEDAS_trv_moneda();
            }
        }
        private void AyudaTARTICULO_trvd_idarticulo_Detalle()
        {
            string[] xlStrValores;
            List<clsColumnsGrilla> vClsColumnsGrilla = new List<clsColumnsGrilla>();
            vClsColumnsGrilla.Add(new clsColumnsGrilla("c_articulo", "Código", 166, true, true, "TEXT", 20, 0, "CENTRO", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_articulo", "Descripción", 350, true, true, "TEXT", 240, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_articulo_tecnico", "Descripción Técnico", 250, true, true, "TEXT", 240, 0, "IZQUIERDA", "", "", false));
            vClsColumnsGrilla.Add(new clsColumnsGrilla("t_marca", "Marca", 166, true, true, "TEXT", 50, 0, "IZQUIERDA", "", "", false));
            HLP_GENERALI MiFrmNuevo = new HLP_GENERALI();
            MiFrmNuevo.pChTitulo = "Ayuda Tabla de Articulos";
            MiFrmNuevo.vClsColumnsGrilla = vClsColumnsGrilla;
            MiFrmNuevo.vLisEntidades = LN_TARTICULO.getListarTARTICULO(null, null).Cast<object>().ToList();
            MiFrmNuevo.ShowDialog();
            if (MiFrmNuevo.pChRetorno.Trim() != "")
            {
                xlStrValores = MiFrmNuevo.pChRetorno.Split('|');
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = xlStrValores[0].Trim();
                //Txttrvd_idarticulo_Des.Text = xlStrValores[1].Trim();
                ValidaTARTICULO_trvd_idarticulo_Detalle();
            }
        }
        private void ValidaTNIVEL_VENTA_trv_tipo()
        {
            var vEntities = (from LE in LN_TNIVEL_VENTA.getListarTNIVEL_VENTA(GlobalesVariables.company, Txttrv_tipo.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_tipo.Tag = vEntities.ToList()[0].tven_codigo.ToString();
                Txttrv_tipo.Text = vEntities.ToList()[0].tven_codigo.ToString();
                Txttrv_tipo_Des.Text = vEntities.ToList()[0].tven_descripcion.ToString();
                GeneraRegistro();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_tipo.Text);
                Btntrv_tipo.Tag = "";
                Txttrv_tipo.Text = "";
                Txttrv_tipo_Des.Text = "";
            }
        }
        private void ValidaTCTACTE_trv_entidad()
        {
            var vEntities = (from LE in LN_TCTACTE.getListarTCTACTE(null, Txttrv_entidad.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_entidad.Tag = vEntities.ToList()[0].id_ctacte.ToString();
                Txttrv_entidad.Text = vEntities.ToList()[0].c_ctacte.ToString();
                Txttrv_entidad_Des.Text = vEntities.ToList()[0].t_razon_social.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_entidad.Text);
                Btntrv_entidad.Tag = "";
                Txttrv_entidad.Text = "";
                Txttrv_entidad_Des.Text = "";
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
            var vEntities = (from LE in LN_TDOCUMENTOS.getListarTDOCUMENTOS(GlobalesVariables.company, Txttrv_tdoc.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_tdoc.Tag = vEntities.ToList()[0].tdoc_codigo.ToString();
                Txttrv_tdoc.Text = vEntities.ToList()[0].tdoc_codigo.ToString();
                Txttrv_tdoc_Des.Text = vEntities.ToList()[0].tdoc_descripcion.ToString();
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
            var vEntities = (from LE in LN_TDOCUMENTOS_SERIES.getListarTDOCUMENTOS_SERIES(GlobalesVariables.company, Txttrv_tdoc.Text, Txttrv_sdoc.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_sdoc.Tag = vEntities.ToList()[0].tdocs_serie.ToString();
                Txttrv_sdoc.Text = vEntities.ToList()[0].tdocs_serie.ToString();
                Txttrv_ndoc.Text = (iConvertir.aEntero(vEntities.ToList()[0].tdocs_numerador.Trim()) + 1).ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_sdoc.Text);
                Btntrv_sdoc.Tag = "";
                Txttrv_sdoc.Text = "";
                Txttrv_ndoc.Text = "";
            }
        }
        private void ValidaTMONEDAS_trv_moneda()
        {
            var vEntities = (from LE in LN_TMONEDAS.getListarTMONEDAS(Txttrv_moneda.Text) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                Btntrv_moneda.Tag = vEntities.ToList()[0].mnd_cod.ToString();
                Txttrv_moneda.Text = vEntities.ToList()[0].mnd_cod.ToString();
                Txttrv_moneda_Des.Text = vEntities.ToList()[0].mnd_des.ToString();
            }
            else
            {
                iUT_Telerik.setRadMensaje("No es existe" + ": " + Lbltrv_moneda.Text);
                Btntrv_moneda.Tag = "";
                Txttrv_moneda.Text = "";
                Txttrv_moneda_Des.Text = "";
            }
        }
        private void ValidaTARTICULO_trvd_idarticulo_Detalle()
        {
            var vEntities = (from LE in LN_TARTICULO.getListarTARTICULO(null, iConvertir.aString(this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value)) select LE).ToList();
            if (vEntities.ToList().Count() > 0)
            {
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Ayu].Tag = vEntities.ToList()[0].id_articulo.ToString();
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo].Value = vEntities.ToList()[0].c_articulo.ToString();
                this.AcxDetalles.Rows[AcxDetalles.CurrentRow.Index].Cells[Col_Det_trvd_idarticulo_Des].Value = vEntities.ToList()[0].t_articulo.ToString();
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
        private void GeneraRegistro()
        {
            int? lIntResult = 0;
            int lIntReturn = 0;
            List<ENT_TRVENTAS_CAB> lLisTRVENTAS_CAB = null;
            lLisTRVENTAS_CAB = LN_TRVENTAS_CAB.getListarTRVENTAS_CAB(GlobalesVariables.company, Convert.ToString(Txttrv_periodo.Value.ToString("yyyy")), Convert.ToString(Txttrv_tipo.Text.ToString().Trim()), null);
            if (lLisTRVENTAS_CAB.ToList().Count == 0)
            {
                lIntReturn = 0;
            }
            else
            {
                lIntResult = (from LE in lLisTRVENTAS_CAB where LE.trv_registro.Substring(0, 2) == Convert.ToString(Txttrv_mes.Value.ToString("MM")) select Convert.ToInt32(LE.trv_registro.Substring(2, 6))).ToList().Max();
                if (lIntResult == null)
                    lIntReturn = 0;
                else
                    lIntReturn = Convert.ToInt32(lIntResult);
            }
            Txttrv_registro.Text = ("000000").Substring(0, 6 - (lIntReturn + 1).ToString().Length) + (lIntReturn + 1).ToString();
        }

        private void Totales()
        {
            decimal lDecIgv = Txttrv_pigv.Value;
            decimal lDecTotDescuento = 0;
            decimal lDecTotBase = 0;
            decimal lDecTotIgv = 0;
            decimal lDecTotVenta = 0;
            for (int lIntRow = 0; lIntRow < AcxDetalles.Rows.Count; lIntRow++)
            {
                decimal lDecCantidad = iConvertir.aDecimal(this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_cant].Value);
                decimal lDecPrecio = iConvertir.aDecimal(this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_preun].Value);
                decimal lDecPorDescue = iConvertir.aDecimal(this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_pdcto].Value) / 100;
                decimal lDecTotDescue = lDecPorDescue * (lDecCantidad * lDecPrecio);
                decimal lDecBase = (lDecCantidad * lDecPrecio) - lDecTotDescue;
                decimal lDecValIgv = Txttrv_aigv.Checked == true ? lDecBase * lDecIgv : 0;
                decimal lDecTotal = lDecBase + lDecValIgv;
                this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_dcto].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotDescue);
                this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_vvta].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecBase);
                this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_igv].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecValIgv);
                this.AcxDetalles.Rows[lIntRow].Cells[Col_Det_trvd_tot].Value = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotal);
                lDecTotDescuento += lDecTotDescue;
                lDecTotBase += lDecBase;
                lDecTotIgv += lDecValIgv;
                lDecTotVenta += lDecTotal;
            }
            Txttrv_dctos.Text = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotDescuento);
            Txttrv_vventa.Text = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotBase);
            Txttrv_igv.Text = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotIgv);
            Txttrv_total.Text = string.Format(GlobalesVariables._formatonumerosmillares2decimales, lDecTotVenta);
        }
        #endregion
    }
}

