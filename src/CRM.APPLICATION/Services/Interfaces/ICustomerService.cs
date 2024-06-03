using CRM.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.APPLICATION.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
        Task<Customer?> GetById(int id);
        Task Create(Customer customer);
        Task Update(Customer customer);
        Task Delete(Customer customer);

    }
}
