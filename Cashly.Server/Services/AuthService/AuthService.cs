
namespace Cashly.Server.Services.AuthService;

public class AuthService : IAuthService
{
    public Task<ServiceResponse<int>> Register(User user, string password)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExists(string username)
    {
        throw new NotImplementedException();
    }
}
