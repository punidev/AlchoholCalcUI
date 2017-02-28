using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AlcoholSimulatorUI.Infrastructure
{
    internal abstract class BaseRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        private readonly SQLiteConnection _connection;
        private readonly SqlTransactionManager _transactionManager;

        protected BaseRepository(SQLiteConnection connection, SqlTransactionManager transactionManager)
        {
            _connection = connection;
            _transactionManager = transactionManager;
        }


        protected T ExecuteScalar<T>(string sql, IDictionary<string, object> parameters = null)
        {
            using (var command = new SQLiteCommand(sql, _connection, _transactionManager.CurrentTransaction))
            {
                FillParameters(parameters, command);
                return (T) command.ExecuteScalar();
            }
        }

        protected int ExecuteNonQuery(string sql, IDictionary<string, object> parameters = null)
        {
            using (var command = new SQLiteCommand(sql, _connection, _transactionManager.CurrentTransaction))
            {
                FillParameters(parameters, command);
                return command.ExecuteNonQuery();
            }
        }

        protected T ExecuteSingleRowSelect<T>(
            string sql,
            Func<SQLiteDataReader, T> rowMapping,
            IDictionary<string, object> parameters = null
            )
        {
            using (var command = new SQLiteCommand(sql, _connection, _transactionManager.CurrentTransaction))
            {
                FillParameters(parameters, command);
                using (var reader = command.ExecuteReader())
                {
                    return reader.Read() ? rowMapping(reader) : default(T);
                }
            }
        }


        protected IList<T> ExecuteSelect<T>(
            string sql,
            Func<SQLiteDataReader, T> rowMapping,
            IDictionary<string, object> parameters = null
            )
        {
            using (var command = new SQLiteCommand(sql, _connection, _transactionManager.CurrentTransaction))
            {
                FillParameters(parameters, command);
                using (var reader = command.ExecuteReader())
                {
                    var list = new List<T>(1);
                    while (reader.Read())
                    {
                        list.Add(rowMapping(reader));
                    }
                    return list;
                }
            }
        }


        protected TEntity ExecuteSingleRowSelect(string sql, SqlParameters sqlParameters = null)
        {
            return ExecuteSingleRowSelect(sql, DefaultRowMapping, sqlParameters);
        }

        protected IList<TEntity> ExecuteSelect(string sql, SqlParameters sqlParameters = null)
        {
            return ExecuteSelect(sql, DefaultRowMapping, sqlParameters);
        }

        private static void FillParameters(IDictionary<string, object> parameters, SQLiteCommand command)
        {
            if (parameters == null) return;
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
            }
        }


        public TKey Upsert(TEntity entity)
        {
            if (Equals(entity.Id, default(TKey)))
                return Insert(entity);
            return Update(entity) ? entity.Id : default(TKey);
        }

        public abstract TKey Insert(TEntity entity);
        public abstract bool Update(TEntity entity);
        protected abstract TEntity DefaultRowMapping(SQLiteDataReader reader);

    }
}
