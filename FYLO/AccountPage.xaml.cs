using System.Collections.Generic;
using Xamarin.Forms;

namespace FYLO
{
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();

            var baseList = new List<string>();
            baseList.Add("Fort Sam Houston");
            baseList.Add("Fort Bragg");
            baseList.Add("Fort Jackson");

            basePicker.ItemsSource = baseList;

            var brigadeList = new List<string>();
            brigadeList.Add("32nd Medical Brigade");
            brigadeList.Add("20th Engineer Battalion");
            brigadeList.Add("165th Infantry Brigade");

            brigadePicker.ItemsSource = brigadeList;

            var battalionList = new List<string>();
            battalionList.Add("232d Medical Battalion");
            battalionList.Add("4-39th Infantry Regiment");
            battalionList.Add("27th Engineer Brigade");

            battalionPicker.ItemsSource = battalionList;

            var commandList = new List<string>();
            commandList.Add("TRADOC");
            commandList.Add("FORSCOM");

            commandPicker.ItemsSource = commandList;

            var companyList = new List<string>();
            companyList.Add("Alpha Company");
            companyList.Add("Bravo Company");
            companyList.Add("57th Sapper Company");

            companyPicker.ItemsSource = companyList;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Saved", "Your settings have been saved successfully.", "OK");
        }
    }
}

