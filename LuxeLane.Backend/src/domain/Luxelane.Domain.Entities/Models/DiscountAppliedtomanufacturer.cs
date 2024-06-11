using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class DiscountAppliedtomanufacturer
{
    public Guid DiscountId { get; set; }

    public Guid ManufacturerId { get; set; }
}
