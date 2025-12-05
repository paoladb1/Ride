using Ride.MVVM.Models;

namespace Ride.MVVM.View
{
    public partial class CrearRaitePage : ContentPage
    {
        public CrearRaitePage()
        {
            InitializeComponent();
        }

        private async void Publicar_Clicked(object sender, EventArgs e)
        {
            RideModel nuevo = new RideModel
            {
                Origen = entryOrigen.Text,
                Destino = entryDestino.Text,
                Horario = entryHorario.Text,
                Asientos = int.Parse(entryAsientos.Text)
            };

            RideStorage.Rides.Add(nuevo);

            await DisplayAlert("Ride publicado", "Tu ride ha sido guardado", "OK");

            await Shell.Current.GoToAsync(nameof(PedirRide));
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
