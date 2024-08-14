namespace ShoppersMobile;

public partial class ColorMaker : ContentPage
{
    bool isRandom;
    public ColorMaker()
    {
        InitializeComponent();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (!isRandom)
        {
            var red = RedSlider.Value;
            var green = GreenSlider.Value;
            var blue = BlueSlider.Value;
            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }

    }

    private void SetColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        ColorLabel.Text = color.ToHex();
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {//hello world
        isRandom = true;
        var random = new Random();
        var color = Color.FromRgb(
                        random.Next(0, 265),
                        random.Next(0, 265),
                        random.Next(0, 265)
                    );
        SetColor(color);

        GreenSlider.Value = color.Red;
        BlueSlider.Value = color.Green;
        RedSlider.Value = color.Blue;
        isRandom = false;
    }
}