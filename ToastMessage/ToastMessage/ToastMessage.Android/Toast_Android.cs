﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ToastMessage.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Toast_Android))] 
namespace ToastMessage.Droid
{
    public class Toast_Android : Toast
    {
        public void Show(string Message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, Message, ToastLength.Long).Show();
        }
    }
}