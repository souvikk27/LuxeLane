using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Activitylog
{
    public Guid Id { get; set; }

    public Guid? Activitylogtypeid { get; set; }

    public string? Comment { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public string? Ipaddress { get; set; }

    public virtual Activitylogtype? Activitylogtype { get; set; }

    public virtual Customer? Customer { get; set; }
}
