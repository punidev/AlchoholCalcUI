using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlcoholSimulatorUI.Infrastructure;

namespace AlcoholSimulatorUI.Class
{
    public class Recipes :  BaseEntity<int>
    {
        public new int? Id { get; set; }
        public int RecipeId { get; set; }
        public int AlcoId { get; set; }
        public double Part { get; set; }
    }
}
