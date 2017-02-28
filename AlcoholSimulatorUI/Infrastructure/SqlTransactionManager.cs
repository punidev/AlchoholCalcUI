using System;
using System.Data.SQLite;
using AlcoholSimulatorUI.Infrastructure.Interfaces;

namespace AlcoholSimulatorUI.Infrastructure
{
    internal class SqlTransactionManager : ITransactionManager
    {
        private readonly SQLiteConnection _connection;
        private SQLiteTransaction _transaction;

        public SqlTransactionManager(SQLiteConnection connection)
        {
            _connection = connection;
        }

        internal SQLiteTransaction CurrentTransaction => _transaction;

        ~SqlTransactionManager()
        {
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _transaction = null;
        }

        public IDisposable Begin()
        {
            //TODO add nested TX, aka. checkpoints support
            _transaction?.Dispose();
            _transaction = _connection.BeginTransaction(/*IsolationLevel.ReadCommitted*/);
            return this;
        }

        public void Commit()
        {
            _transaction?.Commit();
            _transaction = null;
        }

        public void RollBack()
        {
            _transaction?.Rollback();
            _transaction = null;
        }

    }
}
