using AccesoDatos.DB;
using Entidades.Documentos;
using Entidades.Subseries;
using Entidades.UnidadesProductoras;
using Entidades.Usuarios;
using System;
using System.Data;

namespace LogicaNegocios.Documentos
{
    public class ClsDocumentLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase = null;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index
        public void Index(ref ClsDocument obDoc)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "documentos",
                NameSP = "SP_Docs_Index",
                Escalar = false,
            };
            Execute(ref obDoc);
        }
        #endregion

        #region CRUD Documentos

        public void Create(ref ClsDocument obDoc, ref ClsUnidadProductora objUnidad, ref ClsUsuario objUsuario, ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "Documents",
                NameSP = "SP_InsertarDoc",
                Escalar = true,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@descripcion", "17", obDoc.Descripcion);
            ObjDatabase.DtParameters.Rows.Add(@"@año", "16", obDoc.Año);
            ObjDatabase.DtParameters.Rows.Add(@"@ubicacion", "17", obDoc.Ubicación);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", objUsuario.Carnet);
            ObjDatabase.DtParameters.Rows.Add(@"@unidad", "17", objUnidad.Nombre_unidad_productora);
            ObjDatabase.DtParameters.Rows.Add(@"@subs", "17", objSub.Nombresubserie);
            Execute(ref obDoc);
        }

        public void Update(ref ClsDocument obDoc, ref ClsUnidadProductora objUnidad, ref ClsUsuario objUsuario, ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "Documents",
                NameSP = "SP_UpdateDoc",
                Escalar = true,
            };
            ObjDatabase.DtParameters.Rows.Add(@"@codigodoc", "16", obDoc.CodigoDoc);
            ObjDatabase.DtParameters.Rows.Add(@"@descripcion", "17", obDoc.Descripcion);
            ObjDatabase.DtParameters.Rows.Add(@"@año", "16", obDoc.Año);
            ObjDatabase.DtParameters.Rows.Add(@"@ubicacion", "17", obDoc.Ubicación);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", objUsuario.Carnet);
            ObjDatabase.DtParameters.Rows.Add(@"@unidad", "17", objUnidad.Nombre_unidad_productora);
            ObjDatabase.DtParameters.Rows.Add(@"@subs", "17", objSub.Nombresubserie);

            Execute(ref obDoc);
        }

        public void Delete(ref ClsDocument obDoc, ref ClsUsuario objUser)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "Documents",
                NameSP = "SP_DeleteDoc",
                Escalar = true,
            };
            ObjDatabase.DtParameters.Rows.Add(@"@codigodoc", "16", obDoc.CodigoDoc);
            ObjDatabase.DtParameters.Rows.Add(@"@carnet", "16", objUser.Carnet);
            Execute(ref obDoc);
        }

        #endregion

        #region Métodos privados
        private void Execute(ref ClsDocument objDoc)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if(ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objDoc.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objDoc.DtResults = ObjDatabase.DsResults.Tables[0];
                    if(objDoc.DtResults.Rows.Count == 1) 
                    {
                        foreach(DataRow item in objDoc.DtResults.Rows) 
                        {
                            objDoc.IdDocs = (int)Convert.ToInt64(item["ID"].ToString());
                            objDoc.IdSubSerie = (int)Convert.ToInt64(item["IDSS"].ToString());
                            objDoc.IdUnidad = (int)Convert.ToInt64(item["UDP"].ToString());
                            objDoc.IdUsuario = (int)Convert.ToInt64(item["IDUS"].ToString());
                            objDoc.CodigoDoc = item["Codigo"].ToString();
                            objDoc.Descripcion = item["Descripción"].ToString();
                            objDoc.Año = item["Año"].ToString();
                            objDoc.Ubicación = item["Ubicación"].ToString();
                        }
                    }
                }
            }
            else
            {
                objDoc.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        #endregion
    }
}
