using FYLO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace FYLO
{
    public partial class BaseListPage : ContentPage
    {
        private ObservableCollection<Base> _bases;
        IEnumerable<Base> GetBases(string searchText = null)
        {
            _bases = new ObservableCollection<Base>
            {
                new Base { Id = 1, Name = "Fort Bragg", Location = "North Carolina" },
                new Base { Id = 2, Name = "Fort Benning", Location = "Georgia" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return _bases;

            return _bases.Where(c => c.Name.StartsWith(searchText));
        }
        public BaseListPage()
        {
            InitializeComponent();

            ListView.ItemsSource = GetBases();
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

