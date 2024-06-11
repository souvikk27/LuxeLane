using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Measuredimension
{
    public Guid Id { get; set; }

    public Guid? Displayorder { get; set; }

    public string? Name { get; set; }

    public decimal? Ratio { get; set; }

    public string? Systemkeyword { get; set; }
}
