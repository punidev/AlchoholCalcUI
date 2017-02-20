using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

    public class User : Coctails
    {
        public static List<User> Items = new List<User>();

        public static double Calculator(
            List<Ingredient> list,
            int weight,
            int quant,
            int count,
            Func<Ingredient, double> action)
        {
            double sumOfAlco = list.Sum(action);
            var res = quant*sumOfAlco*0.79*0.9/(weight*0.7);
            return Math.Round(res, 3);
        }
        

        public int Weight { get; set; }
        public double Promille { get; set; }

        public override string ToString()
        {
            return $"Название - {Name}, объем - {Quantity}, цена - {Cost}, промилле - {Promille}";
        }
    }
}