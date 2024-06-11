using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Specificationattribute
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Specificationattributeoption> Specificationattributeoptions { get; set; } = new List<Specificationattributeoption>();
}
