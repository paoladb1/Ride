namespace Ride.MVVM.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void IrAPedirRide(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PedirRide));
        }

        private async void IrACrear(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CrearRaitePage));
        }
    }
}
