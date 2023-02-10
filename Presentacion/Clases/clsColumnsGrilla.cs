using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion.Clases
{
    public class clsColumnsGrilla
    {
        private string _NombreBD;
        private string _NombredeColumna;
        private int _AnchodeColumna;
        private bool _MostrarFiltro;
        private bool _PermiteMoverColumnas;
        private string _TipodeCampo;
        private int _TamañodeCampo;
        private int _NumerodeDecimales;
        private string _AlineaciondelCampo = "IZQUIERDA";
        private string _ToolTip = "";
        private string _ListaDrop = "";
        private bool _SoloMayusculas = false;
        private bool _EsVisible = false;
         public void New(){
         //    ' Constructor por defecto. Es necesario para
        //' poder añadir nuevos registros en blanco.
         }

         public clsColumnsGrilla(string pNombreBD, string pNombredeColumna, int pAnchodeColumna, bool pMostrarFiltro, bool pPermiteMoverColumnas, string pTipodeCampo
        , int pTamañodeCampo, int pNumerodeDecimales, string pAlineaciondelCampo, string pToolTip, string pListaDrop, bool pSoloMayusculas, bool pBolEsVisible = true)
            {
                // _GridView = pGridView
                _NombreBD = pNombreBD;
                _NombredeColumna = pNombredeColumna;
                _AnchodeColumna = pAnchodeColumna;
                _MostrarFiltro = pMostrarFiltro;
                _PermiteMoverColumnas = pPermiteMoverColumnas;
                _TipodeCampo = pTipodeCampo;
                _TamañodeCampo = pTamañodeCampo;
                _NumerodeDecimales = pNumerodeDecimales;
                _AlineaciondelCampo = pAlineaciondelCampo;
                _ToolTip = pToolTip;
                _ListaDrop = pListaDrop;
                _SoloMayusculas = pSoloMayusculas;
                _EsVisible = pBolEsVisible;
            }

        public string NombreBD
        {
            get
            {
                return _NombreBD;
            }
            set
            {
                _NombreBD = value;
            }
        }
        public string NombredeColumna
        {
            get
            {
                return _NombredeColumna;
            }
            set
            {
                _NombredeColumna = value;
            }
        }
        public int AnchodeColumna
        {
            get
            {
                return _AnchodeColumna;
            }
            set
            {
                _AnchodeColumna = value;
            }
        }
        public bool MostrarFiltro
        {
            get
            {
                return _MostrarFiltro;
            }
            set
            {
                _MostrarFiltro = value;
            }
        }
        public bool PermiteMoverColumnas
        {
            get
            {
                return _PermiteMoverColumnas;
            }
            set
            {
                _PermiteMoverColumnas = value;
            }
        }
        public string TipodeCampo
        {
            get
            {
                return _TipodeCampo;
            }
            set
            {
                _TipodeCampo = value;
            }
        }
        public int TamañodeCampo
        {
            get
            {
                return _TamañodeCampo;
            }
            set
            {
                _TamañodeCampo = value;
            }
        }
        public int NumerodeDecimales
        {
            get
            {
                return _NumerodeDecimales;
            }
            set
            {
                _NumerodeDecimales = value;
            }
        }
        public string AlineaciondelCampo
        {
            get
            {
                return _AlineaciondelCampo;
            }
            set
            {
                _AlineaciondelCampo = value;
            }
        }
        public string ToolTip
        {
            get
            {
                return _ToolTip;
            }
            set
            {
                _ToolTip = value;
            }
        }
        public string ListaDrop
        {
            get
            {
                return _ListaDrop;
            }
            set
            {
                _ListaDrop = value;
            }
        }
        public bool SoloMayusculas
        {
            get
            {
                return _SoloMayusculas;
            }
            set
            {
                _SoloMayusculas = value;
            }
        }

        public bool EsVisible
        {
            get
            {
                return _EsVisible;
            }
            set
            {
                _EsVisible = value;
            }
        }
    
    


    }
}
