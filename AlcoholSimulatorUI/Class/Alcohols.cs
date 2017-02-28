using AlcoholSimulatorUI.Infrastructure;

namespace AlcoholSimulatorUI.Class
{
    public class Alcohols : BaseEntity<int>
    {
        public new int? Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public override string ToString()
        {
            return $"Название - {Name}, {Rank}%";
        }
    }
}
