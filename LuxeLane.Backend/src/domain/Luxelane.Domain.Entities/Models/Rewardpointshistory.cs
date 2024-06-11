using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Rewardpointshistory
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public string? Message { get; set; }

    public int? Points { get; set; }

    public int? Pointsbalance { get; set; }

    public Guid? Storeid { get; set; }

    public decimal? Usedamount { get; set; }

    public Guid? UsedwithorderId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Order? Usedwithorder { get; set; }
}
