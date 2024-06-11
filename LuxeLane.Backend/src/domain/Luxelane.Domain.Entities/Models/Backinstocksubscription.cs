using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Backinstocksubscription
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Productid { get; set; }

    public Guid? Storeid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
