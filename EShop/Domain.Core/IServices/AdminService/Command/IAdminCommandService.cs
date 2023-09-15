using Domain.Core.Dtos;
using Domain.Core.Entities;
namespace Domain.Core.IServices.AdminService.Command
{
    public interface IAdminCommandService
    {
         Task<bool> EditeProfile(AdminEditDto admineditdto);
    }
}
