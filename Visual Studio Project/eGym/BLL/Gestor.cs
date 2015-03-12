using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace BLL
{
    public class Gestor
    {
        private UnitOfWork unitOfWork;

        public Gestor()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Usuario> ListarUsuarios()
        {
            var lista = unitOfWork.RepositoryUsuario.GetAll();
            return lista;
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

    }
}