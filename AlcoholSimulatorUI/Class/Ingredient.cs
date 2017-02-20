namespace AlcoholSimulatorUI.Class
{
    public class Ingredient : Alcohols
    {
        public string Name { get; set; }
        public double Part { get; set; }
        public double Rank { get; set; }
        public override string ToString()
        {
            return $"{Name} : Крепкость - {Rank * 100}% : Доля в коктейле - {Part}";
        }
    }
}