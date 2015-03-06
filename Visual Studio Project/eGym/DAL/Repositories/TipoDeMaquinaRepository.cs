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
    public class TipoDeMaquinaRepository : IRepository<TipoDeMaquina>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public TipoDeMaquinaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(TipoDeMaquina entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(TipoDeMaquina entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(TipoDeMaquina entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<TipoDeMaquina> GetAll()
        {

            List<TipoDeMaquina> listaTiposDeMaquinas = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarTiposDeMaquinas");



            if (ds.Tables[0].Rows.Count > 0)
            {
                listaTiposDeMaquinas = new List<TipoDeMaquina>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaTiposDeMaquinas.Add(new TipoDeMaquina
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        //Foto = Convert.ToByte(["FOTO"]),
                        Nombre = dr["NOMBRE"].ToString(),
                        Descripcion = dr["DESCRIPCION"].ToString(),
                        Habilitado = Convert.ToBoolean(dr["HABILITADO"]),
                    });
                }
            }

            return listaTiposDeMaquinas;
        }

        public TipoDeMaquina GetById(int id)
        {
            TipoDeMaquina objTipoDeMaquina = null;
            var sqlQuery = "SELECT Id, Nombre, Masa, TemperaturaMedia, DuracionDeUnDia FROM TipoDeMaquinas WHERE ID = @id ";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@id", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objTipoDeMaquina = new TipoDeMaquina
                {
                    Id = Convert.ToInt32(dr["ID"]),
                   // Foto = Convert.ToByte(["FOTO"]),
                    Nombre = dr["NOMBRE"].ToString(),
                    Descripcion = dr["DESCRIPCION"].ToString(),
                    Habilitado = Convert.ToBoolean(dr["HABILITADO"]),

                };
            }

            return objTipoDeMaquina;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (TipoDeMaquina objTipoDeMaquina in _insertItems)
                        {
                            InsertTipoDeMaquina(objTipoDeMaquina);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoDeMaquina p in _updateItems)
                        {
                            UpdateTipoDeMaquina(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoDeMaquina p in _deleteItems)
                        {
                            DeleteTipoDeMaquina(p);
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

        private void InsertTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.Parameters.Add(new SqlParameter("@foto", objTipoDeMaquina.Foto));
                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoDeMaquina.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoDeMaquina.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@habilitado", objTipoDeMaquina.Habilitado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "paInsertarTipoDeMaquina");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                //cmd.Parameters.Add(new SqlParameter("@foto", objTipoDeMaquina.Foto));
                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoDeMaquina.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoDeMaquina.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@habilitado", objTipoDeMaquina.Habilitado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_TipoDeMaquina");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteTipoDeMaquina(TipoDeMaquina objTipoDeMaquina)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@Id", objTipoDeMaquina.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_TipoDeMaquina");

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
