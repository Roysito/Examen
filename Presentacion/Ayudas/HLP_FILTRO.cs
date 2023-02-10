using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Clases; using myClase = Clases;
using Presentacion.Clases;
using System.Collections;

namespace Presentacion.Ayudas
{
    public partial class HLP_FILTRO : Form
    {
        #region "Variables"
        CapaValidacionesRem.Texto.Cadena vTexto = new CapaValidacionesRem.Texto.Cadena();
        //Validar vValidar = new Validar();
        //Numero vNumero = new Numero();
        CapaUtilitariosRem.DataGridView.UT_DataGridView iDtgData = new CapaUtilitariosRem.DataGridView.UT_DataGridView();
        public List<Clases.clsColumnsGrilla> vClsColumnsGrilla;
        string vStrCreterio = "";
        public string pChRetorno;
        public string pChTitulo = "Ayuda";
        public string vStrTabla = "";
        public string vStrValorInicial = "";
        long vIntItem = 0;
        bool vBlCambiaEstatus = false;
        //////bool vBolCellStateChanged;
        //////int vIntColumna=0;
        //////int vIntFila=0;
        public DataTable vLisEntidades;
        #endregion
        #region"Metodos"
        public HLP_FILTRO()
        {
            InitializeComponent();
        }
        public void Confirmar()
        {
            if (vBlCambiaEstatus == false)
                return;
            pChRetorno = "";
            if (AcxRadControl.Rows.Count == 0)
                return;
            if (AcxRadControl.SelectedRows.Count == 0)
                return;
            for (int lInCol = 0; lInCol <= AcxRadControl.Columns.Count - 1; lInCol++)
            {
                pChRetorno = pChRetorno + vTexto.Trim(AcxRadControl.SelectedRows[0].Cells[lInCol].Value).Trim() + "|";
            }

            this.Close();
            this.Dispose();
        }
        public void CargaGrid()
        {
            iDtgData.setInicializaDataGridView(AcxRadControl, true, true, false, false, false, false, false, false);
            AcxRadControl.AutoGenerateColumns = false;
            AcxRadControl.AutoResizeColumns();
            AcxRadControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            int lIntCount = 0;
            if ((vClsColumnsGrilla != null))
            {
                foreach (var LS in vClsColumnsGrilla)
                {
                    iDtgData.getAñadeColumna(AcxRadControl, LS.NombreBD, LS.NombredeColumna, (LS.EsVisible == false ? 0 : LS.AnchodeColumna), LS.MostrarFiltro, LS.PermiteMoverColumnas, LS.TipodeCampo, LS.TamañodeCampo, LS.NumerodeDecimales, LS.AlineaciondelCampo, LS.ToolTip, LS.ListaDrop);
                    if (lIntCount == 0)
                    {
                        vStrCreterio = "Convert(" + LS.NombreBD + ",System.String) LIKE '%{0}%'";
                    }
                    else
                    {
                        vStrCreterio += " OR Convert(" + LS.NombreBD + ",System.String) LIKE '%{0}%'";
                    }

                    lIntCount += 1;
                }
            }

            //AcxRadControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AcxRadControl.ReadOnly = true;
        }
        public void RecuperaDatos()
        {
            DataTable lDttDAtos = new DataTable("MiDato");
            if (this.Visible)
            {
                this.Cursor = Cursors.WaitCursor;
                if (vBlCambiaEstatus == false)
                    return;
            }
            //List<CapaEntidadNegocio.ENT_TipoDato_Form> lObjEntities = vLisEntidades as List<CapaEntidadNegocio.ENT_TipoDato_Form>;
            lDttDAtos = vLisEntidades;
            AcxRadControl.Rows.Clear();
            vBlCambiaEstatus = false;
            if ((vLisEntidades != null))
            {
                AcxRadControl.DataSource = null;
                AcxRadControl.DataSource = lDttDAtos;
            }

            vBlCambiaEstatus = true;
            vIntItem = 0;
            if (AcxRadControl.Rows.Count > 0)
            {
                AcxRadControl.Rows[0].Selected = true;
                //vIntItem = Convert.ToInt32(AcxRadControl.Rows[0]);
            }

            if (this.Visible)
                this.Cursor = Cursors.Default;
        }
        private void AddSubTotales()
        {
            //AcxRadControl.MasterTemplate.SummaryRowGroupHeaders.Clear();
            //AcxRadControl.MasterTemplate.SummaryRowsTop.Clear();
            //AcxRadControl.MasterTemplate.SummaryRowsBottom.Clear();
            //AcxRadControl.MasterTemplate.AutoExpandGroups = true;
            //GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();
            //item1.Add(new GridViewSummaryItem("Column1", "Cuantos: {0}", GridAggregateFunction.Count));
            //AcxRadControl.MasterTemplate.ShowTotals = true;
            //AcxRadControl.MasterTemplate.SummaryRowGroupHeaders.Add(item1);
            //this.AcxRadControl.MasterTemplate.SummaryRowsTop.Add(item1);
        }
        private bool ValidaIngreso(string pStrCadena)
        {
            string lStrCadena = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int lIntResult = lStrCadena.IndexOf(pStrCadena);
            if (lIntResult < 0)
            {
                return false;
            }

            return true;
        }
        #endregion
        #region "Eventos"
        private void HLP_FILTRO_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void HLP_FILTRO_Activated(object sender, EventArgs e)
        {
            txtCriterio.Focus();
        }
        private void HLP_FILTRO_Load(System.Object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pChRetorno = "";
            CargaGrid();
            vBlCambiaEstatus = true;
            //Clases.clsSistema.AsignaPiePaginaRobbin(StatusBar,this.Name);
            this.Text = pChTitulo;
            if (vStrTabla != "")
            {
                stbPrograma.Text = vStrTabla;
            }

            RecuperaDatos();
            txtCriterio.Text = vStrValorInicial;
            this.Cursor = Cursors.Default;
            txtCriterio.Select(txtCriterio.Text.Length, 0);
        }
        private void AcxRadControl_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Confirmar();
        }
        private void txtCriterio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Confirmar();
            }
        }
        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            //(DataTable)AcxRadControl.DataSource.DefaultView.RowFilter = string.Format(vStrCreterio, txtCriterio.Text);
            (AcxRadControl.DataSource as DataTable).DefaultView.RowFilter = string.Format(vStrCreterio, txtCriterio.Text);
        }
        private void AcxRadControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Confirmar();
            }
        }
        private void Mnu_Confirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        #endregion
    }
}
