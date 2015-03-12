﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using System.Transactions;
using System.Data.SqlClient;
namespace DAL.Repositories
{
    class EventoRepository : IRepository<Evento>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        public EventoRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        public void Insert(Evento entity)
        {
            _insertItems.Add(entity);
        }

        public void Update(Evento entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(Evento entity)
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
                        foreach (Evento objExcepcion in _insertItems)
                        {
                            InsertarExcepcion(objExcepcion);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Evento objRol in _updateItems)
                        {
                            //No implementado
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Evento objRol in _deleteItems)
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

        private void InsertarExcepcion(Evento objEvento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@ptitulo", objEvento.Titulo));
                cmd.Parameters.Add(new SqlParameter("@pdescripcion", objEvento.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@pusuario", objEvento.Usuario));


                DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarEvento");

            }
            catch (Exception ex)
            {

            }
        }


        public void Clear()
        {
            _insertItems.Clear();
        }

        public IEnumerable<Evento> GetAll()
        {
            //No implementado
            return null;
        }

        public Evento GetById(int id)
        {
            //No implementado
            return null;
        }
    }
}
