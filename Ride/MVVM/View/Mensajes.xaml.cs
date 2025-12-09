using Ride.MVVM.ViewModel;

namespace Ride.MVVM.View;

public partial class Mensajes : ContentPage
{
    public Mensajes()
    {
        InitializeComponent();
        BindingContext = new MensajesViewModel();
    }
}
