using System.Collections.Generic;

namespace AlcoholSimulatorUI.Class
{
    public class Alcohols
    {
        public static List<Alcohols> Items = new List<Alcohols>();
        public string Name { get; set; }
        public string Rank { get; set; }
        public override string ToString()
        {
            return $"Название - {Name}, {Rank}%";
        }
    }
}
