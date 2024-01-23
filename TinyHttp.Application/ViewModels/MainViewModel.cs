using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TinyHttp.Domain;

namespace TinyHttp.Application.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private Request _request = new();
    
    [ObservableProperty]
    private bool _isEnabled;
    
    [RelayCommand]
    public void Send()
    {
        IsEnabled = false;
    }
}