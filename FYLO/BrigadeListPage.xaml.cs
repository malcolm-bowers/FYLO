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
            ListView.ItemsSource = GetBrigades();
        }
        IEnumerable<Brigade> GetBrigades(string searchText = null)
        {
            _brigades = new ObservableCollection<Brigade>
            {
                new Brigade {
                    id = 1,
                    name = "32nd Medical Brigade",
                    location = "Texas"},
                new Brigade {
                    id = 2,
                    name = "20th Engineer Brigade",
                    location = "North Carolina"}
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return _brigades;

            return _brigades.Where(c => c.name.StartsWith(searchText));
        }
        public BrigadeListPage()
        {
            InitializeComponent();
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var brigade = e.SelectedItem as Brigade;
        }
        private void ListView_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetBrigades();

            ListView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetBrigades(e.NewTextValue);
        }
    }
}

