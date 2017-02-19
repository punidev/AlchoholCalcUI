using System.Collections.Generic;

namespace AlcoholSimulatorUI
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Part { get; set; }
        public double Rank { get; set; }
        public override string ToString()
        {
            return $"Название - {Name} : Крепкость - {Rank * 100}% : Доля в коктейле - {Part}";
        }
    }
}