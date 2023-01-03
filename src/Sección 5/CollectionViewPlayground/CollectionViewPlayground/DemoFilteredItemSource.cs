﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CollectionViewPlayground
{
	internal class DemoFilteredItemSource
	{
		readonly List<CollectionViewGalleryTestItem> _source;
		private readonly Func<string, CollectionViewGalleryTestItem, bool> _filter;

		public ObservableCollection<CollectionViewGalleryTestItem> Items { get; }

		public DemoFilteredItemSource(int count = 50, Func<string, CollectionViewGalleryTestItem, bool> filter = null)
		{
			_source = new List<CollectionViewGalleryTestItem>();

			AddItems(_source, count);

			Items = new ObservableCollection<CollectionViewGalleryTestItem>(_source);

			_filter = filter ?? ItemMatches;
		}


		public void AddItems(IList<CollectionViewGalleryTestItem> list, int count)
		{
			string[] images =
			{
                "defaultimage.png",
                "dotnet_bot.png",
			};

			for (int n = 0; n < count; n++)
			{
				list.Add(new CollectionViewGalleryTestItem(DateTime.Now.AddDays(n),
					$"{images[n % images.Length]}, {n}", images[n % images.Length], n));
			}
		}

		public void FilterItems(string filter)
		{
			var filteredItems = _source.Where(item => _filter(filter, item)).ToList();

			foreach (CollectionViewGalleryTestItem collectionViewGalleryTestItem in _source)
			{
				if (!filteredItems.Contains(collectionViewGalleryTestItem))
				{
					Items.Remove(collectionViewGalleryTestItem);
				}
				else
				{
					if (!Items.Contains(collectionViewGalleryTestItem))
					{
						Items.Add(collectionViewGalleryTestItem);
					}
				}
			}
		}
		bool ItemMatches(string filter, CollectionViewGalleryTestItem item)
		{
			filter = filter ?? "";
			return item.Caption.Contains(filter, StringComparison.OrdinalIgnoreCase);
		}
	}
}