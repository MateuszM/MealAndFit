using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class Exercise
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int KCalBurned { get; set; }
        public DateTime ExerciseDuration { get; set; }
    }
}
