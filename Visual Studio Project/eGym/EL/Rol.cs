using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Rol : IEntity
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


        private String _descripcion;

        public String Descripcion {
            get { return _descripcion;}
            set { _descripcion = value;}
        }

        private Boolean _habilitado;

        public Boolean Habilitado {
            get { return _habilitado;}
            set { _habilitado = value;}
        }

        private List<Permiso> _listaPermisos; 
        
        public List<Permiso> ListaPermisos
        {
            get { return _listaPermisos; }
            set { _listaPermisos = value; }
        }

        #endregion atributos

        #region Constructores

        public Rol(int pid,String pnombre,String pdescripcion,Boolean phabilitado)
        {
            Id = pid;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Habilitado = phabilitado;
        }
        public Rol()
        {
           
        }

        #endregion Constructores
    }


    }

