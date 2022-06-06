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
    public partial class Page2Practicas : ContentPage
    {
        public Page2Practicas()
        {
            InitializeComponent();
        }

        private async void Sig2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private  void BtInicio(object sender, EventArgs e)
        {
           
        }
    }
}