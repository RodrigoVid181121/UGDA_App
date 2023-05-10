using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bitacora
{
    public class ClsBitacora
    {
        #region Variables Privadas
        private string _evento ,_tipo, _hostame, _fecha, _subserie, _unidad, _usuario, _codigodoc, _descripcion, _anio, _ubicacion;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;


        #endregion

        #region Variables publicas
        public string Evento { get => _evento; set => _evento = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Hostame { get => _hostame; set => _hostame = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Subserie { get => _subserie; set => _subserie = value; }
        public string Unidad { get => _unidad; set => _unidad = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Codigodoc { get => _codigodoc; set => _codigodoc = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Anio { get => _anio; set => _anio = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        #endregion
    }
}
