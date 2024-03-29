using Microsoft.AspNetCore.Components.Authorization;

namespace FoodSystemClient.Authentication;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private AuthenticationState authenticationState;
    
    public CustomAuthenticationStateProvider(AuthenticationService service)
    {
        authenticationState = new AuthenticationState(service.CurrentUser);

        service.UserChanged += (newUser) =>
        {
            authenticationState = new AuthenticationState(newUser);

            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(newUser)));
        };
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(authenticationState);
    }
}