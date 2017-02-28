using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.SQLRepository;

namespace AlcoholSimulatorUI.Algorithms
{
    public class OptimizedList
    {
        private SQLiteConnection _sqLiteConnection;
        public OptimizedList(SQLiteConnection _sqLiteConnection)
        {
            this._sqLiteConnection = _sqLiteConnection;
        }

        public void FindOptimizedAlcohol(
            int weight, 
            bool isChecked, 
            string currentMoney)
        {
            User.Items.Clear();
            foreach (var t in new FormPointers(_sqLiteConnection).CoctailsRepository.GetAll())
            {
                User.Items.Add(new User
                {
                    Ingredient = t.Ingredient,
                    Name = t.Name,
                    Quantity = t.Quantity,
                    Weight = weight,
                    Promille = MedicalFormules.Calculator(t.Ingredient, weight, t.Quantity, 1, a => a.Part * a.Rank),
                    Cost = t.Cost
                });
            }
            OptimizedData.DisplayCost = Algorithm(isChecked ? Convert.ToInt32(currentMoney) : 0, weight, isChecked);
        }


        public double Algorithm(int fullMoneyEquivalent, int weight, bool isChecked)
        {
            var values = new List<Ingredient>();
            OptimizedData.PrimaryItems.Clear();
            OptimizedData.PrimaryItems = User.Items
                .OrderBy(s => -s.Promille)
                .ThenBy(s => s.Cost)
                .ToList();
            int quant = 0, cost = 0;
            foreach (var t in OptimizedData.PrimaryItems)
            {
                if (!OptimizedData.PrimaryItems.Any(v => fullMoneyEquivalent <= v.Cost))
                {
                    quant += t.Quantity;
                    cost += t.Cost;
                    OptimizedData.SecondaryItems.Add(t);
                    fullMoneyEquivalent -= t.Cost;
                }
                else
                {
                    break;
                }
            }
            foreach (var s in OptimizedData.SecondaryItems)
            {
                values.AddRange(s.Ingredient);
            }
            OptimizedData.DisplayInxtoxication = 
                TypeOfAlcoholIntoxication(MedicalFormules.Calculator(values, weight, quant, 
                OptimizedData.SecondaryItems.Count, 
                t => t.Rank * t.Part / OptimizedData.SecondaryItems.Count));
            OptimizedData.DisplayAssembly = DisAssembly(values, t => t.Rank > 0);
            return cost;
        }
        public string TypeOfAlcoholIntoxication(double d)
        {
            string res = null;

            if (d >= 0 && d < 1.0)
                res = "Норма";
            if (d >= 1.0 && d < 2.0)
                res = "Легкая степень";
            if (d >= 2.0 && d < 3.0)
                res = "Средняя степень";
            if (d >= 3.0 && d < 4.0)
                res = "Тяжелая степень";
            if (d >= 4.0)
                res = "Cмертельная степень";

            return $"Ваша доза = {d} ‰\n{res} опъянения.";
        }

        public string DisAssembly(
            List<Ingredient> lst,
            Func<Ingredient, bool> action = null)
        {
            if (action != null)
            {
                foreach (var t in lst.Where(action).OrderBy(t => t.Name).ToList())
                {
                    OptimizedData.DisassemblyLogs.Add($"Название - {t.Name} : " +
                                                      $"Крепкость - {t.Rank*100}% : " +
                                                      $"Доля в коктейле - {t.Part}\n");
                }
                return "Только алкогольные напитки: \n";
            }
            else
            {
                foreach (var t in lst)
                {
                    OptimizedData.DisassemblyLogs.Add($"Название - {t.Name} : " +
                                                      $"Крепкость - {t.Rank * 100}% : " +
                                                      $"Доля в коктейле - {t.Part}\n");
                }
                return "Все напитки напитки: \n";
            }
        }
        public string MultiplyCount(int weight)
        {
            var values = new List<Ingredient>();
            int cost = 0, quant = 0;
            foreach (var t in OptimizedData.MultiplyItems)
            {
                values.AddRange(t.Ingredient);
                cost += t.Cost;
                quant += t.Quantity;
            }
            Func<Ingredient, double> linq = t => t.Rank * t.Part / OptimizedData.MultiplyItems.Count;
            return @"Ваша доза опьянения -" +
                          $" {MedicalFormules.Calculator(values, weight, quant, OptimizedData.MultiplyItems.Count, linq)}‰" +
                          $"\nВы потратили - {cost} грн.";
        }
    }
}
