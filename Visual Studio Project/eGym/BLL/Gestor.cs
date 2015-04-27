using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;


using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Gestor
    {
        // VARIABLES
        private UnitOfWork unitOfWork;

        // CONSTRUCTOR
        public Gestor()
        {
            unitOfWork = new UnitOfWork();
        }

        // USUARIO

        public IEnumerable<Usuario> ListarUsuarios()
        {
            return unitOfWork.RepositoryUsuario.GetAll();
        }

        

        public Usuario ObtenerUsuario(int pId)
        {
            var usuario = unitOfWork.RepositoryUsuario.GetById(pId);
            foreach (var contacto in unitOfWork.RepositoryContacto.GetAll())
            {
                if (contacto.Usuario.Id == usuario.Id)
                {
                    usuario.Contactos.Add(contacto);
                }
            }
            foreach (var horario in unitOfWork.RepositoryHorario.GetAll())
            {
                if (horario.Usuario.Id == usuario.Id)
                {
                    usuario.Horarios.Add(horario);
                }
            }
            return usuario;
        }

        public void AgregarUsuario(string pIdentificacion, string pNombre, string pSegundoNombre, string pApellido, string pSegundoApellido, string pAlias, DateTime pFechaNacimiento, string pCorreoElectronico, string pContrasena, byte[] pFotografia, DateTime pFechaIngreso, string pNumeroTelefono, string pNumeroCelular, int pIdRol, int pIdGenero, int pTipoIdentificacion)
        {
            Usuario usuario = new Usuario();
            usuario.Identificacion = pIdentificacion;
            usuario.Nombre = pNombre;
            usuario.SegundoNombre = pSegundoNombre;
            usuario.Apellido = pApellido;
            usuario.SegundoApellido = pSegundoApellido;
            usuario.Alias = pAlias;
            usuario.FechaNacimiento = pFechaNacimiento;
            usuario.CorreoElectronico = pCorreoElectronico;
            usuario.Contrasena = pContrasena;
            usuario.Fotografia = pFotografia;
            usuario.FechaIngreso = pFechaIngreso;
            usuario.NumeroTelefono = pNumeroTelefono;
            usuario.NumeroCelular = pNumeroCelular;
            usuario.IdGenero = pIdGenero;
            usuario.Rol = new GestorRol().obtenerRol(pIdRol)[0];
            usuario.IdTipoIdentificacion = pTipoIdentificacion;
            
            unitOfWork.RepositoryUsuario.Insert(usuario);
            unitOfWork.RepositoryUsuario.Save();
        }

        public void EliminarUsuario(Usuario usuario)
        {
            unitOfWork.RepositoryUsuario.Delete(usuario);
            unitOfWork.RepositoryUsuario.Save();
        }

        public void ModificarUsuario(int pId, string pIdentificacion, string pNombre, string pSegundoNombre, string pApellido, string pSegundoApellido, string pAlias, DateTime pFechaNacimiento, string pCorreoElectronico, string pContrasena, byte[] pFotografia, DateTime pFechaIngreso, string pNumeroTelefono, string pNumeroCelular, int pIdRol, int pIdGenero, int pTipoIdentificacion)
        {
            Usuario usuario = new Usuario();
            usuario.Id = pId;
            usuario.Identificacion = pIdentificacion;
            usuario.Nombre = pNombre;
            usuario.SegundoNombre = pSegundoNombre;
            usuario.Apellido = pApellido;
            usuario.SegundoApellido = pSegundoApellido;
            usuario.Alias = pAlias;
            usuario.FechaNacimiento = pFechaNacimiento;
            usuario.CorreoElectronico = pCorreoElectronico;
            usuario.Contrasena = pContrasena;
            usuario.Fotografia = pFotografia;
            usuario.FechaIngreso = pFechaIngreso;
            usuario.NumeroTelefono = pNumeroTelefono;
            usuario.NumeroCelular = pNumeroCelular;
            usuario.IdGenero = pIdGenero;
            usuario.Rol = new GestorRol().obtenerRol(pIdRol)[0];
            usuario.IdTipoIdentificacion = pTipoIdentificacion;

            unitOfWork.RepositoryUsuario.Update(usuario);
            unitOfWork.RepositoryUsuario.Save();
        }

        // CONTACTOS

        public IEnumerable<Contacto> ListarContactos()
        {
            return unitOfWork.RepositoryContacto.GetAll();
        }

        public Contacto ObtenerContacto(int pId)
        {
            return unitOfWork.RepositoryContacto.GetById(pId);
        }

        public void AgregarContacto(string pNombre, string pNumero, string pParentesco, int pUsuario)
        {
            var contacto = new Contacto();
            contacto.Nombre = pNombre;
            contacto.Telefono = pNumero;
            contacto.Parentesco = pParentesco;
            contacto.Usuario = new Usuario();
            contacto.Usuario.Id = pUsuario;

            unitOfWork.RepositoryContacto.Insert(contacto);
            unitOfWork.RepositoryContacto.Save();
        }

        public void EliminarContacto(Contacto contacto)
        {
            unitOfWork.RepositoryContacto.Delete(contacto);
            unitOfWork.RepositoryContacto.Save();
        }

        public void ModificarContacto(int pId, string pNombre, string pNumero, string pParentesco, int pUsuario)
        {
            var contacto = new Contacto();
            contacto.Id = pId;
            contacto.Nombre = pNombre;
            contacto.Telefono = pNumero;
            contacto.Parentesco = pParentesco;
            contacto.Usuario = new Usuario() { Id = pUsuario };

            unitOfWork.RepositoryContacto.Update(contacto);
            unitOfWork.RepositoryContacto.Save();
        }

        // HORARIOS

        public IEnumerable<Horario> ListarHorarios()
        {
            return unitOfWork.RepositoryHorario.GetAll();
        }

        public Horario ObtenerHorario(int pId)
        {
            return unitOfWork.RepositoryHorario.GetById(pId);
        }

        public void AgregarHorario(DateTime pHoraEntrada, DateTime pHoraSalida, int pDiaSemana, int pIdUsuario)
        {
            var usuario = ObtenerUsuario(pIdUsuario);
            var horario = new Horario();
            horario.DiaSemana = pDiaSemana;
            horario.HoraEntrada = pHoraEntrada;
            horario.HoraSalida = pHoraSalida;
            horario. Usuario = usuario;
            unitOfWork.RepositoryHorario.Insert(horario);
            unitOfWork.RepositoryHorario.Save();
        }

        public void EliminarHorario(int pId)
        {
            var horario = new Horario() { Id = pId };
            unitOfWork.RepositoryHorario.Delete(horario);
            unitOfWork.RepositoryHorario.Save();
        }

        public void ModificarHorario(int pId, DateTime pHoraEntrada, DateTime pHoraSalida, int pDiaSemana, int pIdUsuario)
        {
            var usuario = ObtenerUsuario(pIdUsuario);
            var horario = new Horario();
            horario.Id = pId;
            horario.DiaSemana = pDiaSemana;
            horario.HoraEntrada = pHoraEntrada;
            horario.HoraSalida = pHoraSalida;
            horario.Usuario = usuario;
            unitOfWork.RepositoryHorario.Update(horario);
            unitOfWork.RepositoryHorario.Save();
        }

        public void enviarCorreo()
        {
            var client = new SmtpClient("smtp.gmail.com", 25);
            client.Credentials = new NetworkCredential("egymappegymappegymapp@hotmail.com", "C0ntr4sn@1234");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send("egymapp@hotmail.com", "sebaslamu@gmail.com", "test", "testbody");
            Console.ReadLine();
        }


        // Listar usuariosXrol
        public List<Usuario> listarUsuariosPorRol(int roleId)
        {
            Rol rol = new Rol(roleId);
            return ((DAL.Repositories.UsuarioRepository)unitOfWork.RepositoryUsuario).GetUsuarioPorRol(rol).ToList<Usuario>();      
        }        
    }
}