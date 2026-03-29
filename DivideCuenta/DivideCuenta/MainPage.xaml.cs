namespace DivideCuenta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDivideCuenta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DivideCuentaPage());
        }
    }
}