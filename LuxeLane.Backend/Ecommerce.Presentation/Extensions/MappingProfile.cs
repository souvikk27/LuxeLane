using Ecommerce.Domain.Entities;
using Ecommerce.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Presentation.Extensions
{
    public static class MappingProfile
    {
        //public static Product MaptoProduct(this ProductDto dto)
        //{
        //    var product = new Product()
        //    {
        //        Id = dto.Id,
        //        SKU = dto.SKU,
        //        UPC = dto.UPC,
        //        Name = dto.Name,
        //        Title = dto.Title,
        //        Category = dto.Category,
        //        Price = dto.Price,
        //        Quantity = dto.Quantity,
        //        ListingStatus = dto.ListingStatus,
        //        AddedOn = dto.AddedOn,
        //        ModifiedOn = dto.ModifiedOn
        //    };
        //    return product;
        //}

        public static Category MaptoCategory(this CategoryDto dto)
        {
            var category = new Category()
            {
                Id = dto.Id,
                CategoryName = dto.CategoryName,
                ParentId = dto.ParentId,
                CreatedAt = dto.CreatedAt
            };
            return category;
        }

        public static ApplicationUser MaptoUser(this UserDto dto)
        {
            var user = new ApplicationUser()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.UserName,
                Email = dto.Email,
                EmailConfirmed = true,
            };
            return user;
        }
    }

    
}