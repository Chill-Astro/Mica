using Mica.ViewModels;
using Mica.Contracts.Services;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

namespace Mica.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        var navigationService = App.GetService<INavigationService>();
        navigationService.NavigateTo(typeof(SettingsViewModel).FullName!);
    }
}
