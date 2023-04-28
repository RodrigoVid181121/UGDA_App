using System.Data;

namespace Entidades.UnidadesProductoras
{
    public class ClsUnidadProductora
    {
        #region Variables Privadas
        private int _id_unidad_productora;
        private string _nombre_unidad_productora;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;

        #endregion

        #region Variables Publicas
        public int Id_unidad_productora { get => _id_unidad_productora; set => _id_unidad_productora = value; }
        public string Nombre_unidad_productora { get => _nombre_unidad_productora; set => _nombre_unidad_productora = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        #endregion
    }
}
