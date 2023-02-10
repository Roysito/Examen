using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Clases
{
    public static class GlobalesVariables
    {
        private static string LoginUsuario = "** SISTEMAS";
        private static string finaliceedicion = "Finalice edición para cerrar formulario";
        private static string nombreaplicacion = "Registro de Ventas";
        private static Boolean IsPulsaF1CeldaGrid = false;
        private static string formatonumerosmillares2decimales = "{0:#,#,#.00}";
        private static Keys teclaayuda = Keys.F1;
        public static string _company = "01";
        public static string _LoginUsuario
        {
            get
            {
                return LoginUsuario;
            }
            set
            {
                LoginUsuario = value;
            }
        }
        public static string _finaliceedicion
        {
            get { return finaliceedicion; }
        }
        public static string _nombreaplicacion
        {
            get { return nombreaplicacion; }
        }
        public static bool _IsPulsaF1CeldaGrid
        {
            get
            {
                return IsPulsaF1CeldaGrid;
            }
            set
            {
                IsPulsaF1CeldaGrid = value;
            }
        }
        public static string _formatonumerosmillares2decimales
        {
            get { return formatonumerosmillares2decimales; }
        }
        public static Keys _teclaayuda
        {
            get { return teclaayuda; }
        }
        public static string company
        {
            get { return _company; }
        }
    }
}
