using FYLO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FYLO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BattalionDetailPage : ContentPage
    {
        public BattalionDetailPage(Battalion battalion)
        {
            if (battalion == null)
                throw new ArgumentNullException();

            BindingContext = battalion;

            InitializeComponent();
        }
    }
}