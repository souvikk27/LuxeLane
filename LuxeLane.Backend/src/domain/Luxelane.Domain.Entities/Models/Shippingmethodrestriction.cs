using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Shippingmethodrestriction
{
    public Guid CountryId { get; set; }

    public Guid ShippingmethodId { get; set; }
}
