namespace Ride.MVVM.View
{
    public partial class MisRides : ContentPage
    {
        public MisRides()
        {
            InitializeComponent();
        }

        private void EliminarRaite(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var texto = btn?.CommandParameter as string;

            if (btn?.Parent?.Parent is Frame frame)
            {
                (frame.Parent as VerticalStackLayout)?.Children.Remove(frame);
            }
        }
    }
}
