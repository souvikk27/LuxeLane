using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Tierprice
{
    public Guid Id { get; set; }

    public Guid? Customerroleid { get; set; }

    public decimal? Price { get; set; }

    public Guid? Productid { get; set; }

    public int? Quantity { get; set; }

    public Guid? Storeid { get; set; }

    public virtual Customerrole? Customerrole { get; set; }

    public virtual Product? Product { get; set; }
}
