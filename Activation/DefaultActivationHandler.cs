using Mica_by_Chill_Astro.Contracts.Services;
using Mica_by_Chill_Astro.ViewModels;

using Microsoft.UI.Xaml;

namespace Mica_by_Chill_Astro.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(MicaViewModel).FullName!, args.Arguments);

        await Task.CompletedTask;
    }
}
