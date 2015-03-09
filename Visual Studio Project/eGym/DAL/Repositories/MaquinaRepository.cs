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
    public class MaquinaRepository : IRepository<Maquina>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public MaquinaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Maquina entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Maquina entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Maquina entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Maquina> GetAll()
        {

            List<Maquina> listaMaquinas = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarMaquinas");

            if (ds.Tables[0].Rows.Count > 0)
            {
                listaMaquinas = new List<Maquina>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaMaquinas.Add(new Maquina
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        NumeroActivo = dr["NUMERO_ACTIVO"].ToString(),
                        NumeroMaquina = dr["NUMERO_MAQUINA"].ToString(),
                        Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                        NombreTipoMaquina = dr["NOMBRE"].ToString(),
                    });
                }
            }

            return listaMaquinas;
        }

        public Maquina GetById(int pId)
        {

            Maquina maquina = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@pId", pId);
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_MaquinaPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    maquina = new Maquina
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        NumeroActivo = dr["NUMERO_ACTIVO"].ToString(),
                        NumeroMaquina = dr["NUMERO_MAQUINA"].ToString(),
                        Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                    };
                }
            }

            return maquina;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Maquina objMaquina in _insertItems)
                        {
                            InsertMaquina(objMaquina);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Maquina p in _updateItems)
                        {
                            UpdateMaquina(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Maquina p in _deleteItems)
                        {
                            DeleteMaquina(p);
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

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        private void InsertMaquina(Maquina objMaquina)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@pNumeroActivo", objMaquina.NumeroActivo));
                cmd.Parameters.Add(new SqlParameter("@pNumeroMaquina", objMaquina.NumeroMaquina));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objMaquina.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@pIdTipoDeMaquina", objMaquina.TipoDeMaquina));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_InsertarMaquina");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateMaquina(Maquina objMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objMaquina.Id));
                cmd.Parameters.Add(new SqlParameter("@pNumeroActivo", objMaquina.NumeroActivo));
                cmd.Parameters.Add(new SqlParameter("@pNumeroMaquina", objMaquina.NumeroMaquina));
                cmd.Parameters.Add(new SqlParameter("@pHabilitado", objMaquina.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@pIdTipoDeMaquina", objMaquina.TipoDeMaquina));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ModificarMaquina");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteMaquina(Maquina objMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@pId", objMaquina.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_EliminarMaquina");

            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception


            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception

            }
        }

    }
}
