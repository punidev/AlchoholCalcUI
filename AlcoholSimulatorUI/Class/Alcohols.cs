using System.Collections.Generic;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.SQLRepository;

namespace AlcoholSimulatorUI.Class
{
    public class Alcohols : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public override string ToString()
        {
            return $"Название - {Name}, {Rank}%";
        }
    }
}
