using CommunityToolkit.Maui.Alerts;

namespace ShoppersMobile;

public partial class ColorMaker : ContentPage
{
    bool isRandom;
    string hexValue;
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
        hexValue = color.ToHex();
        ColorLabel.Text = hexValue;
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

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(hexValue);
        var toast = Toast.Make("Color copied", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
        await toast.Show();
    }
}