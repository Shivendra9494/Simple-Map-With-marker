﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Webview.Source = "http://ongdalsam.simget.online/Home";
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)  
        {  
            progress.IsVisible = true;  
        }  
  
        protected void OnNavigated(object sender, WebNavigatedEventArgs e)  
        {  
            progress.IsVisible = false;  
        }  
    }
}
