using System.Windows.Input;

namespace Ride;

    public class PaginaprincipalViewModel
    {
        public ICommand BuscarRaiteCommand { get; }

        public PaginaprincipalViewModel()
        {
            BuscarRaiteCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(PedirRide));
            });
        }
    }
