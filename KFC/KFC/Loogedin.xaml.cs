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
    public partial class Loogedin : ContentPage
    {
        public static string username;
  
        public Loogedin()
        {
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("Bf0205");

            NavigationPage.SetBackButtonTitle(this, "");
            InitializeComponent();
            this.Dobrodosli.Text = "Dobrodošli " + "" + username;
        }
        private void Button_Clicked(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Meni());
        }
        private void Historija(object sender, EventArgs e)

        {
            Navigation.PushAsync(new History());
        }
        private void logout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}