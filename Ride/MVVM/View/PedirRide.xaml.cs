using Ride.MVVM.View;

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
            await Navigation.PushAsync(new ViajesDisponiblesPage());
        }
    }
}
