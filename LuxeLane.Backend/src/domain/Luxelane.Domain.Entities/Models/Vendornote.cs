using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Vendornote
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Note { get; set; }

    public Guid? Vendorid { get; set; }

    public virtual Vendor? Vendor { get; set; }
}
