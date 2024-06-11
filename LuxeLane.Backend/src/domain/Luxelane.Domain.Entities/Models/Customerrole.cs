using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Customerrole
{
    public Guid Id { get; set; }

    public bool? Active { get; set; }

    public bool? Freeshipping { get; set; }

    public bool? Issystemrole { get; set; }

    public string? Name { get; set; }

    public Guid? Purchasedwithproductid { get; set; }

    public string? Systemname { get; set; }

    public bool? Taxexempt { get; set; }

    public virtual ICollection<Aclrecord> Aclrecords { get; set; } = new List<Aclrecord>();

    public virtual ICollection<Tierprice> Tierprices { get; set; } = new List<Tierprice>();
}
