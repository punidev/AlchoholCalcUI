using System;
using System.Collections.Generic;
using System.Linq;

namespace AlcoholSimulatorUI.Class
{
    public class User : Coctails
    {
        public static List<User> Items = new List<User>();
        public int Weight { get; set; }
        public double Promille { get; set; }
   
        public override string ToString()
        {
            return $"Название - {Name}, объем - {Quantity}, цена - {Cost}, промилле - {Promille}";
        }
    }
}