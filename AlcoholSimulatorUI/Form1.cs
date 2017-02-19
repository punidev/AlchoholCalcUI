using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcoholSimulatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
        public static void A()
        {
            var sql = "SELECT * FROM Coctails";
            var command = new SQLiteCommand(sql, Base);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var names = (string)reader["Ingredients"];
                var ranks = (string)reader["Ranks"];
                var parts = (string)reader["Parts"];
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
                    Name = (string)reader["Name"],
                    Ingredient = item,
                    Cost = Convert.ToInt32(reader["Cost"]),
                    Quantity = Convert.ToInt32(reader["Quantity"])

                });
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ConnectToDatabase(Base);

            //foreach (var t in Coctails.list)
            //{
            //    List<string> parts = new List<string>(); List<string> ranks = new List<string>(); List<string> ing = new List<string>();
            //    foreach (var id in t.Ingredients)
            //    {
            //        parts.Add(id.Part.ToString());
            //        ranks.Add(id.Alco.ToString());
            //        ing.Add(id.Name);
            //    }
            //    Insert($"INSERT INTO Coctails (Name, Ingredients, Parts,Ranks, Quantity, Cost) VALUES ('{t.Name}', '{string.Join(", ", ing)}','{string.Join(" ", parts)}','{string.Join(" ", ranks)}','{t.Quantity}','{t.Cost}');", Base);
            //}
            UpdateTab(dgvAlcohols, "Alcohols");
            UpdateTab(dgvCoctails, "Coctails");
            A();
            lbCoctails.DataSource = Coctails.Items.ToList();
        }

        private void lbCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pointer = (Coctails) lbCoctails.SelectedItem;
            lbIngredients.DataSource = null;
           // lbIngredients.DataSource = Coctails.Ingredient.ToString();
        }
    }
}
