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
        private IRepository<Rol> _rolRepository;
        private IRepository<Permiso> _permisoRepository;

        private IRepository<Pago> _pagoRepository;
        private IRepository<Maquina> _maquinaRepository;
        private IRepository<TipoDePago> _tipoDePagoRepository;

        
        
        private IRepository<Usuario> _repositoryUsuario;
        private IRepository<Excepcion> _excepcionRepository;
        private IRepository<Evento> _eventoRepository;

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
        public IRepository<Rol> RolRepository
        {
            get
            {
                if (this._rolRepository == null)
                {
                    this._rolRepository = new RolRepository();
                }
                return _rolRepository;
            }
        }

        public IRepository<Permiso> PermisosRepository
        {
            get
            {
                if (this._permisoRepository == null)
                {
                    this._permisoRepository = new PermisoRepository();
                }
                return _permisoRepository;
            }
        }


        public IRepository<Pago> PagoRepository
        {
            get
            {
                if (this._pagoRepository == null)
                {
                    this._pagoRepository = new PagoRepository();
                }
                return _pagoRepository;
            }
        }
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

        public IRepository<Usuario> RepositoryUsuario
        {
            get
            {
                if (_repositoryUsuario == null)
                {
                    _repositoryUsuario = new UsuarioRepository();
                }
                return _repositoryUsuario;

            }
        }

        public IRepository<Maquina> MaquinaRepository
        {
            get
            {
                if (this._maquinaRepository == null)
                {
                    this._maquinaRepository = new MaquinaRepository();
                }
                return _maquinaRepository;
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
        public IRepository<Excepcion> ExcepcionRepository
        {
            get
            {
                if (this._excepcionRepository == null)
                {
                    this._excepcionRepository = new ExcepcionRepository();
                }
                return _excepcionRepository;
            }
        }
        public IRepository<Evento> EventoRepository
        {
            get
            {
                if (this._eventoRepository == null)
                {
                    this._eventoRepository = new EventoRepository();
                }
                return _eventoRepository;
            }
        }
    }
}