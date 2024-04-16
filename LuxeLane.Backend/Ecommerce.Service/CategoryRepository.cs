using Ecommerce.Domain.Entities;
using Ecommerce.Service.Abstraction;
using Ecommerce.Service.Context;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq.Expressions;


namespace Ecommerce.Service
{
    public class CategoryRepository : RepositoryBase<Category, ApplicationContext>
    {
        public CategoryRepository(IRepositoryOptions<ApplicationContext> options) : base(options)
        {
        }

        public override Expression<Func<ApplicationContext, DbSet<Category>>> DataSet() => o => o.Category;

        public override Expression<Func<Category, object>> Key() => o => o.Id;

        #region Legacy Subcategory Call
        /*public string GetCategoriesWithChildrenJson()
        {
            var rootCategories = Context.Category
                    .Where(category => category.ParentId == null)
                    .ToList();

            var categoriesWithChildren = new List<CategoryWithChildren>();

            foreach (var rootCategory in rootCategories)
            {
                var categoryWithChildren = MapCategoryWithChildren(rootCategory);
                categoriesWithChildren.Add(categoryWithChildren);
            }

            return JsonConvert.SerializeObject(categoriesWithChildren, Formatting.Indented);
        }


        private CategoryWithChildren MapCategoryWithChildren(Category category)
        {
            var categoryWithChildren = new CategoryWithChildren
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Children = new List<CategoryWithChildren>()
            };

            var subcategories = Context.Category
                    .Where(c => c.ParentId == category.Id)
                    .ToList();

            foreach (var subcategory in subcategories)
            {
                var childCategory = MapCategoryWithChildren(subcategory);
                categoryWithChildren.Children.Add(childCategory);
            }

            return categoryWithChildren;
        }*/
        #endregion
        
        public string GetCategoriesWithChildrenJson()
        {
            var rootCategories = Context.Category
                .Where(category => category.ParentId == null)
                .ToList();

            var categoriesWithChildren = new List<CategoryWithChildren>();

            foreach (var rootCategory in rootCategories)
            {
                var categoryWithChildren = new CategoryWithChildren
                {
                    Id = rootCategory.Id,
                    CategoryName = rootCategory.CategoryName,
                    Children = new List<CategoryWithChildren>()
                };

                var queue = new Queue<CategoryWithChildren>();
                queue.Enqueue(categoryWithChildren);

                while (queue.Any())
                {
                    var currentCategory = queue.Dequeue();
                    var subcategories = Context.Category
                        .Where(c => c.ParentId == currentCategory.Id)
                        .ToList();

                    foreach (var subcategory in subcategories)
                    {
                        var childCategory = new CategoryWithChildren
                        {
                            Id = subcategory.Id,
                            CategoryName = subcategory.CategoryName,
                            Children = new List<CategoryWithChildren>()
                        };

                        currentCategory.Children.Add(childCategory);
                        queue.Enqueue(childCategory);
                    }
                }

                categoriesWithChildren.Add(categoryWithChildren);
            }

            return JsonConvert.SerializeObject(categoriesWithChildren, Formatting.Indented);
        }
    }
}
