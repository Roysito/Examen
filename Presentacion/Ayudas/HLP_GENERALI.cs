using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases; using myClase = Clases;

namespace Presentacion.Ayudas
{
    public partial class HLP_GENERALI : Form
    {
        #region "Variables"

        public CapaUtilitariosRem.DataGridView.UT_DataGridView iDgvData = new CapaUtilitariosRem.DataGridView.UT_DataGridView();
        public List<Presentacion.Clases.clsColumnsGrilla> vClsColumnsGrilla;

        private int Col_MCODAF;
        private int Col_MDESAF;

        private string vStrCreterio = "";

        private int Filtro_MCODAF;
        private int Filtro_MDESAF;

        public string pChRestricciones;
        public string pChRetorno;
        public string pChTitulo = "Ayuda";
        public string pChTabla = "";
        public string vStrValorInicial = "";
        private bool lBlDetener;

        private object vInHITEM=0;
        private bool vBlCambiaEstatus = false;
        private bool vBlCellStateChanged;

        private int vInColumna;
        private int vInFila;

        //public object vLisEntidades;
        public List<object> vLisEntidades = new List<object>();
        //public DataTable vDttDatos = new DataTable();
        #endregion "Variables"
        
        #region "Metodos"
        public void Confirmar()
        {
            if (vBlCambiaEstatus == false)
                return;
            if (vBlCambiaEstatus == false)
                return;
            pChRetorno = "";
            if (AcxRadControl.Rows.Count == 0)
                return;
            if (AcxRadControl.SelectedRows.Count == 0)
                return;
            for (int lInCol = 0; lInCol <= AcxRadControl.Columns.Count - 1; lInCol++)
                pChRetorno = pChRetorno + AcxRadControl.SelectedRows[0].Cells[lInCol].Value + "|";

            this.Close();
        }
        public void CargaGrid()
        {
            iDgvData.setInicializaDataGridView(AcxRadControl, true, false, true, true, true, false, false, false);
            AcxRadControl.AutoGenerateColumns = false;
            AcxRadControl.AutoResizeColumns();
            AcxRadControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            int val = 0;
            if ((vClsColumnsGrilla != null))
            {
                
                foreach (var LS in vClsColumnsGrilla)
                {
                    if (LS.EsVisible == false)
                    {
                        val = 0;
                    }
                    else
                    {
                        val = LS.AnchodeColumna;
                    }
                    Col_MCODAF = iDgvData.getAñadeColumna(AcxRadControl, LS.NombreBD, LS.NombredeColumna, val, LS.MostrarFiltro, LS.PermiteMoverColumnas, LS.TipodeCampo, LS.TamañodeCampo, LS.NumerodeDecimales, LS.AlineaciondelCampo, LS.ToolTip, LS.ListaDrop);
                    AcxRadControl.Columns[Col_MCODAF].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }
            AcxRadControl.ReadOnly = true;

        }
        public void RecuperaDatos()
        {
            //DataTable lDttDAtos = new DataTable("MiDato");
            if (this.Visible)
            {
                this.Cursor = Cursors.WaitCursor;
                if (vBlCambiaEstatus == false)
                    return;
            }
            //lDttDAtos = ConvertToDataTable(vLisEntidades);
            AcxRadControl.Rows.Clear();
            lBlDetener = false;
            vBlCambiaEstatus = false;

            //if ((vLisEntidades != null))
            //{
            //    AcxRadControl.DataSource = null;
            //    AcxRadControl.DataSource = iConvertir.aDataTableDesdeLista(vLisEntidades);
            //}
            if ((vLisEntidades != null))
            {
                AcxRadControl.DataSource = null;
                AcxRadControl.DataSource = vLisEntidades;
            }
            vBlCambiaEstatus = true;
            vInHITEM = 0;
            if (AcxRadControl.Rows.Count > 0)
            {
                //AcxRadControl.Rows.Item[0].IsSelected = true;  
                AcxRadControl.CurrentRow.Selected = true;
                //vInHITEM = AcxRadControl.Rows.Item(0)
                //vInHITEM = AcxRadControl.SelectedCells[0];
                
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
        public bool ValidaIngreso(string pStrCadena)
        {
            string lStrCadena = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int lIntResult = lStrCadena.IndexOf(pStrCadena);
            if (lIntResult < 0)
                return false;
            return true;
        }
        public DataTable ConvertToDataTable<T>(IList<T> list)
        {
            DataTable dt = new DataTable();
            System.Reflection.PropertyInfo[] propiedades = typeof(T).GetProperties();
            foreach (System.Reflection.PropertyInfo p in propiedades)
                // dt.Columns.Add(p.Name, p.PropertyType)
                dt.Columns.Add(p.Name);
            foreach (T item in list)
            {
                DataRow row = dt.NewRow();
                foreach (System.Reflection.PropertyInfo p in propiedades)
                    row[p.Name] = p.GetValue(item, null);
                dt.Rows.Add(row);
            }
            return dt;
        }
        public HLP_GENERALI()
        {
            InitializeComponent();
        }
        #endregion "Metodos"

        #region "Eventos"
        private void HLP_FILTRO_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            pChRetorno = "";
            lBlDetener = false;
            CargaGrid();
            vBlCambiaEstatus = true;

            stbUser.Text = GlobalesVariables._LoginUsuario;// Trim(gChUSUARIO); 
            stbPrograma.Text = this.Name;
            stbCompania.Text = ""; // Traduce("Compañía") & " [ " & vChCompaniaCod & " : " & vChCompaniaNom & " ]  RUC [ " & vChCompaniaRUC & " ]"
            stbServidor.Text = "Servidor: SQL";// + gChQNsys;
            stbSession.Text = "Sesión: 1";//; + gChQTrab;
            //stbPrograma.Text = gChModuloGeneral;


            this.Text = pChTitulo;// "Ayuda";
            if (pChTabla != "")
            {
                stbPrograma.Text = pChTabla;                
            }
            RecuperaDatos();
            this.Cursor = Cursors.Default;
        }
        private void HLP_FILTRO_Activated(object sender, EventArgs e)
        {
            
        }
        private void AcxRadControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Confirmar();
        }
        private void Mnu_Confirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtCriterio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Confirmar();
        }
        private void AcxRadControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Confirmar();
        }
        #endregion "Eventos"
    }
}
