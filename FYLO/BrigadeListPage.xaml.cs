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
                    id = 1,
                    name = "32nd Medical Brigade",
                    location = "Texas"},
                new Brigade {
                    id = 2,
                    name = "20th Engineer Brigade",
                    location = "North Carolina"}
            };
        }
    }
}

