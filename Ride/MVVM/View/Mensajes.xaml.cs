using Ride;
using Ride;

namespace Ride
{
    public partial class Mensajes : ContentPage
    {
        public Mensajes()
        {
            InitializeComponent();
            BindingContext = new MensajesViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
   