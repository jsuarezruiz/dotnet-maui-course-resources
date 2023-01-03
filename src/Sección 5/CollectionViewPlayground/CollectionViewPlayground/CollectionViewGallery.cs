using CollectionViewPlayground.AlternateLayoutGalleries;
using CollectionViewPlayground.CarouselViewGalleries;
using CollectionViewPlayground.EmptyViewGalleries;
using CollectionViewPlayground.GroupingGalleries;
using CollectionViewPlayground.HeaderFooterGalleries;
using CollectionViewPlayground.ItemSizeGalleries;
using CollectionViewPlayground.ReorderingGalleries;
using CollectionViewPlayground.ScrollModeGalleries;
using CollectionViewPlayground.SelectionGalleries;
using CollectionViewPlayground.SpacingGalleries;
using Microsoft.Maui.Controls;

namespace CollectionViewPlayground
{
	public class CollectionViewGalleryNavigation : NavigationPage
	{
		public CollectionViewGalleryNavigation()
		{
			PushAsync(new TemplateCodeCollectionViewGallery(LinearItemsLayout.Vertical));
		}
	}

	public class CollectionViewGallery : ContentPage
	{
		public CollectionViewGallery()
		{
			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Spacing = 5,
					Children =
					{
						GalleryBuilder.NavButton("Default Text Galleries", () => new DefaultTextGallery(), Navigation),
						GalleryBuilder.NavButton("DataTemplate Galleries", () => new DataTemplateGallery(), Navigation),
						GalleryBuilder.NavButton("Observable Collection Galleries", () => new ObservableCollectionGallery(), Navigation),
						GalleryBuilder.NavButton("Snap Points Galleries", () => new SnapPointsGallery(), Navigation),
						GalleryBuilder.NavButton("ScrollTo Galleries", () => new ScrollToGallery(), Navigation),
						GalleryBuilder.NavButton("EmptyView Galleries", () => new EmptyViewGallery(), Navigation),
						GalleryBuilder.NavButton("Selection Galleries", () => new SelectionGallery(), Navigation),
						GalleryBuilder.NavButton("Propagation Galleries", () => new PropagationGallery(), Navigation),
						GalleryBuilder.NavButton("Grouping Galleries", () => new GroupingGallery(), Navigation),
						GalleryBuilder.NavButton("Reordering Galleries", () => new ReorderingGallery(), Navigation),
						GalleryBuilder.NavButton("Item Spacing Galleries", () => new ItemsSpacingGallery(), Navigation),
						GalleryBuilder.NavButton("Item Size Galleries", () => new ItemsSizeGallery(), Navigation),
						GalleryBuilder.NavButton("Scroll Mode Galleries", () => new ScrollModeGallery(), Navigation),
						GalleryBuilder.NavButton("Alternate Layout Galleries", () => new AlternateLayoutGallery(), Navigation),
						GalleryBuilder.NavButton("Header/Footer Galleries", () => new HeaderFooterGallery(), Navigation),
						GalleryBuilder.NavButton("Nested CollectionViews", () => new NestedGalleries.NestedCollectionViewGallery(), Navigation),
					}
				}
			};
		}
	}
}