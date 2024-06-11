using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Shippingmethod
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }
}
