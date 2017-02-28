using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AlcoholSimulatorUI.Algorithms;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.Infrastructure;
using AlcoholSimulatorUI.SQLRepository;

namespace AlcoholSimulatorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Coctails Data;
        public static SQLiteConnection Base = new SQLiteConnection($"Data Source={"Alcohol2.db"};Version=3;");

        public static void ConnectToDatabase(SQLiteConnection s) => s.Open();
        public void UpdateTab(DataGridView data)
        {
            var ds = new DataSet();
            var sql = $"Select * From {data.Name.Replace("dgv", null)}";
            var da = new SQLiteDataAdapter(sql, Base);
            da.Fill(ds);
            data.DataSource = ds.Tables[0].DefaultView;
        }
        public void UpdateGrid()
        {
            UpdateTab(dgvAlcohols);
            UpdateTab(dgvCoctails);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = tbMoney.Visible = false;
            ConnectToDatabase(Base);
            UpdateGrid();
            lbCoctails.DataSource = new FormPointers(Base).CoctailsRepository.GetAll();
            lbIn.DataSource = new FormPointers(Base).CoctailsRepository.GetAll();
            lbIn.SelectionMode = lbOut.SelectionMode = SelectionMode.MultiExtended;
        }
        public override void Refresh()
        {
            lbOut.DataSource = OptimizedData.MultiplyItems.ToList();
        }

        private void lbCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pointer = (Coctails) lbCoctails.SelectedItem;
            lbIngredients.DataSource = null;
            var items = new List<Ingredients>();
            items.AddRange(pointer.Ingredient);
            lbIngredients.DataSource = items.ToList();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = !checkBox1.Checked ? 
                (tbMoney.Visible = false) : (tbMoney.Visible = true);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var optimizedData = new OptimizedList(Base);
            rtbLogs.Text = null;
            if (tbWeight.Text.Length != 0 && Convert.ToInt32(tbWeight.Text) > 0)
            {
                optimizedData.FindOptimizedAlcohol(
                    Convert.ToInt32(tbWeight.Text), checkBox1.Checked, tbMoney.Text);

                lbOptimized.DataSource = checkBox1.Checked
                    ? OptimizedData.SecondaryItems.ToList()
                    : OptimizedData.PrimaryItems.ToList();

                rtbLogs.Text += ViewModels.Display();
                OptimizedData.DisassemblyLogs.ForEach(delegate(string i) { rtbLogs.Text += i; });
            }
            else
                MessageBox.Show(@"Неверный формат!");
        }
        public static List<Ingredients> GetIngredients(int id)
        {
            var lst = new FormPointers(Base).AlcoholsRepository;
            var rlst = new FormPointers(Base).RecipesRepository.GetAllAlcohols(id);
            return rlst.Select(t => new Ingredients
            {
                Name = lst.GetById(t.AlcoId).Name,
                Part = t.Part,
                Rank = Convert.ToDouble(lst.GetById(t.AlcoId).Rank.Replace('.', ','))
            }).ToList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var coctailsList = new FormPointers(Base)
                .CoctailsRepository.GetAll();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "По цене":
                    lbCoctails.DataSource = coctailsList
                        .OrderBy(x=>-x.Cost)
                        .ToList();
                    break;
                case "По названию":
                    lbCoctails.DataSource = coctailsList
                        .OrderBy(x => x.Name)
                        .ToList();
                    break;
                case "По объему":
                    lbCoctails.DataSource = coctailsList
                        .OrderBy(x => x.Quantity)
                        .ToList();
                    break;
                case "По кол-ву ингредиентов":
                    lbCoctails.DataSource = coctailsList
                        .OrderBy(x => -x.Ingredient.Count)
                        .ToList();
                    break;
                default:
                    MessageBox.Show(@"Не выбрано ничего");
                    break;
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            foreach (var t in lbIn.SelectedItems.Cast<object>().ToList())
            {
                Data = (Coctails)t;
                OptimizedData.MultiplyItems.Add(Data);
            }
            Refresh();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            foreach (var t in lbOut.SelectedItems.Cast<object>().ToList())
            {
                Data = (Coctails)t;
                OptimizedData.MultiplyItems.Remove(Data);
            }
            Refresh();
        }
   
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbWeight2.Text.Length!=0
                && Convert.ToInt32(tbWeight2.Text) > 0)
                label5.Text= new OptimizedList(Base).MultiplyCount(Convert.ToInt32(tbWeight2.Text));
            else
                MessageBox.Show(@"Неверный формат!");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            new Configuration {Owner = this, Sql = Base}.ShowDialog();
        }
    }
}
