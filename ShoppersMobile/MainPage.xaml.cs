namespace ShoppersMobile
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void On_Color_Maker_Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ColorMaker());
        }

        
        private void On_Color_Maker_Btn_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TipCalc());
        }

        private void Data_Binding_Demo_Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindDemoPage());
        }
    }

}
