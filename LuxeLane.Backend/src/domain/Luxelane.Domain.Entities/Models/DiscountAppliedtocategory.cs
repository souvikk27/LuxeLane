using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class DiscountAppliedtocategory
{
    public Guid CategoryId { get; set; }

    public Guid DiscountId { get; set; }
}
