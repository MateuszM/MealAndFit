
using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
       public DbSet<Body> Bodies { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<DailyDoseLimit> DailyDoseLimits { get; set; }
        public DbSet<DayPlan> DayPlans { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseBase> ExerciseBases { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<MealItem> MealItems { get; set; }
        public DbSet<Meal> Meals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=DESKTOP-866I9OQ;Database=MealAndFit;Integrated Security=True");
        }
    }
}
