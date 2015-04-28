using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Mensaje : IEntity
    {
        public int Id { get; set; }
        public Usuario Destinatario { get; set; }
        public Usuario Remitente { get; set; }
        public string Texto { get; set; }
        public DateTime FechaYHora { get; set; }
        public bool Leido { get; set; }

        public Mensaje()
        {
            Destinatario = Remitente = new Usuario();
        }
    }
}
