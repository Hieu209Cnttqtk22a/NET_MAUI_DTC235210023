using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

// Add Nugget Package CommunityToolkit.Mvvm
using CommunityToolkit.Mvvm.ComponentModel;

using CommunityToolkit.Mvvm.Input;

// Create ViewModel
namespace NET_MAUI_DTC235210023.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        [ObservableProperty]

        ObservableCollection<string> items;

        [ObservableProperty]
        string text;
        [RelayCommand]

        // Create Add logic
        void Add()
        {
            if(string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            // Add our items
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
}
