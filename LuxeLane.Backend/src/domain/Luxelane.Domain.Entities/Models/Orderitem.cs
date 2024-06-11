using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Orderitem
{
    public Guid Id { get; set; }

    public string? Attributedescription { get; set; }

    public string? Attributesxml { get; set; }

    public decimal? Discountamountexcltax { get; set; }

    public decimal? Discountamountincltax { get; set; }

    public int? Downloadcount { get; set; }

    public bool? Isdownloadactivated { get; set; }

    public decimal? Itemweight { get; set; }

    public Guid? Licensedownloadid { get; set; }

    public Guid? Orderid { get; set; }

    public Guid? Orderitemguid { get; set; }

    public decimal? Originalproductcost { get; set; }

    public decimal? Priceexcltax { get; set; }

    public decimal? Priceincltax { get; set; }

    public Guid? Productid { get; set; }

    public int? Quantity { get; set; }

    public DateTime? Rentalenddateutc { get; set; }

    public DateTime? Rentalstartdateutc { get; set; }

    public decimal? Unitpriceexcltax { get; set; }

    public decimal? Unitpriceincltax { get; set; }

    public virtual ICollection<Giftcard> Giftcards { get; set; } = new List<Giftcard>();

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
