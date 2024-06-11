using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class CustomerCustomerroleMapping
{
    public Guid CustomerroleId { get; set; }

    public Guid CustomerId { get; set; }
}
