using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI.Infrastructure.Interfaces
{
    public interface ICoctailsRepository : IBaseRepository<int, Coctails>
    {
        IList<Coctails> GetByCoctailId(int coctailId);
    }
}
