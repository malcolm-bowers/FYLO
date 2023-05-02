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
                new Command { id = 1, name = "FORSCOM" },
                new Command { id = 2, name = "TRADOC" }
            };
        }
    }
}

