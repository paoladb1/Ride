using Ride.MVVM.View;

namespace Ride.MVVM.View
{
    public partial class DetalleRaitePage : ContentPage
    {
        public DetalleRaitePage()
        {
            InitializeComponent();
            BindingContext = new DetalleRaiteViewModel();
        }

        private async void ConductorInfo_Tapped(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Conductor", "Aquí puedes mostrar más información del conductor.", "OK");
        }
    }
}
