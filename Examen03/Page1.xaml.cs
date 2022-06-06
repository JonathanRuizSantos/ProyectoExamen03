using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void HOLAW(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Page2());
        }

        private async void BtPag12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page12());
        }

        private async void BtPag13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}