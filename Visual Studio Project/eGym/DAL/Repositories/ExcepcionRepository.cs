using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using System.Transactions;
using System.Data.SqlClient;
namespace DAL.Repositories
{
    class ExcepcionRepository : IRepository<Excepcion>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        public ExcepcionRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        public void Insert(Excepcion entity)
        {
            _insertItems.Add(entity);
        }

        public void Update(Excepcion entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(Excepcion entity)
        {
            _deleteItems.Add(entity);
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Excepcion objExcepcion in _insertItems)
                        {
                            InsertarExcepcion(objExcepcion);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Excepcion objRol in _updateItems)
                        {
                            //No implementado
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Excepcion objRol in _deleteItems)
                        {
                            //No implementado
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

        private void InsertarExcepcion(Excepcion objExcepcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@ptitulo", objExcepcion.Titulo));
                cmd.Parameters.Add(new SqlParameter("@pdescripcion", objExcepcion.Descripcion));


                DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarExcepcion");

            }
            catch (Exception ex)
            {

            }
        }


        public void Clear()
        {
            _insertItems.Clear();
        }

        public IEnumerable<Excepcion> GetAll()
        {
            //No implementado
            return null;
        }

        public Excepcion GetById(int id)
        {
            //No implementado
            return null;
        }
    }
}
