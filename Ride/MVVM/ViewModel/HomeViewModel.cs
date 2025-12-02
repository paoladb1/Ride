using Ride.MVVM.View;
using System.Windows.Input;

namespace Ride;

public class HomeViewModel
{
    public ICommand IrASolicitarRaiteCommand { get; }
    public ICommand IrACrearRaiteCommand { get; }
    public ICommand VerDetalleCommand { get; }

    public HomeViewModel()
    {
        IrASolicitarRaiteCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(SolicitarRaitePage)));
        IrACrearRaiteCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(CrearRaitePage)));
        VerDetalleCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(DetalleRaitePage)));
    }
}
