namespace Ride.MVVM.View
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
