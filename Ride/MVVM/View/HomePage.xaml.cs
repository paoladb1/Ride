using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void BtnVerRaites_Clicked(object sender, EventArgs e)
        {
            // Navegar a la página PedirRide (debes tenerla creada)
            await Shell.Current.GoToAsync(nameof(PedirRide));
        }
    }
}
