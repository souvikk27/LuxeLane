using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Shipmentitem
{
    public Guid Id { get; set; }

    public Guid? Orderitemid { get; set; }

    public int? Quantity { get; set; }

    public Guid? Shipmentid { get; set; }

    public Guid? Warehouseid { get; set; }

    public virtual Shipment? Shipment { get; set; }
}
