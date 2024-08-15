using ShoppersMobile.MVVM.Views;

namespace ShoppersMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeView());
        }
    }
}
