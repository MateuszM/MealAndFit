using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
   public class DayPlan
    {
        public int Id { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Meal> Meals { get; set; }
        
    }
}
