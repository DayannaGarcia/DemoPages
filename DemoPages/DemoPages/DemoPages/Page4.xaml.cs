﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            btnCerrar.Clicked += BtnCerrar_Clicked;
		}

        private void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}