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
    public partial class Glavna : MasterDetailPage
    {
        public Glavna()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("Bf0205");

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as GlavnaMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page) { BarBackgroundColor = Color.FromHex("Bf0205")
        };
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}