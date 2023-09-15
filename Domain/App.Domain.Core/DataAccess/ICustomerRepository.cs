using App.Domain.Core.Entities;
using App.Domain.Core.DtoModels.Customer;

namespace App.Domain.Core.DataAccess
{
    public interface ICustomerRepository
    {
        Task<Customer> Create(CustomerAddDto customer);
        Task Update(CustomerAddDto customer);
        Task Delete(int customerId);
        Task<Customer?> GetById(int customerId);
        //Task<List<Customer>> GetAll();
    }
}
