using System.Collections.Generic;

using Xamarin.Forms;
using Command = FYLO.Models.CommandElement;

namespace FYLO
{
    public partial class CommandElementListPage : ContentPage
    {
        public CommandElementListPage()
        {
            InitializeComponent();

            commandElementListView.ItemsSource = new List<Command>
            {
                new Command { Id = 1, Name = "FORSCOM" },
                new Command { Id = 2, Name = "TRADOC" }
            };
        }
    }
}

