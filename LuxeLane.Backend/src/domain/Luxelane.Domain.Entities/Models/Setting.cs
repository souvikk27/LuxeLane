using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Setting
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? Storeid { get; set; }

    public string? Value { get; set; }
}
