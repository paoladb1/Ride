using Ride;

namespace Ride;

public partial class PaginaPrincipal : ContentPage
{
	public PaginaPrincipal()
	{
        InitializeComponent();

        BindingContext = new PaginaprincipalViewModel();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}