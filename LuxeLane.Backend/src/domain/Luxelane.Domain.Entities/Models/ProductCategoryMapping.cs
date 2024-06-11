using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductCategoryMapping
{
    public Guid Id { get; set; }

    public Guid? Categoryid { get; set; }

    public int? Displayorder { get; set; }

    public bool? Isfeaturedproduct { get; set; }

    public Guid? Productid { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Product? Product { get; set; }
}
