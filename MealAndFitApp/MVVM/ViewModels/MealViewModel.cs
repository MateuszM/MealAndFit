﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealAndFitApp.MVVM.ViewModels
{
    public class MealViewModel : IPageViewModel
    {
        public string Name { get => "Meals"; set => throw new NotImplementedException(); }
    }
}
