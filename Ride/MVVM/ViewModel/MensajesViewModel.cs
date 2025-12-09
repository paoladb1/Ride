using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Ride.MVVM.ViewModel
{
    public class Mensaje
    {
        public string Texto { get; set; }
    }

    public class MensajesViewModel : BindableObject
    {
        private string _mensajeNuevo;

        public ObservableCollection<Mensaje> Mensajes { get; set; }

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
        public ICommand BorrarMensajeCommand { get; }
        public ICommand BorrarConversacionCommand { get; }

        public MensajesViewModel()
        {
            Mensajes = new ObservableCollection<Mensaje>();

            EnviarCommand = new Command(EnviarMensaje);
            BorrarMensajeCommand = new Command<Mensaje>(BorrarMensaje);
            BorrarConversacionCommand = new Command(BorrarConversacion);
        }

        private void EnviarMensaje()
        {
            if (!string.IsNullOrWhiteSpace(MensajeNuevo))
            {
                Mensajes.Add(new Mensaje { Texto = MensajeNuevo });
                MensajeNuevo = string.Empty;
            }
        }

        private void BorrarMensaje(Mensaje mensaje)
        {
            if (mensaje != null && Mensajes.Contains(mensaje))
                Mensajes.Remove(mensaje);
        }

        private void BorrarConversacion()
        {
            Mensajes.Clear();
        }
    }
}
