using System.Data;

namespace Entidades.Usuarios
{
    public class ClsUsuario
    {
        #region Variables Privadas
        private int _id_usuario, _id_cargo;
        private string _nombre, _apellido, _carnet, _correo, _contraseña;

        private string _errorMessage, _ScalarValue;
        private DataTable _dtResults;
        #endregion

        #region Variables publicas
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public int Id_cargo { get => _id_cargo; set => _id_cargo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Carnet { get => _carnet; set => _carnet = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public string ScalarValue { get => _ScalarValue; set => _ScalarValue = value; }
        public DataTable DtResults { get => _dtResults; set => _dtResults = value; }

        #endregion
    }
}
