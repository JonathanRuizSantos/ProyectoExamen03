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
    public partial class Page12 : ContentPage
    {
        public Page12()
        {
            InitializeComponent();
        }

        private async void BtP01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Practicas());
        }

        private void BtInicio(object sender, EventArgs e)
        {
            
        }
    }
}