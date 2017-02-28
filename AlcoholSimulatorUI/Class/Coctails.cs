using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.SQLRepository;

namespace AlcoholSimulatorUI.Class
{
    public class Coctails : BaseEntity<int>
    {
        public new int Id { get; set; }
        public string Name { get; set; }
        public int Recipeid { get; set; }
        public List<Ingredients> Ingredient { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public int Type { get; set; }

        public override string ToString()
        {
            return $"{CoctailType(Type)} - {Name}, объем - {Quantity}, цена - {Cost}";
        }

        private string CoctailType(int id)
        {
            switch (id)
            {
                case 1:
                    return "Шот";
                case 2:
                    return "Лонг";
                default:
                    return null;
            }
        }

        public static string GetString(List<Ingredients> ing, string search)
        {
            var lst = new List<string>();
            foreach (var t in ing)
            {
                switch (search)
                {
                    case "Ingredients":
                        lst.Add(t.Name);
                        break;
                    case "Parts":
                        lst.Add(t.Part.ToString());
                        break;
                    case "Ranks":
                        lst.Add(t.Rank.ToString());
                        break;
                }
            }
            return search == "Ingredients" ? string.Join(", ", lst) : string.Join(" ", lst);
        }
    }
}