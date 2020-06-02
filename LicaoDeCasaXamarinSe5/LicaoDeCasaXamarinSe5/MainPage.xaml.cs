using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LicaoDeCasaXamarinSe5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Doar")
            {
                foto.Source = "boy_smile";
                bt.Text = "Muito Obrigado !!!";
            }
            else
            {
                foto.Source = "birthday_present";
                bt.Text = "Doar";
            }
            
        }
    }
}
