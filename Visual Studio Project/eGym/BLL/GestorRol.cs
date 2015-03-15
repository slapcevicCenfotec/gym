using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;
using Exceptions.CustomExceptions;
using System.Data.SqlClient;



namespace BLL
{
    /// <summary>
    /// Autor:Alexis Soto
    /// Fecha:03/15/2015
    /// Descripcion: Esta clase se encarga de manejar los metodos de insercion, modificaion y eliminacionpara los Roles del sistema
    /// </summary>
    public class GestorRol
    {
        private UnitOfWork UoW = new UnitOfWork();
        private GestorExcepcion gestorExcepciones = new GestorExcepcion();
        private GestorEvento gestorEventos = new GestorEvento();
        //private GestorSesion gestorSesion;

        /// <summary>
        /// Autor:Alexis Soto
        /// Fecha:03/15/2015
        /// Descripcion: Este metodo devuelve una lista de roles.
        /// </summary>
        /// <returns>List<Rol></returns>
        public IEnumerable<Rol> listarRoles()
        {
            return UoW.RolRepository.GetAll();
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha:03/15/2015
        /// 
        /// Descripcion: Llamma al metodo para insertar un rol.
        /// </summary>
        /// <param name="pnombre">The pnombre.</param>
        /// <param name="pDescripcion">The p descripcion.</param>
        /// <param name="plistaPermisosxRol">The plista permisosx rol.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error agregando el rol
        /// or
        /// Ha ocurrido un error agregando el rol
        /// </exception>
        public void insertarRol(String pnombre, String pDescripcion, List<int> plistaPermisosxRol)
        {

            Rol objRol = null;
            objRol = new Rol();
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

            try
            {
                if (objRol.IsValid)
                {
                    UoW.RolRepository.Insert(objRol);
                    UoW.RolRepository.Save();

                    gestorEventos.insertarEvento("Insertar rol", "El usuario a insertado el rol " + objRol.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRol.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
            catch (SqlException ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando el rol");
            }
            catch (Exception ex)
            {
                gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
                throw new DataAccessException("Ha ocurrido un error agregando el rol");
            }
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Este meetodo se encargar Modificar un rol.
        /// </summary>
        /// <param name="pId">The p identifier.</param>
        /// <param name="pnombre">The pnombre.</param>
        /// <param name="pDescripcion">The p descripcion.</param>
        /// <param name="plistaPermisosxRol">The plista permisosx rol.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error modificando el rol
        /// or
        /// Ha ocurrido un error modificando el rol
        /// </exception>
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

         try
            {
                if (objRol.IsValid)
                {

                    UoW.RolRepository.Update(objRol);
                    UoW.RolRepository.Save();
                    gestorEventos.insertarEvento("Modificar rol", "El usuario a modificado el rol " + objRol.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRol.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
         catch (SqlException ex)
         {
             gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
             throw new DataAccessException("Ha ocurrido un error modificando el rol");
         }
         catch (Exception ex)
         {
             gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
             throw new DataAccessException("Ha ocurrido un error modificando el rol");
         }

        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Este metodo se encraga de  Eliminar un rol.
        /// </summary>
        /// <param name="pId">The p identifier.</param>
        /// <param name="pnombre">The pnombre.</param>
        /// <param name="pDescripcion">The p descripcion.</param>
        /// <exception cref="BusinessLogicException"></exception>
        /// <exception cref="DataAccessException">
        /// Ha ocurrido un error Eliminando el rol
        /// or
        /// Ha ocurrido un error Eliminiado el rol
        /// </exception>
        public void EliminarRol(int pId,String pnombre,String pDescripcion)
        {
            Rol objRol = null;
            List<Permiso> listaPermisos = new List<Permiso>();
            objRol = new Rol();
            objRol.Id = pId;
            objRol.Nombre = pnombre;
            objRol.Descripcion = pDescripcion;
            objRol.Habilitado= true;
            objRol.ListaPermisos = listaPermisos;
         try
            {
                if (objRol.IsValid)
                {

                    UoW.RolRepository.Delete(objRol);
                    UoW.RolRepository.Save();
                    gestorEventos.insertarEvento("Eliminar rol", "El usuario a Eliminado el rol " + objRol.Nombre + " al sistema.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (RuleViolation rv in objRol.GetRuleViolations())
                    {
                        sb.AppendLine(rv.ErrorMessage);
                    }
                    throw new BusinessLogicException(sb.ToString());
                }
            }
         catch (SqlException ex)
         {
             gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
             throw new DataAccessException("Ha ocurrido un error Eliminando el rol");
         }
         catch (Exception ex)
         {
             gestorExcepciones.insertarExcepcion(ex.Message, ex.StackTrace);
             throw new DataAccessException("Ha ocurrido un error Eliminiado el rol");
         }
        }

        /// <summary>
        /// Autor: Alexis Soto
        /// Fecha: 03/15/2015
        /// Descripcion: Este metodo devuelve un rol cuando se le envia el id
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns> List<Rol></returns>
        public List<Rol> obtenerRol(int id)
        {
            List<Rol> listaRoles = new List<Rol>();
            listaRoles.Add(UoW.RolRepository.GetById(id));
            return listaRoles;
        }

    }
}
