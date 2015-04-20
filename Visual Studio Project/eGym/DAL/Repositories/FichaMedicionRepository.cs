using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Transactions;
/// <summary>
/// Fecha de creación: 04/02/2015
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación:  04/02/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>

namespace DAL.Repositories
{
    public class FichaMedicionRepository : IRepository<FichaMedicion>
    {
        /// <summary>
        /// Lista de entidades para registrar.
        /// </summary>
        private List<IEntity> _insertItems;

        /// <summary>
        /// Lista de entidades para eliminar.
        /// </summary>
        private List<IEntity> _deleteItems;

        /// <summary>
        /// Lista de entidades para modificar.
        /// </summary>
        private List<IEntity> _updateItems;

        /// <summary>
        /// Inicializa una nueva instancia de clase <ver cref="FichaMedicionRepository"/>.
        /// </summary>
        public FichaMedicionRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        /// <summary>
        /// Inserta la entidad a la lista de _insertItems.
        /// </summary>
        /// <param name="entity">Instancia de ficha de medición.</param>
        public void Insert(FichaMedicion entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _deleteItems.
        /// </summary>
        /// <param name="entity">Instancia de ficha de medición.</param>
        public void Delete(FichaMedicion entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Inserta la entidad a la lista de _updateItems.
        /// </summary>
        /// <param name="entity">Instancia de ficha de medición.</param>
        public void Update(FichaMedicion entity)
        {
            _updateItems.Add(entity);
        }

        /// <summary>
        /// Lista cada una de las instancias de ficha de medición.
        /// </summary>
        /// <returns>
        /// Devuelve una lista de tipo IEnumerable<FichaMedicion>.
        /// </returns>
        public IEnumerable<FichaMedicion> GetAll()
        {
            List<FichaMedicion> listaFichaMedicion = null;

            SqlCommand cmd = new SqlCommand();

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarFichasDeMedicion");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaFichaMedicion = new List<FichaMedicion>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        listaFichaMedicion.Add(new FichaMedicion
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Cliente = Convert.ToInt32(dr["CLIENTE"]),
                            FechaCreacion = Convert.ToDateTime(dr["FECHA"]),
                            Peso = decimal.Parse(Convert.ToString(dr["PESO"])),
                            Altura = decimal.Parse(Convert.ToString(dr["ALTURA"])),
                            Imc = decimal.Parse(Convert.ToString(dr["IMC"])),
                            ClasificacionIMC = dr["CLASIFICACION_IMC"].ToString(),
                            PorcentajeGrasaCorporal = decimal.Parse(Convert.ToString(dr["PORCENTAJE_GRASA_CORPORAL"])),
                            PorcentajeMasaMuscular = decimal.Parse(Convert.ToString(dr["PORCENTAJE_MASA_MUSCULAR"])),
                            PesoGraso = decimal.Parse(Convert.ToString(dr["PESO_GRASO"])),
                            PerCintura = decimal.Parse(Convert.ToString(dr["PER_CINTURA"])),
                            PerCadera = decimal.Parse(Convert.ToString(dr["PER_CADERA"])),
                            PerAbdomen = decimal.Parse(Convert.ToString(dr["PER_ABDOMEN"])),
                            PerPecho = decimal.Parse(Convert.ToString(dr["PER_PECHO"])),
                            PerEspalda = decimal.Parse(Convert.ToString(dr["PER_ESPALDA"])),
                            PerMusloIzquierdo = decimal.Parse(Convert.ToString(dr["PER_MUSLO_IZQ"])),
                            PerMusloDerecho = decimal.Parse(Convert.ToString(dr["PER_MUSLO_DER"])),
                            PerBicepsIzquierdo = decimal.Parse(Convert.ToString(dr["PER_BICEPS_IZQ"])),
                            PerBicepsDerecho = decimal.Parse(Convert.ToString(dr["PER_BICEPS_DER"])),
                            PerBicepsIzqContraido = decimal.Parse(Convert.ToString(dr["PER_BICEPS_IZQ_CONTRAIDO"])),
                            PerBicepsDerContraido = decimal.Parse(Convert.ToString(dr["PER_BICEPS_DER_CONTRAIDO"])),
                            PerPantorrillaIzquierda = decimal.Parse(Convert.ToString(dr["PER_PANTORRILLA_IZQ"])),
                            PerPantorrillaDerecha = decimal.Parse(Convert.ToString(dr["PER_PANTORRILLA_DER"])),
                            PliAbdominalIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_ABDOMINAL_IZQ"])),
                            PliAbdominalDerecho = decimal.Parse(Convert.ToString(dr["PLI_ABDOMINAL_DER"])),
                            PliMusloIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_MUSLO_IZQ"])),
                            PliMusloDerecho = decimal.Parse(Convert.ToString(dr["PLI_MUSLO_DERECHO"])),
                            PliTricepsIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_TRICEPS_IZQ"])),
                            PliTricepsDerecho = decimal.Parse(Convert.ToString(dr["PLI_TRICEPS_DER"])),
                            PliSubescapularIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_IZQ"])),
                            PliSubescapularDerecho = decimal.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_DER"])),
                            PliSupraespinalIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_IZQ"])),
                            PliSupraespinalDerecho = decimal.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_DER"])),
                            PliPantorrillaIzquierda = decimal.Parse(Convert.ToString(dr["PLI_PANTORRILLA_IZQ"])),
                            PliPantorrillaDerecha = decimal.Parse(Convert.ToString(dr["PLI_PANTORRILLA_DER"])),
                        });
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return listaFichaMedicion;
        }

