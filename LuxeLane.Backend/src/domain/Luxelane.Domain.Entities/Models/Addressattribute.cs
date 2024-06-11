using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Addressattribute
{
    public Guid Id { get; set; }

    public Guid? Attributecontroltypeid { get; set; }

    public int? Displayorder { get; set; }

    public bool? Isrequired { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Addressattributevalue> Addressattributevalues { get; set; } = new List<Addressattributevalue>();
}
