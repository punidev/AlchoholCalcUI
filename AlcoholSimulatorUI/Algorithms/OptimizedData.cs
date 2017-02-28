using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI.Algorithms
{
    internal class OptimizedData : OptimizedList
    {
        public OptimizedData(SQLiteConnection s) 
            : base(s){ }

        public static double DisplayCost { get; set; }
        public static string DisplayInxtoxication { get; set; }
        public static string DisplayAssembly { get; set; }
        public static List<User> PrimaryItems = new List<User>();
        public static List<User> SecondaryItems = new List<User>();
        public static List<Coctails> MultiplyItems = new List<Coctails>();
        public static List<string> DisassemblyLogs = new List<string>(); 
    }
}
