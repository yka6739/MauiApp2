﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ViewModel
{
    [QueryProperty("Text","Text" )]
    public partial class DetailViewModule:ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task  GoBack()
        {
            await Shell.Current.GoToAsync("../");
        }

    }
}
