using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class SolicitarRaitePage : ContentPage
    {
        public HomeViewModel HomeVM { get; private set; }

        // Constructor vacío obligatorio para XAML
        public SolicitarRaitePage()
        {
            InitializeComponent();
        }

        // Constructor que usamos para pasar HomeViewModel
        public SolicitarRaitePage(HomeViewModel homeVM)
        {
            InitializeComponent();

            HomeVM = homeVM;

            // Asignamos BindingContext al HomeViewModel
            BindingContext = HomeVM;

            // Inicializamos el comando Eliminar si no existe
            HomeVM.EliminarCommand ??= new Command<string>(EliminarRide);
        }

        private void EliminarRide(string ride)
        {
            if (HomeVM.MisRaites.Contains(ride))
                HomeVM.MisRaites.Remove(ride);
        }
    }
}
