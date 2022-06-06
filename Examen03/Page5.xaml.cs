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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Sig3(object sender, EventArgs e)
        {

        }

        private async void Sig4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }
    }
}