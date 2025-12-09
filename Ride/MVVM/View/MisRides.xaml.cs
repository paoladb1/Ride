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

        private void EliminarRaite(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn?.Parent?.Parent is Frame frame)
            {
                (frame.Parent as VerticalStackLayout)?.Children.Remove(frame);
            }

        }
    }
}
