using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EL
{
    public class TipoDeMaquina : IEntity
    {
        #region variables

        private int _id;
        private byte[] _foto;
        private string _nombre;
        private string _descripcion;
        private Boolean _habilitado;

        #endregion

        #region propiedades

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

        public TipoDeMaquina(byte[] pfoto, string pnombre, string pdescripcion, Boolean phabilitado)
        {
            Foto = pfoto;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = phabilitado;
        }

        public TipoDeMaquina()
        {
            Nombre = "";
            Descripcion = "";
            Foto = null;
        }

#endregion
        
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

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
