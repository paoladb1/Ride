using Ride.MVVM.ViewModel;

namespace Ride.MVVM.View;

public partial class Perfil : ContentPage
{
    public Perfil()
    {
        InitializeComponent();
        BindingContext = new PerfilViewModel();
    }

    private async void EditarPerfil_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditarPerfil());
    }
}
