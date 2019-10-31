using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace chapter6
{
    public partial class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
         {
         new ListItem { Source ="imageSmall.png", Title = "Khoa", Description="1st item"},
         new ListItem { Source ="imageSmall.png",  Title = "Duong", Description="2nd item"},
         new ListItem { Source ="imageSmall.png", Title = "Tai", Description="3rd item"}
         };
            DataModelList.ItemsSource = ListItems;
        }

         async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }
        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Source { get; set; }
        }
    }
}
