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
            _brigades = new ObservableCollection<Brigade>
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

            ListView.ItemsSource = GetBrigades();

            base.OnAppearing();
        }
        IEnumerable<Brigade> GetBrigades(string searchText = null)
        {
            if (String.IsNullOrWhiteSpace(searchText))
                return _brigades;

            return _brigades.Where(c => c.Name.StartsWith(searchText));
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var bs = e.SelectedItem as Base;
            Navigation.PushAsync(new BaseDetailPage(bs));
        }
        public BrigadeListPage()
        {
            InitializeComponent();
        }
        private void Delete_Clicked(object sender, System.EventArgs e)
        {
            var brigades = (sender as MenuItem).CommandParameter as Brigade;
            _brigades.Remove(brigades);
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

