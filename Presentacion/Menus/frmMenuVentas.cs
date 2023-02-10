using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel.Composition.Primitives;
using Presentacion;
using Presentacion.Facturacion;
//using Clases;
//using ReglaNegocio;
//using Entidades;

namespace Presentacion.Menus
{
    public partial class frmMenuVentas : Form
    {
        #region "Variables"
        //private readonly BOCLogica ocapa = new BOCLogica();
        //private List<Tseguridad_Usuarios> ListaRegistros = new List<Tseguridad_Usuarios>();
        #endregion
        #region "Metodos"
        public frmMenuVentas()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormEnPanelRad(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Telerik.WinControls.UI.RadForm;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        #endregion
        #region "Eventos"
        private void MenuSistema_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
            iconmaximizar_Click(null, e);
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
          
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnEnvio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRegistroVentas());
        }
        #endregion
    }
}