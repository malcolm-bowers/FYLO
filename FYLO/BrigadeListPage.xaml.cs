using FYLO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FYLO
{
    public partial class BrigadeListPage : ContentPage
    {
        private ObservableCollection<Brigade> _brigades;
        protected override void OnAppearing()
        {
            InitializeComponent();

            brigadeListView.ItemsSource = new List<Brigade>
            {
                new Brigade {
                    Id = 1,
                    Name = "32nd Medical Brigade",
                    Location = "Texas"},
                new Brigade {
                    Id = 2,
                    Name = "20th Engineer Brigade",
                    Location = "North Carolina"}
            };
        }
    }
}

