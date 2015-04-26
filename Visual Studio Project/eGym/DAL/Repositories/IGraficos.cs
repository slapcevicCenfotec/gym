using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL.Repositories
{
    public interface IGraficos<T>
    {
        IEnumerable<T> GetAllByCliente(int id);
    }
}
