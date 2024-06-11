using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productattribute
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Predefinedproductattributevalue> Predefinedproductattributevalues { get; set; } = new List<Predefinedproductattributevalue>();

    public virtual ICollection<ProductProductattributeMapping> ProductProductattributeMappings { get; set; } = new List<ProductProductattributeMapping>();
}
