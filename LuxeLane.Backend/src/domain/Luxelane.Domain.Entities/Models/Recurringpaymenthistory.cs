using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Recurringpaymenthistory
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Orderid { get; set; }

    public Guid? Recurringpaymentid { get; set; }

    public virtual Recurringpayment? Recurringpayment { get; set; }
}
