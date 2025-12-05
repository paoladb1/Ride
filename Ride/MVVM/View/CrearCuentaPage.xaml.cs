namespace Ride.MVVM.View
{
    public partial class CrearCuentaPage : ContentPage
    {
        public CrearCuentaPage()
        {
            InitializeComponent();
        }

        private async void Crear_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
    }
}
