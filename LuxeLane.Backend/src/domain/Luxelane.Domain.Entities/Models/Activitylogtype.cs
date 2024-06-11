using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Activitylogtype
{
    public Guid Id { get; set; }

    public bool? Enabled { get; set; }

    public string? Name { get; set; }

    public string? Systemkeyword { get; set; }

    public virtual ICollection<Activitylog> Activitylogs { get; set; } = new List<Activitylog>();
}
