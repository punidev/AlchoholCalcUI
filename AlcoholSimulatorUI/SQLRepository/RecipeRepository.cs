using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.Infrastructure.Interfaces;

namespace AlcoholSimulatorUI.SQLRepository
{
    internal class RecipeRepository : BaseRepository<int, Recipes>, IRecipesRepository<Recipes>
    {

        public RecipeRepository(SQLiteConnection connection, SqlTransactionManager transactionManager)
            : base(connection, transactionManager) { }

        public override int Insert(Recipes entity)
        {
            return ExecuteNonQuery(
                "INSERT INTO Recipes (RecipeId,AlcoId,Part)" +
                "values (@RecipeId,@AlcoId,@Part)",
                new SqlParameters
                    {
                        {"RecipeId", entity.RecipeId},
                        {"AlcoId", entity.AlcoId},
                        {"Part", entity.Part}
                    }
                );
        }



        public override bool Update(Recipes entity)
        {
            var res = ExecuteNonQuery(
                    "UPDATE Recipes SET RecipeId=@RecipeId, AlcoId=@AlcoId, Part=@Part WHERE RecipeId=@RecipeId",
                    new SqlParameters
                    {
                        {"RecipeId", entity.RecipeId},
                        {"AlcoId", entity.AlcoId},
                        {"Part", entity.Part}
                    }
                );

            return res > 0;
        }

        public int GetCount()
        {
            return ExecuteScalar("SELECT count(*) FROM Recipes");
        }

        public Recipes GetById(int id)
        {
            return ExecuteSingleRowSelect(
                    "SELECT * FROM Recipes WHERE Id=@id",
                    new SqlParameters { { "id", id } });
        }


        public bool Delete(string name)
        {
            var res = base.ExecuteNonQuery(
                "DELETE FROM Recipes WHERE RecipeId=@name",
                new SqlParameters { { "name", name } });

            if (res > 1)
                throw new InvalidOperationException("Multiple rows deleted by single delete query");

            return res == 1;
        }

        public IList<Recipes> GetAll()
        {
            return ExecuteSelect("SELECT * FROM Recipes");
        }
        public IList<Recipes> GetAllAlcohols(int id)
        {
            return ExecuteSelect("SELECT * FROM Recipes WHERE RecipeId=@id", new SqlParameters { { "id", id } });
        }

        protected override Recipes DefaultRowMapping(SQLiteDataReader reader)
        {
            string part = (string) reader["Part"];
            return new Recipes
            {
                
                Id = Convert.ToInt32(reader["Id"]),
                RecipeId = Convert.ToInt32(reader["RecipeId"]),
                AlcoId = Convert.ToInt32(reader["AlcoId"]),
                Part = Convert.ToDouble(part.Replace('.',','))
            };
        }

    }
}
