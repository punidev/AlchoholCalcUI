using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace AlcoholSimulatorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Coctails data;
        public static List<Coctails> Plus = new List<Coctails>();
        public static SQLiteConnection Base = new SQLiteConnection($"Data Source={"Alcohol.db"};Version=3;");

        public static void ConnectToDatabase(SQLiteConnection s)
        {
            s.Open();
        }

        public static void Insert(string querry, SQLiteConnection s)
        {
            var command = new SQLiteCommand(querry, s);
            command.ExecuteNonQuery();
        }

        public void UpdateTab(DataGridView data, string _base)
        {
            var ds = new DataSet();
            var sql = $"Select * From {_base}";
            var da = new SQLiteDataAdapter(sql, Base);
            da.Fill(ds);
            data.DataSource = ds.Tables[0].DefaultView;
        }

        public static void GetCoctailsFromDb()
        {
            var sql = "SELECT * FROM Coctails";
            var command = new SQLiteCommand(sql, Base);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var names = (string) reader["Ingredients"];
                var ranks = (string) reader["Ranks"];
                var parts = (string) reader["Parts"];
                List<Ingredient> item = new List<Ingredient>();
                for (int i = 0; i < names.Split(',').Length; i++)
                {
                    item.Add(new Ingredient
                    {
                        Name = names.Split(',')[i],
                        Part = Convert.ToDouble(parts.Split(' ')[i]),
                        Rank = Convert.ToDouble(ranks.Split(' ')[i])
                    });
                }
                Coctails.Items.Add(new Coctails
                {
                    Name = (string) reader["Name"],
                    Ingredient = item,
                    Cost = Convert.ToInt32(reader["Cost"]),
                    Quantity = Convert.ToInt32(reader["Quantity"])
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = tbMoney.Visible = false;
            ConnectToDatabase(Base);
            UpdateTab(dgvAlcohols, "Alcohols");
            UpdateTab(dgvCoctails, "Coctails");
            GetCoctailsFromDb();
            lbCoctails.DataSource = Coctails.Items.ToList();
            lbIn.DataSource = Coctails.Items.ToList();
            lbIn.SelectionMode = lbOut.SelectionMode = SelectionMode.MultiExtended;
        }

        public void Refresh()
        {
            lbOut.DataSource = Plus.ToList();
        }

        private void lbCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pointer = (Coctails) lbCoctails.SelectedItem;
            lbIngredients.DataSource = null;
            var items = new List<Ingredient>();
            items.AddRange(pointer.Ingredient);
            lbIngredients.DataSource = items.ToList();
        }

        public static List<User> Items;
        public static List<User> NItems;

        public void FindAlc(int weight)
        {
            Items = new List<User>();
            NItems = new List<User>();
            User.Items.Clear();
            foreach (var t in Coctails.Items)
            {
                User.Items.Add(new User
                {
                    Ingredient = t.Ingredient,
                    Name = t.Name,
                    Quantity = t.Quantity,
                    Weight = weight,
                    Promille = User.Calculator(t.Ingredient, weight, t.Quantity, 1, a => a.Part*a.Rank),
                    Cost = t.Cost
                });
            }
            A(checkBox1.Checked ? Convert.ToInt32(tbMoney.Text) : 0, weight);
        }


        public void A(int a, int weight)
        {
            List<Ingredient> values = new List<Ingredient>();
            Items.Clear();
            Items = User.Items.OrderBy(s => -s.Promille).ThenBy(s => s.Cost).ToList();
            int quant = 0, cost = 0;
            foreach (var t in Items)
            {
                if (!Items.Any(v => a <= v.Cost))
                {
                    quant += t.Quantity;
                    cost += t.Cost;
                    NItems.Add(t);
                    a -= t.Cost;
                }
                else
                {
                    break;
                }
            }
            foreach (var s in NItems)
            {
                values.AddRange(s.Ingredient);
            }
            lbOptimized.DataSource = checkBox1.Checked ? NItems.ToList() : Items.ToList();
            TypeOfAlcoholIntoxication(User.Calculator(values, weight, quant, NItems.Count,
                t => t.Rank*t.Part/NItems.Count));
            DisAssembly(values, t => t.Rank > 0);
            rtbLogs.Text += $"\nСумма коктейлей: {cost}";
        }

        public void TypeOfAlcoholIntoxication(
            double d)
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

            rtbLogs.Text += $"Ваша доза = {d} ‰\n{res} опъянения.";
        }

        public void DisAssembly(
            List<Ingredient> lst,
            Func<Ingredient, bool> action = null)
        {
            if (action != null)
            {
                rtbLogs.Text += "Только алкогольные напитки: \n";
                foreach (var t in lst.Where(action).OrderBy(t => t.Name).ToList())
                {
                    rtbLogs.Text += $"Название - {t.Name} : Крепкость - {t.Rank*100}% : Доля в коктейле - {t.Part}\n";
                }
            }
            else
            {
                rtbLogs.Text += "Все напитки напитки: \n";
                foreach (var t in lst)
                {
                    rtbLogs.Text += $"Название - {t.Name} : Крепкость - {t.Rank*100}% : Доля в коктейле - {t.Part}\n";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = !checkBox1.Checked ? (tbMoney.Visible = false) : (tbMoney.Visible = true);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            rtbLogs.Text = null;
            FindAlc(Convert.ToInt32(tbWeight.Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "По цене":
                    lbCoctails.DataSource = Coctails.Items.OrderBy(x=>-x.Cost).ToList();
                    break;
                case "По названию":
                    lbCoctails.DataSource = Coctails.Items.OrderBy(x => x.Name).ToList();
                    break;
                case "По объему":
                    lbCoctails.DataSource = Coctails.Items.OrderBy(x => x.Quantity).ToList();
                    break;
                case "По кол-ву ингредиентов":
                    lbCoctails.DataSource = Coctails.Items.OrderBy(x => -x.Ingredient.Count).ToList();
                    break;
                default:
                    MessageBox.Show("Не выбрано ничего");
                    break;
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            foreach (var t in lbIn.SelectedItems.Cast<object>().ToList())
            {
                data = (Coctails)t;
                Plus.Add(data);
            }
            Refresh();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            foreach (var t in lbOut.SelectedItems.Cast<object>().ToList())
            {
                data = (Coctails)t;
                Plus.Remove(data);
            }
            Refresh();
        }
        public void MultiplyCount(int weight)
        {
            List<Ingredient> values = new List<Ingredient>();
            int cost = 0, quant = 0;
            foreach (var t in Plus)
            {
                    values.AddRange(t.Ingredient);
                    cost += t.Cost;
                    quant += t.Quantity;
            }
            label5.Text =
                $"Ваша доза опьянения - {User.Calculator(values, weight, quant, Plus.Count, t => t.Rank*t.Part/Plus.Count)}‰\nВы потратили - {cost} грн.";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbWeight2.Text.Length!=0
                && Convert.ToInt32(tbWeight2.Text) > 0)
                MultiplyCount(Convert.ToInt32(tbWeight2.Text));
            else
                MessageBox.Show("Неверный формат!");
        }
    }
}
