using Microsoft.Maui.Controls;

namespace Ride
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new AppShell();
        }
    }
}
