using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinListViewSample
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            string[] items = new []
            {
                "Mario",
                "Giovanni",
                "Matteo",
                "Carlo",
                "Giacomo",
                "Simone",
                "Nando",
                "Fabio",
                "Martina",
                "Luisa",
                "Anna",
                "Paola",
                "Simone",
                "Nando",
                "Fabio",
                "Simone",
                "Nando",
                "Fabio",
                "Federica"
            };

            MyListView.ItemsSource = items;
            MyListView.ItemTapped += MyListView_ItemTapped;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((NavigationPage)App.Current.MainPage).PushAsync(new DetailPage(e.Item.ToString()));
        }
    }
}
