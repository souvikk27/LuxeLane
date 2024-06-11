using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class DiscountAppliedtoproduct
{
    public Guid DiscountId { get; set; }

    public Guid ProductId { get; set; }
}
