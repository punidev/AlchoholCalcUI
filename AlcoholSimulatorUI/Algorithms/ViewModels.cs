namespace AlcoholSimulatorUI.Algorithms
{
    internal class ViewModels
    {
        public static string Display()
        {
            return $"Сумма коктейлей: {OptimizedData.DisplayCost}\n" +
                   $"{OptimizedData.DisplayInxtoxication}\n" +
                   $"{OptimizedData.DisplayAssembly}";
        }
    }
}
