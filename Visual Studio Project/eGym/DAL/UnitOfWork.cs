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
<<<<<<< HEAD
        private IRepository<Rol> _rolRepository;
        private IRepository<Permiso> _permisoRepository;
=======
        private IRepository<Maquina> _maquinaRepository;
        private IRepository<TipoDePago> _tipoDePagoRepository;
>>>>>>> 729a6dbcfcd1af619261320d608516419cd4b8f7

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

<<<<<<< HEAD
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

        public IRepository<Permiso> PermisosRepository {
            get
            {
                if (this._permisoRepository == null)
                {
                    this._permisoRepository = new PermisoRepository();
                }
                return _permisoRepository;
=======
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
>>>>>>> 729a6dbcfcd1af619261320d608516419cd4b8f7
            }
        }

    }
}