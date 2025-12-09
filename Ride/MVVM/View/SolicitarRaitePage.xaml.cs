using Microsoft.Maui.Controls;

namespace Ride.MVVM.View
{
    public partial class SolicitarRaitePage : ContentPage
    {
        public HomeViewModel HomeVM { get; private set; }


    
        public SolicitarRaitePage(HomeViewModel homeVM)
        {
            InitializeComponent();

            HomeVM = homeVM;


            BindingContext = HomeVM;

            HomeVM.EliminarCommand ??= new Command<string>(EliminarRide);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void EliminarRide(string ride)
        {
            if (HomeVM.MisRaites.Contains(ride))
                HomeVM.MisRaites.Remove(ride);

        }
        private void RadioCheck(object sender, CheckedChangedEventArgs e)
        {
            if (sender is RadioButton rb && rb.IsChecked)
            {

                if (BindingContext is ViewModel.SolicitarRaiteViewModel vm)
                {
                    vm.RaiteSeleccionado = rb.Value.ToString();
                }
            }

        }
    }
}
