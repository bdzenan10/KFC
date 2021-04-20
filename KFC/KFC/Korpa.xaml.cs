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
    public partial class Korpa : ContentPage
    {
        public Korpa()
        {
            InitializeComponent();
            BindingContext = this;
            float cijena = 0.0f;
            if (Cart.ProductsInCart.Count==0) lblNaziv.Text = "Vaša korpa je trenutno prazna";
            else
            {
                
               
                
                for(int i=0; i<Cart.ProductsInCart.Count; i++)
                {

                  //  Label label = new Label { Text= Cart.ProductsInCart.ElementAt(i).Naziv + " " + Cart.ProductsInCart.ElementAt(i).Cijena + " " + Cart.ProductsInCart.ElementAt(i).kolicina };
                    //Image image = new Image { Source = Cart.ProductsInCart.ElementAt(i).image };
                    
                 lblOrd.Text = lblOrd.Text+"\n"+ Cart.ProductsInCart.ElementAt(i).Naziv + " " + " "+Cart.ProductsInCart.ElementAt(i).Cijena + " KM" + " "+Cart.ProductsInCart.ElementAt(i).kolicina+" kom";
                cijena = cijena + (Cart.ProductsInCart.ElementAt(i).Cijena * Cart.ProductsInCart.ElementAt(i).kolicina);
                }
                
            }
            lblCijena.Text = "Ukupno za platiti: "+cijena + " KM";
        }

        
        void Button_Clicked(object sender, EventArgs e)


        {

            if (Cart.ProductsInCart.Count == 0) { DisplayAlert("Korpa", "Vaša korpa je prazna", "OK"); }
            else
            {

               
                Navigation.PushAsync(new Placanje()); 

                Order o = new Order(lblOrd.Text);
                User u = new User();

                try
                {
                    User.bonus.Add(1);
                }
                catch (Exception f) { }

                try
                {
                    User.orders.Add(o);
                }
                catch (Exception d)
                {

                    
                }

                lblOrd.Text = "";
                Cart.ProductsInCart.Clear();
                }
            lblCijena.Text = "0.0 KM";
            lblHead.Text = "";

            lblNaziv.Text = "Vaša korpa je trenutno prazna";
        }

      
    }
}