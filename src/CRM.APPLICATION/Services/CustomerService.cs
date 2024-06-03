using CRM.APPLICATION.Common.Interfaces;
using CRM.APPLICATION.Services.Interfaces;
using CRM.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.APPLICATION.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IApplicationDbContext _context;

        public CustomerService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>>GetAll()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task<Customer?>GetById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }


        public async Task Create (Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return;
        }
        public async Task Update(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return;
        }
        public async Task Delete (Customer customer)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return;
        }




    }
}
