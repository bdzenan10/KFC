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
    public partial class Gost : ContentPage
       
    {
        public IList<Gradovi> ListaGradova { get; set; }
        public Gost(string i)
        {
            InitializeComponent();
            ListaGradova = new List<Gradovi>();
            ListaGradova.Add(new Gradovi { Naziv = "Zenica" });
            ListaGradova.Add(new Gradovi { Naziv = "Sarajevo" });
            ListaGradova.Add(new Gradovi { Naziv = "Tuzla" });
            
            BindingContext = this;

            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("Bf0205");

            this.Dobrodosli.Text = "Dobrosošli"+" "+i+"!";

            


        }
        private void Button_Clicked(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Meni());
        }
    }
}