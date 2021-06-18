using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }
        void LoginGo(System.Object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new LoginPage());

        }
        void SignUPClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());

        }

    }
}