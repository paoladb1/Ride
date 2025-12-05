namespace Ride.MVVM.View
{
    public partial class CrearRaitePage : ContentPage
    {
        public CrearRaitePage()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
