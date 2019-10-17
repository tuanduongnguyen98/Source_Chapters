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
	public partial class PropertyValuesPage : ContentPage
	{
    void ButtonClicked(object sender, System.EventArgs e)
    {
      ((Button)sender).Text = "It is so!";
    }

    public PropertyValuesPage()
    {
      InitializeComponent();
    }
  }
}