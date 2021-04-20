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
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();

            if (User.orders.Count() == 0 || User.bonus.Count==(0))
            {

                this.historija.Text = "Nemate nedavnih narudzbi!";
                this.Bonusi.Text = "Bonusi: 0";
            }
            else { 
            for(int i=0; i<User.orders.Count(); i++) {

                this.historija.Text = User.orders.ElementAt(i).text;
                this.Bonusi.Text = "Bonusi:" + User.bonus.Count().ToString();
                }
            }
            if (User.bonus.Count() < 5)
            {
                pravo.Text =  "Sa 5 bonusa stičete pravo na popust od 10%";
            }
            else
            {
                pravo.Text = "Imate popust od 10% na sve narudžbe!";
            }
            
        }


        public void payment(object sender, EventArgs e) {

            if (User.orders.Count == 0) { DisplayAlert("Quick reorder", "Nemate nedavni narudžbu!", "OK"); }
            else
            {
                Navigation.PushAsync(new Placanje());
            }
        
        }
    }
}