using MealAndFitApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAndFitApp.MVVM.ViewModels
{
    public class DayPlanViewModel : IPageViewModel
    {
        public string Name { get => "Day Plan"; set => throw new NotImplementedException(); }
        ObservableCollection<DayPlanItemModel> observableCollection;
    }
}
