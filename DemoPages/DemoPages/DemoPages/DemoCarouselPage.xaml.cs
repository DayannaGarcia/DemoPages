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
	public partial class DemoCarouselPage : CarouselPage
	{
		public DemoCarouselPage ()
		{
			InitializeComponent ();
		}
	}
}