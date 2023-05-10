using AccesoDatos.DB;
using Entidades.Bitacora;
using Entidades.Subseries;
using System;
using System.Data;

namespace LogicaNegocios.Bitacora
{
    public class ClsBitacoraLn
    {
        #region variables Privadas
        private ClsDatabase ObjDatabase;
        #endregion

        //método index se utiliza para listar información y mostrarla en pantalla
        #region index
        public void Index(ref ClsBitacora objBit)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "bitacora",
                NameSP = "SP_ReadBita",
                Escalar = false,
            };
            Execute(ref objBit);
        }

        public void Delete(ref ClsBitacora objBit)
        {
            ObjDatabase = new ClsDatabase()
            {
                TableName = "bitacora",
                NameSP = "SP_DeleteBita",
                Escalar = true,
            };
            Execute(ref objBit);
        }
        #endregion

        #region Métodos privados
        private void Execute(ref ClsBitacora objBit)
        {

            ObjDatabase.CRUD(ref ObjDatabase);

            if (ObjDatabase.ErrorMessageDB == null)
            {
                if (ObjDatabase.Escalar)
                {
                    objBit.ScalarValue = ObjDatabase.EscalarValue;
                }
                else
                {
                    objBit.DtResults = ObjDatabase.DsResults.Tables[0];
                    if (objBit.DtResults.Rows.Count == 1)
                    {
                        foreach (DataRow item in objBit.DtResults.Rows)
                        {
                            objBit.Evento = item["Evento"].ToString();
                            objBit.Tipo = item["Tipo"].ToString();
                            objBit.Hostame = item["Computadora"].ToString();
                            objBit.Fecha = item["Fecha"].ToString();
                            objBit.Subserie = item["Subserie"].ToString();
                            objBit.Unidad = item["Unidad"].ToString();
                            objBit.Usuario = item["Usuario"].ToString();
                            objBit.Codigodoc = item["ID"].ToString();
                            objBit.Descripcion = item["Descripción"].ToString();
                            objBit.Anio = item["Año"].ToString();
                            objBit.Ubicacion = item["Ubicación"].ToString();
                        }
                    }
                }
            }
            else
            {
                objBit.ErrorMessage = ObjDatabase.ErrorMessageDB;
            }
        }
        #endregion
    }
}