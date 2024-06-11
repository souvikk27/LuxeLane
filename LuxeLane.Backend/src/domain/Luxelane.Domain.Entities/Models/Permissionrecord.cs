using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Permissionrecord
{
    public Guid Id { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public string? Systemname { get; set; }
}
