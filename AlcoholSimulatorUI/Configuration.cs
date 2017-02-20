using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        private MainForm _parrent;
        private Coctails _coctail;
        private Alcohols _alcohols;
        public SQLiteConnection sql { get; set; }
        public List<Ingredient> Items = new List<Ingredient>(); 
        private void Configuration_Load(object sender, EventArgs e)
        {
            _parrent = (MainForm)Owner;
            Refresher();
        }

        public void Refresher()
        {
            _parrent.Refill();
            lbAlco.DataSource = null;
            lbAlco.DataSource = Alcohols.Items.ToList();
            lbCoctails.DataSource = Coctails.Items.ToList();
            lbAssembly.DataSource = Items.ToList();
        }

        public static void Insert(string querry, SQLiteConnection s)
        {
            var command = new SQLiteCommand(querry, s);
            command.ExecuteNonQuery();
        }
        private void btnAddAlco_Click(object sender, EventArgs e)
        {
            var querry = "INSERT " +
                         "INTO Alcohols(Name, Rank) " +
                         $"VALUES('{tbNameAlco.Text}','{tbRankAlco.Text}')";
            Insert(querry, sql);
            Refresher();
        }

        private void btnDelAlco_Click(object sender, EventArgs e)
        {
            _alcohols = (Alcohols) lbAlco.SelectedItem;
            var querry = "DELETE " +
                         "FROM Alcohols " +
                         $"WHERE Name='{_alcohols.Name}'";
            Insert(querry, sql);
            Refresher();
        }

        private void addSoloAlco_Click(object sender, EventArgs e)
        {
            _alcohols = (Alcohols)lbAlco.SelectedItem;
            new EditTarget
            {
                Owner = this,
                _Name = _alcohols.Name,
                _Rank = Convert.ToDouble(_alcohols.Rank.Replace('.',','))
            }.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> parts = new List<string>();
            List<string> ranks = new List<string>();
            List<string> ing = new List<string>();
            foreach (var t in Items)
            {
                parts.Add(t.Part.ToString());
                ranks.Add(t.Rank.ToString());
                ing.Add(t.Name);
            }
            var querry =
                "INSERT " +
                "INTO Coctails(Name, Ingredients, Parts,Ranks, Quantity, Cost) " +
                "VALUES(" +
                $"'{tbNameCoc.Text}'," +
                $"'{string.Join(", ", ing)}'," +
                $"'{string.Join(" ", parts)}'," +
                $"'{string.Join(" ", ranks)}'," +
                $"'{tbQuantCoc.Text}'," +
                $"'{tbCostCoc.Text}')";
            Insert(querry, sql);
            Refresher();
        }

        private void lbCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pointer = (Coctails)lbCoctails.SelectedItem;
            lbAssembly.DataSource = null;
            var items = new List<Ingredient>();
            items.AddRange(pointer.Ingredient);
            lbAssembly.DataSource = items.ToList();
            tbCostCoc.Text = pointer.Cost.ToString();
            tbNameCoc.Text = pointer.Name;
            tbQuantCoc.Text = pointer.Quantity.ToString();
        }

        private void editSoloAlco_Click(object sender, EventArgs e)
        {
            _alcohols = (Alcohols)lbAssembly.SelectedItem;
            new EditTarget
            {
                Owner = this,isEdit = true
            }.ShowDialog();
        }

        private void delSoloAlco_Click(object sender, EventArgs e)
        {
            _coctail = (Coctails)lbCoctails.SelectedItem;
            var querry = $"DELETE FROM Coctails WHERE Name='{_coctail.Name}'";
            Insert(querry, sql);
            Refresher();
        }

        private void btnEditCoctail_Click(object sender, EventArgs e)
        {
            _coctail = (Coctails) lbCoctails.SelectedItem;
            List<string> parts = new List<string>();
            List<string> ranks = new List<string>();
            List<string> ing = new List<string>();
            foreach (var t in _coctail.Ingredient)
            {
                parts.Add(t.Part.ToString());
                ranks.Add(t.Rank.ToString());
                ing.Add(t.Name);
            }
            var querry =
                "UPDATE Coctails " +
                "SET " +
                $"Name='{tbNameCoc.Text}'," +
                $"Ingredients='{string.Join(", ", ing)}'," +
                $"Parts='{string.Join(" ", parts)}'," +
                $"Ranks='{string.Join(" ", ranks)}'," +
                $"Quantity='{tbQuantCoc.Text}'," +
                $"Cost='{tbCostCoc.Text}' " +
                $"WHERE Name='{_coctail.Name}'";
            Insert(querry, sql);
            Refresher();
        }
    }
}
