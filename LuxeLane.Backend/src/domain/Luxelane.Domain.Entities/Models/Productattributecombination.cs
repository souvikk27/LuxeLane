using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productattributecombination
{
    public Guid Id { get; set; }

    public bool? Allowoutofstockorders { get; set; }

    public string? Attributesxml { get; set; }

    public string? Gtin { get; set; }

    public string? Manufacturerpartnumber { get; set; }

    public int? Notifyadminforquantitybelow { get; set; }

    public decimal? Overriddenprice { get; set; }

    public Guid? Productid { get; set; }

    public string? Sku { get; set; }

    public int? Stockquantity { get; set; }

    public virtual Product? Product { get; set; }
}
