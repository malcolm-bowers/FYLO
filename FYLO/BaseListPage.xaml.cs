using FYLO.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FYLO
{
    public partial class BaseListPage : ContentPage
    {
        public BaseListPage()
        {
            InitializeComponent();

            baseListView.ItemsSource = new List<Base>
            {
                new Base { Id = 1, Name = "Fort Bragg", Location = "North Carolina" },
                new Base { Id = 2, Name = "Fort Benning", Location = "Georgia" }
            };
        }
    }
}

