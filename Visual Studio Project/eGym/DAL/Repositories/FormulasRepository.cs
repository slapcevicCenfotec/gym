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
    public class FormulasRepository : IRepository<Formula>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _updateItems;
        private List<IEntity> _deleteItems;

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Inicializa una nueva instancia de  <see cref="FormulasRepository"/> class.
        /// </summary>
        public FormulasRepository()
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
        public void Insert(Formula entity)
        {
            _insertItems.Add(entity);
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion:Actualiza una entidad especifica
        /// </summary>
        /// <param name="entity">Entidad Gimnasio.</param>
        public void Update(Formula entity)
        {
            _updateItems.Add(entity);
        }
        public void Delete(Formula entity)
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
            //not yet implemented
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
        /// Descripcion: : Obtiene todos los gimnasios de la base de datos y lo devuelve en una lista.
        /// </summary>
        /// <returns> IEnumerable<Gimnasio></returns>
        public IEnumerable<Formula> GetAll()
        {

            List<Formula> listaFormulas = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "SP_ListarFormulas");
            if (ds.Tables[0].Rows.Count > 0)
            {
                listaFormulas = new List<Formula>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listaFormulas.Add(new Formula
                    {
                        Id = Convert.ToInt32(dr["ID"]),
                        Formulas = dr["FORMULA"].ToString(),
                        Descripcion = dr["DESCRIPCION"].ToString(),
                    });
                }
            }
            return listaFormulas;
        }
        public Formula GetById(int id)
        {
            Formula objFormula = null;

            return objFormula;
        }

    }
}
