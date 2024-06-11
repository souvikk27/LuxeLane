using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Country
{
    public Guid Id { get; set; }

    public bool? Allowsbilling { get; set; }

    public bool? Allowsshipping { get; set; }

    public int? Displayorder { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Name { get; set; }

    public int? Numericisocode { get; set; }

    public bool? Published { get; set; }

    public bool? Subjecttovat { get; set; }

    public string? Threeletterisocode { get; set; }

    public string? Twoletterisocode { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Stateprovince> Stateprovinces { get; set; } = new List<Stateprovince>();
}
