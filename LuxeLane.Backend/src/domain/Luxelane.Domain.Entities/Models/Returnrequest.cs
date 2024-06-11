using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Returnrequest
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Customnumber { get; set; }

    public string? Customercomments { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Orderitemid { get; set; }

    public int? Quantity { get; set; }

    public string? Reasonforreturn { get; set; }

    public string? Requestedaction { get; set; }

    public Guid? Returnrequeststatusid { get; set; }

    public string? Staffnotes { get; set; }

    public Guid? Storeid { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual Customer? Customer { get; set; }
}
