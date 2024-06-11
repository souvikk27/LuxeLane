using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Specificationattributeoption
{
    public Guid Id { get; set; }

    public string? Colorsquaresrgb { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public Guid? Specificationattributeid { get; set; }

    public virtual ICollection<ProductSpecificationattributeMapping> ProductSpecificationattributeMappings { get; set; } = new List<ProductSpecificationattributeMapping>();

    public virtual Specificationattribute? Specificationattribute { get; set; }
}
