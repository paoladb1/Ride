using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Ride.MVVM.ViewModel
{
    public class MensajesViewModel : BindableObject
    {
        public ObservableCollection<MensajesViewModel> Mensajes { get; set; }
        public string MensajeNuevo { get; set; }

        // Agregar la propiedad faltante 'Texto'
        public string Texto { get; set; }

        public ICommand EnviarCommand { get; }
        public ICommand EliminarCommand { get; }

        public MensajesViewModel()
        {
            Mensajes = new ObservableCollection<MensajesViewModel>();

            EnviarCommand = new Command(() =>
            {
                if (!string.IsNullOrWhiteSpace(MensajeNuevo))
                {
                    Mensajes.Add(new MensajesViewModel { Texto = MensajeNuevo });
                    MensajeNuevo = string.Empty;
                    OnPropertyChanged(nameof(MensajeNuevo));
                }
            });

            EliminarCommand = new Command<MensajesViewModel>((msg) =>
            {
                if (msg != null && Mensajes.Contains(msg))
                {
                    Mensajes.Remove(msg);
                }
            });

        }
    }
}
