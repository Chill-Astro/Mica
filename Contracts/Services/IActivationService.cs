namespace Mica_by_Chill_Astro.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
