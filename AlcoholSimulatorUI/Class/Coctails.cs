using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlcoholSimulatorUI.Infrastructure;

namespace AlcoholSimulatorUI.Class
{
    public class Coctails : BaseEntity<int>
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredient { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public override string ToString()
        {
            return $"Название - {Name}, объем - {Quantity}, цена - {Cost}";
        }

        public static List<Ingredient> GetIngredients(SQLiteDataReader reader)
        {
            var names = (string)reader["Ingredients"];
            var ranks = (string)reader["Ranks"];
            var parts = (string)reader["Parts"];
            var item = new List<Ingredient>();
            for (var i = 0; i < names.Split(',').Length; i++)
            {
                item.Add(new Ingredient
                {
                    Name = names.Split(',')[i],
                    Part = Convert.ToDouble(parts.Split(' ')[i]),
                    Rank = Convert.ToDouble(ranks.Split(' ')[i])
                });
            }
            return item;
        }

        public static string GetString(List<Ingredient> ing, string search)
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