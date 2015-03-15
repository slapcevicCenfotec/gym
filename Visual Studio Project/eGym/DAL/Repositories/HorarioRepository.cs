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
    /// Repositorio de horarios
    /// </summary>
    public class HorarioRepository : IRepository<Horario>
    {
        #region atributos

        private List<Horario> _insertItems;
        private List<Horario> _deleteItems;
        private List<Horario> _updateItems;

        #endregion atributos

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public HorarioRepository()
        {
            _insertItems = new List<Horario>();
            _deleteItems = new List<Horario>();
            _updateItems = new List<Horario>();
        }

        /// <summary>
        /// Inserta un nuevo horario al sistema
        /// </summary>
        /// <param name="horario">Horario a insertar</param>
        public void Insert(Horario horario)
        {
            _insertItems.Add(horario);
        }

        /// <summary>
        /// Borra un horario del sistema
        /// </summary>
        /// <param name="horario">Horario a borrar</param>
        public void Delete(Horario horario)
        {
            _deleteItems.Add(horario);
        }

        /// <summary>
        /// Actualiza un horario del sistema
        /// </summary>
        /// <param name="horario">Horario a actualizar</param>
        public void Update(Horario horario)
        {
            _updateItems.Add(horario);
        }

        /// <summary>
        /// Obtiene una lista de todos los horario del sistema
        /// </summary>
        /// <returns>Una lista con todos los horarios</returns>
        public IEnumerable<Horario> GetAll()
        {
            var horarios = new List<Horario>();
            var sqlCommand = new SqlCommand();
            var dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ListarHorarios");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                Horario horario = new Horario();
                horario.Id = Convert.ToInt32(dataRow["ID"]);
                //string x = Convert.ToString(dataRow["HORA_ENTRADA"]);
                //string y = Convert.ToString(dataRow["HORA_SALIDA"]);
                horario.HoraEntrada = DateTime.Parse(Convert.ToString(dataRow["HORA_ENTRADA"]));
                horario.HoraSalida = DateTime.Parse(Convert.ToString(dataRow["HORA_SALIDA"]));
                horario.DiaSemana = Convert.ToInt32(dataRow["DIA_SEMANA"]);
                horario.Usuario = new Usuario();
                horario.Usuario.Id = Convert.ToInt32(dataRow["USUARIO"]);
                horarios.Add(horario);
            }
            return horarios;
        }

        /// <summary>
        /// Obtiene un horario del sistema
        /// </summary>
        /// <param name="id">Id del horario a consultar</param>
        /// <returns></returns>
        public Horario GetById(int id)
        {
            var horario = new Horario();
            var sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(new SqlParameter("@pId", id));
            var dataSet = DBAccess.ExecuteSPWithDS(ref sqlCommand, "SP_ObtenerHorarioPorId");
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                horario = new Horario();
                horario.Id = Convert.ToInt32(dataRow["ID"]);
                horario.HoraEntrada = Convert.ToDateTime(dataRow["HORA_ENTRADA"]);
                horario.HoraSalida = Convert.ToDateTime(dataRow["HORA_SALIDA"]);
                horario.DiaSemana = Convert.ToInt32(dataRow["DIA_SEMANA"]);
                horario.Usuario = new Usuario();
                horario.Usuario.Id = Convert.ToInt32(dataRow["USUARIO"]);
                break;
            }
            return horario;
        }

        /// <summary>
        /// Guarda los horarios agregados, borrados y modificados del sistema
        /// </summary>
        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (Horario horario in _insertItems)
                {
                    InsertHorario(horario);
                }
                foreach (Horario horario in _deleteItems)
                {
                    DeleteHorario(horario);
                }
                foreach (Horario horario in _updateItems)
                {
                    UpdateHorario(horario);
                }
                scope.Complete();
                Clear();
            }
        }

        /// <summary>
        /// Inserta un nuevo horario al sistema
        /// </summary>
        /// <param name="horario">Horario a insertar</param>
        private void InsertHorario(Horario horario)
        {
            SqlCommand sql = new SqlCommand();
            sql.Parameters.Add(new SqlParameter("@pHoraEntrada", Convert.ToDateTime(horario.HoraEntrada).TimeOfDay));
            sql.Parameters.Add(new SqlParameter("@pHoraSalida", Convert.ToDateTime(horario.HoraSalida).TimeOfDay));
            sql.Parameters.Add(new SqlParameter("@pDiaSemana", horario.DiaSemana));
            if (horario.Usuario.Id == 0)
            {
                sql.Parameters.Add(new SqlParameter("@pUsuario", DBNull.Value));
            }
            else
            {
                sql.Parameters.Add(new SqlParameter("@pUsuario", horario.Usuario.Id));
            }
            DBAccess.ExecuteSPWithDS(ref sql, "SP_InsertarHorario");
        }

        /// <summary>
        /// Borra un horario del sistema
        /// </summary>
        /// <param name="horario">Horario a borrar</param>
        private void DeleteHorario(Horario horario)
        {
            SqlCommand sql = new SqlCommand();
            sql.Parameters.Add(new SqlParameter("@pId", horario.Id));
            DBAccess.ExecuteSPWithDS(ref sql, "SP_EliminarHorario");
        }

        /// <summary>
        /// Actualiza un horario del sistema
        /// </summary>
        /// <param name="horario">Horario a actualizar</param>
        private void UpdateHorario(Horario horario)
        {
            SqlCommand sql = new SqlCommand();
            sql.Parameters.Add(new SqlParameter("@pId", horario.Id));
            sql.Parameters.Add(new SqlParameter("@pHoraEntrada", Convert.ToDateTime(horario.HoraEntrada).TimeOfDay));
            sql.Parameters.Add(new SqlParameter("@pHoraSalida", Convert.ToDateTime(horario.HoraSalida).TimeOfDay));
            sql.Parameters.Add(new SqlParameter("@pDiaSemana", horario.DiaSemana));
            sql.Parameters.Add(new SqlParameter("@pUsuario", horario.Usuario.Id));
            DBAccess.ExecuteSPWithDS(ref sql, "SP_ModificarHorario");
        }

        /// <summary>
        /// Limpia todas las listas de agregado, borrado y modificado del sistema
        /// </summary>
        public void Clear()
        {
            _insertItems = new List<Horario>();
            _deleteItems = new List<Horario>();
            _updateItems = new List<Horario>();
        }
    }
}