        /// <summary>
        /// Obtiene una instancia de ficha de medición por su Id.
        /// </summary>
        /// <param name="pId">Id de la ficha de medición.</param>
        /// <returns>
        /// Devuelve la instancia de la ficha de medición.
        /// </returns>
        public FichaMedicion GetById(int pId)
        {

            FichaMedicion fichaMedicion = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ObtenerFichaDeMedicionPorId");

                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        fichaMedicion = new FichaMedicion
                        {
                            Id = Convert.ToInt32(dr["ID"]),
                            Cliente = Convert.ToInt32(dr["CLIENTE"]),
                            FechaCreacion = Convert.ToDateTime(dr["FECHA"]),
                            Peso = decimal.Parse(Convert.ToString(dr["PESO"])),
                            Altura = decimal.Parse(Convert.ToString(dr["ALTURA"])),
                            Imc = decimal.Parse(Convert.ToString(dr["IMC"])),
                            ClasificacionIMC = dr["CLASIFICACION_IMC"].ToString(),
                            PorcentajeGrasaCorporal = decimal.Parse(Convert.ToString(dr["PORCENTAJE_GRASA_CORPORAL"])),
                            PorcentajeMasaMuscular = decimal.Parse(Convert.ToString(dr["PORCENTAJE_MASA_MUSCULAR"])),
                            PesoGraso = decimal.Parse(Convert.ToString(dr["PESO_GRASO"])),
                            PerCintura = decimal.Parse(Convert.ToString(dr["PER_CINTURA"])),
                            PerCadera = decimal.Parse(Convert.ToString(dr["PER_CADERA"])),
                            PerAbdomen = decimal.Parse(Convert.ToString(dr["PER_ABDOMEN"])),
                            PerPecho = decimal.Parse(Convert.ToString(dr["PER_PECHO"])),
                            PerEspalda = decimal.Parse(Convert.ToString(dr["PER_ESPALDA"])),
                            PerMusloIzquierdo = decimal.Parse(Convert.ToString(dr["PER_MUSLO_IZQ"])),
                            PerMusloDerecho = decimal.Parse(Convert.ToString(dr["PER_MUSLO_DER"])),
                            PerBicepsIzquierdo = decimal.Parse(Convert.ToString(dr["PER_BICEPS_IZQ"])),
                            PerBicepsDerecho = decimal.Parse(Convert.ToString(dr["PER_BICEPS_DER"])),
                            PerBicepsIzqContraido = decimal.Parse(Convert.ToString(dr["PER_BICEPS_IZQ_CONTRAIDO"])),
                            PerBicepsDerContraido = decimal.Parse(Convert.ToString(dr["PER_BICEPS_DER_CONTRAIDO"])),
                            PerPantorrillaIzquierda = decimal.Parse(Convert.ToString(dr["PER_PANTORRILLA_IZQ"])),
                            PerPantorrillaDerecha = decimal.Parse(Convert.ToString(dr["PER_PANTORRILLA_DER"])),
                            PliAbdominalIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_ABDOMINAL_IZQ"])),
                            PliAbdominalDerecho = decimal.Parse(Convert.ToString(dr["PLI_ABDOMINAL_DER"])),
                            PliMusloIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_MUSLO_IZQ"])),
                            PliMusloDerecho = decimal.Parse(Convert.ToString(dr["PLI_MUSLO_DERECHO"])),
                            PliTricepsIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_TRICEPS_IZQ"])),
                            PliTricepsDerecho = decimal.Parse(Convert.ToString(dr["PLI_TRICEPS_DER"])),
                            PliSubescapularIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_IZQ"])),
                            PliSubescapularDerecho = decimal.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_DER"])),
                            PliSupraespinalIzquierdo = decimal.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_IZQ"])),
                            PliSupraespinalDerecho = decimal.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_DER"])),
                            PliPantorrillaIzquierda = decimal.Parse(Convert.ToString(dr["PLI_PANTORRILLA_IZQ"])),
                            PliPantorrillaDerecha = decimal.Parse(Convert.ToString(dr["PLI_PANTORRILLA_DER"])),
                        };
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return fichaMedicion;
        }

