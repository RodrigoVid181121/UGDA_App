using System.Data;

namespace Entidades.Subseries
{
    public class ClsSubSerie
    {
        #region Variables privadas
        private int _idsubserie, _idserie;
        private string _nombresubserie, _codigosubserie;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;

        #endregion

        #region Variables publicas
        public int Idsubserie { get => _idsubserie; set => _idsubserie = value; }
        public int Idserie { get => _idserie; set => _idserie = value; }
        public string Nombresubserie { get => _nombresubserie; set => _nombresubserie = value; }
        public string Codigosubserie { get => _codigosubserie; set => _codigosubserie = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        #endregion

    }
}
