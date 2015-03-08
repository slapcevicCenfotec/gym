using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EL
{
    public class Maquina : IEntity
    {
        #region variables

        private int _id;
        private string _numeroActivo;
        private string _numeroMaquina;
        private Boolean _habilitado;
        private int _tipoDeMaquina;
        private string _nombreTipoMaquina;

        #endregion

        #region propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NumeroActivo
        {
            get { return _numeroActivo; }
            set { _numeroActivo = value; }
        }

        public string NumeroMaquina
        {
            get { return _numeroMaquina; }
            set { _numeroMaquina = value; }
        }

        public Boolean Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public int TipoDeMaquina
        {
            get { return _tipoDeMaquina; }
            set { _tipoDeMaquina = value; }
        }

        public string NombreTipoMaquina
        {
            get { return _nombreTipoMaquina; }
            set { _nombreTipoMaquina = value; }
        }

        #endregion

        public Maquina(int pid, string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            Id = pid;
            NumeroActivo = pnumeroActivo;
            NumeroMaquina = pnumeroMaquina;
            Habilitado = phabilitado;
            TipoDeMaquina = ptipoDeMaquina;
        }

        public Maquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, int ptipoDeMaquina)
        {
            NumeroActivo = pnumeroActivo;
            NumeroMaquina = pnumeroMaquina;
            Habilitado = phabilitado;
            TipoDeMaquina = ptipoDeMaquina;
        }

        public Maquina(string pnumeroActivo, string pnumeroMaquina, Boolean phabilitado, string pnombretipoDeMaquina)
        {
            NumeroActivo = pnumeroActivo;
            NumeroMaquina = pnumeroMaquina;
            Habilitado = phabilitado;
            NombreTipoMaquina = pnombretipoDeMaquina;
        }

        public Maquina()
        {
            NumeroActivo = "";
            NumeroMaquina = "";
            Habilitado = true;
            TipoDeMaquina = 0;
        }
    }
}
