using AccesoDatos.DB;
using Entidades.Cargos;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios.Usuarios
{
    public class ClsUsuarioLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase = null;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index & login
        public void Index(ref ClsUsuario obUsu)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "usuarios",
                NameSP = "SP_Usu_Index",
                Escalar = false,
            };
            Execute(ref obUsu);
        }

        public void Login(ref ClsUsuario obUsu)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "usuarios",
                NameSP = "SP_Login",
                Escalar = false,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@Contraseña", "17", obUsu.Contraseña);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", obUsu.Carnet);
            ExecuteLogin(ref obUsu);
        }
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region ComboBox
        public void FillCB(ref ClsCargo obCargo)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "cargos",
                NameSP = "SP_Cargos_CB",
                Escalar = false,
            };
            ExecuteC(ref obCargo);
        }
        #endregion

        #region CRUD Usuarios
        //Crea nuevo usuario con procedimiento almacenado "InsertarUsu"
        public void Create(ref ClsUsuario obUsu, ref ClsCargo objCargo)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "usuarios",
                NameSP = "SP_InsertarUsu",
                Escalar = true,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@nombre", "17", obUsu.Nombre);
            ObjDatabase.DtParameters.Rows.Add(@"@apellido", "17", obUsu.Apellido);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", obUsu.Carnet);
            ObjDatabase.DtParameters.Rows.Add(@"@correo", "17", obUsu.Correo);
            ObjDatabase.DtParameters.Rows.Add(@"@contrasenia", "17", obUsu.Contraseña);
            ObjDatabase.DtParameters.Rows.Add(@"@cargo", "17", objCargo.NombreCargo);


            ExecuteCom(ref obUsu, ref objCargo);
        }

        public void Update(ref ClsUsuario obUsu, ref ClsCargo objCargo)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "usuarios",
                NameSP = "SP_UpdateUsu",
                Escalar = true,
            };
            ObjDatabase.DtParameters.Rows.Add(@"@nombre", "17", obUsu.Nombre);
            ObjDatabase.DtParameters.Rows.Add(@"@apellido", "17", obUsu.Apellido);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", obUsu.Carnet);
            ObjDatabase.DtParameters.Rows.Add(@"@correo", "17", obUsu.Correo);
            ObjDatabase.DtParameters.Rows.Add(@"@contrasenia", "17", obUsu.Contraseña);
            ObjDatabase.DtParameters.Rows.Add(@"@cargo", "17", objCargo.NombreCargo);


            ExecuteCom(ref obUsu, ref objCargo);
        }

        public void Delete(ref ClsUsuario obUsu)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "usuarios",
                NameSP = "SP_DeleteUsu",
                Escalar = true,
            };
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", obUsu.Carnet);
            Execute(ref obUsu);
        }

        #endregion

        #region Métodos privados
        private void ExecuteC(ref ClsCargo objcar)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objcar.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objcar.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objcar.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objcar.DtResults.Rows)
                        {
                            objcar.IdCargo = (int)Convert.ToInt64(item["id_cargo"].ToString());
                            objcar.NombreCargo = item["nombre_cargo"].ToString();
                        }
                    }
                }
            }
            else
            {
                objcar.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        private void ExecuteCom(ref ClsUsuario objUsu, ref ClsCargo objcargo)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objUsu.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objUsu.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objUsu.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objUsu.DtResults.Rows)
                        {
                            objUsu.Id_usuario = (int)Convert.ToInt64(item["id_usuario"].ToString());
                            objUsu.Id_cargo = (int)Convert.ToInt64(item["id_cargo"].ToString());
                            objUsu.Apellido = item["apellido"].ToString();
                            objUsu.Nombre = item["nombre"].ToString();
                            objUsu.Contraseña = item["contrasenia"].ToString();
                            objUsu.Carnet = item["carnet"].ToString();
                            objUsu.Correo = item["correo"].ToString();
                        }
                    }
                }
            }
            else
            {
                objUsu.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }

        private void Execute(ref ClsUsuario objUsu)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objUsu.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objUsu.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objUsu.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objUsu.DtResults.Rows)
                        {
                            objUsu.Id_usuario = (int)Convert.ToInt64(item["ID"].ToString());
                            objUsu.Id_cargo = (int)Convert.ToInt64(item["ID_Cargo"].ToString());
                            objUsu.Apellido = item["Apellido"].ToString();
                            objUsu.Nombre = item["Nombre"].ToString();
                            objUsu.Carnet = item["Carnet"].ToString();
                            objUsu.Correo = item["Correo"].ToString();
                        }                        
                    }
                }
            }
            else
            {
                objUsu.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }

        private void ExecuteLogin(ref ClsUsuario objUsu)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objUsu.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objUsu.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objUsu.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objUsu.DtResults.Rows)
                        {
                            objUsu.Id_cargo = (int)Convert.ToInt64(item["Cargo"].ToString());
                            objUsu.Apellido = item["Apellido"].ToString();
                            objUsu.Nombre = item["Nombre"].ToString();
                            
                        }

                        Global.nombre_usuario = objUsu.Nombre + " " + objUsu.Apellido;
                        Global.carnet_usuario = objUsu.Carnet;
                    }
                }
            }
            else
            {
                objUsu.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        #endregion
    }
}
