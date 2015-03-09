using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;


namespace BLL
{
    public class GestorRol
    {
        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<Rol> listarRoles()
        {
            return UoW.RolRepository.GetAll();
        }

        public void insertarRol(String pnombre, String pDescripcion,List<int> plistaPermisosxRol) {

            Rol objRol = null;
            objRol = new Rol();
            objRol.Nombre = pnombre;
            objRol.Descripcion = pDescripcion;

            List<Permiso> listaPermisos = new List<Permiso>();

                foreach(int id in plistaPermisosxRol){
                    Permiso objPermiso = new Permiso();
                    objPermiso.Id = id;
                    listaPermisos.Add(objPermiso);
                }

            objRol.ListaPermisos = listaPermisos;

            UoW.RolRepository.Insert(objRol);
            UoW.RolRepository.Save();


        }

        public void ModificarRol(int pId, String pnombre, String pDescripcion, List<int> plistaPermisosxRol)
        {

            Rol objRol = null;
            objRol = new Rol();
            objRol.Id = pId;
            objRol.Nombre = pnombre;
            objRol.Descripcion = pDescripcion;

            List<Permiso> listaPermisos = new List<Permiso>();

            foreach (int id in plistaPermisosxRol)
            {
                Permiso objPermiso = new Permiso();
                objPermiso.Id = id;
                listaPermisos.Add(objPermiso);
            }

            objRol.ListaPermisos = listaPermisos;

            UoW.RolRepository.Update(objRol);
            UoW.RolRepository.Save();


        }

        public void EliminarRol(int pId)
        {
            Rol objRol = null;
            objRol = new Rol();
            objRol.Id = pId;
            UoW.RolRepository.Delete(objRol);
            UoW.RolRepository.Save();
        }

        public List<Rol> obtenerRol(int id) {
            List<Rol> listaRoles = new List<Rol>();
            listaRoles.Add(UoW.RolRepository.GetById(id));
            return listaRoles;
        }

    }
}
