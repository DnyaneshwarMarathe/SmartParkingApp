﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace SmartParkingApp.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;

    [ObservableProperty]
    int availableParking;

    [ObservableProperty]
    int occupiedParking;
}

