using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Checkoutattributevalue
{
    public Guid Id { get; set; }

    public Guid? Checkoutattributeid { get; set; }

    public string? Colorsquaresrgb { get; set; }

    public Guid? Displayorder { get; set; }

    public bool? Ispreselected { get; set; }

    public string? Name { get; set; }

    public decimal? Priceadjustment { get; set; }

    public decimal? Weightadjustment { get; set; }

    public virtual Checkoutattribute? Checkoutattribute { get; set; }
}
