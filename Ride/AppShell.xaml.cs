using Ride.MVVM.View;

namespace Ride
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegistroPage), typeof(RegistroPage));

            Routing.RegisterRoute(nameof(Paginaprincipal), typeof(Paginaprincipal));
            Routing.RegisterRoute(nameof(PedirRide), typeof(PedirRide));
            Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));
            Routing.RegisterRoute(nameof(MisRides), typeof(MisRides));
            Routing.RegisterRoute(nameof(Mensajes), typeof(Mensajes));

            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(CrearRaitePage), typeof(CrearRaitePage));
            Routing.RegisterRoute(nameof(DetalleRaitePage), typeof(DetalleRaitePage));
            Routing.RegisterRoute(nameof(SolicitarRaitePage), typeof(SolicitarRaitePage));
        }
    }
}
