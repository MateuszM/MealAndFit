using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class DailyDoseLimit
    {
        public int Id { get; set; }
        public Ingredients Ingredient { get; set; }
        public int Limit;
    }
}
