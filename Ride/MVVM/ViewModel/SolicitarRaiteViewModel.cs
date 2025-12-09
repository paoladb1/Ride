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
     private string raiteSeleccionado;

        public string RaiteSeleccionado
        {
            get => raiteSeleccionado;
            set
            {
                raiteSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public ICommand SolicitarCommand { get; }

      

        private void SolicitarRaite()
        {

            // Aquí puedes agregar la lógica para solicitar un raite
            Application.Current.MainPage.DisplayAlert("Éxito", "Has solicitado el raite", "OK");

            if (!string.IsNullOrEmpty(RaiteSeleccionado))
            {
                Application.Current.MainPage.DisplayAlert("Éxito",
                    $"Has solicitado el raite: {RaiteSeleccionado}", "OK");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Aviso",
                    "Debes seleccionar un raite antes de solicitarlo.", "OK");
            }

        }
    }
}
