using DAL;
using EL;
using Exceptions.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorEventoCalendario
    {
        private UnitOfWork UoW = new UnitOfWork();

        public List<EventoCalendario> listarEventos()
        {
            return UoW.RepositoryEventoCalendario.GetAll().ToList<EventoCalendario>();
        }
        public void insertarEvento(int pUsuario, int pTipo, String pTitulo, String pDescripcion, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            EventoCalendario auxEvento = new EventoCalendario(pUsuario, pTipo, pTitulo, pDescripcion, pFechaInicial, pFechaFinal);
            UoW.RepositoryEventoCalendario.Insert(auxEvento);
            UoW.RepositoryEventoCalendario.Save();
        }
        public void modificarEvento(int pId, int pUsuario, int pTipo, String pTitulo, String pDescripcion, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            EventoCalendario auxEvento = new EventoCalendario(pId, pUsuario, pTipo, pTitulo, pDescripcion, pFechaInicial, pFechaFinal);
            UoW.RepositoryEventoCalendario.Update(auxEvento);
            UoW.RepositoryEventoCalendario.Save();
        }
        public void eliminarEvento(int pId)
        {
            EventoCalendario auxEvento = new EventoCalendario(pId);
            UoW.RepositoryEventoCalendario.Delete(auxEvento);
            UoW.RepositoryEventoCalendario.Save();
        }
    }
}
