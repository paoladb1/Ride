using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ride.MVVM.ViewModel;

public class PerfilViewModel : INotifyPropertyChanged
{
    private static string _nombre = "Andrea Lopez";
    private static string _rol = "Conductora de Raites";
    private static string _uni = "UTS";
    private static string _grupo = "DSM4A";
    private static string _disp = "Si";
    private static string _desc = "Soy una persona puntual y responsable. Me gusta apoyar con raites para que todos lleguemos seguros.";

    public string Nombre { get => _nombre; set { _nombre = value; OnChanged(); } }
    public string Rol { get => _rol; set { _rol = value; OnChanged(); } }
    public string Universidad { get => _uni; set { _uni = value; OnChanged(); } }
    public string Grupo { get => _grupo; set { _grupo = value; OnChanged(); } }
    public string Disponible { get => _disp; set { _disp = value; OnChanged(); } }
    public string Descripcion { get => _desc; set { _desc = value; OnChanged(); } }

    public event PropertyChangedEventHandler PropertyChanged;
    void OnChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
