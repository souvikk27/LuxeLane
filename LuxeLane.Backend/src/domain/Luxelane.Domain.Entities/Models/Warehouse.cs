using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Warehouse
{
    public Guid Id { get; set; }

    public Guid? Addressid { get; set; }

    public string? Admincomment { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Productwarehouseinventory> Productwarehouseinventories { get; set; } = new List<Productwarehouseinventory>();
}
