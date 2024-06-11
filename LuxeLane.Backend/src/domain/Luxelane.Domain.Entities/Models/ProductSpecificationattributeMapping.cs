using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductSpecificationattributeMapping
{
    public Guid Id { get; set; }

    public bool? Allowfiltering { get; set; }

    public Guid? Attributetypeid { get; set; }

    public string? Customvalue { get; set; }

    public int? Displayorder { get; set; }

    public Guid? Productid { get; set; }

    public bool? Showonproductpage { get; set; }

    public Guid? Specificationattributeoptionid { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Specificationattributeoption? Specificationattributeoption { get; set; }
}
