using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Newscomment
{
    public Guid Id { get; set; }

    public string? Commenttext { get; set; }

    public string? Commenttitle { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Newsitemid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual News? Newsitem { get; set; }
}
