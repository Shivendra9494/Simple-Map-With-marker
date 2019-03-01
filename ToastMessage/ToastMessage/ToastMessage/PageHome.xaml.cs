using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToastMessage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageHome : ContentPage
	{
		public PageHome ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            ButtonToast.Clicked += ButtonToast_Clicked;
        }

        private void ButtonToast_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<Toast>().Show("I am shivendra");
        }
    }
}