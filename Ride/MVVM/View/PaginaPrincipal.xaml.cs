using Ride.MVVM.View;

namespace Ride.MVVM.View
{
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private async void IrAPedirRide(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PedirRide));
        }

        private async void IrACrearRide(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CrearRaitePage));
        }

        private async void IrAMisRides(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MisRides));
        }
    }
}
