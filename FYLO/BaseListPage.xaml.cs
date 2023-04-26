using FYLO.Models;
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
        public const string Url = "http://192.168.1.158:8000/api/base/?format=json";
        public HttpClient _client = new HttpClient();

        private ObservableCollection<Base> _bases;

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var bases = JsonConvert.DeserializeObject<List<Base>>(content);

            _bases = new ObservableCollection<Base>(bases);

            ListView.ItemsSource = GetBases();

            base.OnAppearing();
        }
        IEnumerable<Base> GetBases(string searchText = null)
        {
            //_bases = new ObservableCollection<Base>
            //{
            //    new Base { Id = 1, Name = "Fort Bragg", Location = "North Carolina" },
            //    new Base { Id = 2, Name = "Fort Benning", Location = "Georgia" }
            //};

            if (String.IsNullOrWhiteSpace(searchText))
                return _bases;

            return _bases.Where(c => c.Name.StartsWith(searchText));
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

