using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Customerattributevalue
{
    public Guid Id { get; set; }

    public Guid? Customerattributeid { get; set; }

    public int? Displayorder { get; set; }

    public bool? Ispreselected { get; set; }

    public string? Name { get; set; }

    public virtual Customerattribute? Customerattribute { get; set; }
}
