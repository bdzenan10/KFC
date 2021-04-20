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


    public partial class Placanje : ContentPage
    {
        public IList<Gradovi> ListaGradova { get; set; }
        public Placanje()
        {
            InitializeComponent();
            ListaGradova = new List<Gradovi>();
            ListaGradova.Add(new Gradovi { Naziv = "Zenica" });
            ListaGradova.Add(new Gradovi { Naziv = "Sarajevo" });
            ListaGradova.Add(new Gradovi { Naziv = "Tuzla" });

            BindingContext = this;

          

        }
        private void Card(object sender, EventArgs e)

        {

            if ((Kartica.IsChecked == false && gotovina.IsChecked == false) || ime.Text.Equals("") || prezime.Text.Equals("") || broj.Text.Equals("")) {
                DisplayAlert("KFC", "Niste unijeli sve podatke", "OK");
            }
            else if (Kartica.IsChecked) 
            {

                Navigation.PushAsync(new Kartica());
            }
            else
            {
                DisplayAlert("KFC", "Hvala vam na povjerenju, narudžbu preuzmite u " + Vrijeme.Time.ToString(), "OK");
                Navigation.PushAsync(new Loogedin());
            }
        }

        
    }
}