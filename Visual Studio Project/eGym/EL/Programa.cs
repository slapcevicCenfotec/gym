using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Programa : IEntity
    {
        private int _id;
        private int _idUsuario;
        private TipoAcondicionamiento _tipoAcondicionamiento;        
        private List<EjercicioPrograma> _listaEjercicios;
        private int _estado;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public TipoAcondicionamiento TipoAcondicionamiento
        {
            get { return _tipoAcondicionamiento; }
            set { _tipoAcondicionamiento = value; }
        }
        public List<EjercicioPrograma> ListaEjercicios
        {
            get { return _listaEjercicios; }
            set { _listaEjercicios = value; }
        }

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}
