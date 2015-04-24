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

namespace DAL.Repositories
{
    class EventoCalendarioRepository : IRepository<EventoCalendario>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        public EventoCalendarioRepository()
        {
            _insertItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
        }

        public void Insert(EventoCalendario entity)
        {
            _insertItems.Add(entity);
        }

        public void Update(EventoCalendario entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(EventoCalendario entity)
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
                        foreach (EventoCalendario objEvento in _insertItems)
                        {
                            InsertarEvento(objEvento);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (EventoCalendario objEvento in _updateItems)
                        {
                            UpdateEvento(objEvento);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (EventoCalendario objEvento in _deleteItems)
                        {
                            DeleteEvento(objEvento);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {
                    throw ex;
                }
                catch (ApplicationException ex)
                {
                    throw ex;
                }
                finally
                {
                    Clear();
                }

            }
        }
        public IEnumerable<EventoCalendario> GetAll()
        {
            List<EventoCalendario> listaEventos = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarEventoCalendario");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaEventos = new List<EventoCalendario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    EventoCalendario auxEvento = new EventoCalendario();
                    auxEvento.Id = Convert.ToInt32(dr["ID"]);
                    auxEvento.Usuario = Convert.ToInt32(dr["USUARIO"]);
                    auxEvento.Tipo = Convert.ToInt32(dr["TIPO"]);
                    auxEvento.Titulo = Convert.ToString(dr["TITULO"]);
                    auxEvento.Descripcion = Convert.ToString(dr["DESCRIPCION"]);
                    auxEvento.FechaInicial = Convert.ToDateTime(dr["FECHA_INICIAL"]);
                    auxEvento.FechaFinal = Convert.ToDateTime(dr["FECHA_FINAL"]);
                    auxEvento.Habilitado = Convert.ToBoolean(dr["HABILITADO"]);
                    listaEventos.Add(auxEvento);
                }
            }
            return listaEventos;
        }
        public EventoCalendario GetById(int id)
        {
            //No implementado
            return null;
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }
        private void InsertarEvento(EventoCalendario objEvento)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pUsuario", objEvento.Usuario));
                cmd.Parameters.Add(new SqlParameter("@pTipo", objEvento.Tipo));
                cmd.Parameters.Add(new SqlParameter("@pTitulo", objEvento.Titulo));
                cmd.Parameters.Add(new SqlParameter("@pDescripcion", objEvento.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@pFechaInicial", objEvento.FechaInicial));
                cmd.Parameters.Add(new SqlParameter("@pFechaFinal", objEvento.FechaFinal));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarEventoCalendario");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void UpdateEvento(EventoCalendario objEvento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objEvento.Id));
                cmd.Parameters.Add(new SqlParameter("@pUsuario", objEvento.Usuario));
                cmd.Parameters.Add(new SqlParameter("@pTipo", objEvento.Tipo));
                cmd.Parameters.Add(new SqlParameter("@pTitulo", objEvento.Titulo));
                cmd.Parameters.Add(new SqlParameter("@pDescripcion", objEvento.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@pFechaInicial", objEvento.FechaInicial));
                cmd.Parameters.Add(new SqlParameter("@pFechaFinal", objEvento.FechaFinal));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarEventoCalendario");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void DeleteEvento(EventoCalendario objEvento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objEvento.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarEventoCalendario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
