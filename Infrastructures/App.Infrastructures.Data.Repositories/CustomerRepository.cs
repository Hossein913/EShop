﻿using EShop.Domain.DTOs;
using App.Domain.Core.DtoModels.Category;
using App.Domain.Core.DtoModels.Customer;
using App.Domain.Core.Entities;
using App.Domain.Core.DataAccess;
using App.Infrastructures.Db.SqlServer.Ef;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructures.Ripositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly EshopContext _context;

        public CustomerRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<Customer> Create(CustomerAddDto customerDto)
        {
            Customer customer = new Customer()
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                LastName = customerDto.LastName,
                Address = customerDto.Address,
                Carts = new List<Cart>()
            };
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task Delete(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);
            customer.IsDeleted = true;
            await _context.SaveChangesAsync();

        }

        //public async Task<List<Customer>> GetAll()
        //{
                  //var customer = _context.Customers.AsNoTracking().Include(c => c.IdNavigation);
                 //return customer.ToList();
        //}

        public async Task<Customer?> GetById(int customerId)
        {
            var product = await _context.Customers.FirstOrDefaultAsync(p => p.Id == customerId);
            return product;
        }

        public async Task Update(CustomerAddDto customer)
        {
            //var entity = _context.Customers.Find(customer.Id);
            //entity.Name = customer.Name;
            //entity.LastName = customer.LastName;
            //entity.Address = customer.Address;
            _context.Entry(customer).State = EntityState.Modified;
        }
    }

}