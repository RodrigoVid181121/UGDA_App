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
                NameSP = "InsertarDoc",
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

        public void Read(ref ClsDocument obDoc)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "Documents",
                NameSP = "[].[SP_Docs_Read]",
                Escalar = false,
            };
            ObjDatabase.DtParameters.Rows.Add(@"@id_documento", "4", obDoc.IdDocs);
            Execute(ref obDoc);
        }

        public void Update(ref ClsDocument obDoc, ref ClsUnidadProductora objUnidad, ref ClsUsuario objUsuario, ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "Documents",
                NameSP = "UpdateDoc",
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
                NameSP = "DeleteDoc",
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
                            objDoc.IdDocs = (int)Convert.ToInt64(item["id_documento"].ToString());
                            objDoc.IdSubSerie = (int)Convert.ToInt64(item["id_subserie"].ToString());
                            objDoc.IdUnidad = (int)Convert.ToInt64(item["id_unidad_productora"].ToString());
                            objDoc.IdUsuario = (int)Convert.ToInt64(item["id_usuario"].ToString());
                            objDoc.CodigoDoc = item["codigo_documento"].ToString();
                            objDoc.Descripcion = item["descripcion"].ToString();
                            objDoc.Año = item["anio"].ToString();
                            objDoc.Ubicación = item["ubicacion"].ToString();
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
