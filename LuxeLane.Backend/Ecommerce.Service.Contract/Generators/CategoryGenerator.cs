using Bogus;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Service.Contract.Generators
{
    public class CategoryGenerator
    {
        public static List<Category> GenerateCategories(int count)
        {
            var faker = new Faker();
            var categories = new List<Category>();
            var uniqueNames = new HashSet<string>();
            while (uniqueNames.Count < count)
            {
                var categoryName = faker.Commerce.Categories(1)[0];
                if (uniqueNames.Add(categoryName)) // Returns true if the name was added (unique)
                {
                    categories.Add(new Category
                    {
                        Id = faker.Random.Guid(),
                        CategoryName = categoryName,
                        CreatedAt = faker.Date.Past(),
                        UpdatedAt = faker.Date.Recent()
                    });
                }
            }
            return categories;
        }
    }
}