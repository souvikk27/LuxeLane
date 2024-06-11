using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Scheduletask
{
    public Guid Id { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? Lastendutc { get; set; }

    public DateTime? Laststartutc { get; set; }

    public DateTime? Lastsuccessutc { get; set; }

    public string? Leasedbymachinename { get; set; }

    public DateTime? Leaseduntilutc { get; set; }

    public string? Name { get; set; }

    public int? Seconds { get; set; }

    public bool? Stoponerror { get; set; }

    public string? Type { get; set; }
}
