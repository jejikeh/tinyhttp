using TinyHttp.Application.ViewModels;

namespace TinyHttp.Gui;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        
        BindingContext = new MainViewModel();
    }
}