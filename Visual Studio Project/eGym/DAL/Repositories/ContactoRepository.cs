using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL.Repositories
{
    /// <summary>
    /// Repositorio de contactos
    /// </summary>
    public class ContactoRepository : IRepository<Contacto>
    {
        #region atributos

        private List<Contacto> _insertItems;
        private List<Contacto> _deleteItems;
        private List<Contacto> _updateItems;

        #endregion atributos

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public ContactoRepository()
        {
            _insertItems = new List<Contacto>();
            _deleteItems = new List<Contacto>();
            _updateItems = new List<Contacto>();
        }

        /// <summary>
        /// Inserta un nuevo contacto al sistema
        /// </summary>
        /// <param name="contacto">Contacto a insertar</param>
        public void Insert(Contacto contacto)
        {
            _insertItems.Add(contacto);
        }

        /// <summary>
        /// Borra un contacto del sistema
        /// </summary>
        /// <param name="contacto">Contacto a borrar</param>
        public void Delete(Contacto contacto)
        {
            _deleteItems.Add(contacto);
        }

        /// <summary>
        /// Actualiza un contacto del sistema
        /// </summary>
        /// <param name="contacto">Contacto a actualizar</param>
        public void Update(Contacto contacto)
        {
            _updateItems.Add(contacto);
        }

        /// <summary>
        /// Obtiene una lista de todos los contactos del sistema
        /// </summary>
        /// <returns>Una lista con todos los contactos</returns>
        public IEnumerable<Contacto> GetAll()
        {
            var contactos = new List<Contacto>();
            var sqlCommand = new SqlCommand();
            DataSet dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ListarContactos");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var contacto = new Contacto();
                contacto.Id = Convert.ToInt32(dataRow["ID"]);
                contacto.Nombre = Convert.ToString(dataRow["NOMBRE"]);
                contacto.Parentesco = Convert.ToString(dataRow["PARENTESCO"]);
                contacto.Telefono = Convert.ToString(dataRow["NUMERO_TELEFONO"]);
                contacto.Usuario = new Usuario();
                contacto.Usuario.Id = Convert.ToInt32(dataRow["USUARIO"]);
                contactos.Add(contacto);
            }
            return contactos;
        }

        /// <summary>
        /// Obtiene un contacto del sistema
        /// </summary>
        /// <param name="id">Id del contacto a consultar</param>
        /// <returns></returns>
        public Contacto GetById(int id)
        {
            Contacto contacto = null;
            var sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(new SqlParameter("@pId", id));
            DataSet dataSet = DAL.DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ObtenerContactoPorId");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                contacto = new Contacto();
                contacto.Id = Convert.ToInt32(dataRow["ID"]);
                contacto.Nombre = Convert.ToString(dataRow["NOMBRE"]);
                contacto.Parentesco = Convert.ToString(dataRow["PARENTESCO"]);
                contacto.Telefono = Convert.ToString(dataRow["NUMERO_TELEFONO"]);
                contacto.Usuario = new Usuario();
                contacto.Usuario.Id = Convert.ToInt32(dataRow["USUARIO"]);
                break;
            }
            return contacto;
        }

        /// <summary>
        /// Guarda los contactos agregados, borrados y modificados del sistema
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (Contacto contacto in _insertItems)
                {
                    InsertContacto(contacto);
                }
                foreach (Contacto contacto in _deleteItems)
                {
                    DeleteContacto(contacto);
                }
                foreach (Contacto contacto in _updateItems)
                {
                    UpdateContacto(contacto);
                }
                scope.Complete();
                Clear();
            }
        }

        /// <summary>
        /// Inserta un nuevo contacto al sistema
        /// </summary>
        /// <param name="contacto">Contacto a insertar</param>
        private void InsertContacto(Contacto contacto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@pNombre", contacto.Nombre);
            sqlCommand.Parameters.AddWithValue("@pNumeroTelefono", contacto.Telefono);
            sqlCommand.Parameters.AddWithValue("@pParentesco", contacto.Parentesco);
            if (contacto.Usuario.Id == 0)
            {
                sqlCommand.Parameters.Add("@pUsuario", DBNull.Value);
            }
            else
            {
                sqlCommand.Parameters.Add("@pUsuario", contacto.Usuario.Id);
            }
            DBAccess.ExecuteSPNonQuery(sqlCommand, "SP_InsertarContacto");
        }

        /// <summary>
        /// Borra un contacto del sistema
        /// </summary>
        /// <param name="contacto">Contacto a borrar</param>
        private void DeleteContacto(Contacto contacto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@pId", contacto.Id);
            DBAccess.ExecuteSPNonQuery(sqlCommand, "SP_EliminarContacto");
        }

        /// <summary>
        /// Actualiza un contacto del sistema
        /// </summary>
        /// <param name="contacto">Contacto a actualizar</param>
        private void UpdateContacto(Contacto contacto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add("@pId", contacto.Id);
            sqlCommand.Parameters.Add("@pNombre", contacto.Nombre);
            sqlCommand.Parameters.Add("@pNumeroTelefono", contacto.Telefono);
            sqlCommand.Parameters.Add("@pParentesco", contacto.Parentesco);
            sqlCommand.Parameters.Add("@pUsuario", contacto.Usuario.Id);
            DBAccess.ExecuteSPNonQuery(sqlCommand, "SP_ModificarContacto");
        }

        /// <summary>
        /// Limpia todas las listas de agregado, borrado y modificado del sistema
        /// </summary>
        public void Clear()
        {
            _insertItems = new List<Contacto>();
            _deleteItems = new List<Contacto>();
            _updateItems = new List<Contacto>();
        }
    }
}
