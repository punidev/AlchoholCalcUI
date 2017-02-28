using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.Infrastructure.Interfaces;

namespace AlcoholSimulatorUI.SQLRepository
{
    internal class CoctailsRepository : BaseRepository<int, Coctails>, ICoctailsRepository<Coctails>
    {

        public CoctailsRepository(SQLiteConnection connection, SqlTransactionManager transactionManager)
            : base(connection, transactionManager){ }

        public override int Insert(Coctails entity)
        {
            return ExecuteNonQuery(
                "INSERT INTO Coctails(RecipeId, Name,Quantity, Cost, Type)" +
                "values (@RecipeId, @Name, @Quantity, @Cost, @Type)",
                new SqlParameters
                {
                    {"RecipeId", entity.Recipeid},
                    {"Name", entity.Name},
                    {"Quantity", entity.Quantity},
                    {"Cost", entity.Cost},
                    {"Type", entity.Type}
                }
                );
        }

       

        public override bool Update(Coctails entity)
        {
            var res = ExecuteNonQuery(
                    "UPDATE Coctails SET RecipeId=@RecipeId, Name=@Name,Quantity=@Quantity, Cost=@Cost, Type=@Type  WHERE Name=@Name",
                    new SqlParameters
                    {
                        {"RecipeId", entity.Recipeid},
                        {"Name", entity.Name},
                        {"Quantity", entity.Quantity},
                        {"Cost", entity.Cost},
                        {"Type", entity.Type}
                    }
                );

            return res > 0;
        }

        public int GetCount()
        {
            return ExecuteScalar("SELECT count(*) FROM Coctails");
        }

        public int GetSeqCount()
        {
            return ExecuteScalar("SELECT seq FROM sqlite_sequence WHERE Name='Coctails'");
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

        protected override Coctails DefaultRowMapping(SQLiteDataReader reader)
        {
            return new Coctails
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = (string) reader["Name"],
                Recipeid = Convert.ToInt32(reader["RecipeId"]),
                Ingredient = MainForm.GetIngredients(Convert.ToInt32(reader["Id"])),
                Cost = Convert.ToInt32(reader["Cost"]),
                Quantity = Convert.ToInt32(reader["Quantity"]),
                Type = Convert.ToInt32(reader["Type"])
            };
        }
    }
}
