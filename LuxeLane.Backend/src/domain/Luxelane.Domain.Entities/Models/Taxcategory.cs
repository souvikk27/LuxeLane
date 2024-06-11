using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Taxcategory
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }
}
