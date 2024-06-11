using Ardalis.Specification.EntityFrameworkCore;
using Luxelane.Domain.Entities;
using Luxelane.Domain.Entities.Models;

namespace LuxeLane.Domain.Repository.Products
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(LuxelaneContext dbContext) : base(dbContext)
        {
        }   
    }
}
