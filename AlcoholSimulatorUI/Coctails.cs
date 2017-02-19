using System.Collections.Generic;

namespace AlcoholSimulatorUI
{
    public class Coctails
    {
        public static List<Coctails> Items = new List<Coctails>();
        public string Name { get; set; }
        public List<Ingredient> Ingredient { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public override string ToString()
        {
            return $"Название - {Name}, объем - {Quantity}, цена - {Cost}";
        }
    }
}