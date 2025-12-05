namespace Ride.MVVM.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Iniciar_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PaginaPrincipal));
        }

        private async void CrearCuenta_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CrearCuentaPage));
        }
    }
}
