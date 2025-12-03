using System.Windows.Input;

namespace Ride.MVVM.ViewModel
{
    public class PaginaPrincipalViewModel
    {
        public ICommand BuscarRaiteCommand { get; }

        public PaginaPrincipalViewModel()
        {
            BuscarRaiteCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(View.PedirRide));
            });
        }
    }
}
