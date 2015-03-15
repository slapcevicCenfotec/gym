using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
   public class Gimnasio : IEntity
    {
                #region Atributos 

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private String _ubicacion;

        public String Ubicacion {
            get { return _ubicacion;}
            set { _ubicacion = value;}
        }

        private String _telefono;

        public String Telefono {
            get { return _telefono;}
            set { _telefono = value;}
        }

        private String _fax;

         public String Fax {
            get { return _fax;}
            set { _fax = value;}
        }

        private String _cedulaJuridica;

         public String CedulaJuridica {
            get { return _cedulaJuridica;}
            set { _cedulaJuridica = value;}
        }


        #endregion atributos

         public bool IsValid
         {
             get { return (GetRuleViolations().Count() == 0); }
         }
         #region RuleViolations
         public IEnumerable<RuleViolation> GetRuleViolations()
         {
             if (Id == null)
             {
                 yield return new RuleViolation("Id es requerido", "Id");
             }
             if (String.IsNullOrEmpty(Nombre))
             {
                 yield return new RuleViolation("Nombre requerido", "Nombre");
             }
             if (String.IsNullOrEmpty(Ubicacion))
             {
                 yield return new RuleViolation("Ubicacion requerida", "Ubicacion");
             }
             if (String.IsNullOrEmpty(Telefono))
             {
                 yield return new RuleViolation("Telefono requerido", "Telefono");
             }
             if (String.IsNullOrEmpty(Fax))
             {
                 yield return new RuleViolation("Fax requerido", "Fax");
             }
             if (String.IsNullOrEmpty(CedulaJuridica))
             {
                 yield return new RuleViolation("Cedula requerida", "Cedula Juridica");
             }

             yield break;
         }     
         #endregion


         #region Constructores

         public Gimnasio(int pid,String pnombre,String pubicacion,String ptelefono,String pfax,String pcedulaJuridica)
        {
            Id = pid;
            Nombre = pnombre;
            Ubicacion = pubicacion;
            Telefono = ptelefono;
            Fax = pfax;
            CedulaJuridica = pcedulaJuridica;
        }
        public Gimnasio()
        {
           
        }

        #endregion Constructores
    }
}
