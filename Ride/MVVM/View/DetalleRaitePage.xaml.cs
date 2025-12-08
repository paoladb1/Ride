using Ride.MVVM.View;
using Microsoft.Maui.Controls;
using Ride.MVVM.ViewModel;

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
            await DisplayAlert("Conductor", "Aqui puedes mostrar mas informacion del conductor.", "OK");
        }
    }
}
