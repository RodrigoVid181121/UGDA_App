using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cargos
{
    public class ClsCargo
    {
        #region Variables privadas
        private int _idCargo;
        private string _nombreCargo;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;
        #endregion

        #region Variables Públicas
        public int IdCargo { get => _idCargo; set => _idCargo = value; }
        public string NombreCargo { get => _nombreCargo; set => _nombreCargo = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        #endregion
    }
}
