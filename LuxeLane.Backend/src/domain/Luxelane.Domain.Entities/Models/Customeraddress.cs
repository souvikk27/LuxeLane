using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Customeraddress
{
    public Guid AddressId { get; set; }

    public Guid CustomerId { get; set; }
}
