using System.Data.SQLite;
using AlcoholSimulatorUI.Infrastructure;

namespace AlcoholSimulatorUI.SQLRepository
{
    internal class FormPointers
    {
        private SQLiteConnection _sqLiteConnection;
        public CoctailsRepository CoctailsRepository { get; }
        public AlcoholsRepository AlcoholsRepository { get; }
        public RecipeRepository RecipesRepository { get; }

        public FormPointers(SQLiteConnection s)
        {
            _sqLiteConnection = s;
            CoctailsRepository = new CoctailsRepository(_sqLiteConnection, 
                new SqlTransactionManager(_sqLiteConnection));
            AlcoholsRepository = new AlcoholsRepository(_sqLiteConnection,
                new SqlTransactionManager(_sqLiteConnection));
            RecipesRepository = new RecipeRepository(_sqLiteConnection,
                new SqlTransactionManager(_sqLiteConnection));
        }   
    }
}
