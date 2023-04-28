using System.Data;

namespace Entidades.Series
{
    public class ClsSerie
    {
        #region Variables privadas
        private int _idserie, _idseccion;
        private string _nombre_serie;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;
        #endregion

        #region Variables publicas

        public int Idserie { get => _idserie; set => _idserie = value; }
        public int Idseccion { get => _idseccion; set => _idseccion = value; }
        public string Nombre_serie { get => _nombre_serie; set => _nombre_serie = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        #endregion
    }
}
