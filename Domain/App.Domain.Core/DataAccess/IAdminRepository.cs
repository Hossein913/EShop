using EShop.Domain.DTOs;
using App.Domain.Core.Entities;
using App.Domain.Core.DtoModels.Admin;
namespace App.Domain.Core.DataAccess
{
    public interface IAdminRepository
    {
        Task<Admin> Create(AdminAddDto adminDto);
        Task Update(AdminAddDto adminDto);
        Task Delete(int AdminId);
        Task<Admin?> GetById(int AdminId);
        Task<List<Admin>> GetAll();
    }
}
