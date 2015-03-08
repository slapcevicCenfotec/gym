using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GestorPermiso
    {

        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<Permiso> listarPermisos()
        {
            return UoW.PermisosRepository.GetAll();
        }


    }
}
