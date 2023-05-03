using FYLO.Models;
using Xamarin.Forms;

using System;
using System.Collections.Generic;
using Plugin.XamarinFormsSaveOpenPDFPackage;
using System.IO;
using System.Net.Http;

namespace FYLO
{
    public partial class BaseDetailPage : ContentPage
    {
        string baseAdd = @"http://192.168.1.158:8000";
        public BaseDetailPage(Base bs)
        {
            if (bs == null)
                throw new ArgumentNullException();

            BindingContext = bs;

            InitializeComponent();

            FilesView.ItemsSource = bs.files;
        }


        async void FilesView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // This pulls the pdf from the web.
            var file = e.SelectedItem as Models.File;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseAdd);
            var stream = await httpClient.GetStreamAsync(file.file);
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

