using System;

namespace EL
{
    public class Horario
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _horaEntrada;

        public DateTime HoraEntrada
        {
            get { return _horaEntrada; }
            set { _horaEntrada = value; }
        }
        private DateTime _horaSalida;

        public DateTime HoraSalida
        {
            get { return _horaSalida; }
            set { _horaSalida = value; }
        }
        private int _diaSemana;

        public int DiaSemana
        {
            get { return _diaSemana; }
            set { _diaSemana = value; }
        }
        private Usuario _usuario;

        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }



    }
}
