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
        #region Variables Privadas
        private int _id_cargo;
        private string _nombre_cargo;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;
        #endregion

        #region Variables publicas
        public int Id_cargo { get => _id_cargo; set => _id_cargo = value; }
        public string Nombre_Cargo { get => _nombre_cargo; set => _nombre_cargo = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }
        #endregion
    }
}
