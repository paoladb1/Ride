using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Ride.MVVM.ViewModel
{
    public class CrearRaiteViewModel : BindableObject
    {
        // Campos del formulario
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; } = DateTime.Now;
        public TimeSpan HoraSalida { get; set; } = DateTime.Now.TimeOfDay;
        public int AsientosDisponibles { get; set; }
        public decimal PrecioPorAsiento { get; set; }

        // Lista global de Raites
        public static ObservableCollection<string> Raites { get; set; } = new ObservableCollection<string>();

        // Comando para publicar
        public ICommand PublicarCommand { get; }

        public CrearRaiteViewModel()
        {
            PublicarCommand = new Command(async () => await PublicarRaite());
        }

        private async Task PublicarRaite()
        {
            // Validacion de campos
            if (string.IsNullOrWhiteSpace(Origen) || string.IsNullOrWhiteSpace(Destino) ||
                AsientosDisponibles <= 0 || PrecioPorAsiento <= 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor completa todos los campos correctamente.", "OK");
                return;
            }

            // Crear texto del raite
            string raite = $"{Origen} - {Destino} ({FechaSalida:dd/MM/yyyy} {HoraSalida:hh\\:mm}) - Asientos: {AsientosDisponibles} - Precio: ${PrecioPorAsiento}";

            // Agregar a la lista global
            Raites.Add(raite);

            // Mostrar mensaje de exito
            await Application.Current.MainPage.DisplayAlert("Exito", "Raite publicado correctamente.", "OK");

            // Limpiar campos
            Origen = Destino = "";
            FechaSalida = DateTime.Now;
            HoraSalida = DateTime.Now.TimeOfDay;
            AsientosDisponibles = 0;
            PrecioPorAsiento = 0;
            OnPropertyChanged(nameof(Origen));
            OnPropertyChanged(nameof(Destino));
            OnPropertyChanged(nameof(FechaSalida));
            OnPropertyChanged(nameof(HoraSalida));
            OnPropertyChanged(nameof(AsientosDisponibles));
            OnPropertyChanged(nameof(PrecioPorAsiento));

            // Navegar a la pantalla de mis raites
            await Shell.Current.GoToAsync(nameof(MisRidesPage));
        }
    }
}
