using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using EL;

namespace DAL.Repositories
{
    class PruebaResistenciaRepository :IRepository<PruebaResistencia>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Inicializa una nueva instancia de <see cref="RolRepository"/> class.
        /// </summary>
        public PruebaResistenciaRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Inserta una entidad Especifica.
        /// <param name="entity">Entidad Roly.</param>
        public void Insert(PruebaResistencia entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Actualiza una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Rol.</param>
        public void Update(PruebaResistencia entity)
        {
            _updateItems.Add(entity);
        }
        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Elimina una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Rol.</param>
        public void Delete(PruebaResistencia entity)
        {
            _deleteItems.Add(entity);
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Guarda el conjunto de instancias Rol.
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (PruebaResistencia objPrueba in _insertItems)
                        {
                            //InsertPrueba(objPrueba);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (PruebaResistencia objPrueba in _updateItems)
                        {
                            UpdatePrueba(objPrueba);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (PruebaResistencia objPrueba in _deleteItems)
                        {
                            //DeletePrueba(objPrueba);
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
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Clears Limpia la lista de instacias Rol.
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Este metodo inserta una instancia Rol en la base de datos
        /// </summary>
        /// <param name="objRol">Rol.</param>
        /// <returns></returns>

      

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Este Devuelve una lista de Roles de la base de datos
        /// </summary>
        /// <returns>IEnumerable<Rol></returns>
        public IEnumerable<PruebaResistencia> GetAll()
        {

            List<PruebaResistencia> listaPruebas = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarPruebasResistencia");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaPruebas = new List<PruebaResistencia>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaPruebas.Add(new PruebaResistencia
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Fecha = Convert.ToDateTime(dr["FECHA"]),
                        Peso = Convert.ToDouble(dr["PESO"]),
                        IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]),
                        NombreUsuario = dr["USUARIO"].ToString(),
                        IdTipoPrueba = Convert.ToInt32(dr["TIPO_PRUEBA"])
                    });
                }
            }
            return listaPruebas;
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Este Devuelve una lista un Rol de la base de datos
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Rol</returns>
        public PruebaResistencia GetById(int id)
        {
            PruebaResistencia objPrueba = null;
            List<PruebaResistencia> listaPruebas = new List<PruebaResistencia>();
            var sqlQuery = " SELECT A.ID,A.PESO,A.FECHA,A.USUARIO,B.NOMBRE +' '+ B.APELLIDO +' '+ B.SEGUNDO_APELLIDO AS NOMBRE_C0MPLETO, A.TIPO_PRUEBA,C.NOMBRE AS NOMBRE_PRUEBA FROM T_PRUEBA_RESISTENCIA A INNER JOIN T_USUARIO B ON A.USUARIO = B.ID INNER JOIN [dbo].[T_TIPO_PRUEBA_RESISTENCIA] C ON A.TIPO_PRUEBA = C.ID where B.IDENTIFICACION = @ID";
            //var sqlQuery = "SELECT ID,PESO,FECHA,USUARIO,TIPO_PRUEBA FROM T_PRUEBA_RESISTENCIA where USUARIO = @ID";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@ID", id.ToString());

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objPrueba = new PruebaResistencia
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Fecha = Convert.ToDateTime(dr["FECHA"]),
                    Peso = Convert.ToDouble(dr["PESO"]),
                    IdUsuario = Convert.ToInt32(dr["USUARIO"]),
                    NombreUsuario = dr["NOMBRE_C0MPLETO"].ToString(),
                    NombrePrueba= dr["NOMBRE_PRUEBA"].ToString(),
                    IdTipoPrueba = Convert.ToInt32(dr["TIPO_PRUEBA"]
                    )
                };

            }

            List<ResultadoPruebaResistencia> listaResultadosPruebas = null;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@ID_USUARIO",objPrueba.IdUsuario));
             ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_listaPruebasPorUsuario");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaResultadosPruebas = new List<ResultadoPruebaResistencia>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaResultadosPruebas.Add(new ResultadoPruebaResistencia
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        IdEjericio = Convert.ToInt32(dr["EJERCICIO"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Series = Convert.ToInt32(dr["SERIES"]),
                        Repeticiones = Convert.ToInt32(dr["REPETICIONES"]),
                        Rm1 = Convert.ToDouble(dr["RM1"]),
                        IdPrueba = Convert.ToInt32(dr["ID_PRUEBA"]),
                        Peso = Convert.ToDouble(dr["PESO"]),
                        Prc1 = Convert.ToDouble(dr["PRC1"]),
                        Prc2 = Convert.ToDouble(dr["PRC2"]),
                        Prc3 = Convert.ToDouble(dr["PRC3"])
                    });
                }
            }


            objPrueba.ListaPruebas = listaResultadosPruebas;
            return objPrueba;
        }
        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Este metodo mosifica una instancia Rol en la base de datos
        /// </summary>
        /// <param name="objRol">The object rol.</param>
        /// <returns></returns>
        private void UpdatePrueba(PruebaResistencia objPrueba)
        {
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@PID", objPrueba.Id));
                cmd.Parameters.Add(new SqlParameter("@PPESO", objPrueba.Peso));
                cmd.Parameters.Add(new SqlParameter("@PID_TIPO_PRUEBA", objPrueba.IdTipoPrueba));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarPruebaResistencia");

            }
            catch (Exception ex)
            {

            }
        }
    }
}
