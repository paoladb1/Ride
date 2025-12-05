namespace Ride.MVVM.View
{
    public partial class SolicitarRaitePage : ContentPage
    {
        public SolicitarRaitePage()
        {
            InitializeComponent();
        }

        private async void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void IrAHome(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PaginaPrincipal));
        }
    }
}
