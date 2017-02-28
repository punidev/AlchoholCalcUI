using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.Infrastructure.Interfaces;

namespace AlcoholSimulatorUI.SQLRepository
{
    internal class AlcoholsRepository : BaseRepository<int, Alcohols>, IAlcoholsRepository
    {

        public AlcoholsRepository(SQLiteConnection connection, SqlTransactionManager transactionManager)
                : base(connection, transactionManager){ }

        public override int Insert(Alcohols entity)
        {
            return  ExecuteNonQuery(
                    "INSERT INTO Alcohols(Name, Rank) VALUES (@Name,@Rank)",
                    new SqlParameters
                        {
                            {"Name", entity.Name},
                            {"Rank", entity.Rank}
                        }
                    );
        }

        public override bool Update(Alcohols entity)
        {
            var res = ExecuteNonQuery(
                      "UPDATE Alcohols SET Name=@Name, Rank=@Rank WHERE Id=@Id",
                      new SqlParameters
                      {
                            {"Id", entity.Id},
                            {"Name", entity.Name},
                            {"Rank", entity.Rank}
                      }
                );
            return res > 0;
        }

        public int GetCount()
        {
            return ExecuteScalar<int>("SELECT count(*) FROM Alcohols");
        }

        public Alcohols GetById(int id)
        {
            return ExecuteSingleRowSelect(
                   "SELECT * FROM Alcohols WHERE Id=@id",
                   new SqlParameters{ { "id", id } });
        }
        public bool Delete(string name)
        {
            var res = ExecuteNonQuery(
                "DELETE FROM Alcohols WHERE Name=@name",
                new SqlParameters {{ "name", name } });

            if (res > 1)
                throw new InvalidOperationException("Multiple rows deleted by single delete query");

            return res == 1;
        }

        public IList<Alcohols> GetAll()
        {
            return base.ExecuteSelect("SELECT * FROM Alcohols");
        }

        public IList<Alcohols> GetByAlcoId(int alcoId)
        {
            return base.ExecuteSelect(
                "SELECT * FROM Alcohols WHERE Id=@alcoId",
                new SqlParameters{{"alcoId", alcoId}}
                );
        }


        protected override Alcohols DefaultRowMapping(SQLiteDataReader reader)
        {
            return new Alcohols
            {
                Name = (string)reader["Name"],
                Rank = (string)reader["Rank"]
            };
        }
    }
}
