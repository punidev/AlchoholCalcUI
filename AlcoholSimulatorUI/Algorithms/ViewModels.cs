using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholSimulatorUI.Algorithms
{
    internal class ViewModels
    {
        public static string Display()
        {
            return $"Сумма коктейлей: {OptimizedData.DisplayCost}\n{OptimizedData.DisplayInxtoxication}\n{OptimizedData.DisplayAssembly}";
        }
        
    }
}
