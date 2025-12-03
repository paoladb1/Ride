using Ride.MVVM.ViewModel;

namespace Ride.MVVM.View
{
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            BindingContext = new PaginaPrincipalViewModel();
        }
    }
}
