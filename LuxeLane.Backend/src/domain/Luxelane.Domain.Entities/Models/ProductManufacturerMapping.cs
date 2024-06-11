using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductManufacturerMapping
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public bool? Isfeaturedproduct { get; set; }

    public Guid? Manufacturerid { get; set; }

    public Guid? Productid { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual Product? Product { get; set; }
}
