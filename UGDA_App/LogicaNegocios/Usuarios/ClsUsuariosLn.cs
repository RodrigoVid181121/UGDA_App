using AccesoDatos.DB;
using Entidades.Documentos;
using Entidades.Subseries;
using Entidades.UnidadesProductoras;
using Entidades.Usuarios;
using Entidades.Cargos;
using System;
using System.Data;

namespace LogicaNegocios.Usuarios
{
    internal class ClsUsuariosLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase = null;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index
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
        #endregion

<<<<<<< Updated upstream
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
=======
        ////método index se utiliza para listar información y mostrarla en pantalla
        //#region ComboBox
        //public void FillCB(ref ClsCargos obCargo)
        //{
        //    ObjDatabase = new ClsDatabase()
        //    {
        //        TableName = "cargos",
        //        NameSP = "SP_Cargos_CB",
        //        Escalar = false,
        //    };
        //    ExecuteC(ref obCargo);
        //}
        //#endregion
>>>>>>> Stashed changes

        #region CRUD Documentos
        //Crea nuevo usuario con procedimiento almacenado "InsertarUsu"
        public void Create(ref ClsUsuario obUsu)
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
            ObjDatabase.DtParameters.Rows.Add(@"@correo", "16", obUsu.Correo);
            ObjDatabase.DtParameters.Rows.Add(@"@contrasenia", "16", obUsu.Contraseña);


            Execute(ref obUsu);
        }

        //public void Read(ref ClsUsuario obUsu)
        //{
        //    ObjDatabase = new ClsDatabase()
        //    {
        //        TableName = "usuarios",
        //        NameSP = "[].[SP_Docs_Read]",
        //        Escalar = false,
        //    };
        //    ObjDatabase.DtParameters.Rows.Add(@"@id_documento", "4", obUsu.IdDocs);
        //    Execute(ref obUsu);
        //}

        public void Update(ref ClsUsuario obUsu)
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
            ObjDatabase.DtParameters.Rows.Add(@"@correo", "16", obUsu.Correo);
            ObjDatabase.DtParameters.Rows.Add(@"@contrasenia", "16", obUsu.Contraseña);


            Execute(ref obUsu);
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
                            objcar.Id_cargo = (int)Convert.ToInt64(item["id_cargo"].ToString());                          
                            objcar.Nombre_Cargo = item["nombre_cargo"].ToString();
                        }
                    }
                }
            }
            else
            {
                objcar.ErrorMessage = ObjDatabase.ErrorMessageDB;
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
        #endregion
    }
}