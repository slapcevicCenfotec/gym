using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Repositories;
using EL;

namespace DAL
{

    public class UnitOfWork
    {

        private IRepository<TipoDeMaquina> _tipoDeMaquinaRepository;
        private IRepository<TipoDePago> _tipoDePagoRepository;

        private IRepository<Musculo> _musculoRepository;
        private IRepository<Ejercicio> _ejercicioRepository;

        public IRepository<TipoDeMaquina> TipoDeMaquinaRepository
        {
            get
            {
                if (this._tipoDeMaquinaRepository == null)
                {
                    this._tipoDeMaquinaRepository = new TipoDeMaquinaRepository();
                }
                return _tipoDeMaquinaRepository;
            }
        }
        public IRepository<TipoDePago> TipoDePagoRepository
        {
            get
            {
                if (this._tipoDePagoRepository == null)
                {
                    this._tipoDePagoRepository = new TipoDePagoRepository();
                }
                return _tipoDePagoRepository;
            }
        }


        #region Musculos

        public IRepository<Musculo> MusculoRepository
        {
            get
            {
                if (this._musculoRepository == null)
                {
                    this._musculoRepository = new MusculoRepository();
                }

                return _musculoRepository;
            }

        }

        #endregion

        #region Ejercicios
        public IRepository<Ejercicio> EjercicioRepository
        {
            get
            {
                if (this._ejercicioRepository == null)
                {
                    this._ejercicioRepository = new EjercicioRepository();
                }

                return _ejercicioRepository;
            }

        }
        #endregion

    }
}