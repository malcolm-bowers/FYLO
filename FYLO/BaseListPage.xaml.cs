using FYLO.Models;
using FYLO.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;

namespace FYLO
{
    public partial class BaseListPage : ContentPage
    {
        private ObservableCollection<Base> _bases;

        protected override async void OnAppearing()
        {
            RestService rs = new RestService();
            _bases = await rs.GetAPIBases();

            ListView.ItemsSource = GetBases();

            base.OnAppearing();
        }
        IEnumerable<Base> GetBases(string searchText = null)
        {
            if (String.IsNullOrWhiteSpace(searchText))
                return _bases;

            return _bases.Where(c => c.name.StartsWith(searchText));
        }
        public BaseListPage()
        {
            InitializeComponent();
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var bs = e.SelectedItem as Base;
            Navigation.PushAsync(new BaseDetailPage(bs));
        }
        private void Delete_Clicked(object sender, System.EventArgs e)
        {
            var bs = (sender as MenuItem).CommandParameter as Base;
            _bases.Remove(bs);
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetBases();

            ListView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetBases(e.NewTextValue);
        }
    }
}

