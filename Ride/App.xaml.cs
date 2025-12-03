using Microsoft.Maui.Controls;

namespace Ride
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Se inicializa Shell directamente
            MainPage = new AppShell();
        }
    }
}
