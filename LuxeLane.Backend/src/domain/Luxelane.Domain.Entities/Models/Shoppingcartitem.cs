using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Shoppingcartitem
{
    public Guid Id { get; set; }

    public string? Attributesxml { get; set; }

    public DateTime? Createdonutc { get; set; }

    public decimal? Customerenteredprice { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Productid { get; set; }

    public int? Quantity { get; set; }

    public DateTime? Rentalenddateutc { get; set; }

    public DateTime? Rentalstartdateutc { get; set; }

    public Guid? Shoppingcarttypeid { get; set; }

    public Guid? Storeid { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
