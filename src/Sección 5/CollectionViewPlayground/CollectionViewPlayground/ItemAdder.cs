﻿using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace CollectionViewPlayground
{
	internal class ItemAdder : ObservableCollectionModifier
	{
		public ItemAdder(CollectionView cv) : base(cv, "Adder")
		{
		}

		protected override void ModifyObservableCollection(ObservableCollection<CollectionViewGalleryTestItem> observableCollection, params int[] indexes)
		{
			var item = new CollectionViewGalleryTestItem(DateTime.Now, "Added", "oasis.jpg", observableCollection.Count);
			observableCollection.Add(item);
		}
	}
}