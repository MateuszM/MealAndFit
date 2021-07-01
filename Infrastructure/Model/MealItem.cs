using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class MealItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public int KCal { get; set; }
        public int Mass { get; set; }


    }
}
