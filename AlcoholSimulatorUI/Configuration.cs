using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using AlcoholSimulatorUI.Class;
using AlcoholSimulatorUI.SQLRepository;

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
        private Ingredients _igred;
        private AlcoholsRepository _alcoholRepository;
        private CoctailsRepository _coctailsRepository;
        private RecipeRepository _recipeRepository;
        public SQLiteConnection Sql { get; set; }
        public List<Ingredients> Items = new List<Ingredients>(); 
        private void Configuration_Load(object sender, EventArgs e)
        {
            _alcoholRepository = new FormPointers(Sql).AlcoholsRepository;
            _coctailsRepository = new FormPointers(Sql).CoctailsRepository;
            _recipeRepository = new FormPointers(Sql).RecipesRepository;
            _parrent = (MainForm)Owner;
            Refresher();
        }

        public void Refresher()
        {
            _parrent.UpdateGrid();
            lbAlco.DataSource = null;
            lbAlco.DataSource = _alcoholRepository.GetAll();
            lbCoctails.DataSource = _coctailsRepository.GetAll();
            lbAssembly.DataSource = Items.ToList();
        }

        private void btnAddAlco_Click(object sender, EventArgs e)
        {
            _alcoholRepository.Insert(new Alcohols
            {
                Name = tbNameAlco.Text,
                Rank = tbRankAlco.Text
            });
            Refresher();
        }

        private void btnDelAlco_Click(object sender, EventArgs e)
        {
            _alcohols = (Alcohols) lbAlco.SelectedItem;
            _alcoholRepository.Delete(_alcohols.Name);
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
            }
            .ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var countIndex = _coctailsRepository.GetSeqCount();
            _coctailsRepository.Insert(new Coctails
            {
                Name = tbNameCoc.Text,
                Quantity = Convert.ToInt32(tbQuantCoc.Text),
                Cost = Convert.ToInt32(tbCostCoc.Text),
                Ingredient = Items,
                Type = cbType.SelectedIndex+1,
                Recipeid = countIndex + 1
            });
            foreach (var t in Items)
            {
                _recipeRepository.Insert(new Recipes
                {
                    AlcoId = _alcoholRepository.GetByName(t.Name[0] == ' ' ? t.Name.Remove(0, 1) : t.Name),
                    RecipeId = countIndex + 1,
                    Part = Convert.ToDouble(t.Part)
                });
            }
            
            Refresher();
        }

        private void lbCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pointer = (Coctails)lbCoctails.SelectedItem;
            lbAssembly.DataSource = null;
            var items = new List<Ingredients>();
            items.AddRange(pointer.Ingredient);
            lbAssembly.DataSource = items.ToList();
            tbCostCoc.Text = pointer.Cost.ToString();
            tbNameCoc.Text = pointer.Name;
            tbQuantCoc.Text = pointer.Quantity.ToString();
            cbType.SelectedIndex = pointer.Type-1;
        }

        private void editSoloAlco_Click(object sender, EventArgs e)
        {
            _alcohols = (Alcohols)lbAssembly.SelectedItem;
            new EditTarget
            {
                Owner = this,
                isEdit = true
            }
            .ShowDialog();
        }

        private void delSoloAlco_Click(object sender, EventArgs e)
        {
            _igred = (Ingredients)lbAssembly.SelectedItem;
            Items.Remove(_igred);
            Refresher();
        }

        private void btnEditCoctail_Click(object sender, EventArgs e)
        {
            _coctail = (Coctails) lbCoctails.SelectedItem;
            _coctailsRepository.Update(new Coctails
            {
                Name = tbNameCoc.Text,
                Quantity = Convert.ToInt32(tbQuantCoc.Text),
                Cost = Convert.ToInt32(tbCostCoc.Text),
                Ingredient = _coctail.Ingredient,
                Type = cbType.SelectedIndex + 1
            });
            Refresher();
        }

        private void btnDelCoctail_Click(object sender, EventArgs e)
        {
            _coctail = (Coctails) lbCoctails.SelectedItem;
            _coctailsRepository.Delete(_coctail.Name);
            Refresher();
        }
    }
}
