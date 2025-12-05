namespace Ride.MVVM.View
{
    public partial class MisRides : ContentPage
    {
        public MisRides()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
