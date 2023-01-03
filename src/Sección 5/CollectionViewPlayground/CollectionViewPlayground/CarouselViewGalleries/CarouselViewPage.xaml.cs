using System;

namespace CollectionViewPlayground.CarouselViewGalleries
{
	public partial class CarouselViewPage
	{
		public CarouselViewPage()
		{
			InitializeComponent();
		}

		async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			await DisplayAlert("Item", "Tapped", "Successfully");
		}
	}
}