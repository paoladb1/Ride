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

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(".."); // Regresar
        }

        private async void ConductorInfo_Tapped(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Conductor",
                               "Aqui puedes mostrar mas informacion del conductor.",
                               "OK");
        }
    }
}
