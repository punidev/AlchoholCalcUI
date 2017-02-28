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
        private AlcoholsRepository _alcoholRepository;
        private CoctailsRepository _coctailsRepository;
        public SQLiteConnection Sql { get; set; }
        public List<Ingredient> Items = new List<Ingredient>(); 
        private void Configuration_Load(object sender, EventArgs e)
        {
            _alcoholRepository = new FormPointers(Sql).AlcoholsRepository;
            _coctailsRepository = new FormPointers(Sql).CoctailsRepository;
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
            _coctailsRepository.Insert(new Coctails
            {
                Name = tbNameCoc.Text,
                Quantity = Convert.ToInt32(tbQuantCoc.Text),
                Cost = Convert.ToInt32(tbCostCoc.Text),
                Ingredient = Items
            });
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
                Owner = this,
                isEdit = true
            }
            .ShowDialog();
        }

        private void delSoloAlco_Click(object sender, EventArgs e)
        {
            _coctail = (Coctails)lbCoctails.SelectedItem;
            _coctailsRepository.Delete(_coctail.Name);
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
                Ingredient = _coctail.Ingredient
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
