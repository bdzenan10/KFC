using KFC.Modals;
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
    public partial class Registracija : ContentPage
    {
        public Registracija()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("Bf0205");
        }
        void Register(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
           
            if (user.Check())
            {
                bool tacno = false;
                for (int i = 0; i < App.UserDatabase.getUserCount(); i++)
                {
                    if ((user.Username == App.UserDatabase.GetUser(i).Username))

                    {
                        tacno = true;
                    }
                
                }
                if (tacno == true) { 
                    DisplayAlert("Registracija", "Korisnik sa tim imenom već postoji!", "OK"); }
                else { DisplayAlert("Registracija", "Uspješno ste reistrovani! Prijavite se za nastavak.", "OK");
                    App.UserDatabase.SaveUser(user);
                }
                
            }
            else
            {
                DisplayAlert("Login", "Niste unijeli sve podatke!", "OK");
            }
        }
    }
}