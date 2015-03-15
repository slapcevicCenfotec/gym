using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/// <summary>
/// Fecha de creación: 07/03/2015:
/// Autor: Mauricio Fernández Mora
/// Fecha de modificación: 14/03/2015
/// Modificado por: Mauricio Fernández Mora
/// </summary>

namespace EL
{
    public class TipoDeMaquina : IEntity
    {
        #region Variables

        private int _id;
        private byte[] _foto;
        private string _nombre;
        private string _descripcion;
        private Boolean _habilitado;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        #endregion

        #region Constructores

        public TipoDeMaquina(int pid, byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            Id = pid;
            Foto = pfoto;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = phabilitado;
        }

        public TipoDeMaquina(byte[] pfoto, string pnombre, string pdescripcion)
        {
            Foto = pfoto;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = true;
        }

        public TipoDeMaquina()
        {
            Nombre = "";
            Descripcion = "";
            Foto = null;
        }

#endregion

        /// <summary>
        /// Valida si esta instancia es válida.
        /// </summary>
        /// <value>
        ///   <c>true</c> Si esta instancia es válida; de lo contrario, <c>false</c>.
        /// </value>
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        /// <summary>
        /// Obtiene todos los rule violations.
        /// </summary>
        /// <returns>
        /// Lista tipo IEnumerable<RuleViolation>
        /// </returns>
        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (Id == null)
            {
                yield return new RuleViolation("Id es requerido", "Id");
            }
            if (Foto == null)
            {
                yield return new RuleViolation("La foto de la máquina es requerido", "Foto de Máquina");
            }
            if (String.IsNullOrEmpty(Nombre))
            {
                yield return new RuleViolation("Nombre de la máquina es requerido", "Nombre de máquina");
            }
            if (String.IsNullOrEmpty(Descripcion))
            {
                yield return new RuleViolation("La descripción de la máquina es requerido", "Decripción");
            }
            if (Habilitado == null)
            {
                yield return new RuleViolation("Debe asignarse una estado", "Habilitado");
            }
            yield break;
        }
    }
}
