using System.Collections.Generic;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI.Infrastructure.Interfaces
{
    public interface IAlcoholsRepository<T> : IBaseRepository<int, Alcohols>
    {
        T GetById(int id);
    }
}
