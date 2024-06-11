using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productattributevalue
{
    public Guid Id { get; set; }

    public Guid? Associatedproductid { get; set; }

    public Guid? Attributevaluetypeid { get; set; }

    public string? Colorsquaresrgb { get; set; }

    public decimal? Cost { get; set; }

    public int? Displayorder { get; set; }

    public Guid? Imagesquarespictureid { get; set; }

    public bool? Ispreselected { get; set; }

    public string? Name { get; set; }

    public Guid? Pictureid { get; set; }

    public decimal? Priceadjustment { get; set; }

    public Guid? Productattributemappingid { get; set; }

    public int? Quantity { get; set; }

    public decimal? Weightadjustment { get; set; }

    public virtual ProductProductattributeMapping? Productattributemapping { get; set; }
}
