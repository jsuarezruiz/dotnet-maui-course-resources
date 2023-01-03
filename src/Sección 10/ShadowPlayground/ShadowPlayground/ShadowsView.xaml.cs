namespace ShadowPlayground;

public partial class ShadowsView : ContentPage
{
    public ShadowsView()
    {
        InitializeComponent();

        UpdateShadowOffset();
    }

    void OnShadowOffsetXChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateShadowOffset();
    }

    void OnShadowOffsetYChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateShadowOffset();
    }

    void UpdateShadowOffset()
    {
        var offset = new Point(ShadowOffsetXSlider.Value, ShadowOffsetYSlider.Value);
        ShadowView.Shadow.Offset = offset;
        LabelShadowView.Shadow.Offset = offset;
    }
}