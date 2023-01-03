﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace CollectionViewPlayground.GroupingGalleries
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MeasureFirstStrategy : ContentPage
	{
		public MeasureFirstStrategy()
		{
			InitializeComponent();

			CollectionView.ItemsSource = new SuperTeams();
		}
	}
}