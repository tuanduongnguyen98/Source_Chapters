using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();

      string[] myPageNames = { "Namespace", "Static", "Array", "Reference", "Constructors", "Property Values" };
      examples.ItemsSource = myPageNames;

      examples.ItemTapped += (sender, e) =>
      {
        ContentPage gotoPage;
        switch (e.Item.ToString())
        {
          case "Namespace":
            gotoPage = new NamespacePage();
            break;
          case "Static":
            gotoPage = new StaticPage();
            break;
          case "Array":
            gotoPage = new ArrayPage();
            break;
          case "Reference":
            gotoPage = new ReferancePage();
            break;
          case "Constructors":
            gotoPage = new ConstructorPage();
            break;
          case "Property Values":
            gotoPage = new PropertyValuesPage();
            break;
          default:
            gotoPage = new NamespacePage();
            break;
        }
        Detail = new NavigationPage(gotoPage);
        ((ListView)sender).SelectedItem = null;
        this.IsPresented = false;
      };

      Detail = new NavigationPage(new NamespacePage());
    }
    }
}