using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FYLO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Login_Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Application.Current.MainPage = new MainPage();
            }
            else
            {
                DisplayAlert("Oops..", "Username or password is incorrect!", "OK");
            }
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}