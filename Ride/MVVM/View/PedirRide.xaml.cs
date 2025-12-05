namespace Ride.MVVM.View
{
    public partial class PedirRide : ContentPage
    {
        public PedirRide()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void IrADetalle(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DetalleRaitePage));
        }
    }
}
