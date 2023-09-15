
using Microsoft.AspNetCore.Identity;
using App.Domain.Core.DtoModels.Authenticate;

namespace App.Domain.Core.DataAccess
{
    public interface IUserManagerRepository
    {
        Task<int> Create(UserRegisterDto command, CancellationToken cancellationToken);
        Task<SignInResult> Login(UserLoginDto command, CancellationToken cancellationToken);
        //Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
    }
}
