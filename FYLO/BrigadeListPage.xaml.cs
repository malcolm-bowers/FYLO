using FYLO.Models;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FYLO
{
    public partial class BrigadeListPage : ContentPage
    {
        public BrigadeListPage()
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

