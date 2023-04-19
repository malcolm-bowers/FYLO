using System.Collections.Generic;

using Xamarin.Forms;
using Command = FYLO.Models.Command;

namespace FYLO
{
    public partial class CommandListPage : ContentPage
    {
        public CommandListPage()
        {
            InitializeComponent();

            commandListView.ItemsSource = new List<Command>
            {
                new Command { Id = 1, Name = "FORSCOM" },
                new Command { Id = 2, Name = "TRADOC" }
            };
        }
    }
}

