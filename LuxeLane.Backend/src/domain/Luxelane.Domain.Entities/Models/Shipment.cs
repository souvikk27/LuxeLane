using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Shipment
{
    public Guid Id { get; set; }

    public string? Admincomment { get; set; }

    public DateTime? Createdonutc { get; set; }

    public DateTime? Deliverydateutc { get; set; }

    public Guid? Orderid { get; set; }

    public DateTime? Shippeddateutc { get; set; }

    public decimal? Totalweight { get; set; }

    public string? Trackingnumber { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<Shipmentitem> Shipmentitems { get; set; } = new List<Shipmentitem>();
}
