using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Giftcard
{
    public Guid Id { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Giftcardcouponcode { get; set; }

    public Guid? Giftcardtypeid { get; set; }

    public bool? Isgiftcardactivated { get; set; }

    public bool? Isrecipientnotified { get; set; }

    public string? Message { get; set; }

    public Guid? Purchasedwithorderitemid { get; set; }

    public string? Recipientemail { get; set; }

    public string? Recipientname { get; set; }

    public string? Senderemail { get; set; }

    public string? Sendername { get; set; }

    public virtual ICollection<Giftcardusagehistory> Giftcardusagehistories { get; set; } = new List<Giftcardusagehistory>();

    public virtual Orderitem? Purchasedwithorderitem { get; set; }
}
