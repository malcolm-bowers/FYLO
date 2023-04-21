using Xamarin.Forms;

namespace FYLO
{
    public partial class CatalogPage : ContentPage
    {
        public CatalogPage()
        {
            InitializeComponent();
        }

        async private void Base_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BaseListPage());
        }

        async private void Battalion_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BattalionListPage());
        }

        async private void Brigade_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BrigadeListPage());
        }

        async private void Command_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CommandElementListPage());
        }
    }
}

