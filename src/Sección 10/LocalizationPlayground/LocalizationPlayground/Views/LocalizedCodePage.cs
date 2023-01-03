using LocalizationPlayground.Resources.Strings;

namespace LocalizationPlayground
{
    public class LocalizedCodePage : ContentPage
    {
        public LocalizedCodePage()
        {
            Title = "Localized Code Page";
            Padding = new Thickness(10, 40, 10, 10);

            Label notesLabel = new Label
            {
                Text = AppResources.NotesLabel,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = 300
            };

            Entry notesEntry = new Entry
            {
                Placeholder = AppResources.NotesPlaceholder,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = 300
            };

            Button addButton = new Button
            {
                Text = AppResources.AddButton,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                WidthRequest = 300
            };

            Content = new StackLayout
            {
                Children =
                {
                    notesLabel,
                    notesEntry,
                    addButton
                }
            };
        }
    }
}