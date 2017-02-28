using System.Collections.Generic;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI.Infrastructure.Interfaces
{
    public interface IAlcoholsRepository : IBaseRepository<int, Alcohols>
    {
        IList<Alcohols> GetByAlcoId(int alcoId);
    }
}
