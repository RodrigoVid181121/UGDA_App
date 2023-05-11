using AccesoDatos.DB;
using Entidades.Series;
using Entidades.Subseries;
using System;
using System.Data;

namespace LogicaNegocios.Series
{
    public class ClsSeriesLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index
        public void Index(ref ClsSerie objSer)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "series",
                NameSP = "SP_ReadSer",
                Escalar = false,
            };
            Execute(ref objSer);
        }

        public void ListarSecciones(ref ClsSerie objSer)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "series",
                NameSP = "SP_ListSec",
                Escalar = false,
            };
            Execute(ref objSer);
        }

        public void ListarSeries(ref ClsSerie objSub)
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

        public void Create(ref ClsSerie objSerie)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "series",
                NameSP = "SP_InsertarSer",
                Escalar = true,
            };
            
            ObjDatabase.DtParameters.Rows.Add(@"@idSeccion", "4", objSerie.Idseccion);
            ObjDatabase.DtParameters.Rows.Add(@"@nombreSerie", "17", objSerie.Nombre_serie);
            Execute(ref objSerie);
        }

        public void Update(ref ClsSerie objSerie)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "series",
                NameSP = "SP_UpdateSer",
                Escalar = true,
            };

            ObjDatabase.DtParameters.Rows.Add(@"@idSerie", "4", objSerie.Idserie);
            ObjDatabase.DtParameters.Rows.Add(@"@idSeccion", "4", objSerie.Idseccion);
            ObjDatabase.DtParameters.Rows.Add(@"@nombreSerie", "17", objSerie.Nombre_serie);
            Execute(ref objSerie);
        }

        #endregion

        #region Métodos privados
        private void Execute(ref ClsSerie objSer)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objSer.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objSer.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objSer.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objSer.DtResults.Rows)
                        {
                            objSer.Idserie = (int)Convert.ToInt64(item["ID"].ToString());
                            objSer.Nombre_serie = item["Serie"].ToString();
                            objSer.Nombre_serie = item["Sección"].ToString();
                            objSer.Idseccion = (int)Convert.ToInt64(item["id_seccion"].ToString());
                        }
                    }
                }
            }
            else
            {
                objSer.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        #endregion
    }
}
