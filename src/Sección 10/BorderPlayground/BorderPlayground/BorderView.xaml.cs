using Microsoft.Maui.Controls.Shapes;

namespace BorderPlayground;

public partial class BorderView : ContentPage
{
    public BorderView()
    {
        InitializeComponent();

        BorderShapePicker.SelectedIndex = 1;
        BorderLineJoinPicker.SelectedIndex = 0;
        BorderLineCapPicker.SelectedIndex = 0;

        UpdateBackground();
        UpdateContentBackground();
        UpdateBorder();
        UpdateCornerRadius();
    }

    void OnBorderShapeSelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateBorderShape();
    }

    void OnBorderLineJoinSelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateBorderShape();
    }

    void OnBorderLineCapSelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateBorderShape();
    }

    void OnBackgroundChanged(object sender, TextChangedEventArgs e)
    {
        UpdateBackground();
    }

    void OnBorderChanged(object sender, TextChangedEventArgs e)
    {
        UpdateBorder();
    }

    void OnBorderWidthChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateBorder();
    }

    void OnBorderDashArrayChanged(object sender, TextChangedEventArgs e)
    {
        UpdateBorder();
    }

    void OnBorderDashOffsetChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateBorder();
    }

    void OnCornerRadiusChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateCornerRadius();
    }

    void OnContentBackgroundCheckBoxChanged(object sender, CheckedChangedEventArgs e)
    {
        UpdateContentBackground();
    }

    void UpdateBorderShape()
    {
        CornerRadiusLayout.IsVisible = BorderShapePicker.SelectedIndex == 1;

        UpdateBorder();
    }

    void UpdateBackground()
    {
        var startColor = GetColorFromString(BackgroundStartColor.Text);
        var endColor = GetColorFromString(BackgroundEndColor.Text);

        BackgroundStartColor.BackgroundColor = startColor;
        BackgroundEndColor.BackgroundColor = endColor;

        Border.Background = new LinearGradientBrush
        {
            StartPoint = new Point(0, 0),
            EndPoint = new Point(1, 0),
            GradientStops = new GradientStopCollection
                {
                    new Microsoft.Maui.Controls.GradientStop { Color = startColor, Offset = 0.0f },
                    new Microsoft.Maui.Controls.GradientStop { Color = endColor, Offset = 0.9f }
                }
        };
    }

    void UpdateContentBackground()
    {
        BorderContent.BackgroundColor = ContentBackgroundCheckBox.IsChecked ? Color.FromArgb("#99FF0000") : Colors.Transparent;
    }

    void UpdateBorder()
    {
        var startColor = GetColorFromString(BorderStartColor.Text);
        var endColor = GetColorFromString(BorderEndColor.Text);

        BorderStartColor.BackgroundColor = startColor;
        BorderEndColor.BackgroundColor = endColor;

        Shape borderShape = null;

        switch (BorderShapePicker.SelectedIndex)
        {
            case 0:
                borderShape = new Microsoft.Maui.Controls.Shapes.Rectangle();
                break;
            case 1:
                borderShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(TopLeftCornerSlider.Value, TopRightCornerSlider.Value,
                    BottomLeftCornerSlider.Value, BottomRightCornerSlider.Value)
                };
                break;
            case 2:
                borderShape = new Ellipse();
                break;
        }

        Border.StrokeShape = borderShape;

        Border.Stroke = new LinearGradientBrush
        {
            StartPoint = new Point(0, 0),
            EndPoint = new Point(1, 0),
            GradientStops = new GradientStopCollection
                {
                    new Microsoft.Maui.Controls.GradientStop { Color = startColor, Offset = 0.0f },
                    new Microsoft.Maui.Controls.GradientStop { Color = endColor, Offset = 0.9f }
                }
        };

        Border.StrokeThickness = BorderWidthSlider.Value;

        var borderDashArrayString = BorderDashArrayEntry.Text;

        if (string.IsNullOrEmpty(borderDashArrayString))
            Border.StrokeDashArray = new DoubleCollection();
        else
        {
            var doubleCollectionConverter = new DoubleCollectionConverter();
            var doubleCollection = (DoubleCollection)doubleCollectionConverter.ConvertFromString(borderDashArrayString);
            Border.StrokeDashArray = doubleCollection;
        }

        Border.StrokeDashOffset = BorderDashOffsetSlider.Value;

        PenLineJoin borderLineJoin = PenLineJoin.Miter;

        switch (BorderLineJoinPicker.SelectedIndex)
        {
            case 0:
                borderLineJoin = PenLineJoin.Miter;
                break;
            case 1:
                borderLineJoin = PenLineJoin.Round;
                break;
            case 2:
                borderLineJoin = PenLineJoin.Bevel;
                break;
        }

        Border.StrokeLineJoin = borderLineJoin;

        PenLineCap borderLineCap = PenLineCap.Flat;

        switch (BorderLineCapPicker.SelectedIndex)
        {
            case 0:
                borderLineCap = PenLineCap.Flat;
                break;
            case 1:
                borderLineCap = PenLineCap.Round;
                break;
            case 2:
                borderLineCap = PenLineCap.Square;
                break;
        }

        Border.StrokeLineCap = borderLineCap;
    }

    void UpdateCornerRadius()
    {
        UpdateBorder();
    }

    Color GetColorFromString(string value)
    {
        if (string.IsNullOrEmpty(value))
            return Colors.Transparent;

        try
        {
            return Color.FromArgb(value);
        }
        catch (Exception)
        {
            return Colors.Transparent;
        }
    }
}