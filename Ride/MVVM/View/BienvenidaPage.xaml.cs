using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage(string usuario)
        {
            InitializeComponent();

            // Mostrar nombre del usuario recibido
            LblUsuario.Text = $"Hola, {usuario}!";
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            // Navegar directamente a PedirRide
            await Shell.Current.GoToAsync(nameof(PedirRide));
        }
    }
}
