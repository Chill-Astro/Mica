using Mica_by_Chill_Astro.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Mica_by_Chill_Astro.Views;

public sealed partial class MicaPage : Page
{
    public MicaViewModel ViewModel
    {
        get;
    }

    public MicaPage()
    {
        ViewModel = App.GetService<MicaViewModel>();
        InitializeComponent();
    }
}
