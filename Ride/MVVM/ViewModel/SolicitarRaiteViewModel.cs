using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Ride.MVVM.ViewModel
{
    public class SolicitarRaiteViewModel : BindableObject
    {
        public ICommand SolicitarRaiteCommand { get; }

        public SolicitarRaiteViewModel()
        {
            SolicitarRaiteCommand = new Command(SolicitarRaite);
        }

        private void SolicitarRaite()
        {
            // Aquí puedes agregar la lógica para solicitar un raite
            Application.Current.MainPage.DisplayAlert("Éxito", "Has solicitado el raite", "OK");
        }
    }
}
