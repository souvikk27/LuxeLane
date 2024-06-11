using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Predefinedproductattributevalue
{
    public Guid Id { get; set; }

    public decimal? Cost { get; set; }

    public int? Displayorder { get; set; }

    public bool? Ispreselected { get; set; }

    public string? Name { get; set; }

    public decimal? Priceadjustment { get; set; }

    public Guid? Productattributeid { get; set; }

    public decimal? Weightadjustment { get; set; }

    public virtual Productattribute? Productattribute { get; set; }
}
