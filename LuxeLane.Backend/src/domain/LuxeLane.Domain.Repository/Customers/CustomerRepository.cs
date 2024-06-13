using Ardalis.Specification.EntityFrameworkCore;
using Luxelane.Domain.Entities;
using Luxelane.Domain.Entities.Models;

namespace LuxeLane.Domain.Repository.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(LuxelaneContext dbContext) : base(dbContext)
        {
        }   
    }
}
