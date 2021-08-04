using MealAndFitApp.Core;
using MealAndFitApp.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MealAndFitApp.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ICommand changePageCommand;
        private IPageViewModel currentViewModel;
        private List<IPageViewModel> viewModels;
        public MainViewModel()
        {
            viewModels = new List<IPageViewModel>();
            viewModels.Add(new HomeViewModel());
            viewModels.Add(new CalendarViewModel());
            viewModels.Add(new DayPlanViewModel());
            viewModels.Add(new ExerciseViewModel());
            currentViewModel = viewModels[0];
        }
        public ICommand ChangePageCommand
        {
            get
            {
                if (changePageCommand == null)
                {
                    changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }
                return changePageCommand;
            }
        }
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (viewModels == null)
                    viewModels = new List<IPageViewModel>();

                return viewModels;
            }
        }
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return currentViewModel;
            }
            set
            {
                if (currentViewModel != value)
                {
                    currentViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
    }
}

