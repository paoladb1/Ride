using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Ride.MVVM.ViewModel
{
    public class MensajesViewModel : BaseViewModel
    {
        public ObservableCollection<string> Mensajes { get; set; } = new();

        private string _mensajeNuevo;
        public string MensajeNuevo
        {
            get => _mensajeNuevo;
            set
            {
                _mensajeNuevo = value;
                OnPropertyChanged();
            }
        }

        public ICommand EnviarCommand { get; }

        public MensajesViewModel()
        {
            Mensajes.Add("Hola, ¿a qué hora pasas?");
            Mensajes.Add("En 10 minutos.");
            Mensajes.Add("Perfecto, aquí te espero.");

            EnviarCommand = new Command(EnviarMensaje);
        }

        private void EnviarMensaje()
        {
            if (!string.IsNullOrWhiteSpace(MensajeNuevo))
            {
                Mensajes.Add(MensajeNuevo);
                MensajeNuevo = string.Empty;
            }
        }
    }
}
