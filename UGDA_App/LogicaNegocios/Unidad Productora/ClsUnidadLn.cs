using AccesoDatos.DB;
using Entidades.Series;
using Entidades.UnidadesProductoras;
using System.Data;
using System;

namespace LogicaNegocios.Unidad_Productora
{
    public class ClsUnidadLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase;
        #endregion
        #region index
        public void ListarUnidades(ref ClsUnidadProductora objUnidad)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "subseries",
                NameSP = "SP_ListUn",
                Escalar = false,
            };
            Execute(ref objUnidad);
        }
        #endregion
        #region Métodos privados
        private void Execute(ref ClsUnidadProductora objSer)
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
                            objSer.Id_unidad_productora = (int)Convert.ToInt64(item["ID"].ToString());
                            objSer.Nombre_unidad_productora = item["Nombre"].ToString();
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
