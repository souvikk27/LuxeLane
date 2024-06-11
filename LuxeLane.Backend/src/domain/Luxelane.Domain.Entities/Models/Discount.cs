using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Discount
{
    public Guid Id { get; set; }

    public bool? Appliedtosubcategories { get; set; }

    public string? Couponcode { get; set; }

    public decimal? Discountamount { get; set; }

    public Guid? Discountlimitationid { get; set; }

    public decimal? Discountpercentage { get; set; }

    public Guid? Discounttypeid { get; set; }

    public DateTime? Enddateutc { get; set; }

    public bool? Iscumulative { get; set; }

    public int? Limitationtimes { get; set; }

    public decimal? Maximumdiscountamount { get; set; }

    public int? Maximumdiscountedquantity { get; set; }

    public string? Name { get; set; }

    public bool? Requirescouponcode { get; set; }

    public DateTime? Startdateutc { get; set; }

    public bool? Usepercentage { get; set; }

    public virtual ICollection<Discountrequirement> Discountrequirements { get; set; } = new List<Discountrequirement>();

    public virtual ICollection<Discountusagehistory> Discountusagehistories { get; set; } = new List<Discountusagehistory>();
}
