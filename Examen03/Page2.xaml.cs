using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Numerics;

namespace Examen03
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        double R1, I1, R2, I2;
        Complex r=new Complex();
        public Page2()
        {
            InitializeComponent();
        }

        private async void BtFirma(object sender, EventArgs e)
        {
            await DisplayAlert("IPN ESIME ZACATENCO", "Jonathan Ruiz Santos","ICE","Computacion");
        }

        private void BtResta(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            Complex C2 = new Complex(R2, I2);
            r = Complex.Subtract(C1, C2);
            salida();
        }

        private void BtMultiplica(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            Complex C2 = new Complex(R2, I2);
            r = Complex.Multiply(C1, C2);
            salida();
        }

        private void BtDivide(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            Complex C2 = new Complex(R2, I2);
            r = Complex.Divide(C1, C2);
            salida();
        }

        private void BtPot(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            Complex C2 = new Complex(R2, I2);
            r = Complex.Pow(C1, C2);
            salida();
        }

        private void BtSen(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Sin(C1);
            salida();
        }

        private void BtCos(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Cos(C1);
            salida();
        }

        private void BtTan(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Tan(C1);
            salida();
        }

        private void BtSenh(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Sinh(C1);
            salida();
        }

        private void BtCosh(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Cosh(C1);
            salida();
        }

        private void BtTanh(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Tanh(C1);
            salida();
        }

        private void BtLog(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Log(C1);
            salida();
        }

        private void BtLog10(object sender, EventArgs e)
        {
            entrada();
            Complex C1 = new Complex(R1, I1);
            //Complex C2 = new Complex(R2, I2);
            r = Complex.Log10(C1);
            salida();
        }

        private void BtBorrar(object sender, EventArgs e)
        {
            Real1.Text = "0";
            Imaginario1.Text = "0";
            Real2.Text = "0";
            Imaginario2.Text = "0";
            Result.Text = " ";
        }

        private void BtEjemplo(object sender, EventArgs e)
        {
            Real1.Text = "3";
            Imaginario1.Text = "7";
            Real2.Text = "2";
            Imaginario2.Text = "3";
            Result.Text = " ";
        }

        private void BtSuma(object sender, EventArgs e)
        {
            entrada();
            Complex C1=new Complex(R1,I1);
            Complex C2=new Complex(R2,I2);
            r = Complex.Add(C1, C2);
            salida();
        }
        public void entrada()
        {
            try { 
            R1 = double.Parse(Real1.Text);
            I1 = double.Parse(Imaginario1.Text);
            R2 = double.Parse(Real2.Text);
            I2 = double.Parse(Imaginario2.Text);
            }
            catch
            {
                
            }
        }
        public void salida()
        {
            Result.Text = r.ToString();
            
        }
    }
}