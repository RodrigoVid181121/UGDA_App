
using System.Data;

namespace Entidades.Documentos
{
    public class ClsDocument
    {
        #region Atributos privados
        private int _idDocs, _idSubSerie, _idUnidad, _idUsuario;
        private string _codigoDoc, _descripcion, _año, _ubicación;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;
        #endregion

        #region Atributos publicos 
        public int IdDocs { get => _idDocs; set => _idDocs = value; }
        public int IdSubSerie { get => _idSubSerie; set => _idSubSerie = value; }
        public int IdUnidad { get => _idUnidad; set => _idUnidad = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string CodigoDoc { get => _codigoDoc; set => _codigoDoc = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Año { get => _año; set => _año = value; }
        public string Ubicación { get => _ubicación; set => _ubicación = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        #endregion

    }
}
