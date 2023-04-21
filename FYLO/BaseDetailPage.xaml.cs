using FYLO.Models;
using Xamarin.Forms;

using System;

namespace FYLO
{
    public partial class BaseDetailPage : ContentPage
    {
        public BaseDetailPage(Base bs)
        {
            if (bs == null)
                throw new ArgumentNullException();

            BindingContext = bs;

            InitializeComponent(); 
        }
    }
}

