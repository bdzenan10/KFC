using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kartica : ContentPage
    {
        public Kartica()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (broj.Text.Equals("") || ime.Text.Equals("") || datum.Text.Equals("") || kod.Text.Equals(""))
            {
                DisplayAlert("KFC", "Niste unijeli sve podatke!", "OK");
            }
            else
            {
                DisplayAlert("KFC", "Transakcija uspješna!", "OK");
                Navigation.PushModalAsync(new Glavna());            }
        }
    } 
}