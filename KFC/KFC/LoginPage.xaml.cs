using KFC;
using KFC.Data;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("Bf0205");
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Check())
            {
                bool tacno = false;
                for (int i = 0; i < App.UserDatabase.getUserCount(); i++)
                {
                    if ((user.Username == App.UserDatabase.GetUser(i).Username) && (user.Password == App.UserDatabase.GetUser(i).Password))
                    {
                        tacno = true;
                    }
                }
                if (tacno == true)
                {
                    Loogedin.username = Entry_Username.Text;
                    Navigation.PushModalAsync(new Glavna()
                        );  
                    

                }
                else { DisplayAlert("Prijava", "Netačni podaci!", "OK"); }
            }
            else
            {
                DisplayAlert("Prijava", "Netačni podaci!", "OK");
            }
        }
    }
}