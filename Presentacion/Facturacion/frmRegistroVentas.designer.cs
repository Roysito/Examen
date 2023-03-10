namespace Presentacion.Facturacion
{
    partial class frmRegistroVentas 
    {
        private System.ComponentModel.IContainer components = null;
        /// <summary>;
        /// Clean up any resources being used.;
        /// </summary>;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.Mnu_FiltrosCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_FiltrosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Detener = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Criterios = new System.Windows.Forms.Label();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.Mnu_Filtros = new System.Windows.Forms.MenuStrip();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.AcxControl = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.RadSplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GrpClave = new System.Windows.Forms.GroupBox();
            this.Txttrv_mes = new System.Windows.Forms.DateTimePicker();
            this.Lbltrv_mes = new System.Windows.Forms.Label();
            this.Lbltrv_periodo = new System.Windows.Forms.Label();
            this.Txttrv_registro = new System.Windows.Forms.TextBox();
            this.Txttrv_periodo = new System.Windows.Forms.DateTimePicker();
            this.Lbltrv_registro = new System.Windows.Forms.Label();
            this.Lbltrv_tipo = new System.Windows.Forms.Label();
            this.Txttrv_tipo_Des = new System.Windows.Forms.TextBox();
            this.Txttrv_tipo = new System.Windows.Forms.TextBox();
            this.Btntrv_tipo = new System.Windows.Forms.Button();
            this.Lbltrv_entidad = new System.Windows.Forms.Label();
            this.Txttrv_entidad = new System.Windows.Forms.TextBox();
            this.Btntrv_entidad = new System.Windows.Forms.Button();
            this.Txttrv_entidad_Des = new System.Windows.Forms.TextBox();
            this.Lbltrv_idvendedor = new System.Windows.Forms.Label();
            this.Txttrv_idvendedor = new System.Windows.Forms.TextBox();
            this.Btntrv_idvendedor = new System.Windows.Forms.Button();
            this.Txttrv_idvendedor_Des = new System.Windows.Forms.TextBox();
            this.Lbltrv_idformapago = new System.Windows.Forms.Label();
            this.Txttrv_idformapago = new System.Windows.Forms.TextBox();
            this.Btntrv_idformapago = new System.Windows.Forms.Button();
            this.Txttrv_idformapago_Des = new System.Windows.Forms.TextBox();
            this.Lbltrv_tdoc = new System.Windows.Forms.Label();
            this.Txttrv_tdoc = new System.Windows.Forms.TextBox();
            this.Btntrv_tdoc = new System.Windows.Forms.Button();
            this.Txttrv_tdoc_Des = new System.Windows.Forms.TextBox();
            this.Lbltrv_sdoc = new System.Windows.Forms.Label();
            this.Txttrv_sdoc = new System.Windows.Forms.TextBox();
            this.Btntrv_sdoc = new System.Windows.Forms.Button();
            this.Txttrv_ndoc = new System.Windows.Forms.TextBox();
            this.Lbltrv_femision = new System.Windows.Forms.Label();
            this.Txttrv_femision = new System.Windows.Forms.DateTimePicker();
            this.Lbltrv_fvencimiento = new System.Windows.Forms.Label();
            this.Txttrv_fvencimiento = new System.Windows.Forms.DateTimePicker();
            this.Lbltrv_moneda = new System.Windows.Forms.Label();
            this.Txttrv_moneda = new System.Windows.Forms.TextBox();
            this.Btntrv_moneda = new System.Windows.Forms.Button();
            this.Txttrv_moneda_Des = new System.Windows.Forms.TextBox();
            this.Lbltrv_tcambio = new System.Windows.Forms.Label();
            this.Txttrv_tcambio = new System.Windows.Forms.NumericUpDown();
            this.Lbltrv_aigv = new System.Windows.Forms.Label();
            this.Txttrv_aigv = new System.Windows.Forms.CheckBox();
            this.Lbltrv_flag = new System.Windows.Forms.Label();
            this.Txttrv_flag = new System.Windows.Forms.CheckBox();
            this.ToolDetalles = new System.Windows.Forms.ToolStrip();
            this.Tlb_D_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_D_Elimina = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_D_Duplica = new System.Windows.Forms.ToolStripButton();
            this.Tol_Moneda = new System.Windows.Forms.ToolStripLabel();
            this.AcxDetalles = new System.Windows.Forms.DataGridView();
            this.Txttrv_vventa = new System.Windows.Forms.TextBox();
            this.Lbltrv_pigv = new System.Windows.Forms.Label();
            this.Txttrv_total = new System.Windows.Forms.TextBox();
            this.Txttrv_pigv = new System.Windows.Forms.NumericUpDown();
            this.Lbltrv_total = new System.Windows.Forms.Label();
            this.Lbltrv_dctos = new System.Windows.Forms.Label();
            this.Txttrv_igv = new System.Windows.Forms.TextBox();
            this.Txttrv_dctos = new System.Windows.Forms.TextBox();
            this.Lbltrv_igv = new System.Windows.Forms.Label();
            this.Lbltrv_vventa = new System.Windows.Forms.Label();
            this.Mnu_Principal = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Adicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Duplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Confirmar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Recargar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Criterios_Mostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Criterios_Ocultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Correo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOcultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tlb_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.Tlb_Modificar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_Guardar = new System.Windows.Forms.ToolStripButton();
            this.Tlb_Deshacer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_Duplicar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlb_Consultar = new System.Windows.Forms.ToolStripButton();
            this.Tlb_Cerrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MiToolBar = new System.Windows.Forms.ToolStrip();
            this.PanelFiltros.SuspendLayout();
            this.Mnu_Filtros.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcxControl)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainer2)).BeginInit();
            this.RadSplitContainer2.Panel1.SuspendLayout();
            this.RadSplitContainer2.Panel2.SuspendLayout();
            this.RadSplitContainer2.SuspendLayout();
            this.GrpClave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txttrv_tcambio)).BeginInit();
            this.ToolDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcxDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttrv_pigv)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.MiToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selecci?n de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(648, 24);
            this.miniToolStrip.TabIndex = 39;
            // 
            // Mnu_FiltrosCerrar
            // 
            this.Mnu_FiltrosCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_FiltrosCerrar.Image = global::Presentacion.Properties.Resources.Salir;
            this.Mnu_FiltrosCerrar.Name = "Mnu_FiltrosCerrar";
            this.Mnu_FiltrosCerrar.Size = new System.Drawing.Size(67, 20);
            this.Mnu_FiltrosCerrar.Text = "Cerrar";
            this.Mnu_FiltrosCerrar.Click += new System.EventHandler(this.Mnu_FiltrosCerrar_Click);
            // 
            // Mnu_FiltrosBuscar
            // 
            this.Mnu_FiltrosBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_FiltrosBuscar.Image = global::Presentacion.Properties.Resources.Buscar;
            this.Mnu_FiltrosBuscar.Name = "Mnu_FiltrosBuscar";
            this.Mnu_FiltrosBuscar.Size = new System.Drawing.Size(70, 20);
            this.Mnu_FiltrosBuscar.Text = "Buscar";
            this.Mnu_FiltrosBuscar.Click += new System.EventHandler(this.Mnu_FiltrosBuscar_Click);
            // 
            // Mnu_Detener
            // 
            this.Mnu_Detener.Image = global::Presentacion.Properties.Resources.Parar;
            this.Mnu_Detener.Name = "Mnu_Detener";
            this.Mnu_Detener.Size = new System.Drawing.Size(131, 20);
            this.Mnu_Detener.Text = "Detener B?squeda";
            this.Mnu_Detener.Visible = false;
            this.Mnu_Detener.Click += new System.EventHandler(this.Mnu_Detener_Click);
            // 
            // Lbl_Criterios
            // 
            this.Lbl_Criterios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Criterios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Lbl_Criterios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Criterios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Criterios.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Criterios.Location = new System.Drawing.Point(-1, 123);
            this.Lbl_Criterios.Name = "Lbl_Criterios";
            this.Lbl_Criterios.Size = new System.Drawing.Size(651, 20);
            this.Lbl_Criterios.TabIndex = 36;
            this.Lbl_Criterios.Text = "Criterios de Selecci?n";
            this.Lbl_Criterios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Criterios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Criterios_MouseDown);
            this.Lbl_Criterios.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lbl_Criterios_MouseUp);
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.BackColor = System.Drawing.SystemColors.Control;
            this.PanelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFiltros.Controls.Add(this.Lbl_Criterios);
            this.PanelFiltros.Controls.Add(this.Mnu_Filtros);
            this.PanelFiltros.Location = new System.Drawing.Point(794, 277);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Size = new System.Drawing.Size(650, 145);
            this.PanelFiltros.TabIndex = 39;
            this.PanelFiltros.Visible = false;
            // 
            // Mnu_Filtros
            // 
            this.Mnu_Filtros.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Mnu_Filtros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_FiltrosCerrar,
            this.Mnu_FiltrosBuscar,
            this.Mnu_Detener});
            this.Mnu_Filtros.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Filtros.Name = "Mnu_Filtros";
            this.Mnu_Filtros.Size = new System.Drawing.Size(648, 24);
            this.Mnu_Filtros.TabIndex = 39;
            this.Mnu_Filtros.Text = "MenuStrip2";
            this.Mnu_Filtros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mnu_Filtros_MouseDown);
            this.Mnu_Filtros.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mnu_Filtros_MouseUp);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(0, 52);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(944, 466);
            this.TabControl1.TabIndex = 38;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.AcxControl);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(936, 651);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Informaci?n del General";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // AcxControl
            // 
            this.AcxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AcxControl.Location = new System.Drawing.Point(0, 3);
            this.AcxControl.Name = "AcxControl";
            this.AcxControl.Size = new System.Drawing.Size(933, 645);
            this.AcxControl.TabIndex = 38;
            this.AcxControl.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.AcxControl_CellBeginEdit);
            this.AcxControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxControl_CellContentClick);
            this.AcxControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxControl_CellDoubleClick);
            this.AcxControl.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxControl_CellEndEdit);
            this.AcxControl.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.AcxControl_EditingControlShowing);
            this.AcxControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcxControl_KeyDown);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.RadSplitContainer2);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(936, 438);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Informaci?n del Registro(Ficha de Datos)";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // RadSplitContainer2
            // 
            this.RadSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadSplitContainer2.Location = new System.Drawing.Point(3, 3);
            this.RadSplitContainer2.Name = "RadSplitContainer2";
            this.RadSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RadSplitContainer2.Panel1
            // 
            this.RadSplitContainer2.Panel1.Controls.Add(this.GrpClave);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_entidad);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_entidad);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_entidad);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_entidad_Des);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_idvendedor);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_idvendedor);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_idvendedor);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_idvendedor_Des);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_idformapago);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_idformapago);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_idformapago);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_idformapago_Des);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_tdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_tdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_tdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_tdoc_Des);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_sdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_sdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_sdoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_ndoc);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_femision);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_femision);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_fvencimiento);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_fvencimiento);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_moneda);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_moneda);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Btntrv_moneda);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_moneda_Des);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_tcambio);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_tcambio);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_aigv);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_aigv);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Lbltrv_flag);
            this.RadSplitContainer2.Panel1.Controls.Add(this.Txttrv_flag);
            // 
            // RadSplitContainer2.Panel2
            // 
            this.RadSplitContainer2.Panel2.Controls.Add(this.ToolDetalles);
            this.RadSplitContainer2.Panel2.Controls.Add(this.AcxDetalles);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Txttrv_vventa);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Lbltrv_pigv);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Txttrv_total);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Txttrv_pigv);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Lbltrv_total);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Lbltrv_dctos);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Txttrv_igv);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Txttrv_dctos);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Lbltrv_igv);
            this.RadSplitContainer2.Panel2.Controls.Add(this.Lbltrv_vventa);
            this.RadSplitContainer2.Size = new System.Drawing.Size(930, 432);
            this.RadSplitContainer2.SplitterDistance = 218;
            this.RadSplitContainer2.TabIndex = 68;
            this.RadSplitContainer2.TabStop = false;
            // 
            // GrpClave
            // 
            this.GrpClave.Controls.Add(this.Txttrv_mes);
            this.GrpClave.Controls.Add(this.Lbltrv_mes);
            this.GrpClave.Controls.Add(this.Lbltrv_periodo);
            this.GrpClave.Controls.Add(this.Txttrv_registro);
            this.GrpClave.Controls.Add(this.Txttrv_periodo);
            this.GrpClave.Controls.Add(this.Lbltrv_registro);
            this.GrpClave.Controls.Add(this.Lbltrv_tipo);
            this.GrpClave.Controls.Add(this.Txttrv_tipo_Des);
            this.GrpClave.Controls.Add(this.Txttrv_tipo);
            this.GrpClave.Controls.Add(this.Btntrv_tipo);
            this.GrpClave.Location = new System.Drawing.Point(5, 13);
            this.GrpClave.Name = "GrpClave";
            this.GrpClave.Size = new System.Drawing.Size(913, 60);
            this.GrpClave.TabIndex = 4;
            this.GrpClave.TabStop = false;
            // 
            // Txttrv_mes
            // 
            this.Txttrv_mes.CustomFormat = "MM";
            this.Txttrv_mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Txttrv_mes.Location = new System.Drawing.Point(636, 19);
            this.Txttrv_mes.Name = "Txttrv_mes";
            this.Txttrv_mes.Size = new System.Drawing.Size(44, 23);
            this.Txttrv_mes.TabIndex = 5;
            this.Txttrv_mes.ValueChanged += new System.EventHandler(this.Txttrv_mes_ValueChanged);
            // 
            // Lbltrv_mes
            // 
            this.Lbltrv_mes.AutoSize = true;
            this.Lbltrv_mes.Location = new System.Drawing.Point(598, 23);
            this.Lbltrv_mes.Name = "Lbltrv_mes";
            this.Lbltrv_mes.Size = new System.Drawing.Size(35, 15);
            this.Lbltrv_mes.TabIndex = 4;
            this.Lbltrv_mes.Text = "Mes: ";
            // 
            // Lbltrv_periodo
            // 
            this.Lbltrv_periodo.AutoSize = true;
            this.Lbltrv_periodo.Location = new System.Drawing.Point(15, 19);
            this.Lbltrv_periodo.Name = "Lbltrv_periodo";
            this.Lbltrv_periodo.Size = new System.Drawing.Size(54, 15);
            this.Lbltrv_periodo.TabIndex = 0;
            this.Lbltrv_periodo.Text = "Periodo: ";
            // 
            // Txttrv_registro
            // 
            this.Txttrv_registro.Location = new System.Drawing.Point(811, 20);
            this.Txttrv_registro.MaxLength = 8;
            this.Txttrv_registro.Name = "Txttrv_registro";
            this.Txttrv_registro.ReadOnly = true;
            this.Txttrv_registro.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_registro.TabIndex = 1;
            // 
            // Txttrv_periodo
            // 
            this.Txttrv_periodo.CustomFormat = "yyyy";
            this.Txttrv_periodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Txttrv_periodo.Location = new System.Drawing.Point(75, 16);
            this.Txttrv_periodo.Name = "Txttrv_periodo";
            this.Txttrv_periodo.Size = new System.Drawing.Size(58, 23);
            this.Txttrv_periodo.TabIndex = 1;
            this.Txttrv_periodo.ValueChanged += new System.EventHandler(this.Txttrv_periodo_ValueChanged);
            // 
            // Lbltrv_registro
            // 
            this.Lbltrv_registro.AutoSize = true;
            this.Lbltrv_registro.Location = new System.Drawing.Point(702, 24);
            this.Lbltrv_registro.Name = "Lbltrv_registro";
            this.Lbltrv_registro.Size = new System.Drawing.Size(103, 15);
            this.Lbltrv_registro.TabIndex = 0;
            this.Lbltrv_registro.Text = "N?mero Registro: ";
            // 
            // Lbltrv_tipo
            // 
            this.Lbltrv_tipo.AutoSize = true;
            this.Lbltrv_tipo.Location = new System.Drawing.Point(139, 22);
            this.Lbltrv_tipo.Name = "Lbltrv_tipo";
            this.Lbltrv_tipo.Size = new System.Drawing.Size(72, 15);
            this.Lbltrv_tipo.TabIndex = 0;
            this.Lbltrv_tipo.Text = "Nivel Venta: ";
            // 
            // Txttrv_tipo_Des
            // 
            this.Txttrv_tipo_Des.Location = new System.Drawing.Point(310, 18);
            this.Txttrv_tipo_Des.Name = "Txttrv_tipo_Des";
            this.Txttrv_tipo_Des.ReadOnly = true;
            this.Txttrv_tipo_Des.Size = new System.Drawing.Size(282, 23);
            this.Txttrv_tipo_Des.TabIndex = 2;
            // 
            // Txttrv_tipo
            // 
            this.Txttrv_tipo.Location = new System.Drawing.Point(219, 18);
            this.Txttrv_tipo.MaxLength = 3;
            this.Txttrv_tipo.Name = "Txttrv_tipo";
            this.Txttrv_tipo.Size = new System.Drawing.Size(51, 23);
            this.Txttrv_tipo.TabIndex = 1;
            this.Txttrv_tipo.GotFocus += new System.EventHandler(this.Txttrv_tipo_GotFocus);
            this.Txttrv_tipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_tipo_KeyDown);
            this.Txttrv_tipo.LostFocus += new System.EventHandler(this.Txttrv_tipo_LostFocus);
            // 
            // Btntrv_tipo
            // 
            this.Btntrv_tipo.Location = new System.Drawing.Point(270, 18);
            this.Btntrv_tipo.Name = "Btntrv_tipo";
            this.Btntrv_tipo.Size = new System.Drawing.Size(39, 24);
            this.Btntrv_tipo.TabIndex = 3;
            this.Btntrv_tipo.Text = "...";
            this.Btntrv_tipo.UseVisualStyleBackColor = true;
            this.Btntrv_tipo.Click += new System.EventHandler(this.Btntrv_tipo_Click);
            // 
            // Lbltrv_entidad
            // 
            this.Lbltrv_entidad.AutoSize = true;
            this.Lbltrv_entidad.Location = new System.Drawing.Point(73, 90);
            this.Lbltrv_entidad.Name = "Lbltrv_entidad";
            this.Lbltrv_entidad.Size = new System.Drawing.Size(60, 15);
            this.Lbltrv_entidad.TabIndex = 0;
            this.Lbltrv_entidad.Text = "Id Ctacte: ";
            // 
            // Txttrv_entidad
            // 
            this.Txttrv_entidad.Location = new System.Drawing.Point(139, 87);
            this.Txttrv_entidad.MaxLength = 10;
            this.Txttrv_entidad.Name = "Txttrv_entidad";
            this.Txttrv_entidad.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_entidad.TabIndex = 1;
            this.Txttrv_entidad.GotFocus += new System.EventHandler(this.Txttrv_entidad_GotFocus);
            this.Txttrv_entidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_entidad_KeyDown);
            this.Txttrv_entidad.LostFocus += new System.EventHandler(this.Txttrv_entidad_LostFocus);
            // 
            // Btntrv_entidad
            // 
            this.Btntrv_entidad.Location = new System.Drawing.Point(239, 87);
            this.Btntrv_entidad.Name = "Btntrv_entidad";
            this.Btntrv_entidad.Size = new System.Drawing.Size(39, 23);
            this.Btntrv_entidad.TabIndex = 3;
            this.Btntrv_entidad.Text = "...";
            this.Btntrv_entidad.UseVisualStyleBackColor = true;
            this.Btntrv_entidad.Click += new System.EventHandler(this.Btntrv_entidad_Click);
            // 
            // Txttrv_entidad_Des
            // 
            this.Txttrv_entidad_Des.Location = new System.Drawing.Point(278, 87);
            this.Txttrv_entidad_Des.Name = "Txttrv_entidad_Des";
            this.Txttrv_entidad_Des.ReadOnly = true;
            this.Txttrv_entidad_Des.Size = new System.Drawing.Size(377, 23);
            this.Txttrv_entidad_Des.TabIndex = 2;
            // 
            // Lbltrv_idvendedor
            // 
            this.Lbltrv_idvendedor.AutoSize = true;
            this.Lbltrv_idvendedor.Location = new System.Drawing.Point(57, 115);
            this.Lbltrv_idvendedor.Name = "Lbltrv_idvendedor";
            this.Lbltrv_idvendedor.Size = new System.Drawing.Size(76, 15);
            this.Lbltrv_idvendedor.TabIndex = 0;
            this.Lbltrv_idvendedor.Text = "Id Vendedor: ";
            // 
            // Txttrv_idvendedor
            // 
            this.Txttrv_idvendedor.Location = new System.Drawing.Point(139, 112);
            this.Txttrv_idvendedor.MaxLength = 10;
            this.Txttrv_idvendedor.Name = "Txttrv_idvendedor";
            this.Txttrv_idvendedor.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_idvendedor.TabIndex = 1;
            this.Txttrv_idvendedor.GotFocus += new System.EventHandler(this.Txttrv_idvendedor_GotFocus);
            this.Txttrv_idvendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_idvendedor_KeyDown);
            this.Txttrv_idvendedor.LostFocus += new System.EventHandler(this.Txttrv_idvendedor_LostFocus);
            // 
            // Btntrv_idvendedor
            // 
            this.Btntrv_idvendedor.Location = new System.Drawing.Point(239, 110);
            this.Btntrv_idvendedor.Name = "Btntrv_idvendedor";
            this.Btntrv_idvendedor.Size = new System.Drawing.Size(39, 26);
            this.Btntrv_idvendedor.TabIndex = 3;
            this.Btntrv_idvendedor.Text = "...";
            this.Btntrv_idvendedor.UseVisualStyleBackColor = true;
            this.Btntrv_idvendedor.Click += new System.EventHandler(this.Btntrv_idvendedor_Click);
            // 
            // Txttrv_idvendedor_Des
            // 
            this.Txttrv_idvendedor_Des.Location = new System.Drawing.Point(278, 112);
            this.Txttrv_idvendedor_Des.Name = "Txttrv_idvendedor_Des";
            this.Txttrv_idvendedor_Des.ReadOnly = true;
            this.Txttrv_idvendedor_Des.Size = new System.Drawing.Size(377, 23);
            this.Txttrv_idvendedor_Des.TabIndex = 2;
            // 
            // Lbltrv_idformapago
            // 
            this.Lbltrv_idformapago.AutoSize = true;
            this.Lbltrv_idformapago.Location = new System.Drawing.Point(43, 140);
            this.Lbltrv_idformapago.Name = "Lbltrv_idformapago";
            this.Lbltrv_idformapago.Size = new System.Drawing.Size(90, 15);
            this.Lbltrv_idformapago.TabIndex = 0;
            this.Lbltrv_idformapago.Text = "Id Forma Pago: ";
            // 
            // Txttrv_idformapago
            // 
            this.Txttrv_idformapago.Location = new System.Drawing.Point(139, 137);
            this.Txttrv_idformapago.MaxLength = 10;
            this.Txttrv_idformapago.Name = "Txttrv_idformapago";
            this.Txttrv_idformapago.Size = new System.Drawing.Size(41, 23);
            this.Txttrv_idformapago.TabIndex = 1;
            this.Txttrv_idformapago.GotFocus += new System.EventHandler(this.Txttrv_idformapago_GotFocus);
            this.Txttrv_idformapago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_idformapago_KeyDown);
            this.Txttrv_idformapago.LostFocus += new System.EventHandler(this.Txttrv_idformapago_LostFocus);
            // 
            // Btntrv_idformapago
            // 
            this.Btntrv_idformapago.Location = new System.Drawing.Point(180, 137);
            this.Btntrv_idformapago.Name = "Btntrv_idformapago";
            this.Btntrv_idformapago.Size = new System.Drawing.Size(39, 23);
            this.Btntrv_idformapago.TabIndex = 3;
            this.Btntrv_idformapago.Text = "...";
            this.Btntrv_idformapago.UseVisualStyleBackColor = true;
            this.Btntrv_idformapago.Click += new System.EventHandler(this.Btntrv_idformapago_Click);
            // 
            // Txttrv_idformapago_Des
            // 
            this.Txttrv_idformapago_Des.Location = new System.Drawing.Point(219, 137);
            this.Txttrv_idformapago_Des.Name = "Txttrv_idformapago_Des";
            this.Txttrv_idformapago_Des.ReadOnly = true;
            this.Txttrv_idformapago_Des.Size = new System.Drawing.Size(215, 23);
            this.Txttrv_idformapago_Des.TabIndex = 2;
            // 
            // Lbltrv_tdoc
            // 
            this.Lbltrv_tdoc.AutoSize = true;
            this.Lbltrv_tdoc.Location = new System.Drawing.Point(15, 166);
            this.Lbltrv_tdoc.Name = "Lbltrv_tdoc";
            this.Lbltrv_tdoc.Size = new System.Drawing.Size(118, 15);
            this.Lbltrv_tdoc.TabIndex = 0;
            this.Lbltrv_tdoc.Text = "C?digo Documento: ";
            // 
            // Txttrv_tdoc
            // 
            this.Txttrv_tdoc.Location = new System.Drawing.Point(139, 163);
            this.Txttrv_tdoc.MaxLength = 3;
            this.Txttrv_tdoc.Name = "Txttrv_tdoc";
            this.Txttrv_tdoc.Size = new System.Drawing.Size(41, 23);
            this.Txttrv_tdoc.TabIndex = 1;
            this.Txttrv_tdoc.GotFocus += new System.EventHandler(this.Txttrv_tdoc_GotFocus);
            this.Txttrv_tdoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_tdoc_KeyDown);
            this.Txttrv_tdoc.LostFocus += new System.EventHandler(this.Txttrv_tdoc_LostFocus);
            // 
            // Btntrv_tdoc
            // 
            this.Btntrv_tdoc.Location = new System.Drawing.Point(180, 161);
            this.Btntrv_tdoc.Name = "Btntrv_tdoc";
            this.Btntrv_tdoc.Size = new System.Drawing.Size(39, 25);
            this.Btntrv_tdoc.TabIndex = 3;
            this.Btntrv_tdoc.Text = "...";
            this.Btntrv_tdoc.UseVisualStyleBackColor = true;
            this.Btntrv_tdoc.Click += new System.EventHandler(this.Btntrv_tdoc_Click);
            // 
            // Txttrv_tdoc_Des
            // 
            this.Txttrv_tdoc_Des.Location = new System.Drawing.Point(219, 162);
            this.Txttrv_tdoc_Des.Name = "Txttrv_tdoc_Des";
            this.Txttrv_tdoc_Des.ReadOnly = true;
            this.Txttrv_tdoc_Des.Size = new System.Drawing.Size(156, 23);
            this.Txttrv_tdoc_Des.TabIndex = 2;
            // 
            // Lbltrv_sdoc
            // 
            this.Lbltrv_sdoc.AutoSize = true;
            this.Lbltrv_sdoc.Location = new System.Drawing.Point(383, 165);
            this.Lbltrv_sdoc.Name = "Lbltrv_sdoc";
            this.Lbltrv_sdoc.Size = new System.Drawing.Size(104, 15);
            this.Lbltrv_sdoc.TabIndex = 0;
            this.Lbltrv_sdoc.Text = "Serie Documento: ";
            // 
            // Txttrv_sdoc
            // 
            this.Txttrv_sdoc.Location = new System.Drawing.Point(493, 161);
            this.Txttrv_sdoc.MaxLength = 4;
            this.Txttrv_sdoc.Name = "Txttrv_sdoc";
            this.Txttrv_sdoc.Size = new System.Drawing.Size(52, 23);
            this.Txttrv_sdoc.TabIndex = 1;
            this.Txttrv_sdoc.GotFocus += new System.EventHandler(this.Txttrv_sdoc_GotFocus);
            this.Txttrv_sdoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_sdoc_KeyDown);
            this.Txttrv_sdoc.LostFocus += new System.EventHandler(this.Txttrv_sdoc_LostFocus);
            // 
            // Btntrv_sdoc
            // 
            this.Btntrv_sdoc.Location = new System.Drawing.Point(545, 161);
            this.Btntrv_sdoc.Name = "Btntrv_sdoc";
            this.Btntrv_sdoc.Size = new System.Drawing.Size(39, 24);
            this.Btntrv_sdoc.TabIndex = 3;
            this.Btntrv_sdoc.Text = "...";
            this.Btntrv_sdoc.UseVisualStyleBackColor = true;
            this.Btntrv_sdoc.Click += new System.EventHandler(this.Btntrv_sdoc_Click);
            // 
            // Txttrv_ndoc
            // 
            this.Txttrv_ndoc.Location = new System.Drawing.Point(585, 161);
            this.Txttrv_ndoc.MaxLength = 10;
            this.Txttrv_ndoc.Name = "Txttrv_ndoc";
            this.Txttrv_ndoc.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_ndoc.TabIndex = 1;
            // 
            // Lbltrv_femision
            // 
            this.Lbltrv_femision.AutoSize = true;
            this.Lbltrv_femision.Location = new System.Drawing.Point(440, 140);
            this.Lbltrv_femision.Name = "Lbltrv_femision";
            this.Lbltrv_femision.Size = new System.Drawing.Size(89, 15);
            this.Lbltrv_femision.TabIndex = 0;
            this.Lbltrv_femision.Text = "Fecha Emisi?n: ";
            // 
            // Txttrv_femision
            // 
            this.Txttrv_femision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txttrv_femision.Location = new System.Drawing.Point(535, 137);
            this.Txttrv_femision.Name = "Txttrv_femision";
            this.Txttrv_femision.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_femision.TabIndex = 1;
            // 
            // Lbltrv_fvencimiento
            // 
            this.Lbltrv_fvencimiento.AutoSize = true;
            this.Lbltrv_fvencimiento.Location = new System.Drawing.Point(641, 141);
            this.Lbltrv_fvencimiento.Name = "Lbltrv_fvencimiento";
            this.Lbltrv_fvencimiento.Size = new System.Drawing.Size(113, 15);
            this.Lbltrv_fvencimiento.TabIndex = 0;
            this.Lbltrv_fvencimiento.Text = "Fecha Vencimiento: ";
            // 
            // Txttrv_fvencimiento
            // 
            this.Txttrv_fvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txttrv_fvencimiento.Location = new System.Drawing.Point(760, 137);
            this.Txttrv_fvencimiento.Name = "Txttrv_fvencimiento";
            this.Txttrv_fvencimiento.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_fvencimiento.TabIndex = 1;
            // 
            // Lbltrv_moneda
            // 
            this.Lbltrv_moneda.AutoSize = true;
            this.Lbltrv_moneda.Location = new System.Drawing.Point(34, 190);
            this.Lbltrv_moneda.Name = "Lbltrv_moneda";
            this.Lbltrv_moneda.Size = new System.Drawing.Size(99, 15);
            this.Lbltrv_moneda.TabIndex = 0;
            this.Lbltrv_moneda.Text = "C?digo Moneda: ";
            // 
            // Txttrv_moneda
            // 
            this.Txttrv_moneda.Location = new System.Drawing.Point(139, 187);
            this.Txttrv_moneda.MaxLength = 2;
            this.Txttrv_moneda.Name = "Txttrv_moneda";
            this.Txttrv_moneda.Size = new System.Drawing.Size(41, 23);
            this.Txttrv_moneda.TabIndex = 1;
            this.Txttrv_moneda.GotFocus += new System.EventHandler(this.Txttrv_moneda_GotFocus);
            this.Txttrv_moneda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttrv_moneda_KeyDown);
            this.Txttrv_moneda.LostFocus += new System.EventHandler(this.Txttrv_moneda_LostFocus);
            // 
            // Btntrv_moneda
            // 
            this.Btntrv_moneda.Location = new System.Drawing.Point(180, 185);
            this.Btntrv_moneda.Name = "Btntrv_moneda";
            this.Btntrv_moneda.Size = new System.Drawing.Size(39, 26);
            this.Btntrv_moneda.TabIndex = 3;
            this.Btntrv_moneda.Text = "...";
            this.Btntrv_moneda.UseVisualStyleBackColor = true;
            this.Btntrv_moneda.Click += new System.EventHandler(this.Btntrv_moneda_Click);
            // 
            // Txttrv_moneda_Des
            // 
            this.Txttrv_moneda_Des.Location = new System.Drawing.Point(219, 187);
            this.Txttrv_moneda_Des.Name = "Txttrv_moneda_Des";
            this.Txttrv_moneda_Des.ReadOnly = true;
            this.Txttrv_moneda_Des.Size = new System.Drawing.Size(156, 23);
            this.Txttrv_moneda_Des.TabIndex = 2;
            // 
            // Lbltrv_tcambio
            // 
            this.Lbltrv_tcambio.AutoSize = true;
            this.Lbltrv_tcambio.Location = new System.Drawing.Point(388, 191);
            this.Lbltrv_tcambio.Name = "Lbltrv_tcambio";
            this.Lbltrv_tcambio.Size = new System.Drawing.Size(97, 15);
            this.Lbltrv_tcambio.TabIndex = 0;
            this.Lbltrv_tcambio.Text = "Tipo de Cambio: ";
            // 
            // Txttrv_tcambio
            // 
            this.Txttrv_tcambio.DecimalPlaces = 3;
            this.Txttrv_tcambio.Location = new System.Drawing.Point(491, 186);
            this.Txttrv_tcambio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Txttrv_tcambio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Txttrv_tcambio.Name = "Txttrv_tcambio";
            this.Txttrv_tcambio.Size = new System.Drawing.Size(73, 23);
            this.Txttrv_tcambio.TabIndex = 1;
            this.Txttrv_tcambio.Value = new decimal(new int[] {
            3789,
            0,
            0,
            196608});
            this.Txttrv_tcambio.ValueChanged += new System.EventHandler(this.Txttrv_tcambio_ValueChanged);
            // 
            // Lbltrv_aigv
            // 
            this.Lbltrv_aigv.AutoSize = true;
            this.Lbltrv_aigv.Location = new System.Drawing.Point(671, 91);
            this.Lbltrv_aigv.Name = "Lbltrv_aigv";
            this.Lbltrv_aigv.Size = new System.Drawing.Size(72, 15);
            this.Lbltrv_aigv.TabIndex = 0;
            this.Lbltrv_aigv.Text = "Afeco a Igv: ";
            // 
            // Txttrv_aigv
            // 
            this.Txttrv_aigv.Location = new System.Drawing.Point(749, 87);
            this.Txttrv_aigv.Name = "Txttrv_aigv";
            this.Txttrv_aigv.Size = new System.Drawing.Size(18, 23);
            this.Txttrv_aigv.TabIndex = 1;
            this.Txttrv_aigv.CheckedChanged += new System.EventHandler(this.Txttrv_aigv_CheckedChanged);
            // 
            // Lbltrv_flag
            // 
            this.Lbltrv_flag.AutoSize = true;
            this.Lbltrv_flag.Location = new System.Drawing.Point(826, 91);
            this.Lbltrv_flag.Name = "Lbltrv_flag";
            this.Lbltrv_flag.Size = new System.Drawing.Size(47, 15);
            this.Lbltrv_flag.TabIndex = 0;
            this.Lbltrv_flag.Text = "Activo: ";
            // 
            // Txttrv_flag
            // 
            this.Txttrv_flag.Location = new System.Drawing.Point(879, 87);
            this.Txttrv_flag.Name = "Txttrv_flag";
            this.Txttrv_flag.Size = new System.Drawing.Size(24, 23);
            this.Txttrv_flag.TabIndex = 1;
            // 
            // ToolDetalles
            // 
            this.ToolDetalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tlb_D_Nuevo,
            this.ToolStripSeparator5,
            this.Tlb_D_Elimina,
            this.ToolStripSeparator7,
            this.Tlb_D_Duplica,
            this.Tol_Moneda});
            this.ToolDetalles.Location = new System.Drawing.Point(0, 0);
            this.ToolDetalles.Name = "ToolDetalles";
            this.ToolDetalles.Size = new System.Drawing.Size(930, 25);
            this.ToolDetalles.TabIndex = 67;
            this.ToolDetalles.Text = "ToolStrip2";
            // 
            // Tlb_D_Nuevo
            // 
            this.Tlb_D_Nuevo.Image = global::Presentacion.Properties.Resources.AdicionarItems;
            this.Tlb_D_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_D_Nuevo.Name = "Tlb_D_Nuevo";
            this.Tlb_D_Nuevo.Size = new System.Drawing.Size(66, 22);
            this.Tlb_D_Nuevo.Text = "Insertar";
            this.Tlb_D_Nuevo.Click += new System.EventHandler(this.Tlb_D_Nuevo_Click_1);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Tlb_D_Elimina
            // 
            this.Tlb_D_Elimina.Image = global::Presentacion.Properties.Resources.EliminarItems;
            this.Tlb_D_Elimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_D_Elimina.Name = "Tlb_D_Elimina";
            this.Tlb_D_Elimina.Size = new System.Drawing.Size(70, 22);
            this.Tlb_D_Elimina.Text = "Eliminar";
            this.Tlb_D_Elimina.Click += new System.EventHandler(this.Tlb_D_Elimina_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // Tlb_D_Duplica
            // 
            this.Tlb_D_Duplica.Image = global::Presentacion.Properties.Resources.CopiarItems;
            this.Tlb_D_Duplica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_D_Duplica.Name = "Tlb_D_Duplica";
            this.Tlb_D_Duplica.Size = new System.Drawing.Size(71, 22);
            this.Tlb_D_Duplica.Text = "Duplicar";
            this.Tlb_D_Duplica.Click += new System.EventHandler(this.Tlb_D_Duplica_Click_1);
            // 
            // Tol_Moneda
            // 
            this.Tol_Moneda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tol_Moneda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tol_Moneda.ForeColor = System.Drawing.Color.Green;
            this.Tol_Moneda.Name = "Tol_Moneda";
            this.Tol_Moneda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tol_Moneda.Size = new System.Drawing.Size(0, 22);
            // 
            // AcxDetalles
            // 
            this.AcxDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AcxDetalles.Location = new System.Drawing.Point(3, 28);
            this.AcxDetalles.Name = "AcxDetalles";
            this.AcxDetalles.Size = new System.Drawing.Size(927, 140);
            this.AcxDetalles.TabIndex = 66;
            this.AcxDetalles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.AcxDetalles_CellBeginEdit);
            this.AcxDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxDetalles_CellContentClick);
            this.AcxDetalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxDetalles_CellDoubleClick);
            this.AcxDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AcxDetalles_CellEndEdit);
            this.AcxDetalles.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.AcxDetalles_CellValidating);
            this.AcxDetalles.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.AcxDetalles_EditingControlShowing);
            this.AcxDetalles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcxDetalles_KeyDown);
            // 
            // Txttrv_vventa
            // 
            this.Txttrv_vventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txttrv_vventa.Location = new System.Drawing.Point(467, 174);
            this.Txttrv_vventa.MaxLength = 20;
            this.Txttrv_vventa.Name = "Txttrv_vventa";
            this.Txttrv_vventa.ReadOnly = true;
            this.Txttrv_vventa.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_vventa.TabIndex = 1;
            // 
            // Lbltrv_pigv
            // 
            this.Lbltrv_pigv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltrv_pigv.AutoSize = true;
            this.Lbltrv_pigv.Location = new System.Drawing.Point(5, 179);
            this.Lbltrv_pigv.Name = "Lbltrv_pigv";
            this.Lbltrv_pigv.Size = new System.Drawing.Size(45, 15);
            this.Lbltrv_pigv.TabIndex = 0;
            this.Lbltrv_pigv.Text = "Igv % : ";
            // 
            // Txttrv_total
            // 
            this.Txttrv_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txttrv_total.Location = new System.Drawing.Point(813, 174);
            this.Txttrv_total.MaxLength = 20;
            this.Txttrv_total.Name = "Txttrv_total";
            this.Txttrv_total.ReadOnly = true;
            this.Txttrv_total.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_total.TabIndex = 1;
            // 
            // Txttrv_pigv
            // 
            this.Txttrv_pigv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txttrv_pigv.DecimalPlaces = 2;
            this.Txttrv_pigv.Location = new System.Drawing.Point(56, 174);
            this.Txttrv_pigv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Txttrv_pigv.Name = "Txttrv_pigv";
            this.Txttrv_pigv.Size = new System.Drawing.Size(75, 23);
            this.Txttrv_pigv.TabIndex = 1;
            this.Txttrv_pigv.Value = new decimal(new int[] {
            1800,
            0,
            0,
            131072});
            this.Txttrv_pigv.ValueChanged += new System.EventHandler(this.Txttrv_pigv_ValueChanged);
            // 
            // Lbltrv_total
            // 
            this.Lbltrv_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltrv_total.AutoSize = true;
            this.Lbltrv_total.Location = new System.Drawing.Point(732, 179);
            this.Lbltrv_total.Name = "Lbltrv_total";
            this.Lbltrv_total.Size = new System.Drawing.Size(70, 15);
            this.Lbltrv_total.TabIndex = 0;
            this.Lbltrv_total.Text = "Total Venta: ";
            // 
            // Lbltrv_dctos
            // 
            this.Lbltrv_dctos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltrv_dctos.AutoSize = true;
            this.Lbltrv_dctos.Location = new System.Drawing.Point(144, 179);
            this.Lbltrv_dctos.Name = "Lbltrv_dctos";
            this.Lbltrv_dctos.Size = new System.Drawing.Size(102, 15);
            this.Lbltrv_dctos.TabIndex = 0;
            this.Lbltrv_dctos.Text = "Total Descuentos: ";
            // 
            // Txttrv_igv
            // 
            this.Txttrv_igv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txttrv_igv.Location = new System.Drawing.Point(626, 174);
            this.Txttrv_igv.MaxLength = 20;
            this.Txttrv_igv.Name = "Txttrv_igv";
            this.Txttrv_igv.ReadOnly = true;
            this.Txttrv_igv.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_igv.TabIndex = 1;
            // 
            // Txttrv_dctos
            // 
            this.Txttrv_dctos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txttrv_dctos.Location = new System.Drawing.Point(252, 174);
            this.Txttrv_dctos.MaxLength = 20;
            this.Txttrv_dctos.Name = "Txttrv_dctos";
            this.Txttrv_dctos.ReadOnly = true;
            this.Txttrv_dctos.Size = new System.Drawing.Size(100, 23);
            this.Txttrv_dctos.TabIndex = 1;
            // 
            // Lbltrv_igv
            // 
            this.Lbltrv_igv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltrv_igv.AutoSize = true;
            this.Lbltrv_igv.Location = new System.Drawing.Point(586, 179);
            this.Lbltrv_igv.Name = "Lbltrv_igv";
            this.Lbltrv_igv.Size = new System.Drawing.Size(29, 15);
            this.Lbltrv_igv.TabIndex = 0;
            this.Lbltrv_igv.Text = "Igv: ";
            // 
            // Lbltrv_vventa
            // 
            this.Lbltrv_vventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbltrv_vventa.AutoSize = true;
            this.Lbltrv_vventa.Location = new System.Drawing.Point(367, 179);
            this.Lbltrv_vventa.Name = "Lbltrv_vventa";
            this.Lbltrv_vventa.Size = new System.Drawing.Size(94, 15);
            this.Lbltrv_vventa.TabIndex = 0;
            this.Lbltrv_vventa.Text = "Base Imponible: ";
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.BackColor = System.Drawing.SystemColors.Control;
            this.Mnu_Principal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Adicionar,
            this.Mnu_Modificar,
            this.ToolStripSeparator2,
            this.Mnu_Guardar,
            this.Mnu_Deshacer,
            this.ToolStripSeparator3,
            this.Mnu_Eliminar,
            this.ToolStripSeparator4,
            this.Mnu_Duplicar});
            this.Mnu_Principal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mnu_Principal.Image = global::Presentacion.Properties.Resources.Menu;
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(132, 20);
            this.Mnu_Principal.Text = "Trabajar con Datos";
            // 
            // Mnu_Adicionar
            // 
            this.Mnu_Adicionar.BackColor = System.Drawing.SystemColors.Control;
            this.Mnu_Adicionar.Image = global::Presentacion.Properties.Resources.Adicionar;
            this.Mnu_Adicionar.Name = "Mnu_Adicionar";
            this.Mnu_Adicionar.ShortcutKeyDisplayString = "";
            this.Mnu_Adicionar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Mnu_Adicionar.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Adicionar.Text = "A?adir";
            this.Mnu_Adicionar.Click += new System.EventHandler(this.Mnu_Adicionar_Click);
            // 
            // Mnu_Modificar
            // 
            this.Mnu_Modificar.Image = global::Presentacion.Properties.Resources.Editar;
            this.Mnu_Modificar.Name = "Mnu_Modificar";
            this.Mnu_Modificar.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Modificar.Text = "Modificar";
            this.Mnu_Modificar.Click += new System.EventHandler(this.Mnu_Modificar_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // Mnu_Guardar
            // 
            this.Mnu_Guardar.Image = global::Presentacion.Properties.Resources.Grabar;
            this.Mnu_Guardar.Name = "Mnu_Guardar";
            this.Mnu_Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Mnu_Guardar.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Guardar.Text = "Guardar";
            this.Mnu_Guardar.Click += new System.EventHandler(this.Mnu_Guardar_Click);
            // 
            // Mnu_Deshacer
            // 
            this.Mnu_Deshacer.Image = global::Presentacion.Properties.Resources.Deshacer;
            this.Mnu_Deshacer.Name = "Mnu_Deshacer";
            this.Mnu_Deshacer.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Deshacer.Text = "Deshacer";
            this.Mnu_Deshacer.Click += new System.EventHandler(this.Mnu_Deshacer_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // Mnu_Eliminar
            // 
            this.Mnu_Eliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.Mnu_Eliminar.Name = "Mnu_Eliminar";
            this.Mnu_Eliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Mnu_Eliminar.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Eliminar.Text = "Eliminar";
            this.Mnu_Eliminar.Click += new System.EventHandler(this.Mnu_Eliminar_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // Mnu_Duplicar
            // 
            this.Mnu_Duplicar.Image = global::Presentacion.Properties.Resources.Copiar;
            this.Mnu_Duplicar.Name = "Mnu_Duplicar";
            this.Mnu_Duplicar.Size = new System.Drawing.Size(158, 22);
            this.Mnu_Duplicar.Text = "Duplicar";
            this.Mnu_Duplicar.Click += new System.EventHandler(this.Mnu_Duplicar_Click);
            // 
            // Mnu_Salir
            // 
            this.Mnu_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_Salir.Image = global::Presentacion.Properties.Resources.Salir;
            this.Mnu_Salir.Name = "Mnu_Salir";
            this.Mnu_Salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Mnu_Salir.Size = new System.Drawing.Size(57, 20);
            this.Mnu_Salir.Text = "Salir";
            this.Mnu_Salir.Click += new System.EventHandler(this.Mnu_Salir_Click);
            // 
            // Mnu_Confirmar
            // 
            this.Mnu_Confirmar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_Confirmar.Enabled = false;
            this.Mnu_Confirmar.Image = global::Presentacion.Properties.Resources.Confirmar;
            this.Mnu_Confirmar.Name = "Mnu_Confirmar";
            this.Mnu_Confirmar.Size = new System.Drawing.Size(89, 20);
            this.Mnu_Confirmar.Text = "Confirmar";
            // 
            // Mnu_Imprimir
            // 
            this.Mnu_Imprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_Imprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mnu_Imprimir.Image = global::Presentacion.Properties.Resources.Imprimir;
            this.Mnu_Imprimir.Name = "Mnu_Imprimir";
            this.Mnu_Imprimir.Size = new System.Drawing.Size(79, 20);
            this.Mnu_Imprimir.Text = "Exportar";
            this.Mnu_Imprimir.Click += new System.EventHandler(this.Mnu_Imprimir_Click);
            // 
            // Mnu_Recargar
            // 
            this.Mnu_Recargar.Image = global::Presentacion.Properties.Resources.Refrescar;
            this.Mnu_Recargar.Name = "Mnu_Recargar";
            this.Mnu_Recargar.ShortcutKeyDisplayString = "";
            this.Mnu_Recargar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Mnu_Recargar.Size = new System.Drawing.Size(87, 20);
            this.Mnu_Recargar.Text = "Actualizar";
            this.Mnu_Recargar.ToolTipText = "Recupera Informaci?n del Servidor";
            this.Mnu_Recargar.Click += new System.EventHandler(this.Mnu_Recargar_Click);
            // 
            // Mnu_Criterios_Mostrar
            // 
            this.Mnu_Criterios_Mostrar.Image = global::Presentacion.Properties.Resources.FiltroMostrar;
            this.Mnu_Criterios_Mostrar.Name = "Mnu_Criterios_Mostrar";
            this.Mnu_Criterios_Mostrar.Size = new System.Drawing.Size(129, 20);
            this.Mnu_Criterios_Mostrar.Text = " & Mostrar Criterios";
            this.Mnu_Criterios_Mostrar.Visible = false;
            this.Mnu_Criterios_Mostrar.Click += new System.EventHandler(this.Mnu_Criterios_Mostrar_Click);
            // 
            // Mnu_Criterios_Ocultar
            // 
            this.Mnu_Criterios_Ocultar.Image = global::Presentacion.Properties.Resources.FiltroOcultar;
            this.Mnu_Criterios_Ocultar.Name = "Mnu_Criterios_Ocultar";
            this.Mnu_Criterios_Ocultar.Size = new System.Drawing.Size(127, 20);
            this.Mnu_Criterios_Ocultar.Text = " & Ocultar Criterios";
            this.Mnu_Criterios_Ocultar.Visible = false;
            this.Mnu_Criterios_Ocultar.Click += new System.EventHandler(this.Mnu_Criterios_Ocultar_Click);
            // 
            // Mnu_Correo
            // 
            this.Mnu_Correo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_Correo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mnu_Correo.Image = global::Presentacion.Properties.Resources.Correo;
            this.Mnu_Correo.Name = "Mnu_Correo";
            this.Mnu_Correo.Size = new System.Drawing.Size(76, 20);
            this.Mnu_Correo.Text = "Soporte";
            this.Mnu_Correo.Visible = false;
            // 
            // mnuOcultar
            // 
            this.mnuOcultar.Image = global::Presentacion.Properties.Resources.Mostrar;
            this.mnuOcultar.Name = "mnuOcultar";
            this.mnuOcultar.Size = new System.Drawing.Size(76, 20);
            this.mnuOcultar.Text = "Mostrar";
            this.mnuOcultar.Visible = false;
            this.mnuOcultar.Click += new System.EventHandler(this.mnuOcultar_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Principal,
            this.Mnu_Salir,
            this.Mnu_Confirmar,
            this.Mnu_Imprimir,
            this.Mnu_Recargar,
            this.Mnu_Criterios_Mostrar,
            this.Mnu_Criterios_Ocultar,
            this.Mnu_Correo,
            this.mnuOcultar});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(944, 24);
            this.MenuStrip1.TabIndex = 37;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Tlb_Adicionar
            // 
            this.Tlb_Adicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Adicionar.Image = global::Presentacion.Properties.Resources.Adicionar;
            this.Tlb_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Adicionar.Name = "Tlb_Adicionar";
            this.Tlb_Adicionar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Adicionar.Text = "A?adir";
            this.Tlb_Adicionar.Click += new System.EventHandler(this.Tlb_Adicionar_Click);
            // 
            // Tlb_Modificar
            // 
            this.Tlb_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Modificar.Image = global::Presentacion.Properties.Resources.Editar;
            this.Tlb_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Modificar.Name = "Tlb_Modificar";
            this.Tlb_Modificar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Modificar.Text = "Modificar";
            this.Tlb_Modificar.Click += new System.EventHandler(this.Tlb_Modificar_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // Tlb_Guardar
            // 
            this.Tlb_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Guardar.Image = global::Presentacion.Properties.Resources.Grabar;
            this.Tlb_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Guardar.Name = "Tlb_Guardar";
            this.Tlb_Guardar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Guardar.Text = "Guardar";
            this.Tlb_Guardar.Click += new System.EventHandler(this.Tlb_Guardar_Click);
            // 
            // Tlb_Deshacer
            // 
            this.Tlb_Deshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Deshacer.Image = global::Presentacion.Properties.Resources.Deshacer;
            this.Tlb_Deshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Deshacer.Name = "Tlb_Deshacer";
            this.Tlb_Deshacer.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Deshacer.Text = "Deshacer";
            this.Tlb_Deshacer.Click += new System.EventHandler(this.Tlb_Deshacer_Click);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(6, 25);
            // 
            // Tlb_Eliminar
            // 
            this.Tlb_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Eliminar.Image = global::Presentacion.Properties.Resources.Eliminar;
            this.Tlb_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Eliminar.Name = "Tlb_Eliminar";
            this.Tlb_Eliminar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Eliminar.Text = "Eliminar";
            this.Tlb_Eliminar.Click += new System.EventHandler(this.Tlb_Eliminar_Click);
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.Size = new System.Drawing.Size(6, 25);
            this.ToolStripButton8.Visible = false;
            // 
            // Tlb_Duplicar
            // 
            this.Tlb_Duplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Duplicar.Image = global::Presentacion.Properties.Resources.Copiar;
            this.Tlb_Duplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Duplicar.Name = "Tlb_Duplicar";
            this.Tlb_Duplicar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Duplicar.Text = "Duplicar";
            this.Tlb_Duplicar.Click += new System.EventHandler(this.Tlb_Duplicar_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSeparator8.Visible = false;
            // 
            // Tlb_Consultar
            // 
            this.Tlb_Consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Consultar.Image = global::Presentacion.Properties.Resources.MostrarConsulta;
            this.Tlb_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Consultar.Name = "Tlb_Consultar";
            this.Tlb_Consultar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Consultar.Text = "Consultar";
            this.Tlb_Consultar.Click += new System.EventHandler(this.Tlb_Consultar_Click);
            // 
            // Tlb_Cerrar
            // 
            this.Tlb_Cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tlb_Cerrar.Image = global::Presentacion.Properties.Resources.OcultarConsulta;
            this.Tlb_Cerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tlb_Cerrar.Name = "Tlb_Cerrar";
            this.Tlb_Cerrar.Size = new System.Drawing.Size(23, 22);
            this.Tlb_Cerrar.Text = "Cerrar";
            this.Tlb_Cerrar.Visible = false;
            this.Tlb_Cerrar.Click += new System.EventHandler(this.Tlb_Cerrar_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MiToolBar
            // 
            this.MiToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.MiToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tlb_Adicionar,
            this.Tlb_Modificar,
            this.ToolStripButton3,
            this.Tlb_Guardar,
            this.Tlb_Deshacer,
            this.ToolStripButton6,
            this.Tlb_Eliminar,
            this.ToolStripButton8,
            this.Tlb_Duplicar,
            this.ToolStripSeparator8,
            this.Tlb_Consultar,
            this.Tlb_Cerrar,
            this.ToolStripSeparator1});
            this.MiToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MiToolBar.Location = new System.Drawing.Point(0, 24);
            this.MiToolBar.Name = "MiToolBar";
            this.MiToolBar.Size = new System.Drawing.Size(944, 25);
            this.MiToolBar.TabIndex = 36;
            // 
            // frmRegistroVentas
            // 
            this.ClientSize = new System.Drawing.Size(944, 522);
            this.Controls.Add(this.PanelFiltros);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.MiToolBar);
            this.Controls.Add(this.MenuStrip1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(952, 537);
            this.Name = "frmRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroVentas_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroVentas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistroVentas_KeyDown);
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            this.Mnu_Filtros.ResumeLayout(false);
            this.Mnu_Filtros.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AcxControl)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.RadSplitContainer2.Panel1.ResumeLayout(false);
            this.RadSplitContainer2.Panel1.PerformLayout();
            this.RadSplitContainer2.Panel2.ResumeLayout(false);
            this.RadSplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainer2)).EndInit();
            this.RadSplitContainer2.ResumeLayout(false);
            this.GrpClave.ResumeLayout(false);
            this.GrpClave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txttrv_tcambio)).EndInit();
            this.ToolDetalles.ResumeLayout(false);
            this.ToolDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcxDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txttrv_pigv)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.MiToolBar.ResumeLayout(false);
            this.MiToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip miniToolStrip;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_FiltrosCerrar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_FiltrosBuscar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Detener;
        internal System.Windows.Forms.Label Lbl_Criterios;
        internal System.Windows.Forms.Panel PanelFiltros;
        internal System.Windows.Forms.MenuStrip Mnu_Filtros;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView AcxControl;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.SplitContainer RadSplitContainer2;
        internal System.Windows.Forms.Label Lbltrv_periodo;
        internal System.Windows.Forms.DateTimePicker Txttrv_periodo;
        internal System.Windows.Forms.Label Lbltrv_tipo;
        internal System.Windows.Forms.TextBox Txttrv_tipo;
        internal System.Windows.Forms.Button Btntrv_tipo;
        internal System.Windows.Forms.TextBox Txttrv_tipo_Des;
        internal System.Windows.Forms.Label Lbltrv_registro;
        internal System.Windows.Forms.TextBox Txttrv_registro;
        internal System.Windows.Forms.Label Lbltrv_entidad;
        internal System.Windows.Forms.TextBox Txttrv_entidad;
        internal System.Windows.Forms.Button Btntrv_entidad;
        internal System.Windows.Forms.TextBox Txttrv_entidad_Des;
        internal System.Windows.Forms.Label Lbltrv_idvendedor;
        internal System.Windows.Forms.TextBox Txttrv_idvendedor;
        internal System.Windows.Forms.Button Btntrv_idvendedor;
        internal System.Windows.Forms.TextBox Txttrv_idvendedor_Des;
        internal System.Windows.Forms.Label Lbltrv_idformapago;
        internal System.Windows.Forms.TextBox Txttrv_idformapago;
        internal System.Windows.Forms.Button Btntrv_idformapago;
        internal System.Windows.Forms.TextBox Txttrv_idformapago_Des;
        internal System.Windows.Forms.Label Lbltrv_tdoc;
        internal System.Windows.Forms.TextBox Txttrv_tdoc;
        internal System.Windows.Forms.Button Btntrv_tdoc;
        internal System.Windows.Forms.TextBox Txttrv_tdoc_Des;
        internal System.Windows.Forms.Label Lbltrv_sdoc;
        internal System.Windows.Forms.TextBox Txttrv_sdoc;
        internal System.Windows.Forms.Button Btntrv_sdoc;
        internal System.Windows.Forms.TextBox Txttrv_ndoc;
        internal System.Windows.Forms.Label Lbltrv_femision;
        internal System.Windows.Forms.DateTimePicker Txttrv_femision;
        internal System.Windows.Forms.Label Lbltrv_fvencimiento;
        internal System.Windows.Forms.DateTimePicker Txttrv_fvencimiento;
        internal System.Windows.Forms.Label Lbltrv_moneda;
        internal System.Windows.Forms.TextBox Txttrv_moneda;
        internal System.Windows.Forms.Button Btntrv_moneda;
        internal System.Windows.Forms.TextBox Txttrv_moneda_Des;
        internal System.Windows.Forms.Label Lbltrv_tcambio;
        internal System.Windows.Forms.NumericUpDown Txttrv_tcambio;
        internal System.Windows.Forms.Label Lbltrv_dctos;
        internal System.Windows.Forms.TextBox Txttrv_dctos;
        internal System.Windows.Forms.Label Lbltrv_vventa;
        internal System.Windows.Forms.TextBox Txttrv_vventa;
        internal System.Windows.Forms.Label Lbltrv_igv;
        internal System.Windows.Forms.TextBox Txttrv_igv;
        internal System.Windows.Forms.Label Lbltrv_total;
        internal System.Windows.Forms.TextBox Txttrv_total;
        internal System.Windows.Forms.Label Lbltrv_aigv;
        internal System.Windows.Forms.CheckBox Txttrv_aigv;
        internal System.Windows.Forms.Label Lbltrv_flag;
        internal System.Windows.Forms.CheckBox Txttrv_flag;
        internal System.Windows.Forms.Label Lbltrv_pigv;
        internal System.Windows.Forms.NumericUpDown Txttrv_pigv;
        internal System.Windows.Forms.ToolStrip ToolDetalles;
        internal System.Windows.Forms.ToolStripButton Tlb_D_Nuevo;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton Tlb_D_Elimina;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton Tlb_D_Duplica;
        internal System.Windows.Forms.ToolStripLabel Tol_Moneda;
        internal System.Windows.Forms.DataGridView AcxDetalles;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Principal;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Adicionar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Modificar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Guardar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Deshacer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Eliminar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Duplicar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Salir;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Confirmar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Imprimir;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Recargar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Criterios_Mostrar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Criterios_Ocultar;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Correo;
        internal System.Windows.Forms.ToolStripMenuItem mnuOcultar;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.ToolStripButton Tlb_Adicionar;
        internal System.Windows.Forms.ToolStripButton Tlb_Modificar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton Tlb_Guardar;
        internal System.Windows.Forms.ToolStripButton Tlb_Deshacer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton6;
        internal System.Windows.Forms.ToolStripButton Tlb_Eliminar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton8;
        internal System.Windows.Forms.ToolStripButton Tlb_Duplicar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton Tlb_Consultar;
        internal System.Windows.Forms.ToolStripButton Tlb_Cerrar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStrip MiToolBar;
        private GroupBox GrpClave;
        internal DateTimePicker Txttrv_mes;
        internal Label Lbltrv_mes;
    }
}