        /// <summary>
        /// Guarda los cambios.
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (FichaMedicion objFichaMedicion in _insertItems)
                        {
                            InsertFichaMedicion(objFichaMedicion);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (FichaMedicion p in _updateItems)
                        {
                            UpdateFichaMedicion(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (FichaMedicion p in _deleteItems)
                        {
                            DeleteFichaMedicion(p);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }
            }
        }

        /// <summary>
        /// Limpia las listas de insert, delete y update.
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        /// <summary>
        /// Registra una instancia de ficha de medición.
        /// </summary>
        /// <param name="objFichaMedicion">Objeto ficha de medición.</param>
        private void InsertFichaMedicion(FichaMedicion objFichaMedicion)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pCliente", objFichaMedicion.Cliente));
                cmd.Parameters.Add(new SqlParameter("@pFechaCreacion", objFichaMedicion.FechaCreacion));
                cmd.Parameters.Add(new SqlParameter("@pAltura", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pImc", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@ClasificacionIMC", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeGrasaCorporal", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeMasaMuscular", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPesoGraso", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerCintura", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerCadera", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerAbdomen", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerEspalda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzqContraido", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerContraido", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaIzquierda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaDerecha", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaIzquierda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaDerecha", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalDerecho", objFichaMedicion.Peso));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarFichaDeMedicion");

            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// Modifica una instancia de ficha de medición.
        /// </summary>
        /// <param name="objFichaMedicion">Objecto ficha de medición.</param>
        private void UpdateFichaMedicion(FichaMedicion objFichaMedicion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objFichaMedicion.Id));
                cmd.Parameters.Add(new SqlParameter("@pCliente", objFichaMedicion.Cliente));
                cmd.Parameters.Add(new SqlParameter("@pFechaCreacion", objFichaMedicion.FechaCreacion));
                cmd.Parameters.Add(new SqlParameter("@pAltura", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pImc", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@ClasificacionIMC", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeGrasaCorporal", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeMasaMuscular", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPesoGraso", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzqContraido", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerContraido", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaIzquierda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaDerecha", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerCintura", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerAbdomen", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerCadera", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerPecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPerEspalda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloIzquierdo", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloDerecho", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaIzquierda", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaDerecha", objFichaMedicion.Peso));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarFichaDeMedicion");

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Elimina una instancia de ficha de medición.
        /// </summary>
        /// <param name="objFichaMedicion">Objecto ficha de medición.</param>
        private void DeleteFichaMedicion(FichaMedicion objFichaMedicion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objFichaMedicion.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarFichaDeMedicion");

            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

    }
}
