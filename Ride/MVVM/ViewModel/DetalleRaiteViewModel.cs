using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace Ride
{
    public class DetalleRaiteViewModel
    {
        public ICommand SolicitarRaiteCommand { get; }

        public DetalleRaiteViewModel()
        {
            SolicitarRaiteCommand = new Command(async () => await SolicitarRaite());
        }

        private async Task SolicitarRaite()
        {
            await Application.Current.MainPage.DisplayAlert("Solicitud Enviada", "Tu solicitud fue enviada al conductor.", "OK");
            await Shell.Current.GoToAsync(nameof(MisRides));
        }
    }
}
