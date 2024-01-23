using CommunityToolkit.Mvvm.ComponentModel;


namespace TinyHttp.Domain;

public partial class Request : ObservableObject
{
    [ObservableProperty]
    private string _url = string.Empty;
        
    [ObservableProperty]
    private HttpMethods _method = HttpMethods.Get;
}