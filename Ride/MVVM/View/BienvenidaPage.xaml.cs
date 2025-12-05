using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage(string usuario)
        {
            InitializeComponent();

            LblUsuario.Text = $"Hola, {usuario}!";
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            // Ir a HomePage
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
    }
}
