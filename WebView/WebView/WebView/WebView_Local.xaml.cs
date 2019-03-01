using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebView_Local : ContentPage
	{
		public WebView_Local ()
		{
			InitializeComponent ();

            Webview.Source = new HtmlWebViewSource
            {
                Html = @"<html><body>An html string</body></html>"
            };
        }

        

       
    }
}