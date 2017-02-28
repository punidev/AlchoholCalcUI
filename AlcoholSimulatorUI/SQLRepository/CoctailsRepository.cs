using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.Infrastructure.Interfaces;

namespace AlcoholSimulatorUI.SQLRepository
{
    internal class CoctailsRepository : BaseRepository<int, Coctails>, ICoctailsRepository
    {

        public CoctailsRepository(SQLiteConnection connection, SqlTransactionManager transactionManager)
            : base(connection, transactionManager){ }

        public override int Insert(Coctails entity)
        {
            return ExecuteNonQuery(
                "INSERT INTO Coctails(Name, Ingredients, Parts,Ranks, Quantity, Cost)" +
                "values (@Name, @Ingredients, @Parts, @Ranks, @Quantity, @Cost)",
                new SqlParameters
                    {
                        {"Name", entity.Name},
                        {"Ingredients", Coctails.GetString(entity.Ingredient, "Ingredients")},
                        {"Parts", Coctails.GetString(entity.Ingredient, "Parts")},
                        {"Ranks", Coctails.GetString(entity.Ingredient, "Ranks")},
                        {"Quantity", entity.Quantity},
                        {"Cost", entity.Cost}
                    }
                );
        }

       

        public override bool Update(Coctails entity)
        {
            var res = ExecuteNonQuery(
                    "UPDATE Coctails SET Name=@Name, Ingredients=@Ingredients, Parts=@Parts," +
                    " Ranks=@Ranks, Quantity=@Quantity, Cost=@Cost  WHERE Name=@Name",
                    new SqlParameters
                    {
                        {"Name", entity.Name},
                        {"Ingredients", Coctails.GetString(entity.Ingredient,"Ingredients")},
                        {"Parts", Coctails.GetString(entity.Ingredient,"Parts")},
                        {"Ranks", Coctails.GetString(entity.Ingredient,"Ranks")},
                        {"Quantity", entity.Quantity},
                        {"Cost", entity.Cost}
                    }
                );

            return res > 0;
        }

        public int GetCount()
        {
            return ExecuteScalar<int>("SELECT count(*) FROM Coctails");
        }

        public Coctails GetById(int id)
        {
            return  ExecuteSingleRowSelect(
                    "SELECT * FROM Coctails WHERE Id=@id",
                    new SqlParameters{ {"id",id} });
        }


        public bool Delete(string name)
        {
            var res = base.ExecuteNonQuery(
                "DELETE FROM Coctails WHERE Name=@name",
                new SqlParameters { { "name", name } });

            if (res > 1)
                throw new InvalidOperationException("Multiple rows deleted by single delete query");

            return res == 1;
        }

        public IList<Coctails> GetAll()
        {
            return ExecuteSelect("SELECT * FROM Coctails");
        }

        public IList<Coctails> GetByCoctailId(int coctailId)
        {
            return base.ExecuteSelect(
                "SELECT * FROM Coctails WHERE Id=@coctailId",
                new SqlParameters { { "coctailId", coctailId } });
        }

       

        protected override Coctails DefaultRowMapping(SQLiteDataReader reader)
        {
            return new Coctails
            {
                Name = (string) reader["Name"],
                Ingredient = Coctails.GetIngredients(reader),
                Cost = Convert.ToInt32(reader["Cost"]),
                Quantity = Convert.ToInt32(reader["Quantity"])
            };
        }
    }
}
