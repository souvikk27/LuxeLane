using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Currency
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Currencycode { get; set; }

    public string? Customformatting { get; set; }

    public string? Displaylocale { get; set; }

    public int? Displayorder { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Name { get; set; }

    public bool? Published { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? Updatedonutc { get; set; }
}
