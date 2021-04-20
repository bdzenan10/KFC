using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlavnaMaster : ContentPage
    {
        public ListView ListView;

        public GlavnaMaster()
        {
            InitializeComponent();

            BindingContext = new GlavnaMasterViewModel();
            ListView = MenuItemsListView;
        }

        class GlavnaMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<GlavnaMasterMenuItem> MenuItems { get; set; }

            public GlavnaMasterViewModel()
            {
                
                MenuItems = new ObservableCollection<GlavnaMasterMenuItem>(new[]
                {
                    
                    new GlavnaMasterMenuItem { Id = 0, Title = "Moje narudžbe", TargetType=typeof(History)},
                    new GlavnaMasterMenuItem { Id = 1, Title = "Meni", TargetType = typeof(Loogedin) },
                    new GlavnaMasterMenuItem { Id = 2, Title = "Logout", TargetType = typeof(MainPage) },

                    

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}