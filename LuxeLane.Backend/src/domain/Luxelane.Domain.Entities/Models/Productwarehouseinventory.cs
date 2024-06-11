using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productwarehouseinventory
{
    public Guid Id { get; set; }

    public Guid? Productid { get; set; }

    public int? Reservedquantity { get; set; }

    public int? Stockquantity { get; set; }

    public Guid? Warehouseid { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
