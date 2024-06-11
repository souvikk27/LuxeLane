using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Recurringpayment
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public int? Cyclelength { get; set; }

    public Guid? Cycleperiodid { get; set; }

    public bool? Deleted { get; set; }

    public Guid? Initialorderid { get; set; }

    public bool? Isactive { get; set; }

    public DateTime? Startdateutc { get; set; }

    public int? Totalcycles { get; set; }

    public virtual Order? Initialorder { get; set; }

    public virtual ICollection<Recurringpaymenthistory> Recurringpaymenthistories { get; set; } = new List<Recurringpaymenthistory>();
}
