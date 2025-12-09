using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class PedirRide : ContentPage
    {
        public PedirRide()
        {
            InitializeComponent();
        }

        private async void OnBuscarClicked(object sender, EventArgs e)
        {
            // Navegar a MisRides
            await Navigation.PushAsync(new MisRides());
        }
    }
}
