using Plugin.XamarinFormsSaveOpenPDFPackage;
using System.IO;
using System.Net.Http;
using Xamarin.Forms;
namespace FYLO
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // This is the button action function that happends when the button is clicked.
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // This pulls the pdf from the web.
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync("https://armypubs.army.mil/pub/eforms/DR_a/ARN36501-DA_FORM_31-000-EFILE-1.pdf");

            using (var memoryStream = new MemoryStream())
            {
                await
                    stream.CopyToAsync(memoryStream);
                await
                    CrossXamarinFormsSaveOpenPDFPackage.Current.SaveAndView(
                    "myFile.pdf", "application/pdf", memoryStream, PDFOpenContext.InApp);
            }
        }
    }
}

