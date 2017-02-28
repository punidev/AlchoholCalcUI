using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholSimulatorUI.Infrastructure.Interfaces
{
    public interface ITransactionManager : IDisposable
    {
        /// <summary>
        /// Returned disposable will auto close TX (rollback if not commited)
        /// </summary>
        /// <returns></returns>
        IDisposable Begin();
        void Commit();
        void RollBack();
    }
}
