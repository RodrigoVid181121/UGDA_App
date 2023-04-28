using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DB
{
    public class ClsDatabase
    {
        #region Variables privadas

        private SqlConnection _objSqlConnection;
        private SqlDataAdapter _objSqlAdapter;
        private SqlCommand _objSqlCommand;
        private SqlDataReader _objSqlDataReader;
        private DataSet _dsResults;
        private DataTable _dtParameters;
        private string _tableName, _nameSP, errorMessageDB, _escalarValue, _DBName;
        private bool _escalar;
        /* Table name: variable que almacena el nombre de la tabla para recibir los resultados del DataSet
        * _nameSP: nombre del procedimiento almacenado para enviar dentro del SQlCommand o SqlDataAdapter
        * _errorMessageDB: captura los errores que pueden llegar a generar el SqlCommand o el SqlDataAdapter
        * _escalarValue: almacena el valor escalar (en caso de ser necesario) de una consulta SQL
        * _escalar: permite definir si se utilizará _escalarValue
        */

        #endregion

        #region Variables publicas

        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlAdapter { get => _objSqlAdapter; set => _objSqlAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public SqlDataReader ObjSqlDataReader { get => _objSqlDataReader; set => _objSqlDataReader = value; }
        public DataSet DsResults { get => _dsResults; set => _dsResults = value; }
        public DataTable DtParameters { get => _dtParameters; set => _dtParameters = value; }
        public string TableName { get => _tableName; set => _tableName = value; }
        public string NameSP { get => _nameSP; set => _nameSP = value; }
        public string ErrorMessageDB { get => errorMessageDB; set => errorMessageDB = value; }
        public string EscalarValue { get => _escalarValue; set => _escalarValue = value; }
        public string DBName { get => _DBName; set => _DBName = value; }
        public bool Escalar { get => _escalar; set => _escalar = value; }

        #endregion

        #region Constructores

        public ClsDatabase()
        {
            DtParameters = new DataTable("SpParameters");
            DtParameters.Columns.Add("Name");
            DtParameters.Columns.Add("DataType");
            DtParameters.Columns.Add("Value");

            DBName = "db_alcaldia";
        }

        #endregion

        #region Metodos privados

        private void CreateConnectionDB(ref ClsDatabase objDataBase)
        {
            //se realiza un switch en caso de necesitar más de 1 Base de Datos para el sistema
            switch (objDataBase.DBName)
            {
                case "db_alcaldia":
                    //la cadena de conexión está creada automaticamente en el archivo app.config del proyecto Acceso a Datos
                    //Este archivo se genera en las propiedades del proyecto en el apartado de configuración
                    //se la variable de tipo cadena de conexión y se ingresan los datos correspondientes
                    //para la conexión con la BD
                    objDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.connectionString_db_alcaldia);

                break;


                default:
                    
                break;

            }
        }

        private void ValidateConnectionDB(ref ClsDatabase objDataBase)
        {
            //verifica el estado de la conexión con la BD de datos
            //si está cerrada la abre, de lo contrario la cierra y la quita de memoria para ahorrar recursos
            //el comando Dispose() es el responsable de quitar la conexión de la memoria
            if(objDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                objDataBase.ObjSqlConnection.Open();
            }
            else
            {
                objDataBase.ObjSqlConnection.Close();
                objDataBase.ObjSqlConnection.Dispose();
            }
        }

        private void AddParameters(ref ClsDatabase objDataBase)
        {
            //verifica mediante un switch el tipo de dato que estamos pasando directamente a la BD
            //comparandolo con los datos que tiene el DataTable de parametros
            if (objDataBase.DtParameters != null)
            {
                SqlDbType datatype = new SqlDbType();

                foreach(DataRow item in objDataBase.DtParameters.Rows)
                {
                    switch (item[1])
                    {
                        case "1":
                            datatype = SqlDbType.Bit;
                            break;
                        case "2":
                            datatype = SqlDbType.TinyInt; //1 byte
                            break;
                        case "3":
                            datatype = SqlDbType.SmallInt; //2 bytes
                            break;
                        case "4":
                            datatype = SqlDbType.Int; //4 bytes
                            break;
                        case "5":
                            datatype = SqlDbType.BigInt; //8 bytes
                            break;
                        case "6":
                            datatype = SqlDbType.Decimal;
                            break;
                        case "7":
                            datatype = SqlDbType.SmallMoney;
                            break;
                        case "8":
                            datatype = SqlDbType.Money;
                            break;
                        case "9":
                            datatype = SqlDbType.Float;
                            break;
                        case "10":
                            datatype = SqlDbType.Real;
                            break;
                        case "11":
                            datatype = SqlDbType.Date;
                            break;
                        case "12":
                            datatype = SqlDbType.Time;
                            break;
                        case "13":
                            datatype = SqlDbType.SmallDateTime; //3 bytes
                            break;
                        case "14":
                            datatype = SqlDbType.DateTime; //8 bytes
                            break;
                        case "15":
                            datatype = SqlDbType.Char;
                            break;
                        case "16":
                            datatype = SqlDbType.NChar;
                            break;
                        case "17":
                            datatype = SqlDbType.VarChar;
                            break;
                        case "18":
                            datatype = SqlDbType.NVarChar;
                            break;

                        default:
                            break;
                    }
                    //verifica si el objeto de base de datos devuelve un valor escalar
                    //si lo devuelve se utiliza un sql command, de lo contrario devuelve un sql data adapter (un arreglo)

                    if (objDataBase.Escalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            objDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), datatype).Value = DBNull.Value;
                        }
                        else
                        {
                            objDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), datatype).Value = item[2].ToString();

                        }
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            objDataBase.ObjSqlAdapter.SelectCommand.Parameters.Add(item[0].ToString(), datatype).Value = DBNull.Value;
                        }
                        else
                        {
                            objDataBase.ObjSqlAdapter.SelectCommand.Parameters.Add(item[0].ToString(), datatype).Value = item[2].ToString();

                        }
                    }
                }
            }
        }

        private void PrepareConnectionDB(ref ClsDatabase objDataBase)
        {
            CreateConnectionDB(ref objDataBase);
            ValidateConnectionDB(ref objDataBase);
        }

        private void ExecDataAdapter(ref ClsDatabase objDataBase)
        {
            try
            {
                PrepareConnectionDB(ref objDataBase);

                //prepara el sqlAdapter y le envie el nombre del procedimiento almacenado y la cadena de conexión
                objDataBase.ObjSqlAdapter = new SqlDataAdapter(objDataBase.NameSP, objDataBase.ObjSqlConnection);
                objDataBase.ObjSqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AddParameters(ref objDataBase);

                //utiliza la tabla de resultados (DsResults) para devolver los datos con el nombre de la tabla
                //previamente asignado (TableName)
                objDataBase.DsResults = new DataSet();
                objDataBase.ObjSqlAdapter.Fill(objDataBase.DsResults, objDataBase.TableName);
            }
            catch  (Exception ex)
            {
                objDataBase.errorMessageDB = ex.Message.ToString();
            }
            finally
            {
                //verifica que si despues del error, la conexión continúa abierta se cierra automaticamente
                //aplicando recursividad con la función "ValidateConnectionDB"
                if(objDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidateConnectionDB(ref objDataBase);
                }
            }
        }

        private void ExecCommands(ref ClsDatabase objDataBase)
        {
            try
            {
                PrepareConnectionDB(ref objDataBase);
                objDataBase.ObjSqlCommand = new SqlCommand(objDataBase.NameSP, objDataBase.ObjSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                AddParameters(ref objDataBase);

                if(objDataBase.Escalar == true)
                {
                    objDataBase.EscalarValue = objDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    objDataBase.ObjSqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                objDataBase.errorMessageDB = ex.Message.ToString();
            }
            finally
            {
                if (objDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidateConnectionDB(ref objDataBase);
                }
            }
        }

        #endregion

        #region Metodos publicos
        public void CRUD(ref ClsDatabase objDataBase)
        {
            if (objDataBase.Escalar)
            {
                ExecCommands(ref objDataBase);
            }
            else
            {
                ExecDataAdapter(ref objDataBase);
            }
        }
        #endregion
    }
}
