using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class GestorSesion
    {
        #region variables sesion
        static Usuario _usuario;
        static List<Permiso> _permisos;

        public static Usuario usuarioSesion
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public static List<Permiso> listaPermiso
        {
            get
            {
                return _permisos;
            }
            set
            {
                _permisos = value;
            }
        }
        #endregion

        public Usuario iniciarSesion(String correo, String contrasena)
        {
            AccesoSesion acceso = new AccesoSesion();
            usuarioSesion = acceso.iniciarSesion(correo, contrasena);
            //_permisos = gr.(usuarioSesion.IdRol);

            return usuarioSesion;
        }

        public void cerrarSesion()
        {
            GestorEvento ge = new GestorEvento();
            Gestor g = new Gestor();
            //g.enviarCorreo();
            ge.insertarEvento("Cerrar sesión", "El usuario ha cerrado la sesión");
        }
    }
}
