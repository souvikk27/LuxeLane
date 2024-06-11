using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Blogcomment
{
    public Guid Id { get; set; }

    public Guid? Blogpostid { get; set; }

    public string? Commenttext { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public virtual Blogpost? Blogpost { get; set; }

    public virtual Customer? Customer { get; set; }
}
