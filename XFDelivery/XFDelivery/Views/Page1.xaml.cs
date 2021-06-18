using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDelivery.ViewModel;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private int _quant;
        public int Quant
        {
            get { return _quant; }
            set { SetProperty(ref _quant, value); }
        }
        private void ExecuteAddQuantCommand()
        {
            Quant += 1;
        }

        private void ExecuteDeleteQuantCommand()
        {
            if (Quant > 1)
                Quant -= 1;
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }
    }
}