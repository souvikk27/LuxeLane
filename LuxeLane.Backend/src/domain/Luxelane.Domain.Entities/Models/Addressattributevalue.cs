using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Addressattributevalue
{
    public Guid Id { get; set; }

    public Guid? Addressattributeid { get; set; }

    public int? Displayorder { get; set; }

    public bool? Ispreselected { get; set; }

    public string? Name { get; set; }

    public virtual Addressattribute? Addressattribute { get; set; }
}
