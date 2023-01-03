namespace CollectionViewPlayground
{
    public static class GalleryBuilder
    {
        public static Button NavButton(string galleryName, Func<Page> gallery, INavigation nav)
        {
            var automationId = System.Text.RegularExpressions.Regex.Replace(galleryName, " |\\(|\\)", string.Empty);
            var button = new Button
            {
                Text = $"{galleryName}",
                AutomationId = automationId,
                HorizontalOptions = LayoutOptions.Fill,
                Margin = 5
            };
            button.Clicked += async (sender, args) =>
            {
                await nav.PushAsync(gallery());
            };
            return button;
        }
    }
}
