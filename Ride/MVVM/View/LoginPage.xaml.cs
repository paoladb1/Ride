using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EntryEmail.Text;
            string password = EntryPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Llena todos los campos.", "OK");
                return;
            }

            
            var bienvenidaPage = new BienvenidaPage(email);
            await Navigation.PushAsync(bienvenidaPage);
        }
    }
}
