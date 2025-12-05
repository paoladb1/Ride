using Ride;

namespace Ride.MVVM.View
{
    public partial class CrearRaitePage : ContentPage
    {
        public CrearRaitePage()
        {
            InitializeComponent();
            BindingContext = new CrearRaiteViewModel();
        }
    }
}
