using AccesoDatos.DB;
using Entidades.Series;
using Entidades.Subseries;
using System;
using System.Data;


namespace LogicaNegocios.Subseries
{
    public class ClsSubseriesLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index
        public void Index(ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "subseries",
                NameSP = "SP_ReadSubs",
                Escalar = false,
            };
            Execute(ref objSub);
        }

        public void ListarSeries(ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "subseries",
                NameSP = "SP_ListSer",
                Escalar = false,
            };
            Execute(ref objSub);
        }
        #endregion

        #region CRUD Documentos

        public void Create(ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "subseries",
                NameSP = "SP_InsertarSubs",
                Escalar = true,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@idSerie", "4", objSub.Idserie);
            ObjDatabase.DtParameters.Rows.Add(@"@nombreSubserie", "17", objSub.Nombresubserie);
            ObjDatabase.DtParameters.Rows.Add(@"@codigoSubserie", "16", objSub.Codigosubserie);
            Execute(ref objSub);
        }

        public void Update(ref ClsSubSerie objSub)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "subseries",
                NameSP = "SP_UpdateSubs",
                Escalar = true,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@idSerie", "4", objSub.Idserie);
            ObjDatabase.DtParameters.Rows.Add(@"@nombreSubserie", "17", objSub.Nombresubserie);
            ObjDatabase.DtParameters.Rows.Add(@"@codigoSubserie", "16", objSub.Codigosubserie);
            ObjDatabase.DtParameters.Rows.Add(@"@idSubserie", "4", objSub.Idsubserie);
            Execute(ref objSub);
        }

        #endregion

        #region Métodos privados
        private void Execute(ref ClsSubSerie objSub)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objSub.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objSub.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objSub.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objSub.DtResults.Rows)
                        {

                            objSub.Idsubserie = (int)Convert.ToInt64(item["ID"].ToString());
                            objSub.Nombresubserie = item["Subserie"].ToString();
                            objSub.Codigosubserie = item["Codigo"].ToString();
                            objSub.Codigosubserie = item["Serie"].ToString();
                            objSub.Idserie = (int)Convert.ToInt64(item["ss.id_serie"].ToString());

                        }
                    }
                }
            }
            else
            {
                objSub.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        #endregion
    }
}
