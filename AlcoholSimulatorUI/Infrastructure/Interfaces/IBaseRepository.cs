using System.Collections.Generic;

namespace AlcoholSimulatorUI.Infrastructure.Interfaces
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        TKey Insert(TEntity entity);
        bool Update(TEntity entity);
        TKey Upsert(TEntity entity);

        int GetCount();

        TEntity GetById(TKey id);
        bool Delete(string id);

        IList<TEntity> GetAll();
    }
}
