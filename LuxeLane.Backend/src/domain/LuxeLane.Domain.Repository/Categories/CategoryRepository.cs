using Ardalis.Specification.EntityFrameworkCore;
using Luxelane.Domain.Entities;
using Luxelane.Domain.Entities.Models;

namespace LuxeLane.Domain.Repository.Categories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(LuxelaneContext dbContext) : base(dbContext)
        {
        }   
    }
}
