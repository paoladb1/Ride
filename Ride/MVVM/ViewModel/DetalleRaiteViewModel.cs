using Microsoft.Maui.Controls;
using Ride.MVVM.View;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ride.MVVM.ViewModel
{
    public class DetalleRaiteViewModel
    {
        public ICommand SolicitarRaiteCommand { get; }
        public string MisRides { get; private set; }

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
