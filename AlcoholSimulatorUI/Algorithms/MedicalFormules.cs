using System;
using System.Collections.Generic;
using System.Linq;

namespace AlcoholSimulatorUI.Algorithms
{
    internal class MedicalFormules
    {
        public static double Calculator<T>(List<T> list, int weight, int quant, int count,
            Func<T, double> action) 
        {
            double sumOfAlco = list.Sum(action);
            var res = quant * sumOfAlco * 0.79 * 0.9 / (weight * 0.7);
            return Math.Round(res, 3);
        }
    }
}
