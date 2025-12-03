using Ride;

namespace Ride.MVVM.View
{
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
            BindingContext = new PerfilViewModel();
        }
    }
}
