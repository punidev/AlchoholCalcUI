using System;
using System.Globalization;
using System.Windows.Forms;
using AlcoholSimulatorUI.Class;

namespace AlcoholSimulatorUI
{
    public partial class EditTarget : Form
    {
        public EditTarget()
        {
            InitializeComponent();
        }
        private Ingredients ing;
        private Configuration _conf;
        public string _Name { get; set; }
        public double _Rank { get; set; }
        public bool isEdit { get; set; }
        
        private void EditTarget_Load(object sender, EventArgs e)
        {
            _conf = (Configuration) Owner;
            if (isEdit)
            {
                Text = @"Изменить";
                ing = (Ingredients)_conf.lbAssembly.SelectedItem;
                tbNameAlco.Text = ing.Name;
                tbRankAlco.Text = ing.Rank
                    .ToString(CultureInfo.InvariantCulture)
                    .Replace('.', ',');
                tbPartAlco.Text = ing.Part
                    .ToString(CultureInfo.InvariantCulture)
                    .Replace('.', ',');
            }
            else
            {
                Text = @"Добавить";
                tbNameAlco.Text = _Name;
                tbRankAlco.Text = _Rank
                    .ToString(CultureInfo.InvariantCulture)
                    .Replace('.', ',');

            }
            
        }

        
        private void btnAddAlco_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                ing = new Ingredients();
                _conf.Items.Add(ing);
            }
            ing.Name = tbNameAlco.Text;
            ing.Part = Convert.ToDouble(tbPartAlco.Text);
            ing.Rank = Convert.ToDouble(tbRankAlco.Text);
            _conf.Refresher();
        }
    }
}
