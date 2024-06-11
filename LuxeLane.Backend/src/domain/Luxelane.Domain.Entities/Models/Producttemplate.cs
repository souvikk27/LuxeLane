using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Producttemplate
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public string? Viewpath { get; set; }
}
