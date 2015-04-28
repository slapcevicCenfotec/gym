using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace DAL.Repositories
{
    public class MensajeRepository : IRepository<Mensaje>
    {
        private List<Mensaje> _insertItems;

        public MensajeRepository()
        {
            _insertItems = new List<Mensaje>();
        }

        public void Insert(Mensaje mensaje)
        {
            _insertItems.Add(mensaje);
        }

        public void Delete(Mensaje mensaje)
        {
            throw new NotImplementedException();
        }

        public void Update(Mensaje mensaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mensaje> GetAll()
        {
            var mensajes = new List<Mensaje>();
            var sqlCommand = new SqlCommand();
            var dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ListarMensajes");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var mensaje = new Mensaje();
                mensaje.FechaYHora = Convert.ToDateTime(dataRow["FECHA_Y_HORA"]);
                mensaje.Leido = Convert.ToBoolean(dataRow["LEIDO"]);
                mensaje.Remitente.Id = Convert.ToInt32(dataRow["REMITENTE"]);
                mensaje.Texto = dataRow["MENSAJE"].ToString();
                mensajes.Add(mensaje);
            }
            return mensajes;
        }

        public Mensaje GetById(int id)
        {
            var mensaje = new Mensaje();
            var sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(new SqlParameter("@pId", id));
            var dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ObtenerMensaje");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                mensaje.Destinatario.Id = Convert.ToInt32(dataRow["DESTINATARIO"]);
                mensaje.FechaYHora = Convert.ToDateTime(dataRow["FECHA_Y_HORA"]);
                mensaje.Id = Convert.ToInt32(dataRow["ID"]);
                mensaje.Leido = Convert.ToBoolean(dataRow["LEIDO"]);
                mensaje.Remitente.Id = Convert.ToInt32(dataRow["REMITENTE"]);
                mensaje.Texto = dataRow["MENSAJE"].ToString();
                break;
            }
            return mensaje;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (Mensaje mensaje in _insertItems)
                {
                    InsertMensaje(mensaje);
                }
                scope.Complete();
                Clear();
            }
        }

        private void InsertMensaje(Mensaje mensaje)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add("@pRemitente", mensaje.Remitente.Id);
            sqlCommand.Parameters.Add("@pDestinatario", mensaje.Destinatario.Id);
            sqlCommand.Parameters.Add("@pMensaje", mensaje.Texto);
            DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_InsertarMensaje");
        }

        public void Clear()
        {
            _insertItems = new List<Mensaje>();
        }
    }
}
