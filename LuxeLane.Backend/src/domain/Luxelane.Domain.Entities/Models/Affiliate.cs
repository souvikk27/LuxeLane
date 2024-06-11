using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Affiliate
{
    public Guid Id { get; set; }

    public bool? Active { get; set; }

    public Guid? Addressid { get; set; }

    public string? Admincomment { get; set; }

    public bool? Deleted { get; set; }

    public string? Friendlyurlname { get; set; }

    public virtual Address? Address { get; set; }
}
