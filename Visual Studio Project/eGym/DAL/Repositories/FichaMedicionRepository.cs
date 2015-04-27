﻿using System;
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
                            Peso = float.Parse(Convert.ToString(dr["PESO"])),
                            Altura = float.Parse(Convert.ToString(dr["ALTURA"])),
                            Imc = float.Parse(Convert.ToString(dr["IMC"])),
                            ClasificacionIMC = dr["CLASIFICACION_IMC"].ToString(),
                            PorcentajeGrasaCorporal = float.Parse(Convert.ToString(dr["PORCENTAJE_GRASA_CORPORAL"])),
                            PorcentajeMasaMuscular = float.Parse(Convert.ToString(dr["PORCENTAJE_MASA_MUSCULAR"])),
                            PesoGraso = float.Parse(Convert.ToString(dr["PESO_GRASO"])),
                            PerCintura = float.Parse(Convert.ToString(dr["PER_CINTURA"])),
                            PerCadera = float.Parse(Convert.ToString(dr["PER_CADERA"])),
                            PerAbdomen = float.Parse(Convert.ToString(dr["PER_ABDOMEN"])),
                            PerPecho = float.Parse(Convert.ToString(dr["PER_PECHO"])),
                            PerEspalda = float.Parse(Convert.ToString(dr["PER_ESPALDA"])),
                            PerMusloIzquierdo = float.Parse(Convert.ToString(dr["PER_MUSLO_IZQ"])),
                            PerMusloDerecho = float.Parse(Convert.ToString(dr["PER_MUSLO_DER"])),
                            PerBicepsIzquierdo = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ"])),
                            PerBicepsDerecho = float.Parse(Convert.ToString(dr["PER_BICEPS_DER"])),
                            PerBicepsIzqContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ_CONTRAIDO"])),
                            PerBicepsDerContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_DER_CONTRAIDO"])),
                            PerPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_IZQ"])),
                            PerPantorrillaDerecha = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_DER"])),
                            PliAbdominalIzquierdo = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_IZQ"])),
                            PliAbdominalDerecho = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_DER"])),
                            PliMusloIzquierdo = float.Parse(Convert.ToString(dr["PLI_MUSLO_IZQ"])),
                            PliMusloDerecho = float.Parse(Convert.ToString(dr["PLI_MUSLO_DER"])),
                            PliPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_IZQ"])),
                            PliPantorrillaDerecha = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_DER"])),
                            PliTricepsIzquierdo = float.Parse(Convert.ToString(dr["PLI_TRICEPS_IZQ"])),
                            PliTricepsDerecho = float.Parse(Convert.ToString(dr["PLI_TRICEPS_DER"])),
                            PliSubescapularIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_IZQ"])),
                            PliSubescapularDerecho = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_DER"])),
                            PliSupraespinalIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_IZQ"])),
                            PliSupraespinalDerecho = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_DER"])),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
                            Peso = float.Parse(Convert.ToString(dr["PESO"])),
                            Altura = float.Parse(Convert.ToString(dr["ALTURA"])),
                            Imc = float.Parse(Convert.ToString(dr["IMC"])),
                            ClasificacionIMC = dr["CLASIFICACION_IMC"].ToString(),
                            PorcentajeGrasaCorporal = float.Parse(Convert.ToString(dr["PORCENTAJE_GRASA_CORPORAL"])),
                            PorcentajeMasaMuscular = float.Parse(Convert.ToString(dr["PORCENTAJE_MASA_MUSCULAR"])),
                            PesoGraso = float.Parse(Convert.ToString(dr["PESO_GRASO"])),
                            PerCintura = float.Parse(Convert.ToString(dr["PER_CINTURA"])),
                            PerCadera = float.Parse(Convert.ToString(dr["PER_CADERA"])),
                            PerAbdomen = float.Parse(Convert.ToString(dr["PER_ABDOMEN"])),
                            PerPecho = float.Parse(Convert.ToString(dr["PER_PECHO"])),
                            PerEspalda = float.Parse(Convert.ToString(dr["PER_ESPALDA"])),
                            PerMusloIzquierdo = float.Parse(Convert.ToString(dr["PER_MUSLO_IZQ"])),
                            PerMusloDerecho = float.Parse(Convert.ToString(dr["PER_MUSLO_DER"])),
                            PerBicepsIzquierdo = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ"])),
                            PerBicepsDerecho = float.Parse(Convert.ToString(dr["PER_BICEPS_DER"])),
                            PerBicepsIzqContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ_CONTRAIDO"])),
                            PerBicepsDerContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_DER_CONTRAIDO"])),
                            PerPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_IZQ"])),
                            PerPantorrillaDerecha = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_DER"])),
                            PliAbdominalIzquierdo = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_IZQ"])),
                            PliAbdominalDerecho = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_DER"])),
                            PliMusloIzquierdo = float.Parse(Convert.ToString(dr["PLI_MUSLO_IZQ"])),
                            PliMusloDerecho = float.Parse(Convert.ToString(dr["PLI_MUSLO_DER"])),
                            PliPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_IZQ"])),
                            PliPantorrillaDerecha = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_DER"])),
                            PliTricepsIzquierdo = float.Parse(Convert.ToString(dr["PLI_TRICEPS_IZQ"])),
                            PliTricepsDerecho = float.Parse(Convert.ToString(dr["PLI_TRICEPS_DER"])),
                            PliSubescapularIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_IZQ"])),
                            PliSubescapularDerecho = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_DER"])),
                            PliSupraespinalIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_IZQ"])),
                            PliSupraespinalDerecho = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_DER"])),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
                cmd.Parameters.Add(new SqlParameter("@pPeso", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pAltura", objFichaMedicion.Altura));
                cmd.Parameters.Add(new SqlParameter("@pImc", objFichaMedicion.Imc));
                cmd.Parameters.Add(new SqlParameter("@ClasificacionIMC", objFichaMedicion.ClasificacionIMC));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeGrasaCorporal", objFichaMedicion.PorcentajeGrasaCorporal));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeMasaMuscular", objFichaMedicion.PorcentajeMasaMuscular));
                cmd.Parameters.Add(new SqlParameter("@pPesoGraso", objFichaMedicion.PesoGraso));
                cmd.Parameters.Add(new SqlParameter("@pPerCintura", objFichaMedicion.PerCintura));
                cmd.Parameters.Add(new SqlParameter("@pPerCadera", objFichaMedicion.PerCadera));
                cmd.Parameters.Add(new SqlParameter("@pPerAbdomen", objFichaMedicion.PerAbdomen));
                cmd.Parameters.Add(new SqlParameter("@pPerPecho", objFichaMedicion.PerPecho));
                cmd.Parameters.Add(new SqlParameter("@pPerEspalda", objFichaMedicion.PerEspalda));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloIzquierdo", objFichaMedicion.PerMusloIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloDerecho", objFichaMedicion.PerMusloDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzquierdo", objFichaMedicion.PerBicepsIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerecho", objFichaMedicion.PerBicepsDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzqContraido", objFichaMedicion.PerBicepsIzqContraido));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerContraido", objFichaMedicion.PerBicepsDerContraido));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaIzquierda", objFichaMedicion.PerPantorrillaIzquierda));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaDerecha", objFichaMedicion.PerPantorrillaDerecha));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalIzquierdo", objFichaMedicion.PliAbdominalIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalDerecho", objFichaMedicion.PliAbdominalDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloIzquierdo", objFichaMedicion.PliMusloIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloDerecho", objFichaMedicion.PliMusloDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaIzquierda", objFichaMedicion.PliPantorrillaIzquierda));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaDerecha", objFichaMedicion.PliPantorrillaDerecha));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsIzquierdo", objFichaMedicion.PliTricepsIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsDerecho", objFichaMedicion.PliTricepsDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularIzquierdo", objFichaMedicion.PliSubescapularIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularDerecho", objFichaMedicion.PliSubescapularDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalIzquierdo", objFichaMedicion.PliSupraespinalIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalDerecho", objFichaMedicion.PliSupraespinalDerecho));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objFichaMedicion.Habilitado));

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
                cmd.Parameters.Add(new SqlParameter("@pPeso", objFichaMedicion.Peso));
                cmd.Parameters.Add(new SqlParameter("@pAltura", objFichaMedicion.Altura));
                cmd.Parameters.Add(new SqlParameter("@pImc", objFichaMedicion.Imc));
                cmd.Parameters.Add(new SqlParameter("@ClasificacionIMC", objFichaMedicion.ClasificacionIMC));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeGrasaCorporal", objFichaMedicion.PorcentajeGrasaCorporal));
                cmd.Parameters.Add(new SqlParameter("@pPorcentajeMasaMuscular", objFichaMedicion.PorcentajeMasaMuscular));
                cmd.Parameters.Add(new SqlParameter("@pPesoGraso", objFichaMedicion.PesoGraso));
                cmd.Parameters.Add(new SqlParameter("@pPerCintura", objFichaMedicion.PerCintura));
                cmd.Parameters.Add(new SqlParameter("@pPerCadera", objFichaMedicion.PerCadera));
                cmd.Parameters.Add(new SqlParameter("@pPerAbdomen", objFichaMedicion.PerAbdomen));
                cmd.Parameters.Add(new SqlParameter("@pPerPecho", objFichaMedicion.PerPecho));
                cmd.Parameters.Add(new SqlParameter("@pPerEspalda", objFichaMedicion.PerEspalda));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloIzquierdo", objFichaMedicion.PerMusloIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPerMusloDerecho", objFichaMedicion.PerMusloDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzquierdo", objFichaMedicion.PerBicepsIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerecho", objFichaMedicion.PerBicepsDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsIzqContraido", objFichaMedicion.PerBicepsIzqContraido));
                cmd.Parameters.Add(new SqlParameter("@pPerBicepsDerContraido", objFichaMedicion.PerBicepsDerContraido));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaIzquierda", objFichaMedicion.PerPantorrillaIzquierda));
                cmd.Parameters.Add(new SqlParameter("@pPerPantorrillaDerecha", objFichaMedicion.PerPantorrillaDerecha));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalIzquierdo", objFichaMedicion.PliAbdominalIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliAbdominalDerecho", objFichaMedicion.PliAbdominalDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloIzquierdo", objFichaMedicion.PliMusloIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliMusloDerecho", objFichaMedicion.PliMusloDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaIzquierda", objFichaMedicion.PliPantorrillaIzquierda));
                cmd.Parameters.Add(new SqlParameter("@pPliPantorrillaDerecha", objFichaMedicion.PliPantorrillaDerecha));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsIzquierdo", objFichaMedicion.PliTricepsIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliTricepsDerecho", objFichaMedicion.PliTricepsDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularIzquierdo", objFichaMedicion.PliSubescapularIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliSubescapularDerecho", objFichaMedicion.PliSubescapularDerecho));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalIzquierdo", objFichaMedicion.PliSupraespinalIzquierdo));
                cmd.Parameters.Add(new SqlParameter("@pPliSupraespinalDerecho", objFichaMedicion.PliSupraespinalDerecho));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objFichaMedicion.Habilitado));

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

        public IEnumerable<FichaMedicion> GetAllByCliente(int pcliente)
        {
            List<FichaMedicion> listaFichaMedicion = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pCliente", pcliente);

            try
            {
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarFichasDeMedicionPorCliente");

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
                            Peso = float.Parse(Convert.ToString(dr["PESO"])),
                            Altura = float.Parse(Convert.ToString(dr["ALTURA"])),
                            Imc = float.Parse(Convert.ToString(dr["IMC"])),
                            ClasificacionIMC = dr["CLASIFICACION_IMC"].ToString(),
                            PorcentajeGrasaCorporal = float.Parse(Convert.ToString(dr["PORCENTAJE_GRASA_CORPORAL"])),
                            PorcentajeMasaMuscular = float.Parse(Convert.ToString(dr["PORCENTAJE_MASA_MUSCULAR"])),
                            PesoGraso = float.Parse(Convert.ToString(dr["PESO_GRASO"])),
                            PerCintura = float.Parse(Convert.ToString(dr["PER_CINTURA"])),
                            PerCadera = float.Parse(Convert.ToString(dr["PER_CADERA"])),
                            PerAbdomen = float.Parse(Convert.ToString(dr["PER_ABDOMEN"])),
                            PerPecho = float.Parse(Convert.ToString(dr["PER_PECHO"])),
                            PerEspalda = float.Parse(Convert.ToString(dr["PER_ESPALDA"])),
                            PerMusloIzquierdo = float.Parse(Convert.ToString(dr["PER_MUSLO_IZQ"])),
                            PerMusloDerecho = float.Parse(Convert.ToString(dr["PER_MUSLO_DER"])),
                            PerBicepsIzquierdo = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ"])),
                            PerBicepsDerecho = float.Parse(Convert.ToString(dr["PER_BICEPS_DER"])),
                            PerBicepsIzqContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_IZQ_CONTRAIDO"])),
                            PerBicepsDerContraido = float.Parse(Convert.ToString(dr["PER_BICEPS_DER_CONTRAIDO"])),
                            PerPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_IZQ"])),
                            PerPantorrillaDerecha = float.Parse(Convert.ToString(dr["PER_PANTORRILLA_DER"])),
                            PliAbdominalIzquierdo = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_IZQ"])),
                            PliAbdominalDerecho = float.Parse(Convert.ToString(dr["PLI_ABDOMINAL_DER"])),
                            PliMusloIzquierdo = float.Parse(Convert.ToString(dr["PLI_MUSLO_IZQ"])),
                            PliMusloDerecho = float.Parse(Convert.ToString(dr["PLI_MUSLO_DER"])),
                            PliPantorrillaIzquierda = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_IZQ"])),
                            PliPantorrillaDerecha = float.Parse(Convert.ToString(dr["PLI_PANTORRILLA_DER"])),
                            PliTricepsIzquierdo = float.Parse(Convert.ToString(dr["PLI_TRICEPS_IZQ"])),
                            PliTricepsDerecho = float.Parse(Convert.ToString(dr["PLI_TRICEPS_DER"])),
                            PliSubescapularIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_IZQ"])),
                            PliSubescapularDerecho = float.Parse(Convert.ToString(dr["PLI_SUBESCAPULAR_DER"])),
                            PliSupraespinalIzquierdo = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_IZQ"])),
                            PliSupraespinalDerecho = float.Parse(Convert.ToString(dr["PLI_SUPRAESPINAL_DER"])),
                            Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return listaFichaMedicion;
        }

    }
}
