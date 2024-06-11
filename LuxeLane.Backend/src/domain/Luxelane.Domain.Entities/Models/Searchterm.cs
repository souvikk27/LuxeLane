using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Searchterm
{
    public Guid Id { get; set; }

    public int? Count { get; set; }

    public string? Keyword { get; set; }

    public Guid? Storeid { get; set; }
}
