using FYLO.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Xamarin.Forms;
using System.Linq;

namespace FYLO
{
    public partial class BattalionListPage : ContentPage
    {
        private ObservableCollection<Battalion> _battalions;
        IEnumerable<Battalion> GetBattalions(string searchText = null)
        {
           _battalions = new ObservableCollection<Battalion>
            {
                new Battalion { id = 1, name = "232d Medical Battalion", location = "Texas"},
                new Battalion { id = 2, name = "27th Engineer Battalion", location = "North Carolina" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return _battalions;

            return _battalions.Where(c => c.name.StartsWith(searchText));
        }
        public BattalionListPage()
        {
            InitializeComponent();

            ListView.ItemsSource = GetBattalions();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var battalion = e.SelectedItem as Battalion;
            Navigation.PushAsync(new BattalionDetailPage(battalion));
        }
        private void Delete_Clicked(object sender, System.EventArgs e)
        {
            var battalion = (sender as MenuItem).CommandParameter as Battalion;
            _battalions.Remove(battalion);
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetBattalions();

            ListView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetBattalions(e.NewTextValue);
        }
    }
}

