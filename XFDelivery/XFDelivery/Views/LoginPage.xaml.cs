using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUIDemo.Animations;
using XamUIDemo.Renderers;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () =>
            {
                await ViewAnimations.FadeAnimY(email);
                await ViewAnimations.FadeAnimY(password);
              

            });
        }
        void LoginClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MainPage()));
           
        }
        void SigninGo(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
        
    }
}