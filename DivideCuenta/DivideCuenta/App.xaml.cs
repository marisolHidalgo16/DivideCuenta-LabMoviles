using Microsoft.Extensions.DependencyInjection;

namespace DivideCuenta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}