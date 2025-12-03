using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

     
        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        private async void BtnRegistro_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CrearCuentaPage));
        }
    }
}
