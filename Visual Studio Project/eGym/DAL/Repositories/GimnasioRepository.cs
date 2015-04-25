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
    /// <summary>
    /// Autor: Alexis Soto
    /// Fecha: 03/15/2015
    /// Descricpcion: Este Clase se encarga del acceso a datos del gimnasio. Contiene los metodos de Insertar y modificar
    /// </summary>
    public class GimnasioRepository : IRepository<Gimnasio>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Inicializa una nueva instancia de  <see cref="GimnasioRepository"/> class.
        /// </summary>
        public GimnasioRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Inserta una entidad Especifica.
        /// </summary>
        /// <param name="entity">Entidad Gimnasio.</param>
        public void Insert(Gimnasio entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Actualiza una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Gimnasio.</param>
        public void Update(Gimnasio entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(Gimnasio entity)
        {
            //Not yest Implemented
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Guarda el conjunto de instancias gimnasio.
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Gimnasio objGimnasio in _insertItems)
                        {
                            InsertarGimnasio(objGimnasio);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Gimnasio objGimnasio in _updateItems)
                        {
                            ModificarGimnasio(objGimnasio);
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
        /// Descripcion:Clears Limpia la lista de instacias gimnasio.
        /// </summary>
        public void Clear()
        {
            _insertItems.Clear();
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Este metodo inserta una instancia gimnasio en la base de datos
        /// </summary>
        /// <param name="objGimnasio">The object gimnasio.</param>
        private void InsertarGimnasio(Gimnasio objGimnasio)
        {
            DataSet ds;
            ds = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pnombre", objGimnasio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pubicacion", objGimnasio.Ubicacion));
                cmd.Parameters.Add(new SqlParameter("@ptelefono", objGimnasio.Telefono));
                cmd.Parameters.Add(new SqlParameter("@pfax", objGimnasio.Fax));
                cmd.Parameters.Add(new SqlParameter("@pcedulaJuridica", objGimnasio.CedulaJuridica));


                ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarGimnasio");

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Este metodo modifica una instacia  gimnasio en la base de datos.
        /// </summary>
        /// <param name="objGimnasio">The object gimnasio.</param>
        private void ModificarGimnasio(Gimnasio objGimnasio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pid", objGimnasio.Id));
                cmd.Parameters.Add(new SqlParameter("@pnombre", objGimnasio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@pubicacion", objGimnasio.Ubicacion));
                cmd.Parameters.Add(new SqlParameter("@ptelefono", objGimnasio.Telefono));
                cmd.Parameters.Add(new SqlParameter("@pfax", objGimnasio.Fax));
                cmd.Parameters.Add(new SqlParameter("@pcedulaJuridica", objGimnasio.CedulaJuridica));


                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarGimnasio");

            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: : Obtiene todos los gimnasios de la base de datos y lo devuelve en una lista.
        /// </summary>
        /// <returns> IEnumerable<Gimnasio></returns>
        public IEnumerable<Gimnasio> GetAll()
        {

            List<Gimnasio> listaGimnasios = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarGimnasios");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaGimnasios = new List<Gimnasio>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaGimnasios.Add(new Gimnasio
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Ubicacion = dr["UBICACION"].ToString(),
                        Telefono = dr["TELEFONO"].ToString(),
                        Fax = dr["FAX"].ToString(),
                        CedulaJuridica = dr["CEDULAJURIDICA"].ToString(),
                    });
                }
            }
            return listaGimnasios;
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Obtiene una instancia Gimnasio de la base de datos y se le pasa como parametro el id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Gimnasio</returns>
        public Gimnasio GetById(int id)
        {
            Gimnasio objGimnasio = null;
            var sqlQuery = "SELECT ID, NOMBRE, UBICACION, TELEFONO, FAX, CEDULAJURIDICA FROM T_GIMNASIO WHERE ID  = @ID";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@ID", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objGimnasio = new Gimnasio
                {
                        Id = Convert.ToInt32(dr["ID"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Ubicacion = dr["UBICACION"].ToString(),
                        Telefono = dr["TELEFONO"].ToString(),
                        Fax = dr["FAX"].ToString(),
                        CedulaJuridica = dr["CEDULAJURIDICA"].ToString(),
                };
            }
            return objGimnasio;
        }
    }
}
