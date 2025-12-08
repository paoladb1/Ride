using Microsoft.Maui.Controls;
using Ride.MVVM.ViewModel;

namespace Ride.MVVM.View
{
    public partial class MisRides : ContentPage
    {
        public MisRides()
        {
            InitializeComponent();
            BindingContext = new MisRidesViewModel();
        }
    }
}
