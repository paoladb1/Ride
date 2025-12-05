namespace Ride.MVVM.View
{
    public partial class Mensajes : ContentPage
    {
        public Mensajes()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
