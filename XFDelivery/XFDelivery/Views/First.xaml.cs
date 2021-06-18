using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class First : ContentPage
    {
        public First()
        {
            InitializeComponent();
        }
        public async void Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new firstmessage());

        }
    }
}