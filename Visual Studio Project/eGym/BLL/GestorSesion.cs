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
        public Usuario iniciarSesion(String correo, String contrasena)
        {
            Usuario usuario;
            AccesoSesion acceso = new AccesoSesion();
            usuario = acceso.iniciarSesion(correo, contrasena);
            return usuario;
        }
    }
}
