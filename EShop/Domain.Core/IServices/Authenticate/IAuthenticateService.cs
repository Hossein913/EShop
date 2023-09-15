namespace Domain.Core.IServices.Authenticate
{
    public interface IAuthenticateService
    {
        Task<IdentityResult?> RegisterService(RegisterViewModel registerModel, CancellationToken cancellationToken);
        Task<SignInResult?> LoginService(LoginViewModel LoginModel, CancellationToken cancellationToken);
    }
}
