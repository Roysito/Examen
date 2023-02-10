namespace Presentacion.Ayudas
{
    partial class HLP_GENERALI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP_GENERALI));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mnu_Confirmar = new System.Windows.Forms.ToolStripMenuItem();
            this.AcxRadControl = new System.Windows.Forms.DataGridView();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.stbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbPrograma = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbCompania = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbModulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcxRadControl)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Confirmar});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(881, 24);
            this.MenuStrip1.TabIndex = 42;
            // 
            // Mnu_Confirmar
            // 
            this.Mnu_Confirmar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Mnu_Confirmar.Image = global::Presentacion.Properties.Resources.Confirmar;
            this.Mnu_Confirmar.Name = "Mnu_Confirmar";
            this.Mnu_Confirmar.Size = new System.Drawing.Size(89, 20);
            this.Mnu_Confirmar.Text = "Confirmar";
            this.Mnu_Confirmar.Click += new System.EventHandler(this.Mnu_Confirmar_Click);
            // 
            // AcxRadControl
            // 
            this.AcxRadControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AcxRadControl.Location = new System.Drawing.Point(12, 28);
            this.AcxRadControl.Name = "AcxRadControl";
            this.AcxRadControl.Size = new System.Drawing.Size(857, 267);
            this.AcxRadControl.TabIndex = 52;
            this.AcxRadControl.Text = "RadGridView1";
            this.AcxRadControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcxRadControl_KeyDown);
            this.AcxRadControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AcxRadControl_MouseDoubleClick);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbUser,
            this.stbPrograma,
            this.stbCompania,
            this.stbSession,
            this.stbServidor,
            this.stbModulo});
            this.StatusBar.Location = new System.Drawing.Point(0, 298);
            
            this.StatusBar.Size = new System.Drawing.Size(881, 22);
            this.StatusBar.TabIndex = 122;
            this.StatusBar.Text = "statusStrip1";
            // 
            // stbUser
            // 
            this.stbUser.AccessibleDescription = "Usuario";
            this.stbUser.AccessibleName = "Usuario";
            this.stbUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbUser.Image = ((System.Drawing.Image)(resources.GetObject("stbUser.Image")));
            this.stbUser.Name = "stbUser";
            this.stbUser.Size = new System.Drawing.Size(63, 17);
            this.stbUser.Text = "Usuario";
            // 
            // stbPrograma
            // 
            this.stbPrograma.AccessibleDescription = "Programa";
            this.stbPrograma.AccessibleName = "Programa";
            this.stbPrograma.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.stbPrograma.Image = ((System.Drawing.Image)(resources.GetObject("stbPrograma.Image")));
            this.stbPrograma.Name = "stbPrograma";
            this.stbPrograma.Size = new System.Drawing.Size(74, 17);
            this.stbPrograma.Text = "Programa";
            // 
            // stbCompania
            // 
            this.stbCompania.AccessibleDescription = "Compañía";
            this.stbCompania.AccessibleName = "Compañía";
            this.stbCompania.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbCompania.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stbCompania.Image = ((System.Drawing.Image)(resources.GetObject("stbCompania.Image")));
            this.stbCompania.Name = "stbCompania";
            this.stbCompania.Size = new System.Drawing.Size(76, 17);
            this.stbCompania.Text = "Compañía";
            // 
            // stbSession
            // 
            this.stbSession.AccessibleDescription = "Sessión";
            this.stbSession.AccessibleName = "Sessión";
            this.stbSession.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(68)))));
            this.stbSession.Image = ((System.Drawing.Image)(resources.GetObject("stbSession.Image")));
            this.stbSession.Name = "stbSession";
            this.stbSession.Size = new System.Drawing.Size(62, 17);
            this.stbSession.Text = "Sessión";
            // 
            // stbServidor
            // 
            this.stbServidor.AccessibleDescription = "Servidor";
            this.stbServidor.AccessibleName = "Servidor";
            this.stbServidor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(255)))));
            this.stbServidor.Image = ((System.Drawing.Image)(resources.GetObject("stbServidor.Image")));
            this.stbServidor.Name = "stbServidor";
            this.stbServidor.Size = new System.Drawing.Size(66, 17);
            this.stbServidor.Text = "Servidor";
            // 
            // stbModulo
            // 
            this.stbModulo.AccessibleDescription = "Módulo";
            this.stbModulo.AccessibleName = "Módulo";
            this.stbModulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.stbModulo.Image = ((System.Drawing.Image)(resources.GetObject("stbModulo.Image")));
            this.stbModulo.Name = "stbModulo";
            this.stbModulo.Size = new System.Drawing.Size(65, 17);
            this.stbModulo.Text = "Módulo";
            // 
            // HLP_GENERALI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 320);

            this.Controls.Add(this.AcxRadControl);
            this.Controls.Add(this.MenuStrip1);
            this.KeyPreview = true;
            this.Name = "HLP_GENERALI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HLP_FILTRO";
            this.Activated += new System.EventHandler(this.HLP_FILTRO_Activated);
            this.Load += new System.EventHandler(this.HLP_FILTRO_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcxRadControl)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem Mnu_Confirmar;
        internal global::System.Windows.Forms.DataGridView AcxRadControl;
        private global::System.Windows.Forms.StatusStrip StatusBar;
        private global::System.Windows.Forms.ToolStripStatusLabel stbUser;
        private global::System.Windows.Forms.ToolStripStatusLabel stbPrograma;
        public global::System.Windows.Forms.ToolStripStatusLabel stbCompania;
        private global::System.Windows.Forms.ToolStripStatusLabel stbSession;
        private global::System.Windows.Forms.ToolStripStatusLabel stbServidor;
        private global::System.Windows.Forms.ToolStripStatusLabel stbModulo;
    }
}