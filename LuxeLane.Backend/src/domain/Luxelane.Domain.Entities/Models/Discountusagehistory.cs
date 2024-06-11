using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Discountusagehistory
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Discountid { get; set; }

    public Guid? Orderid { get; set; }

    public virtual Discount? Discount { get; set; }

    public virtual Order? Order { get; set; }
}
