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

            baseListView.ItemsSource = GetBases();
        }
        private void baseListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var bs = e.Item as Base;
            DisplayAlert("Tapped", bs.Name, "OK");
        }

        private void baseListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var bs = e.SelectedItem as Base;
            DisplayAlert("Selection", bs.Name, "OK");
        }
        private void Delete_Clicked(object sender, System.EventArgs e)
        {
            var bs = (sender as MenuItem).CommandParameter as Base;
            _bases.Remove(bs);
        }

        private void baseListView_Refreshing(object sender, EventArgs e)
        {
            baseListView.ItemsSource = GetBases();

            baseListView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            baseListView.ItemsSource = GetBases(e.NewTextValue);
        }
    }
}

