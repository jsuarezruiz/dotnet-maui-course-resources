namespace GesturesPlayground
{
	public class TapInsideFrame : ContentPage
	{
		int _tapCount;
		readonly Label label;

		public TapInsideFrame()
		{
			var frame = new Border
            {
				Stroke = Colors.Blue,
				BackgroundColor = Colors.Transparent,
				Padding = new Thickness(20, 100),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Content = new Label
				{
					Text = "Tap Inside Border",
					FontSize = 24
				}
			};


			var tapGestureRecognizer = 
				new TapGestureRecognizer();
			//tapGestureRecognizer.NumberOfTapsRequired = 2; // Double-tap
			tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
			frame.GestureRecognizers.Add(tapGestureRecognizer);


		 	label = new Label
			{
				Text = " ",
				FontSize = 24,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			Content = new StackLayout
			{
				Children =
				{
					frame,
					label
				}
			};
		}

		void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
            _tapCount++;
			label.Text = string.Format("{0} tap{1} so far!",
                _tapCount,
                _tapCount == 1 ? "" : "s");
		}
	}
}
