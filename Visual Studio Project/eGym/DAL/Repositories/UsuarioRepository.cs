using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL.Repositories
{
    /// <summary>
    /// Repositorio de usuarios
    /// </summary>
    class UsuarioRepository : IRepository<Usuario>
    {
        #region atributos

        public string UltimoInsert { get; set; }
        private List<Usuario> _insertItems;
        private List<Usuario> _deleteItems;
        private List<Usuario> _updateItems;

        #endregion atributos

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public UsuarioRepository()
        {
            _insertItems = new List<Usuario>();
            _deleteItems = new List<Usuario>();
            _updateItems = new List<Usuario>();
        }

        /// <summary>
        /// Inserta un nuevo usuario al sistema
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        public void Insert(Usuario usuario)
        {
            _insertItems.Add(usuario);
        }

        /// <summary>
        /// Borra un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario a borrar</param>
        public void Delete(Usuario usuario)
        {
            _deleteItems.Add(usuario);
        }

        /// <summary>
        /// Actualiza un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario a actualizar</param>
        public void Update(Usuario usuario)
        {
            _updateItems.Add(usuario);
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios del sistema
        /// </summary>
        /// <returns>Una lista con todos los usuarios</returns>
        public IEnumerable<Usuario> GetAll()
        {
            var usuarios = new List<Usuario>();
            var sqlCommand = new SqlCommand();
            var dataSet = DAL.DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ListarUsuarios");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dataRow["ID"]);
                usuario.Identificacion = Convert.ToString(dataRow["IDENTIFICACION"]);
                usuario.Nombre = Convert.ToString(dataRow["NOMBRE"]);
                usuario.SegundoNombre = Convert.ToString(dataRow["SEGUNDO_NOMBRE"]);
                usuario.Apellido = Convert.ToString(dataRow["APELLIDO"]);
                usuario.SegundoApellido = Convert.ToString(dataRow["SEGUNDO_APELLIDO"]);
                usuario.Alias = Convert.ToString(dataRow["ALIAS"]);
                usuario.FechaNacimiento = Convert.ToDateTime(dataRow["FECHA_NACIMIENTO"]);
                usuario.CorreoElectronico = Convert.ToString(dataRow["CORREO_ELECTRONICO"]);
                usuario.IdGenero = Convert.ToInt32(dataRow["GENERO"]);
                usuario.FechaIngreso = Convert.ToDateTime(dataRow["FECHA_INGRESO"]);
                usuario.NumeroTelefono = Convert.ToString(dataRow["NUMERO_TELEFONO"]);
                usuario.NumeroCelular = Convert.ToString(dataRow["NUMERO_CELULAR"]);
                usuario.Habilitado = Convert.ToBoolean(dataRow["HABILITADO"]);
                usuario.IdTipoIdentificacion = Convert.ToInt32(dataRow["TIPO_IDENTIFICACION"]);
                usuario.Rol = new Rol() { Id = Convert.ToInt32(dataRow["ROL"]) };
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        /// <summary>
        /// Obtiene un usuario del sistema
        /// </summary>
        /// <param name="id">Id del usuario a consultar</param>
        /// <returns></returns>
        public Usuario GetById(int id)
        {
            var usuario = new Usuario();
            var sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(new SqlParameter("@pId", id));
            var dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ObtenerUsuarioPorId");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dataRow["ID"]);
                usuario.Identificacion = Convert.ToString(dataRow["IDENTIFICACION"]);
                usuario.Nombre = Convert.ToString(dataRow["NOMBRE"]);
                usuario.SegundoNombre = Convert.ToString(dataRow["SEGUNDO_NOMBRE"]);
                usuario.Apellido = Convert.ToString(dataRow["APELLIDO"]);
                usuario.SegundoApellido = Convert.ToString(dataRow["SEGUNDO_APELLIDO"]);
                usuario.Alias = Convert.ToString(dataRow["ALIAS"]);
                usuario.FechaNacimiento = Convert.ToDateTime(dataRow["FECHA_NACIMIENTO"]);
                usuario.CorreoElectronico = Convert.ToString(dataRow["CORREO_ELECTRONICO"]);
                usuario.Fotografia = (dataRow["FOTOGRAFIA"] == DBNull.Value) ? null : (byte [])(dataRow["FOTOGRAFIA"]);
                usuario.IdGenero = Convert.ToInt32(dataRow["GENERO"]);
                usuario.FechaIngreso = Convert.ToDateTime(dataRow["FECHA_INGRESO"]);
                usuario.NumeroTelefono = Convert.ToString(dataRow["NUMERO_TELEFONO"]);
                usuario.NumeroCelular = Convert.ToString(dataRow["NUMERO_CELULAR"]);
                usuario.Habilitado = Convert.ToBoolean(dataRow["HABILITADO"]);
                usuario.IdTipoIdentificacion = Convert.ToInt32(dataRow["TIPO_IDENTIFICACION"]);
                usuario.Rol = new Rol() { Id = Convert.ToInt32(dataRow["ROL"]) };
                usuario.Contrasena = Convert.ToString(dataRow["CONTRASENA"]);
                break;
            }
            return usuario;
        }

        /// <summary>
        /// Guarda los usuarios agregados, borrados y modificados del sistema
        /// </summary>
        public void Save()
        {
            using(TransactionScope scope = new TransactionScope())
            {
                foreach (Usuario usuario in _insertItems)
                {
                    InsertUsuario(usuario);
                }
                foreach (Usuario usuario in _deleteItems)
                {
                    DeleteUsuario(usuario);
                }
                foreach (Usuario usuario in _updateItems)
                {
                    UpdateUsuario(usuario);
                }
                scope.Complete();
                Clear();
            }
        }

        /// <summary>
        /// Inserta un nuevo usuario al sistema
        /// </summary>
        /// <param name="usuario">Usuario a insertar</param>
        private void InsertUsuario(Usuario usuario)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add("@pIdentificacion", usuario.Identificacion);
            sqlCommand.Parameters.Add("@pNombre", usuario.Nombre);
            sqlCommand.Parameters.Add("@pSegundoNombre", usuario.SegundoNombre);
            sqlCommand.Parameters.Add("@pApellido", usuario.Apellido);
            sqlCommand.Parameters.Add("@pSegundoApellido", usuario.SegundoApellido);
            sqlCommand.Parameters.Add("@pAlias", usuario.Alias);
            sqlCommand.Parameters.Add("@pFechaNacimiento", usuario.FechaNacimiento);
            sqlCommand.Parameters.Add("@pCorreoElectronico", usuario.CorreoElectronico);
            sqlCommand.Parameters.Add("@pGenero", usuario.IdGenero);
            sqlCommand.Parameters.Add("@pContrasena", usuario.Contrasena);
            if (usuario.Fotografia == null)
            {
                sqlCommand.Parameters.Add("@pFotografia", SqlDbType.Image).Value = DBNull.Value;
            }
            else
            {
                sqlCommand.Parameters.Add("@pFotografia", SqlDbType.Image, usuario.Fotografia.Length).Value = usuario.Fotografia;
            }
            sqlCommand.Parameters.Add("@pFechaIngreso", usuario.FechaIngreso);
            sqlCommand.Parameters.Add("@pNumeroTelefono", usuario.NumeroTelefono);
            sqlCommand.Parameters.Add("@pNumeroCelular", usuario.NumeroCelular);
            sqlCommand.Parameters.Add("@pRol", usuario.Rol.Id);
            sqlCommand.Parameters.Add("@pTipoIdentificacion", usuario.IdTipoIdentificacion);
            DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_InsertarUsuario");
        }

        /// <summary>
        /// Borra un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario a borrar</param>
        private void DeleteUsuario(Usuario usuario)
        {
            SqlCommand sql = new SqlCommand();
            sql.Parameters.Add(new SqlParameter("@pId", usuario.Id));
            DBAccess.ExecuteSPWithDS(ref sql, "SP_EliminarUsuario");
        }

        /// <summary>
        /// Actualiza un usuario del sistema
        /// </summary>
        /// <param name="usuario">Usuario a actualizar</param>
        private void UpdateUsuario(Usuario usuario)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add("@pId", usuario.Id);
            sqlCommand.Parameters.Add("@pIdentificacion", usuario.Identificacion);
            sqlCommand.Parameters.Add("@pNombre", usuario.Nombre);
            sqlCommand.Parameters.Add("@pSegundoNombre", usuario.SegundoNombre);
            sqlCommand.Parameters.Add("@pApellido", usuario.Apellido);
            sqlCommand.Parameters.Add("@pSegundoApellido", usuario.SegundoApellido);
            sqlCommand.Parameters.Add("@pAlias", usuario.Alias);
            sqlCommand.Parameters.Add("@pFechaNacimiento", usuario.FechaNacimiento);
            sqlCommand.Parameters.Add("@pCorreoElectronico", usuario.CorreoElectronico);
            sqlCommand.Parameters.Add("@pGenero", usuario.IdGenero);
            sqlCommand.Parameters.Add("@pContrasena", usuario.Contrasena);
            if (usuario.Fotografia == null)
            {
                sqlCommand.Parameters.Add("@pFotografia", SqlDbType.Image).Value = DBNull.Value;
            }
            else
            {
                sqlCommand.Parameters.Add("@pFotografia", SqlDbType.Image, usuario.Fotografia.Length).Value = usuario.Fotografia;
            }

            sqlCommand.Parameters.Add("@pFechaIngreso", usuario.FechaIngreso);
            sqlCommand.Parameters.Add("@pNumeroTelefono", usuario.NumeroTelefono);
            sqlCommand.Parameters.Add("@pNumeroCelular", usuario.NumeroCelular);
            sqlCommand.Parameters.Add("@pRol", usuario.Rol.Id);
            sqlCommand.Parameters.Add("@pTipoIdentificacion", usuario.IdTipoIdentificacion);
            DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ModificarUsuario");
        }

        /// <summary>
        /// Limpia todas las listas de agregado, borrado y modificado del sistema
        /// </summary>
        public void Clear()
        {
            _insertItems = new List<Usuario>();
            _deleteItems = new List<Usuario>();
            _updateItems = new List<Usuario>();
        }
    }
}
