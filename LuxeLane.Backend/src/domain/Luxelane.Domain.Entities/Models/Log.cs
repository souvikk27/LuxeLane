using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Log
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public string? Fullmessage { get; set; }

    public string? Ipaddress { get; set; }

    public Guid? Loglevelid { get; set; }

    public string? Pageurl { get; set; }

    public string? Referrerurl { get; set; }

    public string? Shortmessage { get; set; }

    public virtual Customer? Customer { get; set; }
}
