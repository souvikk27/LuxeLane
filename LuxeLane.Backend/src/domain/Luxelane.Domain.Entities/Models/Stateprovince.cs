using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Stateprovince
{
    public Guid Id { get; set; }

    public string? Abbreviation { get; set; }

    public Guid? Countryid { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public bool? Published { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country? Country { get; set; }
}
