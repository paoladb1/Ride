using Ride;
using System.Windows.Input;

namespace Ride;

public class CrearRaiteViewModel
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public DateTime FechaSalida { get; set; } = DateTime.Now;
    public TimeSpan HoraSalida { get; set; } = DateTime.Now.TimeOfDay;
    public int AsientosDisponibles { get; set; }
    public decimal PrecioPorAsiento { get; set; }

    public ICommand PublicarCommand { get; }

    public CrearRaiteViewModel()
    {
        PublicarCommand = new Command(async () => await PublicarRaite());
    }

    private async Task PublicarRaite()
    {
        if (string.IsNullOrWhiteSpace(Origen) || string.IsNullOrWhiteSpace(Destino) || AsientosDisponibles <= 0 || PrecioPorAsiento <= 0)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Por favor completa todos los datos correctamente.", "OK");
            return;
        }

        await Application.Current.MainPage.DisplayAlert("Éxito", "El raite ha sido publicado correctamente.", "OK");
        await Shell.Current.GoToAsync(nameof(HomePage));
    }
}
